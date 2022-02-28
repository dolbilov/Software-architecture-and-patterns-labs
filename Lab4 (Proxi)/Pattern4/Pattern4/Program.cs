namespace Pattern4;

public static class Program
{
    private static void Main()
    {
        try
        {
            int command;
            var realImage = new RealImage();
            var cachedImage = new CachedImage(realImage);
            var imageEditor = new ImageEditor(cachedImage);
            do
            {
                Console.WriteLine("1 - Left click");
                Console.WriteLine("2 - Right double click");
                Console.WriteLine("Any other character - Exit");

                
                command = Convert.ToInt32(Console.ReadLine());
                if (command == 1)
                {
                    imageEditor.HandleLeftClick();
                }
                else if (command == 2)
                {
                    imageEditor.HandleRightClick();
                }
            } while (command is 1 or 2);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Some error occurred: {e.Message}");
            Environment.Exit(-1);
        }
        
    }
}
namespace Pattern4;

public class OriginalImage : IImage
{
    public OriginalImage()
    {
        Console.WriteLine("Loaded original image");
    }
    
    public void HandleLeftClick()
    {
        Console.WriteLine("Left click handled by ORIGINAL image");
    }

    public void HandleRightClick()
    {
        Console.WriteLine("Right click handled by ORIGINAL image");
    }
}
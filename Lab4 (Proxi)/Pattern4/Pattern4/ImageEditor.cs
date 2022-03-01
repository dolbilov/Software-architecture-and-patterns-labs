namespace Pattern4;

public class ImageEditor
{
    private readonly Image _image;

    public ImageEditor(Image image)
    {
        _image = image;
    }

    public void HandleLeftClick()
    {
        Console.WriteLine($"Draw board {_image.Width}x{_image.Height} pixels");
    }

    public void HandleRightClick()
    {
        Console.WriteLine($"Draw {_image.Pixels.Capacity} pixels");
    }
}
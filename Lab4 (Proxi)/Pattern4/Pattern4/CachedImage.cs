namespace Pattern4;

public class CachedImage : IImage
{
    private OriginalImage? _originalImage;
    public void HandleLeftClick()
    {
        if (_originalImage == null)
        {
            _originalImage = new OriginalImage();
        }
        Console.WriteLine("Left click handled by PROXY image");
    }

    public void HandleRightClick()
    {
        _originalImage ??= new OriginalImage();
        Console.WriteLine("Right click handled by PROXY image");
    }
}
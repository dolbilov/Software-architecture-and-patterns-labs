namespace Pattern4;

public class ImageEditor
{
    private readonly IImage _image;

    public ImageEditor(IImage image)
    {
        _image = image;
    }

    public void HandleLeftClick()
    {
        _image.HandleLeftClick();
    }

    public void HandleRightClick()
    {
        _image.HandleRightClick();
    }
}
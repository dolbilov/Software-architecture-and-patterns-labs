using System.Drawing;

namespace Pattern4;

public class CachedImage : Image
{
    private RealImage? _originalImage;

    public CachedImage(RealImage image)
    {
        _originalImage = image;
    }

    public override int Width
    {
        get
        {
            if (_width == 0)
            {
                _width = _originalImage.Width;
            }

            return _width;
        }
    }

    public override int Height
    {
        get
        {
            if (_height == 0)
            {
                _height = _originalImage.Height;
            }


            return _height;
        }
    }

    public override List<Color> Pixels
    {
        get
        {
            if (_pixels.Capacity == 0)
            {
                _pixels = _originalImage.Pixels;
            }

            return _pixels;
        }
    }
}
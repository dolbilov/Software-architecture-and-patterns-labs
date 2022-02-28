using System.Drawing;

namespace Pattern4;

public sealed class RealImage : Image
{
    public RealImage()
    {
        Console.WriteLine("Loaded real image");
        _width = 1280;
        _height = 720;
        _pixels = new List<Color>(_width * _height);
    }

    public override int Width
    {
        get
        {
            Console.WriteLine("Reading width from real picture");
            return _width;
        }
        protected init => _width = value;
    }

    public override int Height
    {
        get
        {
            Console.WriteLine("Reading height from real picture");
            return _height;
        }
        protected init => _height = value;
    }

    public override List<Color> Pixels
    {
        get
        {
            Console.WriteLine("Reading pixels from real picture");
            return _pixels;
        }
        protected init => _pixels = value;
    }
}
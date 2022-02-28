using System.Drawing;

namespace Pattern4;

public abstract class Image
{
    protected int _width;
    protected int _height;
    protected List<Color> _pixels = new();

    public virtual int Width
    {
        get => _width;
        protected init => _width = value;
    }

    public virtual int Height
    {
        get => _height;
        protected init => _height = value;
    }

    public virtual List<Color> Pixels
    {
        get => _pixels;
        protected init => _pixels = value;
    }
}
namespace Mindbox.Geometry.Abstract
{
    public abstract class RectangleBase : IFigure
    {
        private double _width;

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(message: "width should be greater than 0", paramName: nameof(value));

                _width = value;
            }
        }

        private double _height;

        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(message: "width should be greater than 0", paramName: nameof(value));

                _height = value;
            }
        }

        public RectangleBase(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateArea();
    }
}

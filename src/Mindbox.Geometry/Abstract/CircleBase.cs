namespace Mindbox.Geometry.Abstract
{
    public abstract class CircleBase : IFigure
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(message: "Circle radius should be greater than or equal to 0");

                _radius = value;
            }
        }

        protected CircleBase(double radius)
        {
            Radius = radius;
        }

        public abstract double CalculateArea();
    }
}

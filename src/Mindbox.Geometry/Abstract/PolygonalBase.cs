namespace Mindbox.Geometry.Abstract
{
    public abstract class PolygonalBase : IFigure
    {
        public double[] _sides;
        public double[] Sides
        {
            get => _sides;
            set
            {
                if (value.Where(x => x <= 0).Any())
                    throw new ArgumentException(message: "sides should be greater than 0", paramName: nameof(value));

                _sides = value;
            }
        }

        protected PolygonalBase(double[] sides)
        {
            Sides = sides;
        }

        public abstract double CalculateArea();
    }
}

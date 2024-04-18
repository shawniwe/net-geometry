using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry
{
    public class DefaultAreaCalculator : IAreaCalculator
    {
        public double CalculateArea(IFigure figure)
        {
            if (figure is null)
                throw new ArgumentNullException(paramName: nameof(figure));

            return figure.CalculateArea();
        }
    }
}

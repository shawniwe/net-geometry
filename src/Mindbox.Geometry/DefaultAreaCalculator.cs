using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry
{
    public class DefaultAreaCalculator : IAreaCalculator
    {
        public double CalculateArea(IFigure figure) => figure.CalculateArea();
    }
}

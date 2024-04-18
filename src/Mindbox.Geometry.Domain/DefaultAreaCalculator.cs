using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Domain
{
    public class DefaultAreaCalculator : IAreaCalculator
    {
        public double CalculateArea(IFigure figure) => figure.CalculateArea();
    }
}

using Mindbox.Geometry.Abstract;
using System;

namespace Mindbox.Geometry.Domain
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

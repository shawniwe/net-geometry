using System;
using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Domain.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea() => throw new NotImplementedException();
    }
}

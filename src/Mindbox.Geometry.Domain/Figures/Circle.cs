using System;
using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Domain.Figures
{
    public class Circle : CircleBase
    {
        public Circle(double radius) : base(radius) { }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}

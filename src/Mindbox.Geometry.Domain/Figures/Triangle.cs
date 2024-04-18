using System;
using System.Collections.Generic;
using System.Linq;
using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Domain.Figures
{
    public class Triangle : TriangleBase
    {
        public Triangle(double sideX, double sideY, double sideZ) : base(sideX, sideY, sideZ) { }

        public override double CalculateArea()
        {
            double halfPerimeter = (SideX + SideY + SideZ) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideX) * (halfPerimeter - SideY) * (halfPerimeter - SideZ));
        }

        public override bool IsRight()
        {
            var sides = new List<double> { SideX, SideY, SideZ };
            double biggestSide = sides.Max();
            sides.Remove(biggestSide);

            return Math.Round(Math.Pow(biggestSide, 2), 3) == sides.Select(x => Math.Pow(x, 2)).Sum();
        }
    }
}

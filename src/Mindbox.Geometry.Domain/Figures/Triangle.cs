using System;
using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Domain.Figures
{
    public class Triangle : IFigure
    {
        public double SideX { get; set; }
        public double SideY { get; set; }
        public double SideZ { get; set; }

        public Triangle(double sideX, double sideY, double sideZ)
        {
            SideX = sideX;
            SideY = sideY;
            SideZ = sideZ;
        }

        public double CalculateArea() => throw new NotImplementedException();
    }
}

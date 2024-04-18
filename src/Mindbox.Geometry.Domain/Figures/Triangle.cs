using System;
using Mindbox.Geometry.Abstract;

namespace Mindbox.Geometry.Domain.Figures
{
    public class Triangle : IFigure
    {
        private double _sideX;
        public double SideX
        {
            get => _sideX;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(message: "SideX should be greater than 0", paramName: nameof(value));

                _sideX = value;
            }

        }

        private double _sideY;
        public double SideY
        {
            get => _sideY;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(message: "SideY should be greater than 0", paramName: nameof(value));

                _sideY = value;
            }

        }

        private double _sideZ;
        public double SideZ
        {
            get => _sideZ;
            set
            {
                if (value <= 0)
                    throw new ArgumentException(message: "SideZ should be greater than 0", paramName: nameof(value));

                _sideZ = value;
            }

        }

        public Triangle(double sideX, double sideY, double sideZ)
        {
            SideX = sideX;
            SideY = sideY;
            SideZ = sideZ;
        }

        public double CalculateArea()
        {
            double halfPerimeter = (SideX + SideY + SideZ) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideX) * (halfPerimeter - SideY) * (halfPerimeter - SideZ));
        }
    }
}

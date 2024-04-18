using System;
using System.Collections.Generic;
using System.Text;

namespace Mindbox.Geometry.Abstract
{
    public abstract class TriangleBase : IFigure
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

        protected TriangleBase(double sideX, double sideY, double sideZ)
        {
            SideX = sideX;
            SideY = sideY;
            SideZ = sideZ;
        }

        public abstract bool IsRight();
        public abstract double CalculateArea();
    }
}

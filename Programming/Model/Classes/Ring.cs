using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _externalRadius;
        private double _internalRadius;

        public Point2D Center { get; set; }
        public double ExternalRadius
        {
            get
            {
                return _externalRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "ExternalRadius");
                if (value <= _internalRadius)
                {
                    throw new ArgumentException("Внешний радиус не может быть меньше, чем внутренний");
                }
                _externalRadius = value;
            }
        }
        public double InternalRadius
        {
            get
            {
                return _internalRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "InternalRadius");
                if (value >= _externalRadius)
                {
                    throw new ArgumentException("Внутренний радиус не может быть больше, чем внешний");
                }
                _internalRadius = value;
            }
        }
        public double Area
        {
            get
            {
                return (Math.PI * ExternalRadius * ExternalRadius) - (Math.PI * InternalRadius * InternalRadius);
            }
        }
        public Ring(double externalRadius, double internalRadius, Point2D center)
        {
            ExternalRadius = externalRadius;
            InternalRadius = internalRadius;
            Center = center;
        }

    }
}

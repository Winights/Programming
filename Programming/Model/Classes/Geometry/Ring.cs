using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о геометрических кольцах.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _externalRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _internalRadius;

        /// <summary>
        /// Возвращает и задает координаты X и Y.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца. Должен быть положительным числом и больше внутреннего радиуса.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает внутренний радиус кольца. Должен быть положительным числом и меньше внешнего радиуса.
        /// </summary>
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

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * ExternalRadius * ExternalRadius - Math.PI * InternalRadius * InternalRadius;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="externalRadius">Внешний радиус кольца.</param>
        /// <param name="internalRadius">Внутренний радиус кольца.</param>
        /// <param name="center">Координаты X и Y.</param>
        public Ring(double externalRadius, double internalRadius, Point2D center)
        {
            ExternalRadius = externalRadius;
            InternalRadius = internalRadius;
            Center = center;
        }

    }
}

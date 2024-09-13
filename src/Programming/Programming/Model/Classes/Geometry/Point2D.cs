using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о координатах X и Y.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координаты X.
        /// </summary>
        private readonly double _x;

        /// <summary>
        /// Координаты Y.
        /// </summary>
        private readonly double _y;

        /// <summary>
        /// Возвращает координаты X.
        /// </summary>
        public double X { get { return _x; } }

        /// <summary>
        /// Возвращает координаты Y.
        /// </summary>
        public double Y { get { return _y; } }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координаты X.</param>
        /// <param name="y">Координаты Y.</param>
        public Point2D(double x, double y)
        {
            if (x < 0 || y < 0)
            {
                throw new Exception("Координаты не могут быть отрицательными");
            }
            _x = x;
            _y = y;
        }
    }
}

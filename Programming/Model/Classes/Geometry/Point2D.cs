﻿using System;
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
        /// Координаты X для всех объектов данного класса.
        /// </summary>
        private readonly double _x;

        /// <summary>
        /// Координаты Y для всех объектов данного класса.
        /// </summary>
        private readonly double _y;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }

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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольниках.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Длина для всех объектов данного класса.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина для всех объектов данного класса.
        /// </summary>
        private double _width;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Счетчик для всех существующих объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Цвет для всех объектов данного класса.
        /// </summary>
        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                _length = value;
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }
        public Point2D Center { get; set; }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
        public int Id { get { return _id; } }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Color = "";
            Center = new Point2D(0, 0);
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
    }
}

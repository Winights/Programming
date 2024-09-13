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
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
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
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает координаты X и Y.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает счетчик для всех существующих объектов.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты X и Y.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
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

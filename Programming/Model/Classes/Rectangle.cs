using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private static int _allRectanglesCount;
        private readonly int _id;
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
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Color = "";
            Center = null;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Square
    {
        private double _lenght;
        private double _width;
        private string _color;
        public string Color { get; set; }

        public void SetLenght(double lenght)
        {
            if (lenght < 0)
            {
                throw new ArgumentException("Не может быть отрицательным числом");
            }

            _lenght = lenght;
        }
        public double GetLenght()
        { 
            return _lenght; 
        }

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                throw new ArgumentException("Не может быть отрицательным числом");
            }

            _width = width;
        }
        public double GetWidth()
        {
            return _width;
        }
    }
}

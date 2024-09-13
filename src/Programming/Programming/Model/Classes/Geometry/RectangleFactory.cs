using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Реализует статистическую генерацию нового случайного объекта прямоугольника.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Генерирует случайный обьект прямоугольника.
        /// </summary>
        /// <returns>Возвращает новый случайный объект прямоугольника.</returns>
        public static Rectangle Randomize()
        {
            Random ran = new Random();

            double length = ran.Next(1, 100);
            double width = ran.Next(1, 100);
            double centerX = ran.Next(1, 355);
            double centerY = ran.Next(1, 473);
            Point2D center = new Point2D(centerX, centerY);

            return new Rectangle(length, width, "", center);
        }
    }
}

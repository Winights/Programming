using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.View
{
    /// <summary>
    /// Хранит данные о цветах для индиксации.
    /// </summary>
    public class AppColors
    {
        /// <summary>
        /// Цвет для не пересеченных прямоугольников.
        /// </summary>
        public static readonly Color ValidRectangleColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет для пересеченных прямоугольников.
        /// </summary>
        public static readonly Color InvalidRectangleColor = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет для правильной валидации.
        /// </summary>
        public static readonly Color ValidColor = Color.White;

        /// <summary>
        /// Цвет для неправильной валидации.
        /// </summary>
        public static readonly Color InvalidColor = Color.LightPink;

        /// <summary>
        /// Цвет для осени.
        /// </summary>
        public static readonly Color AutumnColor = Color.FromArgb(226, 156, 69);

        /// <summary>
        /// Цвет для весны.
        /// </summary>
        public static readonly Color SpringColor = Color.FromArgb(85, 156, 69);
    }
}

using Programming.Model.Classes.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Переменная типа Rectangle.
        /// </summary>
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();

        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Model.Classes.Geometry.Rectangle[] _rectangles = new Model.Classes.Geometry.Rectangle[5];
        public RectanglesControl()
        {
            InitializeComponent();
            InitializetionRectangles(_rectangles); 
        }

        /// <summary>
        /// Заполняет массив прямоугольников случайными значениями.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        private void InitializetionRectangles(Model.Classes.Geometry.Rectangle[] rectangles)
        {
            Random ran = new Random();
            string[] colors = { "Red", "Yellow", "Green", "Blue", "Black", "White" };

            //Инициализируем массив _rectangles
            for (int i = 0; i < rectangles.Length; i++)
            {
                double length = Math.Round(ran.NextDouble() * (25 - 1) + 1, 2);
                double width = Math.Round(ran.NextDouble() * (25 - 1) + 1, 2);
                int indexColor = ran.Next(colors.Length);
                string color = colors[indexColor];
                double centerX = width / 2;
                double centerY = length / 2;
                Point2D center = new Point2D(centerX, centerY);
                rectangles[i] = new Model.Classes.Geometry.Rectangle(length, width, color, center);
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem != null)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                //Добавляем в соответствующие TextBox's
                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color.ToString();
                CoordXTextBox.Text = _currentRectangle.Center.X.ToString();
                CoordYTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueLength = double.Parse(LengthTextBox.Text);
                if (valueLength < 0)
                {
                    LengthTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentRectangle.Length = valueLength;
                    LengthTextBox.BackColor = AppColors.ValidColor;
                }
            }
            catch (FormatException)
            {
                LengthTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueWidth = double.Parse(WidthTextBox.Text);
                if (valueWidth < 0)
                {
                    WidthTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentRectangle.Width = valueWidth;
                    WidthTextBox.BackColor = AppColors.ValidColor;
                }
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(ColorTextBox.Text, out var value))
            {
                ColorTextBox.BackColor = AppColors.InvalidColor;
            }
            else
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = AppColors.ValidColor;
            }
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Geometry.Rectangle[] rectangles)
        {
            int indexMaxWidth = 0;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[indexMaxWidth].Width < rectangles[i].Width)
                {
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
        }

        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            int indexMax = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SetSelected(indexMax, true);
        }
    }
}

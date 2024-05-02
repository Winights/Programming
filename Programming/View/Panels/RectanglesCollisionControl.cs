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
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Model.Classes.Geometry.Rectangle> _rectanglesList = new List<Model.Classes.Geometry.Rectangle>();

        /// <summary>
        /// Переменная типа Rectangle.
        /// </summary>
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();

        /// <summary>
        /// Список экзепляров Panel.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Переменная типа CollisionManager.
        /// </summary>
        private CollisionManager _collisionManager = new CollisionManager();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляет элементы списка в RectangleListBox.
        /// </summary>
        private void UpdateListBox()
        {
            RectangleListBox.Items.Clear();

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                _currentRectangle = _rectanglesList[i];
                RectangleListBox.Items.Add($"{_currentRectangle.Id}: (X = {_currentRectangle.Center.X}: " +
                    $"Y = {_currentRectangle.Center.Y}: " +
                    $"W = {_currentRectangle.Width}: H = {_currentRectangle.Length})");
            }
        }

        /// <summary>
        /// Очищает информацию о прямоугольниках в TextBox's.
        /// </summary>
        private void ClearRectangleInfo()
        {
            HeightRectanglesTextBox.Clear();
            HeightRectanglesTextBox.BackColor = AppColors.ValidColor;

            WidthRectanglesTextBox.Clear();
            WidthRectanglesTextBox.BackColor = AppColors.ValidColor;

            CoordXRectanglesTextBox.Clear();
            CoordXRectanglesTextBox.BackColor = AppColors.ValidColor;

            CoordYRectanglesTextBox.Clear();
            CoordYRectanglesTextBox.BackColor = AppColors.ValidColor;

            IdRectanglesTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о прямоугольнике в TexttBox's.
        /// </summary>
        /// <param name="rectangle">Обновляемый прямоугольник.</param>
        private void UpdateRectangleInfo(Model.Classes.Geometry.Rectangle rectangle)
        {
            HeightRectanglesTextBox.Text = rectangle.Length.ToString();
            WidthRectanglesTextBox.Text = rectangle.Width.ToString();
            CoordXRectanglesTextBox.Text = rectangle.Center.X.ToString();
            CoordYRectanglesTextBox.Text = rectangle.Center.Y.ToString();
            IdRectanglesTextBox.Text = rectangle.Id.ToString();
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize();
            _rectanglesList.Add(_currentRectangle);

            Panel panel = new Panel();
            panel.Height = Convert.ToInt32(_currentRectangle.Length);
            int сoordX = Convert.ToInt32(_currentRectangle.Center.X);
            int сoordY = Convert.ToInt32(_currentRectangle.Center.Y);
            panel.Location = new Point(сoordX, сoordY);
            panel.Width = Convert.ToInt32(_currentRectangle.Width);
            panel.BackColor = AppColors.ValidRectangleColor;

            _rectanglePanels.Add(panel);
            RectanglePanel.Controls.Add(panel);

            FindCollisions();
            UpdateListBox();

        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex != -1)
            {
                RectanglePanel.Controls.RemoveAt(RectangleListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(RectangleListBox.SelectedIndex);
                _rectanglesList.RemoveAt(RectangleListBox.SelectedIndex);
                RectangleListBox.Items.RemoveAt(RectangleListBox.SelectedIndex);
                FindCollisions();
            }
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem != null)
            {
                _currentRectangle = _rectanglesList[RectangleListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            if (RectangleListBox.SelectedIndex == -1)
            {
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Обновляет информацию о прямоугольнике в ListBox's.
        /// </summary>
        /// <param name="rectangle">Проверяемый прямоугольник.</param>
        private void UpdateListBoxItem(Model.Classes.Geometry.Rectangle rectangle)
        {
            if (RectangleListBox.SelectedIndex != -1)
            {
                int index = RectangleListBox.SelectedIndex;
                RectangleListBox.Items[index] = $"{_currentRectangle.Id}: (X = {_currentRectangle.Center.X}: " +
                    $"Y = {_currentRectangle.Center.Y}: " +
                    $"W = {_currentRectangle.Width}: H = {_currentRectangle.Length})";
            }
        }

        private void CoordXRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueCoordX = double.Parse(CoordXRectanglesTextBox.Text);
                if (valueCoordX < 0)
                {
                    CoordXRectanglesTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentRectangle.Center = new Point2D(valueCoordX, _currentRectangle.Center.Y);
                    UpdateListBoxItem(_currentRectangle);
                    CoordXRectanglesTextBox.BackColor = AppColors.ValidColor;

                    int coordX = Convert.ToInt32(valueCoordX);
                    int coordY = Convert.ToInt32(_currentRectangle.Center.Y);
                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Location = new Point(coordX, coordY);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                CoordXRectanglesTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void CoordYRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueCoordY = double.Parse(CoordYRectanglesTextBox.Text);
                if (valueCoordY < 0)
                {
                    CoordYRectanglesTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, valueCoordY);
                    UpdateListBoxItem(_currentRectangle);
                    CoordYRectanglesTextBox.BackColor = AppColors.ValidColor;

                    int coordX = Convert.ToInt32(_currentRectangle.Center.X);
                    int coordY = Convert.ToInt32(valueCoordY);
                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Location = new Point(coordX, coordY);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                CoordYRectanglesTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueWidth = double.Parse(WidthRectanglesTextBox.Text);
                if (valueWidth < 0)
                {
                    WidthRectanglesTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentRectangle.Width = valueWidth;
                    UpdateListBoxItem(_currentRectangle);
                    WidthRectanglesTextBox.BackColor = AppColors.ValidColor;

                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Width = Convert.ToInt32(valueWidth);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                WidthRectanglesTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void HeightRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueLength = double.Parse(HeightRectanglesTextBox.Text);
                if (valueLength < 0)
                {
                    HeightRectanglesTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentRectangle.Length = valueLength;
                    UpdateListBoxItem(_currentRectangle);
                    HeightRectanglesTextBox.BackColor = AppColors.ValidColor;

                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Height = Convert.ToInt32(valueLength);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                HeightRectanglesTextBox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.ValidRectangleColor;
            }

            for (int i = 0; i < _rectanglesList.Count(); i++)
            {
                for (int j = i + 1; j < _rectanglesList.Count(); j++)
                {
                    if (_collisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.InvalidRectangleColor;
                        _rectanglePanels[j].BackColor = AppColors.InvalidRectangleColor;
                    }
                }
            }
        }
    }
}

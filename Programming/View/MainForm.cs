using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Model.Classes.Geometry.Rectangle> _rectanglesList = new List<Model.Classes.Geometry.Rectangle>();
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();
        private Model.Classes.Geometry.Rectangle[] _rectangles = new Model.Classes.Geometry.Rectangle[5];
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie = new Movie();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private CollisionManager _collisionManager = new CollisionManager();
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            DefaultSelectedEnums();
            LoadSeasonComboBox();
            InitializetionRectangles(_rectangles);
            InitializetionMovies(_movies);
            UpdateListBox();
        }
        private void InitializetionRectangles(Model.Classes.Geometry.Rectangle[] rectangles)
        {
            Random ran = new Random();
            string[] colors = { "Red", "Yellow", "Green", "Blue", "Black", "White" };

            //�������������� ������ _rectangles
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
        private void InitializetionMovies(Movie[] movies)
        {
            Random ran = new Random();
            string[] genres = { "Comedy", "Drama", "Thriller", "Actioner", "Horror", "Blockbuster", "Romantic" };
            string[] titles = { "Green Mile", "Frozen", "Back to the future", "Lolita", "Braveheart", "Lost" };

            //�������������� ������ _movies
            for (int i = 0; i < movies.Length; i++)
            {
                int durationMinutes = ran.Next(40, 180);
                int releaseYear = ran.Next(1900, DateTime.Now.Year);
                double rating = Math.Round(ran.NextDouble() * (10 - 1) + 1, 2);
                int indexGenre = ran.Next(genres.Length);
                int indexTitle = ran.Next(titles.Length);
                string genre = genres[indexGenre];
                string title = titles[indexTitle]; ;
                movies[i] = new Movie(durationMinutes, releaseYear, rating, genre, title);
            }
        }
        private void PopulateEnumsListBox()
        {
            //��������� ���� ����� � ������
            Type[] types = typeof(Program).Assembly.GetTypes();

            //��������� ������ ������������
            var enumTypes = Array.FindAll(types, type => type.IsEnum);

            //��������� ����� ������������ � EnumsListBox
            foreach (var enumType in enumTypes)
            {
                EnumsListBox.Items.Add(enumType.Name);
            }
        }
        private void DefaultSelectedEnums()
        {
            EnumsListBox.SetSelected(0, true);
            ValuesListBox.SetSelected(1, true);
        }
        private void LoadSeasonComboBox()
        {
            //��������� �������� Season � SeasonComboBox
            foreach (var item in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(item);
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //������� ValuesListBox
            ValuesListBox.Items.Clear();

            if (EnumsListBox.SelectedItem != null)
            {
                //�������� ���������� �������� � EnumsListBox
                int selectedEnumName = EnumsListBox.SelectedIndex;

                //��������� ���� ����� � ������
                Type[] types = typeof(Program).Assembly.GetTypes();

                //��������� ������ ������������
                var enumTypes = Array.FindAll(types, type => type.IsEnum);

                //��������� �������� ������������ � ValuesListBox
                foreach (var item in Enum.GetValues(enumTypes[selectedEnumName]))
                {
                    ValuesListBox.Items.Add(item);
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //������� ValuesTextBox
            ValueTextBox.Clear();

            if (ValuesListBox.SelectedItem != null)
            {
                int selectedEnumName = ValuesListBox.SelectedIndex;
                ValueTextBox.AppendText(selectedEnumName.ToString());
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            //������� ResultTextBox
            ResultTextBox.Clear();

            if (WeekdayTextBox.Text == "")
            {
                MessageBox.Show("������� �����");
                return;
            }

            string inputUserText = WeekdayTextBox.Text;
            bool flagNumber = false;

            if (int.TryParse(inputUserText, out int intUserText))
            {
                if ((intUserText < 8) && (intUserText > 0))
                {
                    flagNumber = true;
                }

                int IndexWeekday = intUserText - 1;

                if (Enum.TryParse(IndexWeekday.ToString(), out Weekday valueWeekday) && (flagNumber == true))
                {
                    ResultTextBox.AppendText($"��� ���� ������ ({intUserText} = {valueWeekday})");
                }
                else
                {
                    ResultTextBox.AppendText("��� ������ ��� ������");
                }
            }
            else
            {
                if (Enum.TryParse(inputUserText, out Weekday result))
                {
                    int numericValue = (int)result;
                    ResultTextBox.AppendText($"��� ���� ������ ({inputUserText} = {numericValue + 1})");
                }
                else
                {
                    ResultTextBox.AppendText("��� ������ ��� ������");
                }
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("�������� ����� ����");
                return;
            }

            //����������� � ������������ Season
            Season selectedSeason = (Season)SeasonComboBox.SelectedItem;
            switch (selectedSeason)
            {
                case Season.Summer: MessageBox.Show("���! ������!!"); break;
                case Season.Autumn: this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69); break;
                case Season.Winter: MessageBox.Show("���! �������!"); break;
                case Season.Spring: this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69); break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem != null)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                //��������� � ��������������� TextBox's
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
                    LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Length = valueLength;
                    LengthTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (FormatException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueWidth = double.Parse(WidthTextBox.Text);
                if (valueWidth < 0)
                {
                    WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Width = valueWidth;
                    WidthTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(ColorTextBox.Text, out var value))
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = System.Drawing.Color.White;
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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedItem != null)
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];

                //��������� � ��������������� TextBox's
                TitleTextBox.Text = _currentMovie.Title.ToString();
                GenreTextBox.Text = _currentMovie.Genre.ToString();
                DurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
                ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
                RatingTextBox.Text = _currentMovie.Rating.ToString();

            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TitleTextBox.Text, out var value))
            {
                TitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                _currentMovie.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = System.Drawing.Color.White;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(GenreTextBox.Text, out var value))
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            else
            {
                _currentMovie.Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = System.Drawing.Color.White;
            }
        }

        private void DurationMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valueDurationMinutes = int.Parse(DurationMinutesTextBox.Text);
                if (valueDurationMinutes < 0)
                {
                    DurationMinutesTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentMovie.DurationMinutes = valueDurationMinutes;
                    DurationMinutesTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (FormatException)
            {
                DurationMinutesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valueReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                if (valueReleaseYear < 0)
                {
                    ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentMovie.ReleaseYear = valueReleaseYear;
                    ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (FormatException)
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueRating = double.Parse(RatingTextBox.Text);
                if (valueRating < 0)
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentMovie.Rating = valueRating;
                    RatingTextBox.BackColor = System.Drawing.Color.White;

                }
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindMoviesWithMaxRating(Movie[] movies)
        {
            int indexMaxRating = 0;
            for (int i = 1; i < movies.Length; i++)
            {
                if (movies[indexMaxRating].Rating < movies[i].Rating)
                {
                    indexMaxRating = i;
                }
            }
            return indexMaxRating;
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            int indexMax = FindMoviesWithMaxRating(_movies);
            MoviesListBox.SetSelected(indexMax, true);
        }
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
        private void ClearRectangleInfo()
        {
            HeightRectanglesTextBox.Clear();
            HeightRectanglesTextBox.BackColor = System.Drawing.Color.White;

            WidthRectanglesTextBox.Clear();
            WidthRectanglesTextBox.BackColor = System.Drawing.Color.White;

            CoordXRectanglesTextBox.Clear();
            CoordXRectanglesTextBox.BackColor = System.Drawing.Color.White;

            CoordYRectanglesTextBox.Clear();
            CoordYRectanglesTextBox.BackColor = System.Drawing.Color.White;

            IdRectanglesTextBox.Clear();
        }
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
            int CoordX = Convert.ToInt32(_currentRectangle.Center.X);
            int CoordY = Convert.ToInt32(_currentRectangle.Center.Y);
            panel.Location = new Point(CoordX, CoordY);
            panel.Width = Convert.ToInt32(_currentRectangle.Width);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

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
                    CoordXRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Center = new Point2D(valueCoordX, _currentRectangle.Center.Y);
                    UpdateListBoxItem(_currentRectangle);
                    CoordXRectanglesTextBox.BackColor = System.Drawing.Color.White;

                    int coordX = Convert.ToInt32(valueCoordX);
                    int coordY = Convert.ToInt32(_currentRectangle.Center.Y);
                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Location = new Point(coordX, coordY);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                CoordXRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void CoordYRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueCoordY = double.Parse(CoordYRectanglesTextBox.Text);
                if (valueCoordY < 0)
                {
                    CoordYRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, valueCoordY);
                    UpdateListBoxItem(_currentRectangle);
                    CoordYRectanglesTextBox.BackColor = System.Drawing.Color.White;

                    int coordX = Convert.ToInt32(_currentRectangle.Center.X);
                    int coordY = Convert.ToInt32(valueCoordY);
                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Location = new Point(coordX, coordY);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                CoordYRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueWidth = double.Parse(WidthRectanglesTextBox.Text);
                if (valueWidth < 0)
                {
                    WidthRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Width = valueWidth;
                    UpdateListBoxItem(_currentRectangle);
                    WidthRectanglesTextBox.BackColor = System.Drawing.Color.White;

                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Width = Convert.ToInt32(valueWidth);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                WidthRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void HeightRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueLength = double.Parse(HeightRectanglesTextBox.Text);
                if (valueLength < 0)
                {
                    HeightRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Length = valueLength;
                    UpdateListBoxItem(_currentRectangle);
                    HeightRectanglesTextBox.BackColor = System.Drawing.Color.White;

                    var panel = _rectanglePanels[RectangleListBox.SelectedIndex];
                    panel.Height = Convert.ToInt32(valueLength);
                }
                FindCollisions();
            }
            catch (FormatException)
            {
                HeightRectanglesTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglesList.Count(); i++)
            {
                for (int j = i + 1; j < _rectanglesList.Count(); j++)
                {
                    if (_collisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}

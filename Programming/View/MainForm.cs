using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle[] _rectangles = new Model.Classes.Rectangle[5];
        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie = new Movie();
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            DefaultSelectedEnums();
            LoadSeasonComboBox();
            InitializetionRectangles(_rectangles);
            InitializetionMovies(_movies);
        }
        private void InitializetionRectangles(Model.Classes.Rectangle[] rectangles)
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
                rectangles[i] = new Model.Classes.Rectangle(length, width, color, center);
            }
        }
        private void InitializetionMovies(Movie[] movies)
        {
            Random ran = new Random();
            string[] genres = { "Comedy", "Drama", "Thriller", "Actioner", "Horror", "Blockbuster", "Romantic" };
            string[] titles = { "Green Mile", "Frozen", "Back to the future", "Lolita", "Braveheart", "Lost" };

            //Инициализируем массив _movies
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
            //Получение всех типов в сборке
            Type[] types = typeof(Program).Assembly.GetTypes();

            //Фильтруем только перечисления
            var enumTypes = Array.FindAll(types, type => type.IsEnum);

            //Добавляем имена перечислений в EnumsListBox
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
            //Добавляем элементы Season в SeasonComboBox
            foreach (var item in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(item);
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очистка ValuesListBox
            ValuesListBox.Items.Clear();

            if (EnumsListBox.SelectedItem != null)
            {
                //Название выбранного элемента в EnumsListBox
                int selectedEnumName = EnumsListBox.SelectedIndex;

                //Получение всех типов в сборке
                Type[] types = typeof(Program).Assembly.GetTypes();

                //Фильтруем только перечисления
                var enumTypes = Array.FindAll(types, type => type.IsEnum);

                //Добавляем значения перечисления в ValuesListBox
                foreach (var item in Enum.GetValues(enumTypes[selectedEnumName]))
                {
                    ValuesListBox.Items.Add(item);
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очистка ValuesTextBox
            ValueTextBox.Clear();

            if (ValuesListBox.SelectedItem != null)
            {
                int selectedEnumName = ValuesListBox.SelectedIndex;
                ValueTextBox.AppendText(selectedEnumName.ToString());
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            //Очистка ResultTextBox
            ResultTextBox.Clear();

            if (WeekdayTextBox.Text == "")
            {
                MessageBox.Show("Введите текст");
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
                    ResultTextBox.AppendText($"Это день недели ({intUserText} = {valueWeekday})");
                }
                else
                {
                    ResultTextBox.AppendText("Нет такого дня недели");
                }
            }
            else
            {
                if (Enum.TryParse(inputUserText, out Weekday result))
                {
                    int numericValue = (int)result;
                    ResultTextBox.AppendText($"Это день недели ({inputUserText} = {numericValue + 1})");
                }
                else
                {
                    ResultTextBox.AppendText("Нет такого дня недели");
                }
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите время года");
                return;
            }

            //Преобразуем в перечисление Season
            Season selectedSeason = (Season)SeasonComboBox.SelectedItem;
            switch (selectedSeason)
            {
                case Season.Summer: MessageBox.Show("Ура! Солнце!!"); break;
                case Season.Autumn: this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69); break;
                case Season.Winter: MessageBox.Show("Брр! Холодно!"); break;
                case Season.Spring: this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69); break;
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
        private void CoordXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueCoordX = double.Parse(CoordXTextBox.Text);
                if (valueCoordX < 0)
                {
                    CoordXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Width = valueCoordX;
                    CoordXTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (FormatException)
            {
                CoordXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void CoordYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueCoordY = double.Parse(CoordYTextBox.Text);
                if (valueCoordY < 0)
                {
                    CoordYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentRectangle.Width = valueCoordY;
                    CoordYTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (FormatException)
            {
                CoordYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
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

                //Добавляем в соответствующие TextBox's
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
    }
}

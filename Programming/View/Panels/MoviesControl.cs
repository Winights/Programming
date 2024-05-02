using Programming.Model.Classes;
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
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies = new Movie[5];

        /// <summary>
        /// Переменная типа Movie.
        /// </summary>
        private Movie _currentMovie = new Movie();
        public MoviesControl()
        {
            InitializeComponent();
            InitializetionMovies(_movies);
        }

        /// <summary>
        /// Заполняет массив фильмов случайными значениями.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
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
                TitleTextBox.BackColor = AppColors.InvalidColor;
            }
            else
            {
                _currentMovie.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = AppColors.ValidColor;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(GenreTextBox.Text, out var value))
            {
                GenreTextBox.BackColor = AppColors.InvalidColor;
            }
            else
            {
                _currentMovie.Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = AppColors.ValidColor;
            }
        }

        private void DurationMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valueDurationMinutes = int.Parse(DurationMinutesTextBox.Text);
                if (valueDurationMinutes < 0)
                {
                    DurationMinutesTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentMovie.DurationMinutes = valueDurationMinutes;
                    DurationMinutesTextBox.BackColor = AppColors.ValidColor;
                }
            }
            catch (FormatException)
            {
                DurationMinutesTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valueReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                if (valueReleaseYear < 0)
                {
                    ReleaseYearTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentMovie.ReleaseYear = valueReleaseYear;
                    ReleaseYearTextBox.BackColor = AppColors.ValidColor;
                }
            }
            catch (FormatException)
            {
                ReleaseYearTextBox.BackColor = AppColors.InvalidColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                ReleaseYearTextBox.BackColor = AppColors.InvalidColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueRating = double.Parse(RatingTextBox.Text);
                if (valueRating < 0)
                {
                    RatingTextBox.BackColor = AppColors.InvalidColor;
                }
                else
                {
                    _currentMovie.Rating = valueRating;
                    RatingTextBox.BackColor = AppColors.ValidColor;

                }
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = AppColors.InvalidColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                RatingTextBox.BackColor = AppColors.InvalidColor;
            }
        }
        /// <summary>
        /// Ищет индекс элемента массива с большим рейтингом.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
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

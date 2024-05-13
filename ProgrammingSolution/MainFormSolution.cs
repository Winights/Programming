using ProgrammingSolution.ModelSolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgrammingSolution
{
    public partial class MainFormSolution : Form
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Books> _booksList = new List<Books>();

        /// <summary>
        /// Переменная типа Rectangle.
        /// </summary>
        private Books _currentBooks = new Books();
        public MainFormSolution()
        {
            InitializeComponent();
            LoadGenreComboBox();
        }
        private void LoadGenreComboBox()
        {
            //Добавляем элементы Genres в GenreComboBox
            foreach (var item in Enum.GetValues(typeof(Genres)))
            {
                GenreComboBox.Items.Add(item);
            }
        }
        private void UpdateListBox()
        {
            BooksListBox.Items.Clear();

            for (int i = 0; i < _booksList.Count; i++)
            {
                _currentBooks = _booksList[i];
                BooksListBox.Items.Add($"Название {_currentBooks.Title} / Автор {_currentBooks.Author} / " +
                    $"Жанр {_currentBooks.Genre}");
            }
        }
        private void AddBooksInfo(Books book)
        {
            if (GenreComboBox.SelectedItem != null)
            {
                book.Title = TitleTextBox.Text;
                book.YearOfIssue = int.Parse(YearOfIssueTextBox.Text);
                book.Author = AuthorTextBox.Text;
                book.Pages = int.Parse(PagesTextBox.Text);
                book.Genre = (Genres)GenreComboBox.SelectedItem;
            }
        }
        private void ClearBookInfo()
        {
            TitleTextBox.Clear();
            TitleTextBox.BackColor = Color.White;

            YearOfIssueTextBox.Clear();
            YearOfIssueTextBox.BackColor = Color.White;

            AuthorTextBox.Clear();
            AuthorTextBox.BackColor = Color.White;

            PagesTextBox.Clear();
            PagesTextBox.BackColor = Color.White;

            GenreComboBox.SelectedIndex = -1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем список TextBox'ов, которые нужно проверить
            var textBoxes = new List<System.Windows.Forms.TextBox> { TitleTextBox, YearOfIssueTextBox,
                AuthorTextBox, PagesTextBox };

            // Проверяем, что все TextBox'ы не пустые
            if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && GenreComboBox.SelectedItem != null)
            {
                AddBooksInfo(_currentBooks);
                _booksList.Add(_currentBooks);
                UpdateListBox();
                ClearBookInfo();
            }
            else
            {
                // Выводим сообщение, если какой-либо TextBox пустой
                MessageBox.Show("Заполните соответсвующие поля или выберите жанр.");
                return;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1)
            {
                _booksList.RemoveAt(BooksListBox.SelectedIndex);
                BooksListBox.Items.RemoveAt(BooksListBox.SelectedIndex);
                ClearBookInfo();
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearOfIssueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valueYear = int.Parse(YearOfIssueTextBox.Text);
                if (valueYear < 0)
                {
                    YearOfIssueTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    _currentBooks.YearOfIssue = valueYear;
                    YearOfIssueTextBox.BackColor = Color.White;

                }
            }
            catch (FormatException)
            {
                YearOfIssueTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                YearOfIssueTextBox.BackColor = Color.LightPink;
            }
        }


        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void PagesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valuePages = int.Parse(PagesTextBox.Text);
                if (valuePages < 0)
                {
                    PagesTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    _currentBooks.Pages = valuePages;
                    PagesTextBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                PagesTextBox.BackColor = Color.LightPink;
            }
            catch (NullReferenceException)
            {
                PagesTextBox.BackColor = Color.LightPink;
            }

        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                _currentBooks = _booksList[BooksListBox.SelectedIndex];
                UpdateRectangleInfo(_currentBooks);
            }
            if (BooksListBox.SelectedIndex == -1)
            {
                ClearBookInfo();
            }
        }
        private void UpdateRectangleInfo(Books book)
        {
            TitleTextBox.Text = book.Title.ToString();
            YearOfIssueTextBox.Text = book.YearOfIssue.ToString();
            AuthorTextBox.Text = book.Author.ToString();
            PagesTextBox.Text = book.Pages.ToString();
            GenreComboBox.Text = book.Genre.ToString();
        }
    }
}

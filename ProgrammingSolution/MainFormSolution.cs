using ProgrammingSolution.ModelSolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgrammingSolution
{
    public partial class MainFormSolution : Form
    {
        /// <summary>
        /// Список книг.
        /// </summary>
        private List<Books> _booksList = new List<Books>();

        /// <summary>
        /// Переменная типа Rectangle.
        /// </summary>
        private Books _currentBooks = new Books();

        /// <summary>
        /// Список отсортированных книг.
        /// </summary>
        private List<Books> _sortedBooks = new List<Books>();
        private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string _filePath = Path.Combine(_appDataPath, "AppBook/BooksInfo"); // Путь к файлу
        public MainFormSolution()
        {
            InitializeComponent();
            LoadGenreComboBox();
            LoadBooksListBox();
        }
        private void LoadGenreComboBox()
        {
            //Добавляем элементы Genres в GenreComboBox
            foreach (var item in Enum.GetValues(typeof(Genres)))
            {
                GenreComboBox.Items.Add(item);
            }
        }
        private void SaveToFile()
        {
            // Запись массива в файл
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                for (int i = 0; i < _sortedBooks.Count; i++)
                {
                    _currentBooks = _sortedBooks[i];
                    writer.WriteLine($"{_currentBooks.Title},{_currentBooks.YearOfIssue},{_currentBooks.Author},{_currentBooks.Pages},{_currentBooks.Genre}");
                }
            }
        }
        private void LoadBooksListBox()
        {
            // Создание пути к файлу, если он не существует
            if (!Directory.Exists(Path.GetDirectoryName(_filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
            }
            else if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Dispose();
            }
            else
            {
                string[] lines = File.ReadAllLines(_filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        int yearOfIssue = int.Parse(parts[1]);
                        int pages = int.Parse(parts[3]);
                        Enum.TryParse(parts[4], out Genres genre);
                        _currentBooks = new Books(parts[0], yearOfIssue, parts[2], pages, genre);
                        BooksListBox.Items.Add($"{_currentBooks.Title} / {_currentBooks.Author} / {_currentBooks.Genre}");
                        _booksList.Add(_currentBooks);
                        _sortedBooks.Add(_currentBooks);
                    }
                }
            }
        }
        private void UpdateListBox()
        {
            BooksListBox.Items.Clear();

            // Сортируем список книг по названиям
            _sortedBooks = _booksList.OrderBy(book => book.Title).ToList();

           
            foreach (var book in _sortedBooks)
            {
                BooksListBox.Items.Add($"{book.Title} / {book.Author} / {book.Genre}");
            }
            SaveToFile();
        }
        private void AddBooksInfo()
        {
            if (GenreComboBox.SelectedItem != null)
            {
                string title = TitleTextBox.Text;
                int yearOfIssue = int.Parse(YearOfIssueTextBox.Text);
                string author = AuthorTextBox.Text;
                int pages = int.Parse(PagesTextBox.Text);
                Genres genre = (Genres)GenreComboBox.SelectedItem;
                _currentBooks = new Books(title, yearOfIssue, author, pages, genre);
            }
        }
        private void EditBooksInfo()
        {
            if (GenreComboBox.SelectedItem != null)
            {
                _currentBooks.Title = TitleTextBox.Text;
                _currentBooks.YearOfIssue = int.Parse(YearOfIssueTextBox.Text);
                _currentBooks.Author = AuthorTextBox.Text;
                _currentBooks.Pages = int.Parse(PagesTextBox.Text);
                _currentBooks.Genre = (Genres)GenreComboBox.SelectedItem;
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

            bool ifRed = true;

            foreach (var textBox in textBoxes)
            {
                if (textBox.BackColor == Color.LightPink)
                {
                    ifRed = false;
                }
            }
            // Проверяем, что все TextBox'ы не пустые
            if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && GenreComboBox.SelectedItem != null
                && ifRed)
            {
                AddBooksInfo();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditBooksInfo();
            UpdateListBox();
            ClearBookInfo();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            string valueTitle = TitleTextBox.Text;
            if (valueTitle.Length == 0)
            {
                TitleTextBox.BackColor = Color.LightPink;
            }
            else
            {
                TitleTextBox.BackColor = Color.White;

            }
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
            catch (NullReferenceException)
            {
                PagesTextBox.BackColor = Color.LightPink;
            }
        }
        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            string valueAuthor = AuthorTextBox.Text;
            if (!Regex.IsMatch(valueAuthor, @"^[a-zA-Zа-яА-Я ,.!?;:'-]*$") || valueAuthor.Length == 0)
            {
                AuthorTextBox.BackColor = Color.LightPink;
            }
            else
            {
                AuthorTextBox.BackColor = Color.White;

            }
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
                _currentBooks = _sortedBooks[BooksListBox.SelectedIndex];
                UpdateBookInfo(_currentBooks);
            }
            if (BooksListBox.SelectedIndex == -1)
            {
                ClearBookInfo();
            }
        }
        private void UpdateBookInfo(Books book)
        {
            TitleTextBox.Text = book.Title.ToString();
            YearOfIssueTextBox.Text = book.YearOfIssue.ToString();
            AuthorTextBox.Text = book.Author.ToString();
            PagesTextBox.Text = book.Pages.ToString();
            GenreComboBox.Text = book.Genre.ToString();
        }
    }
}

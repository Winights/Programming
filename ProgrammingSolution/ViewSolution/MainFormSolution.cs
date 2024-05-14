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
        private List<Book> _booksList = new List<Book>();

        /// <summary>
        /// Переменная типа Rectangle.
        /// </summary>
        private Book _currentBook = new Book();

        /// <summary>
        /// Путь к AppData/Local.
        /// </summary>
        private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        /// <summary>
        /// Путь к AppBook/BooksInfo.
        /// </summary>
        private string _filePath = Path.Combine(_appDataPath, "AppBook/BooksInfo"); // Путь к файлу
        public MainFormSolution()
        {
            InitializeComponent();
            LoadGenreComboBox();
            LoadBooksListBox();
        }

        /// <summary>
        /// Добавляет элементы Genres в GenreComboBox.
        /// </summary>
        private void LoadGenreComboBox()
        {
            //Добавляем элементы Genres в GenreComboBox
            foreach (var item in Enum.GetValues(typeof(Genre)))
            {
                GenreComboBox.Items.Add(item);
            }
        }
        /// <summary>
        /// Записывает элементы списка книг в файл BookInfo.
        /// </summary>
        private void SaveToFile()
        {
            // Запись массива в файл
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                for (int i = 0; i < _booksList.Count; i++)
                {
                    _currentBook = _booksList[i];
                    writer.WriteLine($"{_currentBook.Title},{_currentBook.YearOfIssue}," +
                        $"{_currentBook.Author},{_currentBook.Pages},{_currentBook.Genre}");
                }
            }
        }
        /// <summary>
        /// Добавляет из файла BookInfo данные в BooksListBox и в список книг.
        /// </summary>
        private void LoadBooksListBox()
        {
            // Создание пути к файлу, если он не существует
            if (!Directory.Exists(Path.GetDirectoryName(_filePath)))
            {
                if (_filePath != null && !Directory.Exists(Path.GetDirectoryName(_filePath) ?? ""))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(_filePath) ?? "");
                }
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
                        Enum.TryParse(parts[4], out Genre genre);
                        _currentBook = new Book(parts[0], yearOfIssue, parts[2], pages, genre);
                        BookListBox.Items.Add($"{_currentBook.Title} / {_currentBook.Author} / {_currentBook.Genre}");
                        _booksList.Add(_currentBook);
                    }
                }
            }
        }
        /// <summary>
        /// Добавляет элементы списка в BooksListBox.
        /// </summary>
        private void UpdateListBox()
        {
            BookListBox.Items.Clear();

            // Сортируем список книг по названиям
            List<Book> sortedBooks = _booksList.OrderBy(book => book.Title).ToList();
            _booksList = sortedBooks;
   
            foreach (var book in _booksList)
            {
                BookListBox.Items.Add($"{book.Title} / {book.Author} / {book.Genre}");
            }
            SaveToFile();
        }
        /// <summary>
        /// Генерирует объект книги с помощью TextBox's.
        /// </summary>
        private void AddBooksInfo()
        {
            if (GenreComboBox.SelectedItem != null)
            {
                string title = TitleTextBox.Text;
                int yearOfIssue = int.Parse(YearOfIssueTextBox.Text);
                string author = AuthorTextBox.Text;
                int pages = int.Parse(PagesTextBox.Text);
                Genre genre = (Genre)GenreComboBox.SelectedItem;
                _currentBook = new Book(title, yearOfIssue, author, pages, genre);
            }
        }
        /// <summary>
        /// Редактирует объект книги с помощью TextBox's.
        /// </summary>
        private void EditBooksInfo()
        {
            if (GenreComboBox.SelectedItem != null)
            {
                _currentBook.Title = TitleTextBox.Text;
                _currentBook.YearOfIssue = int.Parse(YearOfIssueTextBox.Text);
                _currentBook.Author = AuthorTextBox.Text;
                _currentBook.Pages = int.Parse(PagesTextBox.Text);
                _currentBook.Genre = (Genre)GenreComboBox.SelectedItem;
            }
        }
        /// <summary>
        /// Очищает информацию о книге в TextBox's.
        /// </summary>
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
        /// <summary>
        /// Обновляет информацию о книге в TextBox's.
        /// </summary>
        /// <param name="book">Обновляемая книга.</param>
        private void UpdateBookInfo(Book book)
        {
            TitleTextBox.Text = book.Title.ToString();
            YearOfIssueTextBox.Text = book.YearOfIssue.ToString();
            AuthorTextBox.Text = book.Author.ToString();
            PagesTextBox.Text = book.Pages.ToString();
            GenreComboBox.Text = book.Genre.ToString();
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
                _booksList.Add(_currentBook);
                UpdateListBox();
                ClearBookInfo();
            }
            else if (!ifRed)
            {
                // Выводим сообщение, если какой-либо TextBox покрашен в красный
                MessageBox.Show(
                    "Некоректные значения. Введите корректные значения для корректной работы программы",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                // Выводим сообщение, если какой-либо TextBox пустой
                MessageBox.Show(
                    "Введите данные в поля или выберете жанр для корректной работы программы",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex != -1)
            {
                _booksList.RemoveAt(BookListBox.SelectedIndex);
                BookListBox.Items.RemoveAt(BookListBox.SelectedIndex);
                ClearBookInfo();
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
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
            if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && GenreComboBox.SelectedItem != null && ifRed)
            {
                EditBooksInfo();
                UpdateListBox();
                ClearBookInfo();
            }
            else if (!ifRed)
            {
                // Выводим сообщение, если какой-либо TextBox пустой
                MessageBox.Show(
                    "Некоректные значения. Введите корректные значения для корректной работы программы",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                // Выводим сообщение, если какой-либо TextBox пустой
                MessageBox.Show(
                    "Введите данные в поля или выберете жанр для корректной работы программы",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
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
                    _currentBook.YearOfIssue = valueYear;
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
                    _currentBook.Pages = valuePages;
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
            if (BookListBox.SelectedItem != null)
            {
                _currentBook = _booksList[BookListBox.SelectedIndex];
                UpdateBookInfo(_currentBook);
            }
            if (BookListBox.SelectedIndex == -1)
            {
                ClearBookInfo();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ProgrammingSolution.ModelSolution
{
    /// <summary>
    /// Хранит данные о книге.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Название книги.
        /// </summary>
        private string _title = string.Empty;

        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _yearOfIssue;

        /// <summary>
        /// Возвращает и задает автора книги.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        private int _pages;

        /// <summary>
        /// Возвращает и задает жанр книги.
        /// </summary>
        public Genre Genre {  get; set; }

        /// <summary>
        /// Возвращает и задает название книги. Длина должно быть не более 100 символов.
        /// </summary>
        public string Title 
        { 
            get 
            { 
                return _title; 
            } 
            set 
            {
                Validator.AssertStringLength(value, 100, "Title");
                _title = value; 
            } 
        }

        /// <summary>
        /// Возвращает и задает количество страниц. Должен быть положительным числом.
        /// </summary>
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Pages");
                _pages = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска. Должен быть положительным числом и быть не более текущего года.
        /// </summary>
        public int YearOfIssue
        {
            get
            {
                return _yearOfIssue;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, DateTime.Now.Year, "YearOfIssue");
                _yearOfIssue = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Book"/>.
        /// </summary>
        /// <param name="title">Название книги.</param>
        /// <param name="yearOfIssue">Год выпуска.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="pages">Количество страниц.</param>
        /// <param name="genre">Жанр книги.</param>
        public Book(string title, int yearOfIssue, string author, int pages, Genre genre)
        {
            Title = title;
            YearOfIssue = yearOfIssue;
            Author = author;
            Pages = pages;
            Genre = genre;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Book"/>.
        /// </summary>
        public Book()
        {
            Title = "";
            YearOfIssue = 0;
            Author = "";
            Pages = 0;
            Genre = 0;
        }
    }
}

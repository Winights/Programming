using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ProgrammingSolution.ModelSolution
{
    public class Books
    {
        private string _title = string.Empty;
        private int _yearOfIssue;
        public string Author { get; set; }
        private int _pages;
        public Genres Genre {  get; set; } 

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
        
        public Books(string title, int yearOfIssue, string author, int pages, Genres genre)
        {
            Title = title;
            YearOfIssue = yearOfIssue;
            Author = author;
            Pages = pages;
            Genre = genre;
        }
        public Books()
        {
            Title = "";
            YearOfIssue = 0;
            Author = "";
            Pages = 0;
            Genre = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактных данных.
    /// </summary>
    public class Contact
    {
        private string _name = string.Empty;
        private string _surname = string.Empty;
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, "Name");
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }
        private void AssertStringContainsOnlyLetters(string value, string Name)
        {
            bool consistsOfEnglishLetters = Regex.IsMatch(value, @"^[a-zA-Z]+$");
            if (consistsOfEnglishLetters == false)
            {
                throw new ArgumentException($"Строка должна содержать только символы английского алфавита. Ошибка в {Name}");
            }
        }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string surname, string phoneNumber, string email)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Contact()
        {
            Name = "";
            Surname = "";
            PhoneNumber = "";
            Email = "";
        }
    }
    
}

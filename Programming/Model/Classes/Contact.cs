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
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname = string.Empty;

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должно состоять только из букв.
        /// </summary>
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

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="Name">Имя свойства или объекта, которое подлежит проверке.</param>
        private void AssertStringContainsOnlyLetters(string value, string Name)
        {
            bool consistsOfEnglishLetters = Regex.IsMatch(value, @"^[a-zA-Z]+$");
            if (consistsOfEnglishLetters == false)
            {
                throw new ArgumentException($"Строка должна содержать только символы английского алфавита. Ошибка в {Name}");
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="phoneNumber">Номер контакта.</param>
        /// <param name="email">Почта контакта.</param>

        public Contact(string name, string surname, string phoneNumber, string email)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            Name = "";
            Surname = "";
            PhoneNumber = "";
            Email = "";
        }
    }
    
}

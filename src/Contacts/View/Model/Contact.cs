using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email = string.Empty;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber = string.Empty;

        /// <summary>
        /// Возвращает и задает полное имя контакта. Должен не превышать 200 символов.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnEmpty(value, "Fullname");
                ValueValidator.AssertStringOnLength(value, 100, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта. Должен не превышать 250 символов.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                ValueValidator.AssertStringOnEmail(value, "Email");
                ValueValidator.AssertStringOnLength(value, 100, "Email");
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта. Должен быть в формате номера телефона.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                ValueValidator.AssertStringOnPhoneNumber(value, "PhoneNumber");
                _phoneNumber = PhoneNumberFormatter.FormatPhoneNumber(value);
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="fullname">Полное имя контакта.</param>
        /// <param name="email">Почта контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        public Contact(string fullname, string email, string phoneNumber)
        {
            Fullname = fullname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            Fullname = "Alexsandr Ivanov";
            Email = "yuri.smirnov@no.mail";
            PhoneNumber = "+79999999999";
        }
    }
}

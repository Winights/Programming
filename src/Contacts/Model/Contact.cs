using Model.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : ObservableObject
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
                ValueValidator.AssertStringOnEmpty(value, nameof(Fullname));
                ValueValidator.AssertStringOnName(value, nameof(Fullname));
                ValueValidator.AssertStringOnLength(value, 100, nameof(Fullname));
                SetProperty(ref _fullname, value);
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
                ValueValidator.AssertStringOnEmail(value, nameof(Email));
                ValueValidator.AssertStringOnLength(value, 100, nameof(Email));
                SetProperty(ref _email, value);
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
                ValueValidator.AssertStringOnPhoneNumber(value, nameof(PhoneNumber));
                SetProperty(ref _phoneNumber, PhoneNumberFormatter.Format(value));
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

        }
    }
}

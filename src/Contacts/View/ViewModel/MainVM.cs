using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику для работы с интерфейсом.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает и задает новое значение для контакта. Должен быть новым значением 
        /// для обновления информации.
        /// </summary>
        public Contact Contact
        { 
            get 
            { 
                return _contact;
            }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя контакта.Должен быть новым значением 
        /// для обновления информации.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _contact?.Fullname;
            }
            set
            {
                if (_contact.Fullname != value && _contact != null)
                {
                    _contact.Fullname = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.Должен быть новым значением 
        /// для обновления информации.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact?.PhoneNumber;
            }
            set
            {
                if (value != _contact?.PhoneNumber && _contact != null)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.Должен быть новым значением 
        /// для обновления информации.
        /// </summary>
        public string Email
        {
            get 
            {
                return _contact?.Email;
            }
            set
            {
                if (_contact.Email != value && _contact != null)
                {
                    _contact.Email = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Событие изменения информации о контакте.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Сообщает интерфейсу об изменении значения в свойстве.
        /// </summary>
        /// <param name="prop">Имя свойства, в котором произошло событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public MainVM()
        {
            Contact = new Contact();
        }
    }
}

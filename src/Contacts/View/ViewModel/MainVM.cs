using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику для работы с основным окном.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Объект контакта.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Команда для сохранения объекта в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда для загрузки объекта их файла.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Возвращает и задает новое значение для объекта контакта. Должен быть новым значением 
        /// для обновления информации.
        /// </summary>
        public Contact CurrentContact
        { 
            get 
            { 
                return _currentContact;
            }
            set
            {
                if (_currentContact != value)
                {
                    _currentContact = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя контакта. Должен быть новым значением 
        /// для обновления информации и не пустым.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _currentContact?.Fullname;
            }
            set
            {
                if (_currentContact.Fullname != value && value != null)
                {
                    _currentContact.Fullname = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта. Должен быть новым значением 
        /// для обновления информации и не пустым.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _currentContact?.PhoneNumber;
            }
            set
            {
                if (value != _currentContact?.PhoneNumber && value != null)
                {
                    _currentContact.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта. Должен быть новым значением 
        /// для обновления информации и не пустым.
        /// </summary>
        public string Email
        {
            get 
            {
                return _currentContact?.Email;
            }
            set
            {
                if (_currentContact.Email != value && value != null)
                {
                    _currentContact.Email = value;
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
        /// Создаёт пустой экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurrentContact = new Contact();
            SaveCommand = new SaveCommand(CurrentContact);
            LoadCommand = new LoadCommand(contact => CurrentContact = contact);
        }
    }
}

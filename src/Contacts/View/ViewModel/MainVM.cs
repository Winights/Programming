using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model;
using View.Model.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Флаг, показывающий идет ли создание нового контакта или нет.
        /// </summary>
        private bool _isCreatingContact = false;

        /// <summary>
        /// Флаг, показывающий идет ли редактирование контакта или нет.
        /// </summary>
        private bool _isEditingContact = false;

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; } 
            = new ObservableCollection<Contact>();


        /// <summary>
        /// Событие изменения информации о контакте.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Команда для добавления контакта.
        /// </summary>
        public ICommand AddContactCommand { get; }

        /// <summary>
        /// Команда для редактирования контакта.
        /// </summary>
        public ICommand EditContactCommand { get; }

        /// <summary>
        /// Команда для сохранения контакта в списке.
        /// </summary>
        public ICommand ApplyContactCommand { get; }

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
        /// Возвращает и задает выбранный контакт. Если шло создание нового контакта 
        /// или редактирование, то создание отменяется.
        /// </summary>
        public Contact SelectedContact
        {
            get
            {
               return _selectedContact;
            }
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;

                    if (IsCreatingContact || IsEditingContact)
                    {
                        CancelContact();
                    }

                    CurrentContact = _selectedContact;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsEditEnabled));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает флаг, показывающий создание нового контакта. 
        /// </summary>
        public bool IsCreatingContact
        {
            get
            {
                return _isCreatingContact;
            }
            private set
            {
                _isCreatingContact = value;
                OnPropertyChanged(nameof(IsCreatingContact));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(IsEnabled));
                OnPropertyChanged(nameof(IsVisibleApply));
            }
        }

        /// <summary>
        /// Возвращает и задает флаг, показывающий редактирование контакта. 
        /// </summary>
        public bool IsEditingContact
        {
            get
            {
                return _isEditingContact;
            }
            private set
            {
                _isEditingContact = value;
                OnPropertyChanged(nameof(IsEditingContact));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(IsEnabled));
                OnPropertyChanged(nameof(IsVisibleApply));
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
                return _currentContact.Fullname;
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
                return _currentContact.PhoneNumber;
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
                return _currentContact.Email;
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
        /// Сообщает интерфейсу об изменении значения в свойстве.
        /// </summary>
        /// <param name="prop">Имя свойства, в котором произошло событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        /// <summary>
        /// Начинает процесс создания контакта.
        /// </summary>
        private void StartNewContact()
        {
            SelectedContact = null; 
            CurrentContact = new Contact();
            IsCreatingContact = true;
            IsEditingContact = false;
        }

        /// <summary>
        /// Сохраняет новый контакт и изменения в список.
        /// </summary>
        private void SaveChanges()
        {
            if (CurrentContact == null)
            {
                return;
            }

            if (IsCreatingContact)
            {
                Contacts.Add(CurrentContact);
                SelectedContact = CurrentContact;
                IsCreatingContact = false;
            }

            if (IsEditingContact)
            {
                SelectedContact.Fullname = CurrentContact.Fullname;
                SelectedContact.Email = CurrentContact.Email;
                SelectedContact.PhoneNumber = CurrentContact.PhoneNumber;
                IsEditingContact = false;
            }
        }

        /// <summary>
        /// Отменяет создание и редактирование контакта.
        /// </summary>
        private void CancelContact()
        {
            IsCreatingContact = false;
            IsEditingContact = false;

            if (_selectedContact != null)
            {
                CurrentContact = _selectedContact;
            }

            CurrentContact = Contacts.Any() ? Contacts.First() : new Contact();
        }

        /// <summary>
        /// Начинает процесс редактирование контакта.
        /// </summary>
        private void StartEditContact()
        {
            if (SelectedContact == null)
            {
                return;
            }

            IsEditingContact = true;
            IsCreatingContact = false;
            CurrentContact = new Contact
            {
                Fullname = SelectedContact.Fullname,
                PhoneNumber = SelectedContact.PhoneNumber,
                Email = SelectedContact.Email
            };

        }

        /// <summary>
        /// Возвращает флаг, показывающий доступны ли поля или нет.
        /// </summary>
        public bool IsReadOnly => !(IsCreatingContact || IsEditingContact);

        /// <summary>
        /// Возвращает флаг, показывающий доступны ли кнопки или нет.
        /// </summary>
        public bool IsEnabled => !IsCreatingContact;

        /// <summary>
        /// Возвращает флаг, показывающий доступнв ли кнопка редактирования или нет.
        /// </summary>
        public bool IsEditEnabled => SelectedContact != null;

        /// <summary>
        /// Возвращает флаг, показывающий видна ли кнопка Apply или нет.
        /// </summary>
        public bool IsVisibleApply => (IsCreatingContact || IsEditingContact);

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurrentContact = new Contact();
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
            AddContactCommand = new RelayCommand(_ => StartNewContact());
            EditContactCommand = new RelayCommand(_ => StartEditContact());
            ApplyContactCommand = new RelayCommand(_ => SaveChanges(), _ => (IsCreatingContact 
            || IsEditingContact));
        }
    }
}

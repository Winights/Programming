using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
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
        /// Выбранный контакта.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Копия контакта.
        /// </summary>
        private Contact _originalContact;

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
        public ICommand AddContactCommand 
        { 
            get 
            {
                return new RelayCommand(create => StartСreatNewContact(),
                condition => IsInEditingOrCreatingMode);
            } 
        }

        /// <summary>
        /// Команда для редактирования контакта.
        /// </summary>
        public ICommand EditContactCommand
        {
            get
            {
                return new RelayCommand(edit => StartEditContact(),
                condition => IsInEditingOrCreatingMode && IsEnabled);
            }
        }

        /// <summary>
        /// Команда для сохранения контакта в списке.
        /// </summary>
        public ICommand ApplyContactCommand 
        { 
            get
            {
                return new RelayCommand(apply => ApplyExecute(),
                    condition => IsApplyEnabled);
            }
        }

        /// <summary>
        /// Команда для удаления контакта в списке.
        /// </summary>
        public ICommand RemoveContactCommand
        {
            get
            {
                return new RelayCommand(remove => RemoveContact(),
                condition => IsEnabled && IsInEditingOrCreatingMode);
            }
        }

        /// <summary>
        /// Возвращает и задает новое значение для объекта контакта. 
        /// Должен быть новым значением для обновления информации.
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
                    if (IsCreatingContact || IsEditingContact)
                    {
                        CancelContact();
                    }

                    _currentContact = value;
                    OnPropertyChanged();
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
                OnPropertyChanged(nameof(IsInEditingOrCreatingMode));
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
                OnPropertyChanged(nameof(IsInEditingOrCreatingMode));
                OnPropertyChanged(nameof(IsVisibleApply));
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий в моде создания или редактирования ли кнопки или нет.
        /// </summary>
        public bool IsInEditingOrCreatingMode
        {
            get
            {
                return !(IsCreatingContact || IsEditingContact);
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий видна ли кнопка Apply или нет.
        /// </summary>
        public bool IsVisibleApply
        {
            get
            {
                return IsCreatingContact || IsEditingContact;
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий доступна ли кнопка Apply или нет.
        /// </summary>
        public bool IsApplyEnabled
        {
            get
            {
                return CurrentContact == null || 
                    (string.IsNullOrWhiteSpace(CurrentContact.Email)
                    && string.IsNullOrWhiteSpace(CurrentContact.Fullname) &&
                    string.IsNullOrWhiteSpace(CurrentContact.PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий выбран ли контакт или нет.
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return CurrentContact != null;
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.LoadContacts();
        }

        /// <summary>
        /// Начинает процесс создания контакта.
        /// </summary>
        private void StartСreatNewContact()
        {
            _originalContact = null;
            CurrentContact = new Contact();
            IsCreatingContact = true;
            IsEditingContact = false;
        }

        /// <summary>
        /// Сохраняет новый контакт и изменения в список.
        /// </summary>
        private void ApplyExecute()
        {
            if (IsCreatingContact)
            {
                Contacts.Add(CurrentContact);
                IsCreatingContact = false;
            }

            if (IsEditingContact)
            {
                IsEditingContact = false;
                _originalContact = null;
            }
        }

        /// <summary>
        /// Отменяет создание и редактирование контакта.
        /// </summary>
        private void CancelContact()
        {
            if (IsEditingContact)
            {
                CurrentContact.Email = _originalContact.Email;
                CurrentContact.Fullname = _originalContact.Fullname;
                CurrentContact.PhoneNumber = _originalContact.PhoneNumber;
                IsEditingContact = false;
            }
            IsCreatingContact = false;         
        }

        /// <summary>
        /// Начинает процесс редактирование контакта.
        /// </summary>
        private void StartEditContact()
        {
            if (CurrentContact == null)
            {
                return;
            }

            IsEditingContact = true;
            _originalContact = new Contact
            {
                Email = CurrentContact.Email,
                PhoneNumber = CurrentContact.PhoneNumber,
                Fullname = CurrentContact.Fullname,
            };
        }

        /// <summary>
        /// Начинает процесс удаление контакта.
        /// </summary>
        private void RemoveContact()
        {
            if (CurrentContact == null)
            {
                return;
            }

            int index = Contacts.IndexOf(CurrentContact);
            Contacts.Remove(CurrentContact);

            if (Contacts.Count == 0)
            {
                CurrentContact = null;
            }
            else if (index >= Contacts.Count)
            {
                CurrentContact = Contacts.Last();
            }
            else
            {
                CurrentContact = Contacts[index];
            }              
        }

        /// <summary>
        /// Сообщает интерфейсу об изменении значения в свойстве.
        /// </summary>
        /// <param name="prop">Имя свойства, в котором произошло событие.</param>
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        /// <summary>
        /// Сохранеяет список контактов после закрытия программы.
        /// </summary>
        public void SaveOnExit()
        {
            ContactSerializer.SaveContacts(Contacts);
        }
    }
}

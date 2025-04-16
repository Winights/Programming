using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model.Services;
using Model;

namespace ViewModel
{
    /// <summary>
    /// Реализует логику для работы с основным окном.
    /// </summary>
    public partial class MainVM : ObservableObject
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

                    SetProperty(ref _currentContact, value);
                    UpdateContactSubscription(value);

                    EditContactCommand.NotifyCanExecuteChanged();
                    RemoveContactCommand.NotifyCanExecuteChanged();
                    ApplyContactCommand.NotifyCanExecuteChanged();
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
                SetProperty(ref _isCreatingContact, value);
                UpdatePropertyChanged();
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
                SetProperty(ref _isEditingContact, value);
                UpdatePropertyChanged();
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
                (!string.IsNullOrWhiteSpace(CurrentContact.Email)
                && !string.IsNullOrWhiteSpace(CurrentContact.Fullname) &&
                !string.IsNullOrWhiteSpace(CurrentContact.PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий выбран ли контакт или нет.
        /// </summary>
        public bool IsEditRemoveAvailable
        {
            get
            {
                return CurrentContact != null && IsInEditingOrCreatingMode;
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
        [RelayCommand(CanExecute = nameof(IsInEditingOrCreatingMode))]
        private void AddContact()
        {
            _originalContact = null;
            CurrentContact = new Contact();
            IsCreatingContact = true;
            IsEditingContact = false;
        }

        /// <summary>
        /// Сохраняет новый контакт и изменения в список.
        /// </summary>
        [RelayCommand(CanExecute = nameof(IsApplyEnabled))]
        private void ApplyContact()
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
        [RelayCommand(CanExecute = nameof(IsEditRemoveAvailable))]
        private void EditContact()
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
        [RelayCommand(CanExecute = nameof(IsEditRemoveAvailable))]
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
        /// Уведомляет интерфейс о изменениях свойств.
        /// </summary>
        private void UpdatePropertyChanged()
        {
            OnPropertyChanged(nameof(IsInEditingOrCreatingMode));
            OnPropertyChanged(nameof(IsVisibleApply));
            EditContactCommand.NotifyCanExecuteChanged();
            RemoveContactCommand.NotifyCanExecuteChanged();
        }

        private void UpdateContactSubscription(Contact? newContact)
        {
            if (_currentContact != null)
            {
                _currentContact.PropertyChanged -= OnCurrentContactPropertyChanged;
            }

            if (newContact != null)
            {
                newContact.PropertyChanged += OnCurrentContactPropertyChanged;
            }
        }

        /// <summary>
        /// Если одно из полей изменилось, то уведомляет интерфейс.
        /// </summary>
        private void OnCurrentContactPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Contact.Email) ||
                e.PropertyName == nameof(Contact.Fullname) ||
                e.PropertyName == nameof(Contact.PhoneNumber))
            {
                ApplyContactCommand.NotifyCanExecuteChanged();
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

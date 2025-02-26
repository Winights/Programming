using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику для загрузки объекта контакта из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Ссылка на метод обновления контакта.
        /// </summary>
        private readonly Action<Contact> _updateContact;

        /// <summary>
        /// Событие для команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Может ли команда выполниться.
        /// </summary>
        /// <param name="parameter">Дополнительная информация при вызове команды.</param>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Логика для выполнения команды, а именно загрузки объекта контакта из файла.
        /// </summary>
        /// <param name="parameter">Дополнительная информация при вызове команды.</param>
        public void Execute(object parameter) 
        {
            var contact = ContactSerializer.LoadContact();
            if (contact != null)
            {
                _updateContact(contact);
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="updateContact">ССылка на метод обновления контакта.</param>
        public LoadCommand(Action<Contact> updateContact)
        {
            _updateContact = updateContact;
        }
    }
}

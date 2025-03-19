using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику для сохранения объекта контакта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Ссылка на MainVM.
        /// </summary>
        private readonly MainVM _mainVM;

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
        /// Логика для выполнения команды, а именно сохранения объекта контакта в файл.
        /// </summary>
        /// <param name="parameter">Дополнительная информация при вызове команды.</param>
        public void Execute(object parameter)
        {
            ContactSerializer.SaveContact(_mainVM.CurrentContact);
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="mainVM">Ссылка на MainVM.</param>
        public SaveCommand(MainVM mainVM)
        {
            _mainVM = mainVM;
        }
    }
}

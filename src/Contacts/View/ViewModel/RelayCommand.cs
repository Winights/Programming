using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику для кнопок.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат, который представляет собой метод, выполняемый при вызове команды.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Делегат, который представляет собой метод, определяющий, 
        /// может ли команда быть выполнена в текущий момент.
        /// </summary>
        private Func<object, bool> _canExecute;

        /// <summary>
        /// События для команд.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Может ли команда выполниться.
        /// </summary>
        /// <param name="parameter">Дополнительная информация при вызове команды.</param>
        /// <returns> Возвращает true,если метод, определяющий, выполниться ли команда в 
        /// данный момент равен null и если передано значение для делегата, иначе false.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Логика для выполнения команды.
        /// </summary>
        /// <param name="parameter">Дополнительная информация при вызове команды.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Метод, выполняемый при вызове команды.</param>
        /// <param name="canExecute">Метод, определяющий, 
        /// может ли команда быть выполнена в текущий момент.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
    }
}

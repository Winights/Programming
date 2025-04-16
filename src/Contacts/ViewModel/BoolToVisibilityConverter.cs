using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace ViewModel
{
    /// <summary>
    /// Конверитирует булевые значения в Visibility.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение в параметр для Visibility.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="targetType">Тип, в котором нужно преобразовать исходное значение.</param>
        /// <param name="parameter">Дополнительная информация для выполнения конвертации.</param>
        /// <param name="culture">Сведения об определенном языке и региональных параметрах, 
        /// используемые в этом правиле.</param>
        /// <returns> Возвращает Visible, если значение является булевым и 
        /// равен true, иначе Hidden.</returns>
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Hidden;
            }
            return Visibility.Hidden;
        }

        /// <summary>
        /// Конвертирует параметр для Visibility в булевое значение.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="targetType">Тип, в котором нужно преобразовать исходное значение.</param>
        /// <param name="parameter">Дополнительная информация для выполнения конвертации.</param>
        /// <param name="culture">Сведения об определенном языке и региональных параметрах, 
        /// используемые в этом правиле.</param>
        /// <returns> Возвращает true, если значение является Visibility и 
        /// равен Visible, иначе false.</returns>
        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return (value is Visibility visibility) && visibility == Visibility.Visible;
        }
    }
}

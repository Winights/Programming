using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using Model.Services;

namespace ViewModel.Validation
{
    /// <summary>
    /// Реализует логику валидации для электронной почты.
    /// </summary>
    public class EmailValidationRule : ValidationRule
    {
        /// <summary>
        /// Выполняет проверку значений.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="cultureInfo">Сведения об определенном языке и региональных параметрах, 
        /// используемые в этом правиле.</param>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string patternOfEmail = ValueValidator.GetEmailPattern();

            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult(false, "Email must not null");
            }

            if (!Regex.IsMatch(value.ToString(), patternOfEmail))
            {
                return new ValidationResult(false, "Incorrect email format. Example: user@example.com");
            }

            if ((value.ToString()).Length > 100)
            {
                return new ValidationResult(false, "Email is too long");
            }

            return ValidationResult.ValidResult;
        }
    }
}

using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using Model.Services;

namespace ViewModel.Validation
{
    /// <summary>
    /// Реализует логику валидации для номера телефона.
    /// </summary>
    public class PhoneNumberValidationRule : ValidationRule
    {
        /// <summary>
        /// Выполняет проверку значений.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="cultureInfo">Культура, используемая в этом правиле.</param>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string pattern = ValueValidator.GetPhoneNumberPattern();

            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult(false, "Phone number  must not null");
            }

            if (!Regex.IsMatch(value.ToString(), pattern))
            {
                return new ValidationResult(false, "Incorrect phone number format. " +
                    "Example: +7 (123) 456-78-90");
            }

            return ValidationResult.ValidResult;
        }
    }
}

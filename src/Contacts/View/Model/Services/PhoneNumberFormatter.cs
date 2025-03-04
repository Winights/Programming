using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public class PhoneNumberFormatter
    {
        public static string FormatPhoneNumber(string value)
        {
            string digits = new string(value.Where(char.IsDigit).ToArray());
            if (digits.Length == 11)
            {
                return $"+7 ({digits.Substring(1, 3)}) {digits.Substring(3, 3)}-" +
                $"{digits.Substring(6, 2)}-{digits.Substring(8, 2)}";
            }
            if (digits.Length == 10)
            {
                return $"+7 ({digits.Substring(0, 3)}) {digits.Substring(3, 3)}-" +
                $"{digits.Substring(6, 2)}-{digits.Substring(8, 2)}";
            }
            else
            {
                throw new Exception("Incorrect phone number");
            }
        }
    }
}

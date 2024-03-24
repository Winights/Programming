﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _surname;
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }
        private void AssertStringContainsOnlyLetters(string value)
        {
            bool consistsOfEnglishLetters = Regex.IsMatch(value, @"^[a-zA-Z]+$");
            if (consistsOfEnglishLetters == false)
            {
                throw new ArgumentException("Строка должна содержать только символы английского алфавита.");
            }
        }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string surname, string phoneNumber, string email)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Contact()
        {
            Name = "";
            Surname = "";
            PhoneNumber = "";
            Email = "";
        }
    }
    
}

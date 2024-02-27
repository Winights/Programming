using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Contact()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }
    }
    
}

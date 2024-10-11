using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Переменная типа Address.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address OurAddress { get { return _address; } set { _address = value; } }

        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        public void SelelctedTextBoxs()
        {
            IndexTextBox.Text = OurAddress.Index.ToString();
            CountryTextBox.Text = OurAddress.Country.ToString();
            CityTextBox.Text = OurAddress.City.ToString();
            StreetTextBox.Text = OurAddress.Street.ToString();
            BuildingTextBox.Text = OurAddress.Building.ToString();
            ApartmentTextBox.Text = OurAddress.Apartment.ToString();
        }

        /// <summary>
        /// Очищает текстбоксы.
        /// </summary>
        public void ClearTextBoxs()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Добавляет информацию из текстбоксов.
        /// </summary>
        public Address AddFromTextBoxs()
        {
            int index = int.Parse(IndexTextBox.Text);
            string country = CountryTextBox.Text;
            string city = CityTextBox.Text;
            string street = StreetTextBox.Text;
            string building = BuildingTextBox.Text;
            string apartment = ApartmentTextBox.Text;

            return new Address(index, country, city, street, building, apartment);
        }

        /// <summary>
        /// Редактирует информацию из текстбоксов.
        /// </summary>
        public void EditTextBoxs(Customer customer)
        {
            customer.CustomerAddress.Index = int.Parse(IndexTextBox.Text);
            customer.CustomerAddress.Country = CountryTextBox.Text;
            customer.CustomerAddress.City = CityTextBox.Text;
            customer.CustomerAddress.Street = StreetTextBox.Text;
            customer.CustomerAddress.Building = BuildingTextBox.Text;
            customer.CustomerAddress.Apartment = ApartmentTextBox.Text;
        }



        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(IndexTextBox.Text);
                IndexTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (IndexTextBox.Text != "")
                {
                    IndexTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }
    }
}

using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customersList = new List<Customer>();

        /// <summary>
        /// Переменная типа Customer.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Переменная типа Customer c пустыми значениями.
        /// </summary>
        private Customer _nullCustomer = new Customer();

        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Генерирует объект товара с помощью TextBox's.
        /// </summary>
        private Customer AddItemsInfo()
        {
            string fullname = FullnameTextBox.Text;
            string address = AddressTextBox.Text;
            return new Customer(fullname, address);
        }

        /// <summary>
        /// Добавляет элементы списка в ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customersList)
            {
                CustomersListBox.Items.Add($"{customer.Id} / {customer.Fullname}");
            }
        }

        /// <summary>
        /// Очищает информацию о покупателе в TextBox's.
        /// </summary>
        private void ClearItemInfo()
        {
            FullnameTextBox.Clear();
            FullnameTextBox.BackColor = Color.White;

            AddressTextBox.Clear();
            AddressTextBox.BackColor = Color.White;

            IdTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о товаре в TextBox's.
        /// </summary>
        private void UpdateItemInfo(Customer customer)
        {
            IdTextBox.Text = customer.Id.ToString();
            FullnameTextBox.Text = customer.Fullname.ToString();
            AddressTextBox.Text = customer.Address.ToString();
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = FullnameTextBox.Text;
                FullnameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                FullnameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем список TextBox'ов, которые нужно проверить
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { FullnameTextBox, AddressTextBox };
                bool ifRed = true;

                foreach (var textBox in textBoxes)
                {
                    if (textBox.BackColor == Color.LightPink)
                    {
                        ifRed = false;
                    }
                }

                // Проверяем, что все TextBox'ы не пустые и не один из TextBox'ов не красный
                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && ifRed)
                {
                    Customer selectedCustomer = AddItemsInfo();
                    _customersList.Add(selectedCustomer);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Некоректные значения. Введите корректные значения для корректной работы программы.");
                }
            }
            catch (Exception ex)
            {
                // Выводим сообщение с ошибкой
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "Не выбран элемент для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _customersList.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                _currentCustomer = _customersList[CustomersListBox.SelectedIndex];
                UpdateItemInfo(_currentCustomer);
            }
        }

        private void CustomersListBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
                _currentCustomer = _nullCustomer;
            }
        }
    }
}

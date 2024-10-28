using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.DiscountsModalWindow;
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
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Переменная типа Customer.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }

        /// <summary>
        /// Переменная для приоритетных покупателей.
        /// </summary>
        private bool _isPriority = false;

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
            return new Customer(fullname);
        }

        /// <summary>
        /// Добавляет элементы списка в ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
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

            AddressControl.ClearTextBoxs();

            IdTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о товаре в TextBox's.
        /// </summary>
        private void UpdateItemInfo()
        {
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullnameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressControl.OurAddress = _currentCustomer.CustomerAddress;
            AddressControl.SelectedTextBoxs();
            UpdateDiscountsListBox(_currentCustomer);
        }

        /// <summary>
        /// Обновляет данные в списке скидок покупателя.
        /// </summary>
        /// <param name="customer">Текущий покупатель.</param>
        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Обновляет данные в списке скидок покупателя.
        /// </summary>
        public void UpdateDiscountsListBox()
        {
            if (CustomersListBox.SelectedIndex > 0)
            {
                UpdateDiscountsListBox(Customers[CustomersListBox.SelectedIndex]);
            }
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем список TextBox'ов, которые нужно проверить
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { FullnameTextBox };
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
                    selectedCustomer.CustomerAddress = AddressControl.AddFromTextBoxs();
                    selectedCustomer.IsPriority = _isPriority;
                    _customers.Add(selectedCustomer);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Некоректные значения. Введите корректные " +
                        "значения для корректной работы программы.");
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
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateItemInfo();
            }
        }

        private void CustomersListBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                AddressControl.EditTextBoxs(_currentCustomer);
            }
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriorityCheckBox.Checked)
            {
                _isPriority = true;
            }
            else
            {
                _isPriority = false;
            }
        }

        private void AddDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                var discountWindowPopUp = new DiscountModalWindow(_currentCustomer);

                if (discountWindowPopUp.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var discount = new PercentDiscount(discountWindowPopUp.Category);
                _currentCustomer.Discounts.Add(discount);
                UpdateDiscountsListBox(_currentCustomer);
            }
            else
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "Не выбран покупатель для добавления скидки.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }           
        }

        private void RemoveDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1 && DiscountsListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                if (DiscountsListBox.SelectedIndex != 0)
                {
                    _currentCustomer.Discounts.RemoveAt(
                        DiscountsListBox.SelectedIndex);
                    UpdateDiscountsListBox(_currentCustomer);
                }
                else 
                {
                    return;
                }
            }
            else
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "Не выбран покупатель или скидка для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }         
        }
    }
}

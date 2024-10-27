using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Возвращает и задаёт покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; } = new Customer();

        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляет элементы списка в ItemsListBox.
        /// </summary>
        private void FillItemListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in Items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }
        }

        /// <summary>
        /// Добавляет элементы списка Customers в CustomerComboBox.
        /// </summary>
        private void LoadCustomersComboBox()
        {
            CustomerComboBox.Items.Clear();

            foreach (var customer in Customers)
            {
                CustomerComboBox.Items.Add($"{customer.Fullname}");
            }
        }

        /// <summary>
        /// Обновляет корзину покупателя.
        /// </summary>
        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();

            if (CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                foreach (Item item in CurrentCustomer.CustomerCart.Items)
                {
                    CartListBox.Items.Add($"{item.Name}");
                }
            }
            else
            {
                CartListBox.Items.Clear();
            }
            TotalCostLabel.Text = CurrentCustomer.CustomerCart.Amount.ToString();
        }

        /// <summary>
        /// Обновляет значения товаров и покупателей.
        /// </summary>
        public void RefreshData()
        {
            LoadCustomersComboBox();
            FillItemListBox();
            CartListBox.Items.Clear();
            TotalCostLabel.Text = "0";
            CustomerComboBox.Text = null;
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedItem != null)
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
                UpdateCartListBox();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null || CustomerComboBox.SelectedItem == null)
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "Чтобы добавить в корзизу, выберете товар или покупателя",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            CurrentCustomer.CustomerCart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1)
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
            CurrentCustomer.CustomerCart.Items.RemoveAt(CartListBox.SelectedIndex);
            UpdateCartListBox();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1 && CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                MessageBox.Show($"{CurrentCustomer.IsPriority}");
                if (CurrentCustomer.IsPriority)
                {
                    CurrentCustomer.Orders.Add(new PriorityOrder(CurrentCustomer.CustomerCart.Items, 
                        CurrentCustomer.CustomerAddress,
                        CurrentCustomer.Fullname,
                        DeliveryTime.Morning, DateTime.Now.Date));
                    CurrentCustomer.CustomerCart.Items.Clear();
                    UpdateCartListBox();
                }
                else 
                {
                    CurrentCustomer.Orders.Add(new Order(CurrentCustomer.CustomerAddress,
                    CurrentCustomer.CustomerCart.Items, CurrentCustomer.Fullname));
                    CurrentCustomer.CustomerCart.Items.Clear();
                    UpdateCartListBox();
                }              
            }
            else
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "Заполните корзину товарами иил выберете покупателя, чтобы сделать заказ.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.CustomerCart.Items.Clear();
                UpdateCartListBox();
            }
        }
    }
}

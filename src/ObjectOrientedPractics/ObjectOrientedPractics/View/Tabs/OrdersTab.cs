using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Выбранный индекс в таблице заказов.
        /// </summary>
        private int _selectedOrderIndex;

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder = new Order();

        public OrdersTab()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обновляет данные при переключении на вкладку.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            RefreshDataGrid();
            LoadStatusComboBox();
        }

        /// <summary>
        /// Обновляет таблицу с заказами.
        /// </summary>
        private void RefreshDataGrid()
        {
            OrdersDataGridView.Rows.Clear();

            foreach (Order order in _orders)
            {
                OrdersDataGridView.Rows.Add(order.Id, order.Date, $"{order.Address.Country},{order.Address.City}" +
                    $"{order.Address.Street}, {order.Address.Building},{order.Address.Apartment}", order.CustomerFullName);
            }
        }

        /// <summary>
        /// Обновляет список заказов.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders.Count != 0)
                {
                    foreach (Order order in customer.Orders)
                    {
                        _orders.Add(order);
                    }
                }
            }
        }
        /// <summary>
        /// Заполняет листбокс товарами заказа.
        /// </summary>
        private void FillOrderItemsListBox()
        {
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _orders[_selectedOrderIndex].Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Добавляет элементы списка Customers в CustomerComboBox.
        /// </summary>
        private void LoadStatusComboBox()
        {
            StatusComboBox.Items.Clear();

            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedOrder = _orders[_selectedOrderIndex];
                AddressControl.OurAddress = _orders[_selectedOrderIndex].Address;
                AddressControl.SelelctedTextBoxs();
                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.OrderStatus;
                TotalCostLabel.Text = _selectedOrder.Amount.ToString();
                FillOrderItemsListBox();
            }
            catch (Exception) { }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ourStatus = StatusComboBox.Text;
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), ourStatus);
                _selectedOrder.OrderStatus = orderStatus;
            }
            catch (Exception) { }
        }
    }
}

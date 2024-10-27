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
        /// Выбранный индекс строки в таблице заказов.
        /// </summary>
        private int _selectedOrderIndex;

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder = new Order();

        /// <summary>
        /// Массив со временем доставки.
        /// </summary>
        private string[] _desiredDeliveryTime = new string[]
        { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00",
            "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };

        /// <summary>
        /// Приоритетный заказ. 
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

        public OrdersTab()
        {
            InitializeComponent();
            PriorityOptionsPanel.Visible = false;
        }

        /// <summary>
        /// Обновляет данные при переключении на вкладку.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            RefreshDataGrid();
            LoadStatusComboBox();
            LoadDeliveryTimeComboBox();
            TotalCostLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет таблицу с заказами.
        /// </summary>
        private void RefreshDataGrid()
        {
            OrdersDataGridView.Rows.Clear();

            foreach (Order order in _orders)
            {
                OrdersDataGridView.Rows.Add(order.Id, order.Date,
                    order.OrderStatus, order.CustomerFullName);
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
        /// Заполняет список товарами заказа.
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
        /// Добавляет элементы перечисления Orderstatus в StatusComboBox.
        /// </summary>
        private void LoadStatusComboBox()
        {
            StatusComboBox.Items.Clear();

            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Добавляет элементы перечисления DeliveryTime в DeliveryTimeComboBox.
        /// </summary>
        private void LoadDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.Items.Clear();

            foreach (var delivery in _desiredDeliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(delivery);
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                _selectedOrderIndex = OrdersDataGridView.CurrentCell.RowIndex;
                _selectedOrder = _orders[_selectedOrderIndex];

                if (_selectedOrder is PriorityOrder priorityOrder)
                {
                    PriorityOptionsPanel.Visible = true;
                    _priorityOrder = (PriorityOrder)_orders[_selectedOrderIndex];
                    DeliveryTimeComboBox.SelectedIndex = ((int)_priorityOrder.DesiredDeliveryTime - 1);
                }
                else if (_selectedOrder is Order)
                {
                    PriorityOptionsPanel.Visible = false;
                    _priorityOrder = null;
                }

                OrderAddressControl.OurAddress = _orders[_selectedOrderIndex].Address;
                OrderAddressControl.SelectedTextBoxs();

                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.OrderStatus;
                TotalCostLabel.Text = _selectedOrder.Amount.ToString();

                FillOrderItemsListBox();
            }

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.Text != null)
            {
                string ourStatus = StatusComboBox.Text;
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), ourStatus);
                _selectedOrder.OrderStatus = orderStatus;
                RefreshDataGrid();
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.Text != null)
            {
                var selectedDeliveryTime = DeliveryTimeComboBox.Text;
                switch (selectedDeliveryTime)
                {
                    case "9:00 - 11:00":
                        _priorityOrder.DesiredDeliveryTime = DeliveryTime.Morning;
                        break;
                    case "11:00 - 13:00":
                        _priorityOrder.DesiredDeliveryTime = DeliveryTime.Lunch;
                        break;
                    case "13:00 - 15:00":
                        _priorityOrder.DesiredDeliveryTime = DeliveryTime.Afternoon;
                        break;
                    case "15:00 - 17:00":
                        _priorityOrder.DesiredDeliveryTime = DeliveryTime.Evening;
                        break;
                    case "17:00 - 19:00":
                        _priorityOrder.DesiredDeliveryTime = DeliveryTime.LateEvening;
                        break;
                    case "19:00 - 21:00":
                        _priorityOrder.DesiredDeliveryTime = DeliveryTime.Night;
                        break;
                }
            }

        }
    }
}

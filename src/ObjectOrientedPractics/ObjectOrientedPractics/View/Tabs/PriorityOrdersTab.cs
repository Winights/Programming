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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Список приоритентых заказов.
        /// </summary>
        private List<PriorityOrder> _priorityOrders = new List<PriorityOrder>();

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Выбранный индекс строки в таблице заказов.
        /// </summary>
        private int _selectedOrderIndex;

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private PriorityOrder _selectedOrder = new PriorityOrder();

        /// <summary>
        /// Массив со временем доставки.
        /// </summary>
        private string[] _desiredDeliveryTime = new string[]
        { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00",
            "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };
        public PriorityOrdersTab()
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
            LoadDeliveryTimeComboBox();
            TotalCostLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет таблицу с заказами.
        /// </summary>
        private void RefreshDataGrid()
        {
            OrdersDataGridView.Rows.Clear();

            foreach (PriorityOrder order in _priorityOrders)
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
            _priorityOrders.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders.Count != 0)
                {
                    foreach (Order order in customer.Orders)
                    {
                        _priorityOrders.Add(new PriorityOrder(order.Items, order.Address,
                            order.CustomerFullName, order.Id, DeliveryTime.Morning, DateTime.Now));
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
            foreach (Item item in _priorityOrders[_selectedOrderIndex].Items)
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

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        public void ClearTextBoxs()
        {
            IdTextBox.Text = string.Empty;
            CreatedDateTextBox.Text = string.Empty; 
            StatusComboBox.SelectedItem = null;
            DeliveryTimeComboBox.SelectedItem = null;
            TotalCostLabel.Text = "0";
            PriorityAddressControl.ClearTextBoxs();
            OrderItemsListBox.Items.Clear();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedOrder = _priorityOrders[_selectedOrderIndex];

                PriorityAddressControl.OurAddress = _priorityOrders[_selectedOrderIndex].Address;
                PriorityAddressControl.SelectedTextBoxs();

                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedDateTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.OrderStatus;
                DeliveryTimeComboBox.SelectedItem = _selectedOrder.DesiredDeliveryTime;
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
                        _selectedOrder.DesiredDeliveryTime = DeliveryTime.Morning;
                        break;
                    case "11:00 - 13:00":
                        _selectedOrder.DesiredDeliveryTime = DeliveryTime.Lunch;
                        break;
                    case "13:00 - 15:00":
                        _selectedOrder.DesiredDeliveryTime = DeliveryTime.Afternoon;
                        break;
                    case "15:00 - 17:00":
                        _selectedOrder.DesiredDeliveryTime = DeliveryTime.Evening;
                        break;
                    case "17:00 - 19:00":
                        _selectedOrder.DesiredDeliveryTime = DeliveryTime.LateEvening;
                        break;
                    case "19:00 - 21:00":
                        _selectedOrder.DesiredDeliveryTime = DeliveryTime.Night;
                        break;
                }
            } 
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            _selectedOrder.Items.Add(Items[ran.Next(Items.Count)]);
            FillOrderItemsListBox();
            TotalCostLabel.Text = _selectedOrder.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _selectedOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            FillOrderItemsListBox();
            TotalCostLabel.Text = _selectedOrder.Amount.ToString();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _selectedOrderIndex = OrdersDataGridView.CurrentCell.RowIndex;

            _priorityOrders.RemoveAt(_selectedOrderIndex);
            OrdersDataGridView.Rows.RemoveAt(_selectedOrderIndex);

            var newOrder = new PriorityOrder();
            _priorityOrders.Add(newOrder);
            OrdersDataGridView.Rows.Insert(_selectedOrderIndex, newOrder.Id, 
                newOrder.Date, newOrder.OrderStatus, newOrder.CustomerFullName);

            ClearTextBoxs();
        }
    }
}

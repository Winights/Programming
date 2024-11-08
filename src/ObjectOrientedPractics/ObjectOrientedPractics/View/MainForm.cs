using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная типа Store.
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
            ItemsTab.ItemsChanged += ItemsChanged;
            CartsTab.OrdersCreated += OrdersCreated;
            CustomersTab.CustomersChanged += CustomersChanged;
        }

        private void CustomersChanged(object? sender, EventArgs e)
        {
            CartsTab.Customers = CustomersTab.Customers;
            OrdersTab.Customers = _store.Customers;
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }

        private void OrdersCreated(object? sender, EventArgs e)
        {
            CartsTab.Items = ItemsTab.Items;
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }

        private void ItemsChanged(object? sender, EventArgs e)
        {
            CartsTab.Items = ItemsTab.Items;
            CartsTab.RefreshData();
        }
    }
}

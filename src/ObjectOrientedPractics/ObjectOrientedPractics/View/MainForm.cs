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
        }

        private void ObjecTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ObjecTabControl.SelectedIndex)
            {
                case 0:
                    break;
                case 2:
                    CartsTab.RefreshData();
                    break;
                case 3:
                    OrdersTab.RefreshData();
                    break;
            }
        }
    }
}

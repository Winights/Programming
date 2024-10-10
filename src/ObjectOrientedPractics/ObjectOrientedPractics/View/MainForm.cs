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
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
        }

        private void ObjecTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ObjecTabControl.SelectedIndex)
            {
                case 0:
                    break;
                case 2:
                    cartsTab1.RefreshData();
                    break;
            }
        }
    }
}

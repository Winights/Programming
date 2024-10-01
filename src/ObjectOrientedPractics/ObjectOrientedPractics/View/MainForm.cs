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
        }
    }
}

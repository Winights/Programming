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
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.DiscountsModalWindow
{
    /// <summary>
    /// Модальное окно для добавления новой процентной скидки покупателю.
    /// </summary>
    public partial class DiscountModalWindow : Form
    {

        /// <summary>
        /// Возвращает и задает категорию товара скидки.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает покупателя.
        /// </summary>
        public Customer Customer { get; } = new Customer();

        /// <summary>
        /// Создает экземпляр класса <see cref="DiscountModalWindow"/>.
        /// </summary>
        /// /// <param name="customer">Текущий покупатель.</param>
        public DiscountModalWindow(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            LoadCategoryComboBox();

        }

        /// <summary>
        /// Добавляет элементы Category в CategoryComboBox.
        /// </summary>
        private void LoadCategoryComboBox()
        {
            var customerCategories = Customer.Discounts
                .OfType<PercentDiscount>()
                .Select(discount => discount.Category)
                .Distinct()
                .ToList();

            var dataCategories = Enum.GetValues(typeof(Category))
                .Cast<Category>()
                .ToList()
                .Except(customerCategories)
                .ToList();

            CategoryComboBox.DataSource = dataCategories;
        }

        private void OkDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                Category = (Category)CategoryComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }           
        }

        private void CancelDiscountsButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkDiscountsButton.Enabled = CategoryComboBox.SelectedIndex >= 0;
        }
    }
}

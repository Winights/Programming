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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        public PointsDiscount _currentPoints = new PointsDiscount();

        public PercentDiscount _currentPercent = new PercentDiscount();


        public DiscountsTab()
        {
            InitializeComponent();
            InfoLabel.Text = _currentPercent.Info;
            TotalCostLabel.Text = "0";
            TotalDIscountLabel.Text = "0";
            _currentPercent.Category = Category.Books;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            TotalDIscountLabel.Text = $"{_currentPercent.Calculate(Items)}";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            foreach (var item in Items)
            {
                totalCost += item.Cost;
            }

            TotalCostLabel.Text = $"{totalCost- _currentPercent.Apply(Items)}";
            TotalDIscountLabel.Text = "0";
            InfoLabel.Text = _currentPercent.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            foreach (var item in Items)
            {
                totalCost += item.Cost;
            }
            TotalCostLabel.Text = $"{totalCost}";
            _currentPercent.Update(Items);
            InfoLabel.Text = _currentPercent.Info;
        }
    }
}

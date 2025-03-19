using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
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
            InfoLabel.Text = _currentPoints.Info;
            TotalCostLabel.Text = "0";
            TotalDIscountLabel.Text = "0";
            //_currentPoints.Category = Category.Books;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            TotalDIscountLabel.Text = $"{_currentPoints.Calculate(Items)}";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            foreach (var item in Items)
            {
                totalCost += item.Cost;
            }

            TotalCostLabel.Text = $"{totalCost- _currentPoints.Apply(Items)}";
            TotalDIscountLabel.Text = "0";
            InfoLabel.Text = _currentPoints.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            foreach (var item in Items)
            {
                totalCost += item.Cost;
            }
            TotalCostLabel.Text = $"{totalCost}";
            _currentPoints.Update(Items);
            InfoLabel.Text = _currentPoints.Info;
        }
    }
}

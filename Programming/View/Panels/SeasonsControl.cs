using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();
            LoadSeasonComboBox();
        }

        /// <summary>
        /// Добавляет элементы Season в SeasonComboBox.
        /// </summary>
        private void LoadSeasonComboBox()
        {
            //Добавляем элементы Season в SeasonComboBox
            foreach (var item in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(item);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите время года");
                return;
            }

            //Преобразуем в перечисление Season
            Season selectedSeason = (Season)SeasonComboBox.SelectedItem;
            switch (selectedSeason)
            {
                case Season.Summer: MessageBox.Show("Ура! Солнце!!"); break;
                case Season.Autumn: SeasonTextBox.Text = $"Текущее время года: Осень"; ; break;
                case Season.Winter: MessageBox.Show("Брр! Холодно!"); break;
                case Season.Spring: SeasonTextBox.Text = $"Текущее время года: Весна"; break;
            }
        }
    }
}

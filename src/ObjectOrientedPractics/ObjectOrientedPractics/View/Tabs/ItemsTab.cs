using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Model.Item> _items = new();

        /// <summary>
        /// Переменная типа Item.
        /// </summary>
        private Model.Item _currentItem = new Model.Item();

        /// <summary>
        /// Переменная типа Item c пустыми значениями.
        /// </summary>
        private Model.Item _selectedItem = new Model.Item();

        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Генерирует объект товара с помощью TextBox's.
        /// </summary>
        private Model.Item AddItemsInfo()
        {
            string name = NameTextBox.Text;
            string descryption = DescriptionTextBox.Text;
            double cost = double.Parse(CostTextBox.Text);
            return new Model.Item(name, descryption, cost);
        }

        /// <summary>
        /// Добавляет элементы списка в ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Model.Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name}");
            }
        }

        /// <summary>
        /// Очищает информацию о товаре в TextBox's.
        /// </summary>
        private void ClearItemInfo()
        {
            IdTextBox.Clear();

            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;

            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;

            DescriptionTextBox.Clear();
            DescriptionTextBox.BackColor = Color.White;
            
        }

        /// <summary>
        /// Обновляет информацию о товаре в TextBox's.
        /// </summary>
        private void UpdateItemInfo(Model.Item item)
        {  
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (CostTextBox.Text != "")
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем список TextBox'ов, которые нужно проверить
                var textBoxes = new List<TextBox> { CostTextBox,
                    NameTextBox, DescriptionTextBox };
                bool ifRed = true;

                foreach (var textBox in textBoxes)
                {
                    if (textBox.BackColor == Color.LightPink)
                    {
                        ifRed = false;
                    }
                }

                // Проверяем, что все TextBox'ы не пустые и не один из TextBox'ов не красный
                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && ifRed)
                {
                    Model.Item selectedItem = AddItemsInfo();
                    _items.Add(selectedItem);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Некоректные значения. Введите корректные значения для " +
                        "корректной работы программы.");
                }
            }
            catch (Exception ex)
            {
                // Выводим сообщение с ошибкой
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "Не выбран элемент для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                UpdateListBox();
                _currentItem = _selectedItem;
            }
        }
    }
}
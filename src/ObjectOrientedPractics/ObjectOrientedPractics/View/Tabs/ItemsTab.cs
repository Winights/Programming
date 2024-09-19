using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<Model.Item> _itemsList = new List<Model.Item>();

        /// <summary>
        /// Переменная типа Item.
        /// </summary>
        private Model.Item _currentItem = new Model.Item();
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Генерирует объект товара с помощью TextBox's.
        /// </summary>
        private void AddItemsInfo()
        {
            string name = NameTextBox.Text;
            string descryption = DescryptionTextBox.Text;
            double cost = double.Parse(CostTextBox.Text);
            _currentItem = new Model.Item(name, descryption, cost);
        }

        /// <summary>
        /// Добавляет элементы списка в ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Model.Item item in _itemsList)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name} / {item.Cost}");
            }
        }

        /// <summary>
        /// Очищает информацию о товаре в TextBox's.
        /// </summary>
        private void ClearItemInfo()
        {
            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;

            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;

            DescryptionTextBox.Clear();
            DescryptionTextBox.BackColor = Color.White;

            IdTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о товаре в TextBox's.
        /// </summary>
        /// <param name="item">Обновляемая книга.</param>
        private void UpdateItemInfo(Model.Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name.ToString();
            DescryptionTextBox.Text = item.Info.ToString();
        }

        /// <summary>
        /// Редактирует объект книги с помощью TextBox's.
        /// </summary>
        private void EditBooksInfo()
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                _currentItem.Name = NameTextBox.Text;
                _currentItem.Info = DescryptionTextBox.Text;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double valueCost = double.Parse(CostTextBox.Text);
                if (valueCost < 0 || valueCost > 100000)
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    CostTextBox.BackColor = Color.White;
                }
            }
            catch (SystemException)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueName = NameTextBox.Text;
                if (valueName.Length > 200)
                {
                    NameTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    NameTextBox.BackColor = Color.White;
                }
            }
            catch (SystemException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void DescryptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valueInfo = DescryptionTextBox.Text;
                if (valueInfo.Length > 1000)
                {
                    DescryptionTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    DescryptionTextBox.BackColor = Color.White;
                }
            }
            catch (SystemException)
            {
                DescryptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем список TextBox'ов, которые нужно проверить
                var textBoxes = new List<TextBox> { CostTextBox,
                    NameTextBox, DescryptionTextBox };
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
                    AddItemsInfo();
                    _itemsList.Add(_currentItem);
                    UpdateListBox();
                    ClearItemInfo();
                }
                else
                {
                    throw new Exception("Некоректные значения. Введите корректные значения для корректной работы программы.");
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
            _itemsList.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = _itemsList[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }

            if (ItemsListBox.SelectedIndex == -1)
            {
                ClearItemInfo();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                EditBooksInfo();
                UpdateListBox();
                ClearItemInfo();
            }
        }
    }
}

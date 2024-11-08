using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Переменная типа Item.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает и задает делегат критерия фильтрации.
        /// </summary>
        private Predicate<Item> FilterСriterion { get; set; }

        /// <summary>
        /// Список фильтрованных товаров.
        /// </summary>
        private List<Item> _displayedItems = new ();

        /// <summary>
        /// Возвращает и задает делегат критерия сортировки.
        /// </summary>
        private DataTools.CompareCriteria SortСriterion { get; set; }

        /// <summary>
        /// Событие при изменении информации о товарах.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        public ItemsTab()
        {
            InitializeComponent();
            LoadCategoryComboBox();
            OrderByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Добавляет элементы Category в CategoryComboBox.
        /// </summary>
        private void LoadCategoryComboBox()
        {
            //Добавляем элементы Genres в GenreComboBox
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Генерирует объект товара с помощью TextBox's.
        /// </summary>
        private Item AddItemInfo()
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                string name = NameTextBox.Text;
                string descryption = DescriptionTextBox.Text;
                double cost = double.Parse(CostTextBox.Text);
                return new Item(name, descryption, cost);
            }
            else
            {
                throw new Exception("Категория товара не выбрана");
            }
        }

        /// <summary>
        /// Добавляет элементы списка в ItemsListBox.
        /// </summary>
        private void UpdateListBox(List<Item> items)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in items)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name} / {item.Category}");
            }
        }

        /// <summary>
        /// Обновить список товаров, который будет выведен на экран.
        /// </summary>
        private void UpdateDisplayedItems()
        {
            var displayedItems = Items;

            if (FilterСriterion != null)
            {
                displayedItems = DataTools.FilterItems(displayedItems, FilterСriterion);
            }
            if (SortСriterion != null)
            {
                displayedItems = DataTools.SortItems(displayedItems, SortСriterion);
            }

            _displayedItems = displayedItems;
            UpdateListBox(_displayedItems);
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

            CategoryComboBox.SelectedIndex = -1;

        }

        /// <summary>
        /// Обновляет информацию о товаре в TextBox's.
        /// </summary>
        private void UpdateItemInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Info;
            CategoryComboBox.Text = item.Category.ToString();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text))
                    && CategoryComboBox.SelectedItem != null && ifRed)
                {
                    Item selectedItem = AddItemInfo();
                    selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
                    Items.Add(selectedItem);
                    _displayedItems = Items;
                    UpdateDisplayedItems();
                    ItemsChanged?.Invoke(this, EventArgs.Empty);

                    //var clone = (Item)selectedItem.Clone();
                    //MessageBox.Show($"{clone.Id} {clone.Name} {clone.Info} {clone.Cost} {clone.Category}");
                    //var equals = selectedItem.Equals(_items[0]);
                    //MessageBox.Show($"{equals}");
                    //var compare = selectedItem.CompareTo(_items[0]);
                    //MessageBox.Show($"{compare}");
                    //UpdateListBox();
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
            Items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ClearItemInfo();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = _displayedItems[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                UpdateDisplayedItems();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null && ItemsListBox.SelectedItem != null)
            {
                _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
                UpdateItemInfo(_currentItem);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length == 0)
            {
                FilterСriterion = null;
            }
            else
            {
                FilterСriterion = (item) => { return item.Name.Contains(FindTextBox.Text); };
            }
            UpdateDisplayedItems();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OrderByComboBox.SelectedIndex)
            {
                case 0:
                    SortСriterion = (first, second) =>
                    {
                        return first.Name.CompareTo(second.Name) < 0;
                    };
                    break;
                case 1:
                    SortСriterion = (first, second) =>
                    {
                        return first.Cost.CompareTo(second.Cost) > 0;
                    };
                    break;
                case 2:
                    SortСriterion = (first, second) =>
                    {
                        return first.Cost.CompareTo(second.Cost) < 0;
                    };
                    break;
            }
            _displayedItems = Items;
            UpdateDisplayedItems();
        }
    }
}
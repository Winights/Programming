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
    public partial class AllEnumerationsControl : UserControl
    {
        public AllEnumerationsControl()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            DefaultSelectedEnums();
        }

        /// <summary>
        /// Добавляет имена перечислений в EnumsListBox.
        /// </summary>
        private void PopulateEnumsListBox()
        {
            //Получение всех типов в сборке
            Type[] types = typeof(Program).Assembly.GetTypes();

            //Фильтруем только перечисления
            var enumTypes = Array.FindAll(types, type => type.IsEnum);

            //Добавляем имена перечислений в EnumsListBox
            foreach (var enumType in enumTypes)
            {
                EnumsListBox.Items.Add(enumType.Name);
            }
        }

        /// <summary>
        /// Выбирает начальные элементы EnumsListBox и ValuesListBox.
        /// </summary>
        private void DefaultSelectedEnums()
        {
            EnumsListBox.SetSelected(0, true);
            ValuesListBox.SetSelected(1, true);
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очистка ValuesListBox
            ValuesListBox.Items.Clear();

            if (EnumsListBox.SelectedItem != null)
            {
                //Название выбранного элемента в EnumsListBox
                int selectedEnumName = EnumsListBox.SelectedIndex;

                //Получение всех типов в сборке
                Type[] types = typeof(Program).Assembly.GetTypes();

                //Фильтруем только перечисления
                var enumTypes = Array.FindAll(types, type => type.IsEnum);

                //Добавляем значения перечисления в ValuesListBox
                foreach (var item in Enum.GetValues(enumTypes[selectedEnumName]))
                {
                    ValuesListBox.Items.Add(item);
                }
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очистка ValuesTextBox
            ValueTextBox.Clear();

            if (ValuesListBox.SelectedItem != null)
            {
                int selectedEnumName = ValuesListBox.SelectedIndex;
                ValueTextBox.AppendText(selectedEnumName.ToString());
            }
        }
    }
}

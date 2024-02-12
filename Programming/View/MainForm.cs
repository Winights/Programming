using Programming.Model.Enums;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            DefaultSelectedEnums();
            LoadSeasonComboBox();
        }
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
        private void DefaultSelectedEnums()
        {
            EnumsListBox.SetSelected(0, true);
            ValuesListBox.SetSelected(1, true);
        }
        private void LoadSeasonComboBox()
        {
            //Добавляем элементы Season в SeasonComboBox
            foreach (var item in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(item);
            }
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

        private void ParseButton_Click(object sender, EventArgs e)
        {
            //Очистка ResultTextBox
            ResultTextBox.Clear();

            if (WeekdayTextBox.Text == "")
            {
                MessageBox.Show("Введите текст");
                return;
            }

            string inputUserText = WeekdayTextBox.Text;
            bool flagNumber = false;

            if (int.TryParse(inputUserText, out int intUserText))
            {
                if ((intUserText < 8) && (intUserText > 0))
                {
                    flagNumber = true;
                }
                int IndexWeekday = intUserText - 1;
                if (Enum.TryParse(IndexWeekday.ToString(), out Weekday valueWeekday) && (flagNumber == true))
                {
                    ResultTextBox.AppendText($"Это день недели ({intUserText} = {valueWeekday})");
                }
                else
                {
                    ResultTextBox.AppendText("Нет такого дня недели");
                }
            }
            else
            {
                if (Enum.TryParse(inputUserText, out Weekday result))
                {
                    int numericValue = (int)result;
                    ResultTextBox.AppendText($"Это день недели ({inputUserText} = {numericValue + 1})");
                }
                else
                {
                    ResultTextBox.AppendText("Нет такого дня недели");
                }
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
                case Season.Autumn: this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69); break;
                case Season.Winter: MessageBox.Show("Брр! Холодно!"); break;
                case Season.Spring: this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69); break;
            }
        }
    }
}

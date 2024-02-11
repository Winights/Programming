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
            //��������� ���� ����� � ������
            Type[] types = typeof(Program).Assembly.GetTypes();

            //��������� ������ ������������
            var enumTypes = Array.FindAll(types, type => type.IsEnum);

            //��������� ����� ������������ � EnumsListBox
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
            foreach (var item in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(item);
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            if (EnumsListBox.SelectedItem == null)
            {
                MessageBox.Show("�������� �������");
                return;
            }

            //�������� ���������� �������� � EnumsListBox
            string selectedEnumName = EnumsListBox.SelectedItem.ToString();

            //��������� ���� ����� � ������
            Type[] types = typeof(Program).Assembly.GetTypes();

            //��������� ������ ������������
            var enumTypes = Array.FindAll(types, type => type.IsEnum);
            int indexSelectedEnum = 0;
            for (int i = 0; i < enumTypes.Length; i++)
            {
                if (enumTypes[i].Name == selectedEnumName)
                {
                    break;
                }
                indexSelectedEnum++;
            }
            if (EnumsListBox.SelectedItem != null)
            {
                //��������� �������� ������������ � ValuesListBox
                foreach (var item in Enum.GetValues(enumTypes[indexSelectedEnum]))
                {
                    ValuesListBox.Items.Add(item);
                }
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Clear();

            if (ValuesListBox.SelectedItem != null)
            {
                int selectedEnumName = ValuesListBox.SelectedIndex;
                ValueTextBox.AppendText(selectedEnumName.ToString());
            }
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();

            if (WeekdayTextBox.Text == "")
            {
                MessageBox.Show("������� �����");
                return;
            }

            string inputUserText = WeekdayTextBox.Text;
            if (int.TryParse(inputUserText, out int intUserText) == true)
            {
                int IndexWeekday = intUserText - 1;
                if (Enum.TryParse(IndexWeekday.ToString(), out Weekday valueWeekday) && (intUserText < 8))
                {
                    ResultTextBox.AppendText($"��� ���� ������ ({intUserText} = {valueWeekday})");
                }
                else
                {
                    ResultTextBox.AppendText("��� ������ ��� ������");
                }
            }

            else
            {
                if (Enum.TryParse(inputUserText, out Weekday result) == true)
                {
                    int numericValue = (int)result;
                    ResultTextBox.AppendText($"��� ���� ������ ({inputUserText} = {numericValue + 1})");
                }
                else
                {
                    ResultTextBox.AppendText("��� ������ ��� ������");
                }
            }
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("�������� ����� ����");
                return;
            }
            Season selectedSeason = (Season)SeasonComboBox.SelectedItem;
            switch (selectedSeason)
            {
                case Season.Summer:
                    MessageBox.Show("���! ������!");
                    break;
                case Season.Autumn:
                    this.BackColor = Color.Orange;
                    break;
                case Season.Winter:
                    MessageBox.Show("���! �������!");
                    break;
                case Season.Spring:
                    this.BackColor = Color.ForestGreen;
                    break;
            }
        }
    }
}

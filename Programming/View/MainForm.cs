using Programming.Model;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
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
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

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
    }
}

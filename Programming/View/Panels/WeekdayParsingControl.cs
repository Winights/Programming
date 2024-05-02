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
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
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
    }
}

namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            WeekdayGroupBox = new GroupBox();
            ResultTextBox = new TextBox();
            WeekdayTextLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            WeekdayGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(ResultTextBox);
            WeekdayGroupBox.Controls.Add(WeekdayTextLabel);
            WeekdayGroupBox.Controls.Add(ParseButton);
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Dock = DockStyle.Fill;
            WeekdayGroupBox.Location = new Point(0, 0);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(350, 169);
            WeekdayGroupBox.TabIndex = 9;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ResultTextBox
            // 
            ResultTextBox.BorderStyle = BorderStyle.None;
            ResultTextBox.ForeColor = SystemColors.WindowText;
            ResultTextBox.Location = new Point(9, 83);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(270, 20);
            ResultTextBox.TabIndex = 3;
            // 
            // WeekdayTextLabel
            // 
            WeekdayTextLabel.AutoSize = true;
            WeekdayTextLabel.Location = new Point(6, 27);
            WeekdayTextLabel.Name = "WeekdayTextLabel";
            WeekdayTextLabel.Size = new Size(158, 20);
            WeekdayTextLabel.TabIndex = 10;
            WeekdayTextLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(184, 50);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(92, 27);
            ParseButton.TabIndex = 9;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 50);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(172, 27);
            WeekdayTextBox.TabIndex = 9;
            // 
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayGroupBox);
            Name = "WeekdayParsingControl";
            Size = new Size(350, 169);
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayGroupBox;
        private TextBox ResultTextBox;
        private Label WeekdayTextLabel;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
    }
}

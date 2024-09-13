namespace Programming.View.Panels
{
    partial class AllEnumerationsControl
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
            EnumGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            ValueTextBox = new TextBox();
            TextBoxLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsLabel = new Label();
            ValueLabel = new Label();
            EnumGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Controls.Add(ValueTextBox);
            EnumGroupBox.Controls.Add(TextBoxLabel);
            EnumGroupBox.Controls.Add(ValuesListBox);
            EnumGroupBox.Controls.Add(EnumsLabel);
            EnumGroupBox.Controls.Add(ValueLabel);
            EnumGroupBox.Dock = DockStyle.Fill;
            EnumGroupBox.Location = new Point(0, 0);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(750, 300);
            EnumGroupBox.TabIndex = 8;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumaration";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(6, 46);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(150, 224);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(350, 46);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(169, 27);
            ValueTextBox.TabIndex = 5;
            // 
            // TextBoxLabel
            // 
            TextBoxLabel.AutoSize = true;
            TextBoxLabel.Location = new Point(350, 23);
            TextBoxLabel.Name = "TextBoxLabel";
            TextBoxLabel.Size = new Size(65, 20);
            TextBoxLabel.TabIndex = 6;
            TextBoxLabel.Text = "int value";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(179, 46);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 224);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsLabel
            // 
            EnumsLabel.AutoSize = true;
            EnumsLabel.Location = new Point(6, 23);
            EnumsLabel.Name = "EnumsLabel";
            EnumsLabel.Size = new Size(146, 20);
            EnumsLabel.TabIndex = 2;
            EnumsLabel.Text = "Choose enumaration";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(179, 23);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(97, 20);
            ValueLabel.TabIndex = 3;
            ValueLabel.Text = "Choose value";
            // 
            // AllEnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumGroupBox);
            Name = "AllEnumerationsControl";
            Size = new Size(750, 300);
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumGroupBox;
        private ListBox EnumsListBox;
        private TextBox ValueTextBox;
        private Label TextBoxLabel;
        private ListBox ValuesListBox;
        private Label EnumsLabel;
        private Label ValueLabel;
    }
}

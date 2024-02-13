namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Enums = new TabPage();
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            WeekdayGroupBox = new GroupBox();
            ResultTextBox = new TextBox();
            WeekdayTextLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            EnumGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            ValueTextBox = new TextBox();
            TextBoxLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsLabel = new Label();
            ValueLabel = new Label();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 531);
            tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(SeasonGroupBox);
            Enums.Controls.Add(WeekdayGroupBox);
            Enums.Controls.Add(EnumGroupBox);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(768, 498);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Location = new Point(374, 312);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(384, 169);
            SeasonGroupBox.TabIndex = 9;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(6, 27);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(109, 20);
            SeasonLabel.TabIndex = 2;
            SeasonLabel.Text = "Choose Season";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(163, 49);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 28);
            GoButton.TabIndex = 1;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 49);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(151, 28);
            SeasonComboBox.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(ResultTextBox);
            WeekdayGroupBox.Controls.Add(WeekdayTextLabel);
            WeekdayGroupBox.Controls.Add(ParseButton);
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Location = new Point(8, 312);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(350, 169);
            WeekdayGroupBox.TabIndex = 8;
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
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Controls.Add(ValueTextBox);
            EnumGroupBox.Controls.Add(TextBoxLabel);
            EnumGroupBox.Controls.Add(ValuesListBox);
            EnumGroupBox.Controls.Add(EnumsLabel);
            EnumGroupBox.Controls.Add(ValueLabel);
            EnumGroupBox.Location = new Point(8, 6);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(750, 300);
            EnumGroupBox.TabIndex = 7;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label EnumsLabel;
        private Label ValueLabel;
        private Label TextBoxLabel;
        private TextBox ValueTextBox;
        private GroupBox EnumGroupBox;
        private GroupBox WeekdayGroupBox;
        private TextBox WeekdayTextBox;
        private Button ParseButton;
        private Label WeekdayTextLabel;
        private GroupBox SeasonGroupBox;
        private Label SeasonLabel;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private TextBox ResultTextBox;
    }
}

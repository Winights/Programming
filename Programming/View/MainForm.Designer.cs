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
            mainTabControl = new TabControl();
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
            tabPage1 = new TabPage();
            FIndRectanglesButton = new Button();
            ColorTextBox = new TextBox();
            WIdthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            RectanglesGroupBox = new GroupBox();
            RectanglesListBox = new ListBox();
            LengthLabel = new Label();
            WidthLabel = new Label();
            ColorLabel = new Label();
            mainTabControl.SuspendLayout();
            Enums.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            tabPage1.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(Enums);
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Location = new Point(12, 12);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(776, 531);
            mainTabControl.TabIndex = 0;
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
            // tabPage1
            // 
            tabPage1.Controls.Add(RectanglesGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 498);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FIndRectanglesButton
            // 
            FIndRectanglesButton.Location = new Point(182, 206);
            FIndRectanglesButton.Name = "FIndRectanglesButton";
            FIndRectanglesButton.Size = new Size(125, 27);
            FIndRectanglesButton.TabIndex = 4;
            FIndRectanglesButton.Text = "Find";
            FIndRectanglesButton.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(182, 156);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 3;
            // 
            // WIdthTextBox
            // 
            WIdthTextBox.Location = new Point(182, 103);
            WIdthTextBox.Name = "WIdthTextBox";
            WIdthTextBox.Size = new Size(125, 27);
            WIdthTextBox.TabIndex = 2;
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(182, 50);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 1;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(ColorLabel);
            RectanglesGroupBox.Controls.Add(FIndRectanglesButton);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WIdthTextBox);
            RectanglesGroupBox.Location = new Point(15, 18);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(400, 288);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(161, 204);
            RectanglesListBox.TabIndex = 1;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(182, 26);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(57, 20);
            LengthLabel.TabIndex = 4;
            LengthLabel.Text = "Length:";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(182, 80);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 5;
            WidthLabel.Text = "Width:";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(182, 133);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(mainTabControl);
            Name = "MainForm";
            Text = "Programming Demo";
            mainTabControl.ResumeLayout(false);
            Enums.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            tabPage1.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
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
        private TabPage tabPage1;
        private Button FIndRectanglesButton;
        private TextBox ColorTextBox;
        private TextBox WIdthTextBox;
        private TextBox LengthTextBox;
        private GroupBox RectanglesGroupBox;
        private ListBox RectanglesListBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
    }
}

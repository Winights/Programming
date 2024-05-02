namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            RectanglesGroupBox = new GroupBox();
            Idlabel = new Label();
            IdTextBox = new TextBox();
            CoordYLabel = new Label();
            CoordXLabel = new Label();
            CoordYTextBox = new TextBox();
            CoordXTextBox = new TextBox();
            ColorLabel = new Label();
            FindRectanglesButton = new Button();
            WidthLabel = new Label();
            ColorTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            LengthLabel = new Label();
            LengthTextBox = new TextBox();
            WidthTextBox = new TextBox();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(Idlabel);
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(CoordYLabel);
            RectanglesGroupBox.Controls.Add(CoordXLabel);
            RectanglesGroupBox.Controls.Add(CoordYTextBox);
            RectanglesGroupBox.Controls.Add(CoordXTextBox);
            RectanglesGroupBox.Controls.Add(ColorLabel);
            RectanglesGroupBox.Controls.Add(FindRectanglesButton);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(364, 413);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.Location = new Point(182, 291);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(22, 20);
            Idlabel.TabIndex = 11;
            Idlabel.Text = "Id";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(182, 314);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 8;
            // 
            // CoordYLabel
            // 
            CoordYLabel.AutoSize = true;
            CoordYLabel.Location = new Point(182, 238);
            CoordYLabel.Name = "CoordYLabel";
            CoordYLabel.Size = new Size(110, 20);
            CoordYLabel.TabIndex = 10;
            CoordYLabel.Text = "Coordination y:";
            // 
            // CoordXLabel
            // 
            CoordXLabel.AutoSize = true;
            CoordXLabel.Location = new Point(182, 186);
            CoordXLabel.Name = "CoordXLabel";
            CoordXLabel.Size = new Size(110, 20);
            CoordXLabel.TabIndex = 9;
            CoordXLabel.Text = "Coordination x:";
            // 
            // CoordYTextBox
            // 
            CoordYTextBox.Enabled = false;
            CoordYTextBox.Location = new Point(182, 261);
            CoordYTextBox.Name = "CoordYTextBox";
            CoordYTextBox.ReadOnly = true;
            CoordYTextBox.Size = new Size(125, 27);
            CoordYTextBox.TabIndex = 8;
            // 
            // CoordXTextBox
            // 
            CoordXTextBox.Enabled = false;
            CoordXTextBox.Location = new Point(182, 209);
            CoordXTextBox.Name = "CoordXTextBox";
            CoordXTextBox.ReadOnly = true;
            CoordXTextBox.Size = new Size(125, 27);
            CoordXTextBox.TabIndex = 7;
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
            // FindRectanglesButton
            // 
            FindRectanglesButton.Location = new Point(182, 363);
            FindRectanglesButton.Name = "FindRectanglesButton";
            FindRectanglesButton.Size = new Size(125, 27);
            FindRectanglesButton.TabIndex = 4;
            FindRectanglesButton.Text = "Find";
            FindRectanglesButton.UseVisualStyleBackColor = true;
            FindRectanglesButton.Click += FindRectanglesButton_Click;
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
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(182, 156);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 3;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(161, 364);
            RectanglesListBox.TabIndex = 1;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
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
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(182, 50);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 1;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(182, 103);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 2;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesControl";
            Size = new Size(364, 413);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Label Idlabel;
        private TextBox IdTextBox;
        private Label CoordYLabel;
        private Label CoordXLabel;
        private TextBox CoordYTextBox;
        private TextBox CoordXTextBox;
        private Label ColorLabel;
        private Button FindRectanglesButton;
        private Label WidthLabel;
        private TextBox ColorTextBox;
        private ListBox RectanglesListBox;
        private Label LengthLabel;
        private TextBox LengthTextBox;
        private TextBox WidthTextBox;
    }
}

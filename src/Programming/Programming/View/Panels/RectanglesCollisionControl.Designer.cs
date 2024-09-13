namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            RectanglePanel = new Panel();
            RectangleGroupBox = new GroupBox();
            WidthRectangleLabel = new Label();
            HeightRectanglelabel = new Label();
            CoordYRectangleLabel = new Label();
            CoordXRectangleLabel = new Label();
            IdRectangleLabel = new Label();
            NamesLabel = new Label();
            CoordYRectanglesTextBox = new TextBox();
            CoordXRectanglesTextBox = new TextBox();
            HeightRectanglesTextBox = new TextBox();
            WidthRectanglesTextBox = new TextBox();
            IdRectanglesTextBox = new TextBox();
            RectangleListBox = new ListBox();
            AddRectangleButton = new Button();
            DeleteRectangleButton = new Button();
            RectangleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglePanel
            // 
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(405, 3);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(355, 473);
            RectanglePanel.TabIndex = 4;
            // 
            // RectangleGroupBox
            // 
            RectangleGroupBox.Controls.Add(WidthRectangleLabel);
            RectangleGroupBox.Controls.Add(HeightRectanglelabel);
            RectangleGroupBox.Controls.Add(CoordYRectangleLabel);
            RectangleGroupBox.Controls.Add(CoordXRectangleLabel);
            RectangleGroupBox.Controls.Add(IdRectangleLabel);
            RectangleGroupBox.Controls.Add(NamesLabel);
            RectangleGroupBox.Controls.Add(CoordYRectanglesTextBox);
            RectangleGroupBox.Controls.Add(CoordXRectanglesTextBox);
            RectangleGroupBox.Controls.Add(HeightRectanglesTextBox);
            RectangleGroupBox.Controls.Add(WidthRectanglesTextBox);
            RectangleGroupBox.Controls.Add(IdRectanglesTextBox);
            RectangleGroupBox.Controls.Add(RectangleListBox);
            RectangleGroupBox.Controls.Add(AddRectangleButton);
            RectangleGroupBox.Controls.Add(DeleteRectangleButton);
            RectangleGroupBox.Location = new Point(0, 3);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Size = new Size(399, 473);
            RectangleGroupBox.TabIndex = 5;
            RectangleGroupBox.TabStop = false;
            RectangleGroupBox.Text = "Rectangles";
            // 
            // WidthRectangleLabel
            // 
            WidthRectangleLabel.AutoSize = true;
            WidthRectangleLabel.Location = new Point(33, 399);
            WidthRectangleLabel.Name = "WidthRectangleLabel";
            WidthRectangleLabel.Size = new Size(49, 20);
            WidthRectangleLabel.TabIndex = 13;
            WidthRectangleLabel.Text = "Width";
            // 
            // HeightRectanglelabel
            // 
            HeightRectanglelabel.AutoSize = true;
            HeightRectanglelabel.Location = new Point(31, 435);
            HeightRectanglelabel.Name = "HeightRectanglelabel";
            HeightRectanglelabel.Size = new Size(57, 20);
            HeightRectanglelabel.TabIndex = 12;
            HeightRectanglelabel.Text = "Height:";
            // 
            // CoordYRectangleLabel
            // 
            CoordYRectangleLabel.AutoSize = true;
            CoordYRectangleLabel.Location = new Point(61, 369);
            CoordYRectangleLabel.Name = "CoordYRectangleLabel";
            CoordYRectangleLabel.Size = new Size(20, 20);
            CoordYRectangleLabel.TabIndex = 11;
            CoordYRectangleLabel.Text = "Y:";
            // 
            // CoordXRectangleLabel
            // 
            CoordXRectangleLabel.AutoSize = true;
            CoordXRectangleLabel.Location = new Point(61, 336);
            CoordXRectangleLabel.Name = "CoordXRectangleLabel";
            CoordXRectangleLabel.Size = new Size(21, 20);
            CoordXRectangleLabel.TabIndex = 10;
            CoordXRectangleLabel.Text = "X:";
            // 
            // IdRectangleLabel
            // 
            IdRectangleLabel.AutoSize = true;
            IdRectangleLabel.Location = new Point(61, 303);
            IdRectangleLabel.Name = "IdRectangleLabel";
            IdRectangleLabel.Size = new Size(25, 20);
            IdRectangleLabel.TabIndex = 9;
            IdRectangleLabel.Text = "Id:";
            // 
            // NamesLabel
            // 
            NamesLabel.AutoSize = true;
            NamesLabel.Location = new Point(0, 275);
            NamesLabel.Name = "NamesLabel";
            NamesLabel.Size = new Size(139, 20);
            NamesLabel.TabIndex = 8;
            NamesLabel.Text = "Selected Rectangle:";
            // 
            // CoordYRectanglesTextBox
            // 
            CoordYRectanglesTextBox.Location = new Point(89, 366);
            CoordYRectanglesTextBox.Name = "CoordYRectanglesTextBox";
            CoordYRectanglesTextBox.Size = new Size(125, 27);
            CoordYRectanglesTextBox.TabIndex = 7;
            CoordYRectanglesTextBox.TextChanged += CoordYRectanglesTextBox_TextChanged;
            // 
            // CoordXRectanglesTextBox
            // 
            CoordXRectanglesTextBox.Location = new Point(89, 333);
            CoordXRectanglesTextBox.Name = "CoordXRectanglesTextBox";
            CoordXRectanglesTextBox.Size = new Size(125, 27);
            CoordXRectanglesTextBox.TabIndex = 6;
            CoordXRectanglesTextBox.TextChanged += CoordXRectanglesTextBox_TextChanged;
            // 
            // HeightRectanglesTextBox
            // 
            HeightRectanglesTextBox.Location = new Point(89, 432);
            HeightRectanglesTextBox.Name = "HeightRectanglesTextBox";
            HeightRectanglesTextBox.Size = new Size(125, 27);
            HeightRectanglesTextBox.TabIndex = 5;
            HeightRectanglesTextBox.TextChanged += HeightRectanglesTextBox_TextChanged;
            // 
            // WidthRectanglesTextBox
            // 
            WidthRectanglesTextBox.Location = new Point(89, 399);
            WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            WidthRectanglesTextBox.Size = new Size(125, 27);
            WidthRectanglesTextBox.TabIndex = 4;
            WidthRectanglesTextBox.TextChanged += WidthRectanglesTextBox_TextChanged;
            // 
            // IdRectanglesTextBox
            // 
            IdRectanglesTextBox.Enabled = false;
            IdRectanglesTextBox.Location = new Point(89, 300);
            IdRectanglesTextBox.Name = "IdRectanglesTextBox";
            IdRectanglesTextBox.ReadOnly = true;
            IdRectanglesTextBox.Size = new Size(125, 27);
            IdRectanglesTextBox.TabIndex = 3;
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.Location = new Point(6, 26);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(383, 184);
            RectangleListBox.TabIndex = 2;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Location = new Point(6, 229);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(154, 29);
            AddRectangleButton.TabIndex = 1;
            AddRectangleButton.Text = "Add Rectangle";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Location = new Point(236, 229);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(153, 29);
            DeleteRectangleButton.TabIndex = 0;
            DeleteRectangleButton.Text = "Delete Rectangle";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleGroupBox);
            Controls.Add(RectanglePanel);
            Name = "RectanglesCollisionControl";
            Size = new Size(763, 480);
            RectangleGroupBox.ResumeLayout(false);
            RectangleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RectanglePanel;
        private GroupBox RectangleGroupBox;
        private Label WidthRectangleLabel;
        private Label HeightRectanglelabel;
        private Label CoordYRectangleLabel;
        private Label CoordXRectangleLabel;
        private Label IdRectangleLabel;
        private Label NamesLabel;
        private TextBox CoordYRectanglesTextBox;
        private TextBox CoordXRectanglesTextBox;
        private TextBox HeightRectanglesTextBox;
        private TextBox WidthRectanglesTextBox;
        private TextBox IdRectanglesTextBox;
        private ListBox RectangleListBox;
        private Button AddRectangleButton;
        private Button DeleteRectangleButton;
    }
}

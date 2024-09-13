namespace Programming.View.Panels
{
    partial class SeasonsControl
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
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonTextBox = new TextBox();
            SeasonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonTextBox);
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Dock = DockStyle.Fill;
            SeasonGroupBox.Location = new Point(0, 0);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(384, 169);
            SeasonGroupBox.TabIndex = 10;
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
            // SeasonTextBox
            // 
            SeasonTextBox.BorderStyle = BorderStyle.None;
            SeasonTextBox.ForeColor = SystemColors.WindowText;
            SeasonTextBox.Location = new Point(6, 83);
            SeasonTextBox.Name = "SeasonTextBox";
            SeasonTextBox.Size = new Size(251, 20);
            SeasonTextBox.TabIndex = 3;
            // 
            // SeasonsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonGroupBox);
            Name = "SeasonsControl";
            Size = new Size(384, 169);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonGroupBox;
        private Label SeasonLabel;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private TextBox SeasonTextBox;
    }
}

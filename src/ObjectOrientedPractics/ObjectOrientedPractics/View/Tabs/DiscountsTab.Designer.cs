namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            InfoLabel = new Label();
            UpdateButton = new Button();
            ApplyButton = new Button();
            CalculateButton = new Button();
            TotalCostLabel = new Label();
            AmountLabel = new Label();
            TotalDIscountLabel = new Label();
            DiscountAmountLabel = new Label();
            SuspendLayout();
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(30, 25);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(50, 20);
            InfoLabel.TabIndex = 0;
            InfoLabel.Text = "label1";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(264, 74);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(151, 74);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(94, 29);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(30, 74);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 29);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(413, 45);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(89, 28);
            TotalCostLabel.TabIndex = 9;
            TotalCostLabel.Text = "4990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(388, 25);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(126, 20);
            AmountLabel.TabIndex = 8;
            AmountLabel.Text = "Products Amount:";
            // 
            // TotalDIscountLabel
            // 
            TotalDIscountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalDIscountLabel.AutoSize = true;
            TotalDIscountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalDIscountLabel.Location = new Point(419, 94);
            TotalDIscountLabel.Name = "TotalDIscountLabel";
            TotalDIscountLabel.Size = new Size(89, 28);
            TotalDIscountLabel.TabIndex = 11;
            TotalDIscountLabel.Text = "4990,90";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Location = new Point(375, 74);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(127, 20);
            DiscountAmountLabel.TabIndex = 10;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TotalDIscountLabel);
            Controls.Add(DiscountAmountLabel);
            Controls.Add(TotalCostLabel);
            Controls.Add(AmountLabel);
            Controls.Add(CalculateButton);
            Controls.Add(ApplyButton);
            Controls.Add(UpdateButton);
            Controls.Add(InfoLabel);
            Name = "DiscountsTab";
            Size = new Size(517, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoLabel;
        private Button UpdateButton;
        private Button ApplyButton;
        private Button CalculateButton;
        private Label TotalCostLabel;
        private Label AmountLabel;
        private Label TotalDIscountLabel;
        private Label DiscountAmountLabel;
    }
}

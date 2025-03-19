namespace ObjectOrientedPractics.View.DiscountsModalWindow
{
    partial class DiscountModalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiscountsModelWindowPanel = new Panel();
            CancelDiscountsButton = new Button();
            OkDiscountsButton = new Button();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            PercentDiscountLabel = new Label();
            DiscountsModelWindowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiscountsModelWindowPanel
            // 
            DiscountsModelWindowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsModelWindowPanel.Controls.Add(CancelDiscountsButton);
            DiscountsModelWindowPanel.Controls.Add(OkDiscountsButton);
            DiscountsModelWindowPanel.Controls.Add(CategoryComboBox);
            DiscountsModelWindowPanel.Controls.Add(CategoryLabel);
            DiscountsModelWindowPanel.Controls.Add(PercentDiscountLabel);
            DiscountsModelWindowPanel.Location = new Point(12, 12);
            DiscountsModelWindowPanel.Name = "DiscountsModelWindowPanel";
            DiscountsModelWindowPanel.Size = new Size(371, 172);
            DiscountsModelWindowPanel.TabIndex = 0;
            // 
            // CancelDiscountsButton
            // 
            CancelDiscountsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelDiscountsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelDiscountsButton.Location = new Point(241, 102);
            CancelDiscountsButton.Name = "CancelDiscountsButton";
            CancelDiscountsButton.Size = new Size(108, 53);
            CancelDiscountsButton.TabIndex = 14;
            CancelDiscountsButton.Text = "Cancel";
            CancelDiscountsButton.UseVisualStyleBackColor = true;
            CancelDiscountsButton.Click += CancelDiscountsButton_Click;
            // 
            // OkDiscountsButton
            // 
            OkDiscountsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkDiscountsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OkDiscountsButton.Location = new Point(110, 102);
            OkDiscountsButton.Name = "OkDiscountsButton";
            OkDiscountsButton.Size = new Size(108, 53);
            OkDiscountsButton.TabIndex = 13;
            OkDiscountsButton.Text = "OK";
            OkDiscountsButton.UseVisualStyleBackColor = true;
            OkDiscountsButton.Click += OkDiscountsButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(81, 45);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(270, 28);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(3, 48);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentDiscountLabel.Location = new Point(3, 11);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(132, 20);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // DiscountModalWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 196);
            Controls.Add(DiscountsModelWindowPanel);
            Name = "DiscountModalWindow";
            Text = "Add Discount";
            DiscountsModelWindowPanel.ResumeLayout(false);
            DiscountsModelWindowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DiscountsModelWindowPanel;
        private Label PercentDiscountLabel;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Button CancelDiscountsButton;
        private Button OkDiscountsButton;
    }
}
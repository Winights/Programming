namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            ItemsGroupBox = new GroupBox();
            AddCartButton = new Button();
            ItemsListBox = new ListBox();
            CustomerGroupBox = new GroupBox();
            DiscountsCheckedListBox = new CheckedListBox();
            TotalCostWithDiscountlLabel = new Label();
            TotalLabel = new Label();
            TotalDiscountLabel = new Label();
            DiscountAmountLabel = new Label();
            DiscountsLabel = new Label();
            TotalCostLabel = new Label();
            AmountLabel = new Label();
            CartLabel = new Label();
            CustomerLabel = new Label();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            CreateOrderButton = new Button();
            CartListBox = new ListBox();
            CustomerComboBox = new ComboBox();
            ItemsGroupBox.SuspendLayout();
            CustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsGroupBox.Controls.Add(AddCartButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(401, 687);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // AddCartButton
            // 
            AddCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCartButton.Font = new Font("Segoe UI", 9F);
            AddCartButton.Location = new Point(12, 577);
            AddCartButton.Name = "AddCartButton";
            AddCartButton.Size = new Size(117, 64);
            AddCartButton.TabIndex = 1;
            AddCartButton.Text = "Add To Cart";
            AddCartButton.UseVisualStyleBackColor = true;
            AddCartButton.Click += AddCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Font = new Font("Segoe UI", 9F);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(12, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(380, 544);
            ItemsListBox.TabIndex = 1;
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CustomerGroupBox.Controls.Add(DiscountsCheckedListBox);
            CustomerGroupBox.Controls.Add(TotalCostWithDiscountlLabel);
            CustomerGroupBox.Controls.Add(TotalLabel);
            CustomerGroupBox.Controls.Add(TotalDiscountLabel);
            CustomerGroupBox.Controls.Add(DiscountAmountLabel);
            CustomerGroupBox.Controls.Add(DiscountsLabel);
            CustomerGroupBox.Controls.Add(TotalCostLabel);
            CustomerGroupBox.Controls.Add(AmountLabel);
            CustomerGroupBox.Controls.Add(CartLabel);
            CustomerGroupBox.Controls.Add(CustomerLabel);
            CustomerGroupBox.Controls.Add(RemoveItemButton);
            CustomerGroupBox.Controls.Add(ClearCartButton);
            CustomerGroupBox.Controls.Add(CreateOrderButton);
            CustomerGroupBox.Controls.Add(CartListBox);
            CustomerGroupBox.Controls.Add(CustomerComboBox);
            CustomerGroupBox.Location = new Point(407, 0);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(473, 687);
            CustomerGroupBox.TabIndex = 1;
            CustomerGroupBox.TabStop = false;
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Bottom;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(0, 454);
            DiscountsCheckedListBox.MinimumSize = new Size(290, 92);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(290, 180);
            DiscountsCheckedListBox.TabIndex = 14;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // TotalCostWithDiscountlLabel
            // 
            TotalCostWithDiscountlLabel.Anchor = AnchorStyles.Bottom;
            TotalCostWithDiscountlLabel.AutoSize = true;
            TotalCostWithDiscountlLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostWithDiscountlLabel.Location = new Point(344, 603);
            TotalCostWithDiscountlLabel.Name = "TotalCostWithDiscountlLabel";
            TotalCostWithDiscountlLabel.Size = new Size(121, 38);
            TotalCostWithDiscountlLabel.TabIndex = 13;
            TotalCostWithDiscountlLabel.Text = "4990,90";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(399, 577);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(66, 23);
            TotalLabel.TabIndex = 12;
            TotalLabel.Text = "TOTAL:";
            // 
            // TotalDiscountLabel
            // 
            TotalDiscountLabel.Anchor = AnchorStyles.Bottom;
            TotalDiscountLabel.AutoSize = true;
            TotalDiscountLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalDiscountLabel.Location = new Point(344, 454);
            TotalDiscountLabel.Name = "TotalDiscountLabel";
            TotalDiscountLabel.Size = new Size(121, 38);
            TotalDiscountLabel.TabIndex = 11;
            TotalDiscountLabel.Text = "4990,90";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(313, 431);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(155, 23);
            DiscountAmountLabel.TabIndex = 10;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.Anchor = AnchorStyles.Bottom;
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DiscountsLabel.Location = new Point(4, 431);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(82, 20);
            DiscountsLabel.TabIndex = 9;
            DiscountsLabel.Text = "Discounts:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Bottom;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(344, 308);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(121, 38);
            TotalCostLabel.TabIndex = 8;
            TotalCostLabel.Text = "4990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(372, 285);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(80, 23);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "Amount:";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(6, 79);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(39, 20);
            CartLabel.TabIndex = 6;
            CartLabel.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerLabel.Location = new Point(6, 32);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(82, 20);
            CustomerLabel.TabIndex = 5;
            CustomerLabel.Text = "Customer:";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom;
            RemoveItemButton.Font = new Font("Segoe UI", 9F);
            RemoveItemButton.Location = new Point(246, 363);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(108, 53);
            RemoveItemButton.TabIndex = 4;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom;
            ClearCartButton.Font = new Font("Segoe UI", 9F);
            ClearCartButton.Location = new Point(360, 363);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(108, 53);
            ClearCartButton.TabIndex = 3;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom;
            CreateOrderButton.Font = new Font("Segoe UI", 9F);
            CreateOrderButton.Location = new Point(4, 363);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(108, 53);
            CreateOrderButton.TabIndex = 2;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(4, 102);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(464, 164);
            CartListBox.TabIndex = 1;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(94, 29);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(376, 28);
            CustomerComboBox.TabIndex = 0;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "CartsTab";
            Size = new Size(883, 687);
            ItemsGroupBox.ResumeLayout(false);
            CustomerGroupBox.ResumeLayout(false);
            CustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button AddCartButton;
        private ListBox ItemsListBox;
        private GroupBox CustomerGroupBox;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Button CreateOrderButton;
        private ListBox CartListBox;
        private ComboBox CustomerComboBox;
        private Label AmountLabel;
        private Label CartLabel;
        private Label CustomerLabel;
        private Label TotalCostLabel;
        private Label TotalDiscountLabel;
        private Label DiscountAmountLabel;
        private Label DiscountsLabel;
        private Label TotalCostWithDiscountlLabel;
        private Label TotalLabel;
        private CheckedListBox DiscountsCheckedListBox;
    }
}

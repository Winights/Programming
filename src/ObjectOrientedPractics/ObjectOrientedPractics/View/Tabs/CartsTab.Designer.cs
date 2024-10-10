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
            ItemsGroupBox.Controls.Add(AddCartButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Dock = DockStyle.Left;
            ItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(853, 576);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // AddCartButton
            // 
            AddCartButton.Font = new Font("Segoe UI", 9F);
            AddCartButton.Location = new Point(6, 505);
            AddCartButton.Name = "AddCartButton";
            AddCartButton.Size = new Size(108, 53);
            AddCartButton.TabIndex = 1;
            AddCartButton.Text = "Add To Cart";
            AddCartButton.UseVisualStyleBackColor = true;
            AddCartButton.Click += AddCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Font = new Font("Segoe UI", 9F);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(6, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(397, 464);
            ItemsListBox.TabIndex = 1;
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Controls.Add(TotalCostLabel);
            CustomerGroupBox.Controls.Add(AmountLabel);
            CustomerGroupBox.Controls.Add(CartLabel);
            CustomerGroupBox.Controls.Add(CustomerLabel);
            CustomerGroupBox.Controls.Add(RemoveItemButton);
            CustomerGroupBox.Controls.Add(ClearCartButton);
            CustomerGroupBox.Controls.Add(CreateOrderButton);
            CustomerGroupBox.Controls.Add(CartListBox);
            CustomerGroupBox.Controls.Add(CustomerComboBox);
            CustomerGroupBox.Dock = DockStyle.Right;
            CustomerGroupBox.Location = new Point(409, 0);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(444, 576);
            CustomerGroupBox.TabIndex = 1;
            CustomerGroupBox.TabStop = false;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(306, 301);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(121, 38);
            TotalCostLabel.TabIndex = 8;
            TotalCostLabel.Text = "4990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(334, 278);
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
            RemoveItemButton.Font = new Font("Segoe UI", 9F);
            RemoveItemButton.Location = new Point(205, 350);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(108, 53);
            RemoveItemButton.TabIndex = 4;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Font = new Font("Segoe UI", 9F);
            ClearCartButton.Location = new Point(319, 350);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(108, 53);
            ClearCartButton.TabIndex = 3;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Font = new Font("Segoe UI", 9F);
            CreateOrderButton.Location = new Point(6, 350);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(108, 53);
            CreateOrderButton.TabIndex = 2;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(6, 102);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(422, 164);
            CartListBox.TabIndex = 1;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(94, 29);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(333, 28);
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
            Size = new Size(853, 576);
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
    }
}

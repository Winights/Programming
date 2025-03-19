namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            Model.Address address1 = new Model.Address();
            OrdersGroupBox = new GroupBox();
            OrdersDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            FullnameColumn = new DataGridViewTextBoxColumn();
            SelectedOrderGroupBox = new GroupBox();
            IdLabel = new Label();
            CreatedDateLabel = new Label();
            SatusLabel = new Label();
            DeliveryTimeLabel = new Label();
            CreatedDateTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            DeliveryTimeComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            AddItemButton = new Button();
            TotalCostLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            PriorityAddressControl = new Controls.AddressControl();
            OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SelectedOrderGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersGroupBox
            // 
            OrdersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersGroupBox.Controls.Add(OrdersDataGridView);
            OrdersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrdersGroupBox.Location = new Point(3, 3);
            OrdersGroupBox.Name = "OrdersGroupBox";
            OrdersGroupBox.Size = new Size(400, 678);
            OrdersGroupBox.TabIndex = 0;
            OrdersGroupBox.TabStop = false;
            OrdersGroupBox.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, StatusColumn, FullnameColumn });
            OrdersDataGridView.Location = new Point(6, 26);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(388, 634);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 125;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 6;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.Width = 125;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.Width = 125;
            // 
            // FullnameColumn
            // 
            FullnameColumn.HeaderText = "Fullname";
            FullnameColumn.MinimumWidth = 6;
            FullnameColumn.Name = "FullnameColumn";
            FullnameColumn.Width = 125;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedDateLabel);
            SelectedOrderGroupBox.Controls.Add(SatusLabel);
            SelectedOrderGroupBox.Controls.Add(DeliveryTimeLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedDateTextBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(DeliveryTimeComboBox);
            SelectedOrderGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderGroupBox.Location = new Point(409, 3);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(611, 158);
            SelectedOrderGroupBox.TabIndex = 1;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F);
            IdLabel.Location = new Point(13, 26);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(25, 20);
            IdLabel.TabIndex = 7;
            IdLabel.Text = "Id:";
            // 
            // CreatedDateLabel
            // 
            CreatedDateLabel.AutoSize = true;
            CreatedDateLabel.Font = new Font("Segoe UI", 9F);
            CreatedDateLabel.Location = new Point(13, 76);
            CreatedDateLabel.Name = "CreatedDateLabel";
            CreatedDateLabel.Size = new Size(64, 20);
            CreatedDateLabel.TabIndex = 6;
            CreatedDateLabel.Text = "Created:";
            // 
            // SatusLabel
            // 
            SatusLabel.AutoSize = true;
            SatusLabel.Font = new Font("Segoe UI", 9F);
            SatusLabel.Location = new Point(13, 121);
            SatusLabel.Name = "SatusLabel";
            SatusLabel.Size = new Size(52, 20);
            SatusLabel.TabIndex = 5;
            SatusLabel.Text = "Status:";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Font = new Font("Segoe UI", 9F);
            DeliveryTimeLabel.Location = new Point(261, 30);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(100, 20);
            DeliveryTimeLabel.TabIndex = 4;
            DeliveryTimeLabel.Text = "Delivery time:";
            // 
            // CreatedDateTextBox
            // 
            CreatedDateTextBox.Enabled = false;
            CreatedDateTextBox.Font = new Font("Segoe UI", 9F);
            CreatedDateTextBox.Location = new Point(83, 73);
            CreatedDateTextBox.Name = "CreatedDateTextBox";
            CreatedDateTextBox.ReadOnly = true;
            CreatedDateTextBox.Size = new Size(151, 27);
            CreatedDateTextBox.TabIndex = 3;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Segoe UI", 9F);
            IdTextBox.Location = new Point(83, 27);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Font = new Font("Segoe UI", 9F);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(83, 118);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 1;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Font = new Font("Segoe UI", 9F);
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(367, 26);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 0;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(RemoveItemButton);
            groupBox3.Controls.Add(ClearOrderButton);
            groupBox3.Controls.Add(AddItemButton);
            groupBox3.Controls.Add(TotalCostLabel);
            groupBox3.Controls.Add(AmountLabel);
            groupBox3.Controls.Add(OrderItemsListBox);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(409, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(614, 329);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Items:";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom;
            RemoveItemButton.Font = new Font("Segoe UI", 9F);
            RemoveItemButton.Location = new Point(129, 258);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(108, 53);
            RemoveItemButton.TabIndex = 10;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Anchor = AnchorStyles.Bottom;
            ClearOrderButton.Font = new Font("Segoe UI", 9F);
            ClearOrderButton.Location = new Point(500, 258);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(108, 53);
            ClearOrderButton.TabIndex = 9;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom;
            AddItemButton.Font = new Font("Segoe UI", 9F);
            AddItemButton.Location = new Point(15, 258);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(108, 53);
            AddItemButton.TabIndex = 8;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(519, 202);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(89, 28);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "4990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(537, 182);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(71, 20);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.Font = new Font("Segoe UI", 9F);
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(6, 26);
            OrderItemsListBox.MinimumSize = new Size(602, 54);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(602, 104);
            OrderItemsListBox.TabIndex = 0;
            // 
            // PriorityAddressControl
            // 
            PriorityAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriorityAddressControl.Enabled = false;
            PriorityAddressControl.Location = new Point(406, 155);
            PriorityAddressControl.Name = "PriorityAddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            PriorityAddressControl.OurAddress = address1;
            PriorityAddressControl.Size = new Size(614, 202);
            PriorityAddressControl.TabIndex = 3;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriorityAddressControl);
            Controls.Add(groupBox3);
            Controls.Add(SelectedOrderGroupBox);
            Controls.Add(OrdersGroupBox);
            Name = "PriorityOrdersTab";
            Size = new Size(1023, 684);
            OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OrdersGroupBox;
        private GroupBox SelectedOrderGroupBox;
        private GroupBox groupBox3;
        private Controls.AddressControl PriorityAddressControl;
        private DataGridView OrdersDataGridView;
        private ListBox OrderItemsListBox;
        private Label TotalCostLabel;
        private Label AmountLabel;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private Button AddItemButton;
        private Label IdLabel;
        private Label CreatedDateLabel;
        private Label SatusLabel;
        private Label DeliveryTimeLabel;
        private TextBox CreatedDateTextBox;
        private TextBox IdTextBox;
        private ComboBox StatusComboBox;
        private ComboBox DeliveryTimeComboBox;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn FullnameColumn;
    }
}

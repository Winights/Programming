namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            PriorityOptionsPanel = new Panel();
            DeliveryTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            OrderAddressControl = new Controls.AddressControl();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            IdTextBox = new TextBox();
            OrderItemsGroupBox = new GroupBox();
            TotalCostLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SelectedOrderGroupBox.SuspendLayout();
            PriorityOptionsPanel.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersGroupBox
            // 
            OrdersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersGroupBox.Controls.Add(OrdersDataGridView);
            OrdersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrdersGroupBox.Location = new Point(0, 0);
            OrdersGroupBox.Name = "OrdersGroupBox";
            OrdersGroupBox.Size = new Size(476, 725);
            OrdersGroupBox.TabIndex = 0;
            OrdersGroupBox.TabStop = false;
            OrdersGroupBox.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeight = 30;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, StatusColumn, FullnameColumn });
            OrdersDataGridView.Location = new Point(6, 26);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(463, 677);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Width = 125;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 6;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.ReadOnly = true;
            CreatedColumn.Width = 125;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "OrderStatus";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            StatusColumn.Width = 125;
            // 
            // FullnameColumn
            // 
            FullnameColumn.HeaderText = "Customer Fullname";
            FullnameColumn.MinimumWidth = 6;
            FullnameColumn.Name = "FullnameColumn";
            FullnameColumn.ReadOnly = true;
            FullnameColumn.Width = 125;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SelectedOrderGroupBox.Controls.Add(PriorityOptionsPanel);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedLabel);
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Controls.Add(OrderAddressControl);
            SelectedOrderGroupBox.Controls.Add(CreatedTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderGroupBox.Location = new Point(481, 0);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(619, 388);
            SelectedOrderGroupBox.TabIndex = 1;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order:";
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsPanel.Controls.Add(PriorityOptionsLabel);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Location = new Point(312, 0);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(268, 109);
            PriorityOptionsPanel.TabIndex = 8;
            PriorityOptionsPanel.Visible = false;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Font = new Font("Segoe UI", 9F);
            DeliveryTimeLabel.Location = new Point(3, 26);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(100, 20);
            DeliveryTimeLabel.TabIndex = 9;
            DeliveryTimeLabel.Text = "Delivery time:";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Location = new Point(0, 0);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(106, 20);
            PriorityOptionsLabel.TabIndex = 1;
            PriorityOptionsLabel.Text = "Priority Label:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Font = new Font("Segoe UI", 9F);
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(109, 23);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 0;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9F);
            StatusLabel.Location = new Point(6, 121);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Font = new Font("Segoe UI", 9F);
            CreatedLabel.Location = new Point(6, 75);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 6;
            CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F);
            IdLabel.Location = new Point(6, 29);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 5;
            IdLabel.Text = "ID:";
            // 
            // OrderAddressControl
            // 
            OrderAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            OrderAddressControl.Enabled = false;
            OrderAddressControl.Location = new Point(6, 168);
            OrderAddressControl.Name = "OrderAddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            OrderAddressControl.OurAddress = address1;
            OrderAddressControl.Size = new Size(610, 214);
            OrderAddressControl.TabIndex = 0;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CreatedTextBox.Enabled = false;
            CreatedTextBox.Font = new Font("Segoe UI", 9F);
            CreatedTextBox.Location = new Point(84, 68);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(151, 27);
            CreatedTextBox.TabIndex = 4;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            StatusComboBox.Font = new Font("Segoe UI", 9F);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(84, 113);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 3;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Segoe UI", 9F);
            IdTextBox.Location = new Point(84, 26);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 1;
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            OrderItemsGroupBox.Controls.Add(TotalCostLabel);
            OrderItemsGroupBox.Controls.Add(AmountLabel);
            OrderItemsGroupBox.Controls.Add(OrderItemsListBox);
            OrderItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsGroupBox.Location = new Point(481, 394);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Size = new Size(619, 331);
            OrderItemsGroupBox.TabIndex = 2;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "Order Items";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(524, 272);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(89, 28);
            TotalCostLabel.TabIndex = 5;
            TotalCostLabel.Text = "4990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(542, 252);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(71, 20);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrderItemsListBox.Enabled = false;
            OrderItemsListBox.Font = new Font("Segoe UI", 9F);
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(6, 31);
            OrderItemsListBox.MinimumSize = new Size(607, 64);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(607, 144);
            OrderItemsListBox.TabIndex = 3;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderItemsGroupBox);
            Controls.Add(SelectedOrderGroupBox);
            Controls.Add(OrdersGroupBox);
            Name = "OrdersTab";
            Size = new Size(1100, 728);
            OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            OrderItemsGroupBox.ResumeLayout(false);
            OrderItemsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OrdersGroupBox;
        private DataGridView OrdersDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewTextBoxColumn FullnameColumn;
        private GroupBox SelectedOrderGroupBox;
        private Controls.AddressControl OrderAddressControl;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private GroupBox OrderItemsGroupBox;
        private ListBox OrderItemsListBox;
        private Label TotalCostLabel;
        private Label AmountLabel;
        private Panel PriorityOptionsPanel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsLabel;
    }
}

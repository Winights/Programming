namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomerGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            PriorityCheckBox = new CheckBox();
            CustomerPanel = new Panel();
            RemoveDiscountsButton = new Button();
            AddDiscountsButton = new Button();
            DiscountsListBox = new ListBox();
            DiscountsLabel = new Label();
            AddressControl = new Controls.AddressControl();
            FullnameLabel = new Label();
            IDLabel = new Label();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CustomerGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            CustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox.Controls.Add(RemoveButton);
            CustomerGroupBox.Controls.Add(AddButton);
            CustomerGroupBox.Controls.Add(CustomersListBox);
            CustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerGroupBox.Location = new Point(0, 0);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(302, 654);
            CustomerGroupBox.TabIndex = 0;
            CustomerGroupBox.TabStop = false;
            CustomerGroupBox.Text = "Customers";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(119, 568);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 53);
            RemoveButton.TabIndex = 10;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(6, 569);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 53);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.Font = new Font("Segoe UI", 9F);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(6, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(283, 524);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            CustomersListBox.DoubleClick += CustomersListBox_DoubleClick;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SelectedCustomerGroupBox.BackColor = Color.White;
            SelectedCustomerGroupBox.Controls.Add(PriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerPanel);
            SelectedCustomerGroupBox.Controls.Add(AddressControl);
            SelectedCustomerGroupBox.Controls.Add(FullnameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Controls.Add(FullnameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IdTextBox);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerGroupBox.Location = new Point(308, 0);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(624, 654);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Font = new Font("Segoe UI", 9F);
            PriorityCheckBox.Location = new Point(6, 134);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(92, 24);
            PriorityCheckBox.TabIndex = 6;
            PriorityCheckBox.Text = "is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // CustomerPanel
            // 
            CustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerPanel.BackColor = Color.White;
            CustomerPanel.Controls.Add(RemoveDiscountsButton);
            CustomerPanel.Controls.Add(AddDiscountsButton);
            CustomerPanel.Controls.Add(DiscountsListBox);
            CustomerPanel.Controls.Add(DiscountsLabel);
            CustomerPanel.Location = new Point(6, 382);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(612, 269);
            CustomerPanel.TabIndex = 2;
            // 
            // RemoveDiscountsButton
            // 
            RemoveDiscountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveDiscountsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveDiscountsButton.Location = new Point(340, 103);
            RemoveDiscountsButton.Name = "RemoveDiscountsButton";
            RemoveDiscountsButton.Size = new Size(108, 53);
            RemoveDiscountsButton.TabIndex = 12;
            RemoveDiscountsButton.Text = "Remove";
            RemoveDiscountsButton.UseVisualStyleBackColor = true;
            RemoveDiscountsButton.Click += RemoveDiscountsButton_Click;
            // 
            // AddDiscountsButton
            // 
            AddDiscountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDiscountsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddDiscountsButton.Location = new Point(340, 32);
            AddDiscountsButton.Name = "AddDiscountsButton";
            AddDiscountsButton.Size = new Size(108, 53);
            AddDiscountsButton.TabIndex = 11;
            AddDiscountsButton.Text = "Add";
            AddDiscountsButton.UseVisualStyleBackColor = true;
            AddDiscountsButton.Click += AddDiscountsButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Font = new Font("Segoe UI", 9F);
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.Location = new Point(8, 32);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(326, 124);
            DiscountsListBox.TabIndex = 1;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Location = new Point(3, 9);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(78, 20);
            DiscountsLabel.TabIndex = 0;
            DiscountsLabel.Text = "Discounts";
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddressControl.Location = new Point(6, 177);
            AddressControl.Name = "AddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            AddressControl.OurAddress = address1;
            AddressControl.Size = new Size(612, 199);
            AddressControl.TabIndex = 5;
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Font = new Font("Segoe UI", 9F);
            FullnameLabel.Location = new Point(6, 95);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(76, 20);
            FullnameLabel.TabIndex = 4;
            FullnameLabel.Text = "Full name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 9F);
            IDLabel.Location = new Point(6, 45);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "ID:";
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Font = new Font("Segoe UI", 9F);
            FullnameTextBox.Location = new Point(88, 91);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(354, 27);
            FullnameTextBox.TabIndex = 2;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Segoe UI", 9F);
            IdTextBox.Location = new Point(88, 42);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 0;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomerGroupBox);
            Name = "CustomersTab";
            Size = new Size(932, 654);
            CustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            CustomerPanel.ResumeLayout(false);
            CustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomerGroupBox;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox FullnameTextBox;
        private TextBox IdTextBox;
        private Label FullnameLabel;
        private Label IDLabel;
        private Panel CustomerPanel;
        private ListBox CustomersListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Controls.AddressControl AddressControl;
        private CheckBox PriorityCheckBox;
        private ListBox DiscountsListBox;
        private Label DiscountsLabel;
        private Button RemoveDiscountsButton;
        private Button AddDiscountsButton;
    }
}

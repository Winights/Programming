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
            Model.Address address2 = new Model.Address();
            CustomerGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            CustomerPanel = new Panel();
            AddressControl = new Controls.AddressControl();
            FullnameLabel = new Label();
            IDLabel = new Label();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CustomerGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Controls.Add(RemoveButton);
            CustomerGroupBox.Controls.Add(AddButton);
            CustomerGroupBox.Controls.Add(CustomersListBox);
            CustomerGroupBox.Dock = DockStyle.Left;
            CustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerGroupBox.Location = new Point(0, 0);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(352, 622);
            CustomerGroupBox.TabIndex = 0;
            CustomerGroupBox.TabStop = false;
            CustomerGroupBox.Text = "Customers";
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(119, 536);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 53);
            RemoveButton.TabIndex = 10;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(6, 537);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 53);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Font = new Font("Segoe UI", 9F);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(6, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(333, 504);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            CustomersListBox.DoubleClick += CustomersListBox_DoubleClick;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.BackColor = Color.White;
            SelectedCustomerGroupBox.Controls.Add(CustomerPanel);
            SelectedCustomerGroupBox.Controls.Add(AddressControl);
            SelectedCustomerGroupBox.Controls.Add(FullnameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Controls.Add(FullnameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IdTextBox);
            SelectedCustomerGroupBox.Dock = DockStyle.Right;
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerGroupBox.Location = new Point(355, 0);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(624, 622);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // CustomerPanel
            // 
            CustomerPanel.BackColor = Color.White;
            CustomerPanel.Location = new Point(6, 322);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(612, 300);
            CustomerPanel.TabIndex = 2;
            // 
            // AddressControl
            // 
            AddressControl.Location = new Point(6, 125);
            AddressControl.Name = "AddressControl";
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            AddressControl.OurAddress = address2;
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
            FullnameTextBox.Font = new Font("Segoe UI", 9F);
            FullnameTextBox.Location = new Point(88, 92);
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
            Size = new Size(979, 622);
            CustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
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
    }
}

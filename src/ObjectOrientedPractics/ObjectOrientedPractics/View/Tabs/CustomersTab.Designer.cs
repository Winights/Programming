﻿namespace ObjectOrientedPractics.View.Tabs
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
            CustomerPanel = new Panel();
            AddressControl = new Controls.AddressControl();
            FullnameLabel = new Label();
            IDLabel = new Label();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            PriorityCheckBox = new CheckBox();
            CustomerGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
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
            CustomerGroupBox.Size = new Size(355, 654);
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
            CustomersListBox.Size = new Size(336, 524);
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
            SelectedCustomerGroupBox.Location = new Point(355, 0);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(624, 654);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // CustomerPanel
            // 
            CustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomerPanel.BackColor = Color.White;
            CustomerPanel.Location = new Point(6, 382);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(612, 269);
            CustomerPanel.TabIndex = 2;
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
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomerGroupBox);
            Name = "CustomersTab";
            Size = new Size(979, 654);
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
        private CheckBox PriorityCheckBox;
    }
}

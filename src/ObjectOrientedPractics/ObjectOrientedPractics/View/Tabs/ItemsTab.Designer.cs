﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            EditButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            IdLabel = new Label();
            CostLabel = new Label();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(EditButton);
            ItemsGroupBox.Controls.Add(RemoveButton);
            ItemsGroupBox.Controls.Add(AddButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsGroupBox.Location = new Point(0, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(348, 615);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditButton.Location = new Point(231, 536);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(108, 53);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(119, 536);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 53);
            RemoveButton.TabIndex = 8;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(6, 536);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(108, 53);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(6, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(333, 504);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.BackColor = Color.White;
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(DescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemGroupBox.Location = new Point(348, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(455, 615);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IdLabel.Location = new Point(6, 35);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 7;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CostLabel.Location = new Point(6, 72);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 6;
            CostLabel.Text = "Cost:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionLabel.Location = new Point(6, 255);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(6, 112);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionTextBox.Location = new Point(6, 278);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(443, 180);
            DescriptionTextBox.TabIndex = 3;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(6, 133);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(443, 119);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CostTextBox.Location = new Point(50, 68);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(125, 27);
            CostTextBox.TabIndex = 1;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IdTextBox.Location = new Point(50, 32);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(806, 622);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label IdLabel;
        private Label CostLabel;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Button RemoveButton;
        private Button AddButton;
        private Button EditButton;
    }
}

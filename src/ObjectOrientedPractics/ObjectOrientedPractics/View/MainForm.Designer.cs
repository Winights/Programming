namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ObjecTabControl = new TabControl();
            tabPage1 = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            tabPage3 = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            tabPage4 = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            ObjecTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // ObjecTabControl
            // 
            ObjecTabControl.Controls.Add(tabPage1);
            ObjecTabControl.Controls.Add(tabPage2);
            ObjecTabControl.Controls.Add(tabPage3);
            ObjecTabControl.Controls.Add(tabPage4);
            ObjecTabControl.Dock = DockStyle.Fill;
            ObjecTabControl.Location = new Point(0, 0);
            ObjecTabControl.Name = "ObjecTabControl";
            ObjecTabControl.SelectedIndex = 0;
            ObjecTabControl.Size = new Size(982, 627);
            ObjecTabControl.TabIndex = 0;
            ObjecTabControl.SelectedIndexChanged += ObjecTabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTab);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 594);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(968, 588);
            ItemsTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CustomersTab);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1228, 594);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(0, 0);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1228, 594);
            CustomersTab.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(CartsTab);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1228, 594);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CartTab";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Items = null;
            CartsTab.Location = new Point(3, 3);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1222, 588);
            CartsTab.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(OrdersTab);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1228, 594);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "OrdersTab";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1222, 588);
            OrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 627);
            Controls.Add(ObjecTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            ObjecTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ObjecTabControl;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab ItemsTab;
        private TabPage tabPage2;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage tabPage3;
        private View.Tabs.CartsTab CartsTab;
        private TabPage tabPage4;
        private View.Tabs.OrdersTab OrdersTab;
    }
}

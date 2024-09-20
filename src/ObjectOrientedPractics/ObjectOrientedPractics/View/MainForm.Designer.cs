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
            ObjecTabControl = new TabControl();
            tabPage1 = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            ObjecTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // ObjecTabControl
            // 
            ObjecTabControl.Controls.Add(tabPage1);
            ObjecTabControl.Controls.Add(tabPage2);
            ObjecTabControl.Dock = DockStyle.Fill;
            ObjecTabControl.Location = new Point(0, 0);
            ObjecTabControl.Name = "ObjecTabControl";
            ObjecTabControl.SelectedIndex = 0;
            ObjecTabControl.Size = new Size(814, 653);
            ObjecTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 608);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(780, 602);
            itemsTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(806, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(0, 0);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(806, 620);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 653);
            Controls.Add(ObjecTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            ObjecTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ObjecTabControl;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage tabPage2;
        private View.Tabs.CustomersTab customersTab1;
    }
}

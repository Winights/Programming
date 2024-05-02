namespace Programming
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
            RectanglesMainTabControl = new TabControl();
            EnumsTabPage = new TabPage();
            seasonsControl1 = new View.Panels.SeasonsControl();
            weekdayParsingControl1 = new View.Panels.WeekdayParsingControl();
            allEnumerationsControl1 = new View.Panels.AllEnumerationsControl();
            ClassesTabPage = new TabPage();
            moviesControl1 = new View.Panels.MoviesControl();
            RectanglesTabPage = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            RectanglesMainTabControl.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesMainTabControl
            // 
            RectanglesMainTabControl.Controls.Add(EnumsTabPage);
            RectanglesMainTabControl.Controls.Add(ClassesTabPage);
            RectanglesMainTabControl.Controls.Add(RectanglesTabPage);
            RectanglesMainTabControl.Location = new Point(12, 12);
            RectanglesMainTabControl.Name = "RectanglesMainTabControl";
            RectanglesMainTabControl.SelectedIndex = 0;
            RectanglesMainTabControl.Size = new Size(776, 531);
            RectanglesMainTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(seasonsControl1);
            EnumsTabPage.Controls.Add(weekdayParsingControl1);
            EnumsTabPage.Controls.Add(allEnumerationsControl1);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(768, 498);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonsControl1
            // 
            seasonsControl1.Dock = DockStyle.Right;
            seasonsControl1.Location = new Point(374, 306);
            seasonsControl1.Name = "seasonsControl1";
            seasonsControl1.Size = new Size(391, 189);
            seasonsControl1.TabIndex = 12;
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Dock = DockStyle.Left;
            weekdayParsingControl1.Location = new Point(3, 306);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(365, 189);
            weekdayParsingControl1.TabIndex = 11;
            // 
            // allEnumerationsControl1
            // 
            allEnumerationsControl1.Dock = DockStyle.Top;
            allEnumerationsControl1.Location = new Point(3, 3);
            allEnumerationsControl1.Name = "allEnumerationsControl1";
            allEnumerationsControl1.Size = new Size(762, 303);
            allEnumerationsControl1.TabIndex = 10;
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(rectanglesControl1);
            ClassesTabPage.Controls.Add(moviesControl1);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(768, 498);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            moviesControl1.Dock = DockStyle.Right;
            moviesControl1.Location = new Point(376, 3);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(389, 492);
            moviesControl1.TabIndex = 1;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(rectanglesCollisionControl1);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(768, 498);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(762, 492);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Dock = DockStyle.Left;
            rectanglesControl1.Location = new Point(3, 3);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(367, 492);
            rectanglesControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(RectanglesMainTabControl);
            Name = "MainForm";
            Text = "Programming Demo";
            RectanglesMainTabControl.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            RectanglesTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl RectanglesMainTabControl;
        private TabPage EnumsTabPage;
        private TabPage ClassesTabPage;
        private TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.AllEnumerationsControl allEnumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonsControl seasonsControl1;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
    }
}

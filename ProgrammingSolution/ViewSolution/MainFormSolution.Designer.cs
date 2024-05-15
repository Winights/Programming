namespace ProgrammingSolution
{
    partial class MainFormSolution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            GenreLabel = new Label();
            PagesLabel = new Label();
            AuthotLabel = new Label();
            YearOfIssueLabel = new Label();
            TitleLabel = new Label();
            YearOfIssueTextBox = new TextBox();
            TitleTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            PagesTextBox = new TextBox();
            GenreComboBox = new ComboBox();
            BookListBox = new ListBox();
            AddButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GenreLabel);
            groupBox1.Controls.Add(PagesLabel);
            groupBox1.Controls.Add(AuthotLabel);
            groupBox1.Controls.Add(YearOfIssueLabel);
            groupBox1.Controls.Add(TitleLabel);
            groupBox1.Controls.Add(YearOfIssueTextBox);
            groupBox1.Controls.Add(TitleTextBox);
            groupBox1.Controls.Add(AuthorTextBox);
            groupBox1.Controls.Add(PagesTextBox);
            groupBox1.Controls.Add(GenreComboBox);
            groupBox1.Location = new Point(348, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 278);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Book:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(26, 222);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(48, 20);
            GenreLabel.TabIndex = 10;
            GenreLabel.Text = "Genre";
            // 
            // PagesLabel
            // 
            PagesLabel.AutoSize = true;
            PagesLabel.Location = new Point(26, 178);
            PagesLabel.Name = "PagesLabel";
            PagesLabel.Size = new Size(47, 20);
            PagesLabel.TabIndex = 9;
            PagesLabel.Text = "Pages";
            // 
            // AuthotLabel
            // 
            AuthotLabel.AutoSize = true;
            AuthotLabel.Location = new Point(26, 135);
            AuthotLabel.Name = "AuthotLabel";
            AuthotLabel.Size = new Size(57, 20);
            AuthotLabel.TabIndex = 8;
            AuthotLabel.Text = "Author:";
            // 
            // YearOfIssueLabel
            // 
            YearOfIssueLabel.AutoSize = true;
            YearOfIssueLabel.Location = new Point(26, 86);
            YearOfIssueLabel.Name = "YearOfIssueLabel";
            YearOfIssueLabel.Size = new Size(94, 20);
            YearOfIssueLabel.TabIndex = 7;
            YearOfIssueLabel.Text = "Year of issue:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(26, 39);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(76, 20);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "Book title:";
            // 
            // YearOfIssueTextBox
            // 
            YearOfIssueTextBox.Location = new Point(137, 83);
            YearOfIssueTextBox.Name = "YearOfIssueTextBox";
            YearOfIssueTextBox.Size = new Size(151, 27);
            YearOfIssueTextBox.TabIndex = 5;
            YearOfIssueTextBox.TextChanged += YearOfIssueTextBox_TextChanged;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(137, 39);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(151, 27);
            TitleTextBox.TabIndex = 4;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(137, 132);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(151, 27);
            AuthorTextBox.TabIndex = 3;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged;
            // 
            // PagesTextBox
            // 
            PagesTextBox.Location = new Point(137, 175);
            PagesTextBox.Name = "PagesTextBox";
            PagesTextBox.Size = new Size(151, 27);
            PagesTextBox.TabIndex = 2;
            PagesTextBox.TextChanged += PagesTextBox_TextChanged;
            // 
            // GenreComboBox
            // 
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(137, 219);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(151, 28);
            GenreComboBox.TabIndex = 1;
            // 
            // BookListBox
            // 
            BookListBox.FormattingEnabled = true;
            BookListBox.Location = new Point(12, 12);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(324, 364);
            BookListBox.TabIndex = 2;
            BookListBox.SelectedIndexChanged += BooksListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(12, 392);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(242, 392);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Location = new Point(128, 392);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // MainFormSolution
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(BookListBox);
            Controls.Add(groupBox1);
            Name = "MainFormSolution";
            Text = "AppBook";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox GenreComboBox;
        private TextBox YearOfIssueTextBox;
        private TextBox TitleTextBox;
        private TextBox AuthorTextBox;
        private TextBox PagesTextBox;
        private ListBox BookListBox;
        private Button AddButton;
        private Button DeleteButton;
        private Button EditButton;
        private Label GenreLabel;
        private Label PagesLabel;
        private Label AuthotLabel;
        private Label YearOfIssueLabel;
        private Label TitleLabel;
    }
}
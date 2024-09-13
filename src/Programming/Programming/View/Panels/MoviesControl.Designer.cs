namespace Programming.View.Panels
{
    partial class MoviesControl
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
            MovieGroupBox = new GroupBox();
            RatingLabel = new Label();
            ReleaseYearLabel = new Label();
            TitleLabel = new Label();
            DurationLabel = new Label();
            RatingTextBox = new TextBox();
            GenreLabel = new Label();
            ReleaseYearTextBox = new TextBox();
            FindMoviesButton = new Button();
            GenreTextBox = new TextBox();
            DurationMinutesTextBox = new TextBox();
            TitleTextBox = new TextBox();
            MoviesListBox = new ListBox();
            MovieGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MovieGroupBox
            // 
            MovieGroupBox.Controls.Add(RatingLabel);
            MovieGroupBox.Controls.Add(ReleaseYearLabel);
            MovieGroupBox.Controls.Add(TitleLabel);
            MovieGroupBox.Controls.Add(DurationLabel);
            MovieGroupBox.Controls.Add(RatingTextBox);
            MovieGroupBox.Controls.Add(GenreLabel);
            MovieGroupBox.Controls.Add(ReleaseYearTextBox);
            MovieGroupBox.Controls.Add(FindMoviesButton);
            MovieGroupBox.Controls.Add(GenreTextBox);
            MovieGroupBox.Controls.Add(DurationMinutesTextBox);
            MovieGroupBox.Controls.Add(TitleTextBox);
            MovieGroupBox.Controls.Add(MoviesListBox);
            MovieGroupBox.Dock = DockStyle.Fill;
            MovieGroupBox.Location = new Point(0, 0);
            MovieGroupBox.Name = "MovieGroupBox";
            MovieGroupBox.Size = new Size(364, 413);
            MovieGroupBox.TabIndex = 2;
            MovieGroupBox.TabStop = false;
            MovieGroupBox.Text = "Movies";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(183, 237);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 7;
            RatingLabel.Text = "Rating:";
            // 
            // ReleaseYearLabel
            // 
            ReleaseYearLabel.AutoSize = true;
            ReleaseYearLabel.Location = new Point(183, 186);
            ReleaseYearLabel.Name = "ReleaseYearLabel";
            ReleaseYearLabel.Size = new Size(95, 20);
            ReleaseYearLabel.TabIndex = 4;
            ReleaseYearLabel.Text = "Release Year:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(183, 27);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "Title:";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(183, 133);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(142, 20);
            DurationLabel.TabIndex = 3;
            DurationLabel.Text = "Duration in minutes:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(183, 259);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(139, 27);
            RatingTextBox.TabIndex = 6;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(183, 80);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 2;
            GenreLabel.Text = "Genre:";
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(183, 209);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(139, 27);
            ReleaseYearTextBox.TabIndex = 5;
            ReleaseYearTextBox.TextChanged += ReleaseYearTextBox_TextChanged;
            // 
            // FindMoviesButton
            // 
            FindMoviesButton.Location = new Point(183, 361);
            FindMoviesButton.Name = "FindMoviesButton";
            FindMoviesButton.Size = new Size(142, 29);
            FindMoviesButton.TabIndex = 4;
            FindMoviesButton.Text = "Find";
            FindMoviesButton.UseVisualStyleBackColor = true;
            FindMoviesButton.TextChanged += FindMoviesButton_Click;
            FindMoviesButton.Click += FindMoviesButton_Click;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(183, 103);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(139, 27);
            GenreTextBox.TabIndex = 3;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // DurationMinutesTextBox
            // 
            DurationMinutesTextBox.Location = new Point(183, 156);
            DurationMinutesTextBox.Name = "DurationMinutesTextBox";
            DurationMinutesTextBox.Size = new Size(139, 27);
            DurationMinutesTextBox.TabIndex = 2;
            DurationMinutesTextBox.TextChanged += DurationMinutesTextBox_TextChanged;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(183, 50);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(139, 27);
            TitleTextBox.TabIndex = 1;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(6, 26);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(161, 364);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MovieGroupBox);
            Name = "MoviesControl";
            Size = new Size(364, 413);
            MovieGroupBox.ResumeLayout(false);
            MovieGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MovieGroupBox;
        private Label RatingLabel;
        private Label ReleaseYearLabel;
        private Label TitleLabel;
        private Label DurationLabel;
        private TextBox RatingTextBox;
        private Label GenreLabel;
        private TextBox ReleaseYearTextBox;
        private Button FindMoviesButton;
        private TextBox GenreTextBox;
        private TextBox DurationMinutesTextBox;
        private TextBox TitleTextBox;
        private ListBox MoviesListBox;
    }
}

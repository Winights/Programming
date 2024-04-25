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
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            WeekdayGroupBox = new GroupBox();
            ResultTextBox = new TextBox();
            WeekdayTextLabel = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            EnumGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            ValueTextBox = new TextBox();
            TextBoxLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsLabel = new Label();
            ValueLabel = new Label();
            ClassesTabPage = new TabPage();
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
            RectanglesGroupBox = new GroupBox();
            Idlabel = new Label();
            IdTextBox = new TextBox();
            CoordYLabel = new Label();
            CoordXLabel = new Label();
            CoordYTextBox = new TextBox();
            CoordXTextBox = new TextBox();
            ColorLabel = new Label();
            FindRectanglesButton = new Button();
            WidthLabel = new Label();
            ColorTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            LengthLabel = new Label();
            LengthTextBox = new TextBox();
            WidthTextBox = new TextBox();
            RectanglesTabPage = new TabPage();
            RectangleGroupBox = new GroupBox();
            WidthRectangleLabel = new Label();
            HeightRectanglelabel = new Label();
            CoordYRectangleLabel = new Label();
            CoordXRectangleLabel = new Label();
            IdRectangleLabel = new Label();
            NamesLabel = new Label();
            CoordYRectanglesTextBox = new TextBox();
            CoordXRectanglesTextBox = new TextBox();
            HeightRectanglesTextBox = new TextBox();
            WidthRectanglesTextBox = new TextBox();
            IdRectanglesTextBox = new TextBox();
            RectangleListBox = new ListBox();
            AddRectangleButton = new Button();
            DeleteRectangleButton = new Button();
            RectanglePanel = new Panel();
            RectanglesMainTabControl.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            EnumGroupBox.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            MovieGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            RectangleGroupBox.SuspendLayout();
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
            EnumsTabPage.Controls.Add(SeasonGroupBox);
            EnumsTabPage.Controls.Add(WeekdayGroupBox);
            EnumsTabPage.Controls.Add(EnumGroupBox);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(768, 498);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Location = new Point(374, 312);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(384, 169);
            SeasonGroupBox.TabIndex = 9;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(6, 27);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(109, 20);
            SeasonLabel.TabIndex = 2;
            SeasonLabel.Text = "Choose Season";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(163, 49);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 28);
            GoButton.TabIndex = 1;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 49);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(151, 28);
            SeasonComboBox.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(ResultTextBox);
            WeekdayGroupBox.Controls.Add(WeekdayTextLabel);
            WeekdayGroupBox.Controls.Add(ParseButton);
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Location = new Point(8, 312);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(350, 169);
            WeekdayGroupBox.TabIndex = 8;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ResultTextBox
            // 
            ResultTextBox.BorderStyle = BorderStyle.None;
            ResultTextBox.ForeColor = SystemColors.WindowText;
            ResultTextBox.Location = new Point(9, 83);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(270, 20);
            ResultTextBox.TabIndex = 3;
            // 
            // WeekdayTextLabel
            // 
            WeekdayTextLabel.AutoSize = true;
            WeekdayTextLabel.Location = new Point(6, 27);
            WeekdayTextLabel.Name = "WeekdayTextLabel";
            WeekdayTextLabel.Size = new Size(158, 20);
            WeekdayTextLabel.TabIndex = 10;
            WeekdayTextLabel.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(184, 50);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(92, 27);
            ParseButton.TabIndex = 9;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 50);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(172, 27);
            WeekdayTextBox.TabIndex = 9;
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Controls.Add(ValueTextBox);
            EnumGroupBox.Controls.Add(TextBoxLabel);
            EnumGroupBox.Controls.Add(ValuesListBox);
            EnumGroupBox.Controls.Add(EnumsLabel);
            EnumGroupBox.Controls.Add(ValueLabel);
            EnumGroupBox.Location = new Point(8, 6);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(750, 300);
            EnumGroupBox.TabIndex = 7;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumaration";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(6, 46);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(150, 224);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(350, 46);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(169, 27);
            ValueTextBox.TabIndex = 5;
            // 
            // TextBoxLabel
            // 
            TextBoxLabel.AutoSize = true;
            TextBoxLabel.Location = new Point(350, 23);
            TextBoxLabel.Name = "TextBoxLabel";
            TextBoxLabel.Size = new Size(65, 20);
            TextBoxLabel.TabIndex = 6;
            TextBoxLabel.Text = "int value";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(179, 46);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 224);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsLabel
            // 
            EnumsLabel.AutoSize = true;
            EnumsLabel.Location = new Point(6, 23);
            EnumsLabel.Name = "EnumsLabel";
            EnumsLabel.Size = new Size(146, 20);
            EnumsLabel.TabIndex = 2;
            EnumsLabel.Text = "Choose enumaration";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(179, 23);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(97, 20);
            ValueLabel.TabIndex = 3;
            ValueLabel.Text = "Choose value";
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(MovieGroupBox);
            ClassesTabPage.Controls.Add(RectanglesGroupBox);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(768, 498);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
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
            MovieGroupBox.Location = new Point(398, 18);
            MovieGroupBox.Name = "MovieGroupBox";
            MovieGroupBox.Size = new Size(364, 413);
            MovieGroupBox.TabIndex = 1;
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
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(Idlabel);
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(CoordYLabel);
            RectanglesGroupBox.Controls.Add(CoordXLabel);
            RectanglesGroupBox.Controls.Add(CoordYTextBox);
            RectanglesGroupBox.Controls.Add(CoordXTextBox);
            RectanglesGroupBox.Controls.Add(ColorLabel);
            RectanglesGroupBox.Controls.Add(FindRectanglesButton);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Location = new Point(6, 18);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(364, 413);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.Location = new Point(182, 291);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(22, 20);
            Idlabel.TabIndex = 11;
            Idlabel.Text = "Id";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(182, 314);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 8;
            // 
            // CoordYLabel
            // 
            CoordYLabel.AutoSize = true;
            CoordYLabel.Location = new Point(182, 238);
            CoordYLabel.Name = "CoordYLabel";
            CoordYLabel.Size = new Size(110, 20);
            CoordYLabel.TabIndex = 10;
            CoordYLabel.Text = "Coordination y:";
            // 
            // CoordXLabel
            // 
            CoordXLabel.AutoSize = true;
            CoordXLabel.Location = new Point(182, 186);
            CoordXLabel.Name = "CoordXLabel";
            CoordXLabel.Size = new Size(110, 20);
            CoordXLabel.TabIndex = 9;
            CoordXLabel.Text = "Coordination x:";
            // 
            // CoordYTextBox
            // 
            CoordYTextBox.Enabled = false;
            CoordYTextBox.Location = new Point(182, 261);
            CoordYTextBox.Name = "CoordYTextBox";
            CoordYTextBox.ReadOnly = true;
            CoordYTextBox.Size = new Size(125, 27);
            CoordYTextBox.TabIndex = 8;
            // 
            // CoordXTextBox
            // 
            CoordXTextBox.Enabled = false;
            CoordXTextBox.Location = new Point(182, 209);
            CoordXTextBox.Name = "CoordXTextBox";
            CoordXTextBox.ReadOnly = true;
            CoordXTextBox.Size = new Size(125, 27);
            CoordXTextBox.TabIndex = 7;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(182, 133);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // FindRectanglesButton
            // 
            FindRectanglesButton.Location = new Point(182, 363);
            FindRectanglesButton.Name = "FindRectanglesButton";
            FindRectanglesButton.Size = new Size(125, 27);
            FindRectanglesButton.TabIndex = 4;
            FindRectanglesButton.Text = "Find";
            FindRectanglesButton.UseVisualStyleBackColor = true;
            FindRectanglesButton.Click += FindRectanglesButton_Click;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(182, 80);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 5;
            WidthLabel.Text = "Width:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(182, 156);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 3;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(161, 364);
            RectanglesListBox.TabIndex = 1;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(182, 26);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(57, 20);
            LengthLabel.TabIndex = 4;
            LengthLabel.Text = "Length:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(182, 50);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 1;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(182, 103);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 2;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(RectangleGroupBox);
            RectanglesTabPage.Controls.Add(RectanglePanel);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(768, 498);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectangleGroupBox
            // 
            RectangleGroupBox.Controls.Add(WidthRectangleLabel);
            RectangleGroupBox.Controls.Add(HeightRectanglelabel);
            RectangleGroupBox.Controls.Add(CoordYRectangleLabel);
            RectangleGroupBox.Controls.Add(CoordXRectangleLabel);
            RectangleGroupBox.Controls.Add(IdRectangleLabel);
            RectangleGroupBox.Controls.Add(NamesLabel);
            RectangleGroupBox.Controls.Add(CoordYRectanglesTextBox);
            RectangleGroupBox.Controls.Add(CoordXRectanglesTextBox);
            RectangleGroupBox.Controls.Add(HeightRectanglesTextBox);
            RectangleGroupBox.Controls.Add(WidthRectanglesTextBox);
            RectangleGroupBox.Controls.Add(IdRectanglesTextBox);
            RectangleGroupBox.Controls.Add(RectangleListBox);
            RectangleGroupBox.Controls.Add(AddRectangleButton);
            RectangleGroupBox.Controls.Add(DeleteRectangleButton);
            RectangleGroupBox.Location = new Point(6, 6);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Size = new Size(395, 486);
            RectangleGroupBox.TabIndex = 4;
            RectangleGroupBox.TabStop = false;
            RectangleGroupBox.Text = "Rectangles";
            // 
            // WidthRectangleLabel
            // 
            WidthRectangleLabel.AutoSize = true;
            WidthRectangleLabel.Location = new Point(33, 399);
            WidthRectangleLabel.Name = "WidthRectangleLabel";
            WidthRectangleLabel.Size = new Size(49, 20);
            WidthRectangleLabel.TabIndex = 13;
            WidthRectangleLabel.Text = "Width";
            // 
            // HeightRectanglelabel
            // 
            HeightRectanglelabel.AutoSize = true;
            HeightRectanglelabel.Location = new Point(31, 435);
            HeightRectanglelabel.Name = "HeightRectanglelabel";
            HeightRectanglelabel.Size = new Size(57, 20);
            HeightRectanglelabel.TabIndex = 12;
            HeightRectanglelabel.Text = "Height:";
            // 
            // CoordYRectangleLabel
            // 
            CoordYRectangleLabel.AutoSize = true;
            CoordYRectangleLabel.Location = new Point(61, 369);
            CoordYRectangleLabel.Name = "CoordYRectangleLabel";
            CoordYRectangleLabel.Size = new Size(20, 20);
            CoordYRectangleLabel.TabIndex = 11;
            CoordYRectangleLabel.Text = "Y:";
            // 
            // CoordXRectangleLabel
            // 
            CoordXRectangleLabel.AutoSize = true;
            CoordXRectangleLabel.Location = new Point(61, 336);
            CoordXRectangleLabel.Name = "CoordXRectangleLabel";
            CoordXRectangleLabel.Size = new Size(21, 20);
            CoordXRectangleLabel.TabIndex = 10;
            CoordXRectangleLabel.Text = "X:";
            // 
            // IdRectangleLabel
            // 
            IdRectangleLabel.AutoSize = true;
            IdRectangleLabel.Location = new Point(61, 303);
            IdRectangleLabel.Name = "IdRectangleLabel";
            IdRectangleLabel.Size = new Size(25, 20);
            IdRectangleLabel.TabIndex = 9;
            IdRectangleLabel.Text = "Id:";
            // 
            // NamesLabel
            // 
            NamesLabel.AutoSize = true;
            NamesLabel.Location = new Point(0, 275);
            NamesLabel.Name = "NamesLabel";
            NamesLabel.Size = new Size(139, 20);
            NamesLabel.TabIndex = 8;
            NamesLabel.Text = "Selected Rectangle:";
            // 
            // CoordYRectanglesTextBox
            // 
            CoordYRectanglesTextBox.Location = new Point(89, 366);
            CoordYRectanglesTextBox.Name = "CoordYRectanglesTextBox";
            CoordYRectanglesTextBox.Size = new Size(125, 27);
            CoordYRectanglesTextBox.TabIndex = 7;
            CoordYRectanglesTextBox.TextChanged += CoordYRectanglesTextBox_TextChanged;
            // 
            // CoordXRectanglesTextBox
            // 
            CoordXRectanglesTextBox.Location = new Point(89, 333);
            CoordXRectanglesTextBox.Name = "CoordXRectanglesTextBox";
            CoordXRectanglesTextBox.Size = new Size(125, 27);
            CoordXRectanglesTextBox.TabIndex = 6;
            CoordXRectanglesTextBox.TextChanged += CoordXRectanglesTextBox_TextChanged;
            // 
            // HeightRectanglesTextBox
            // 
            HeightRectanglesTextBox.Location = new Point(89, 432);
            HeightRectanglesTextBox.Name = "HeightRectanglesTextBox";
            HeightRectanglesTextBox.Size = new Size(125, 27);
            HeightRectanglesTextBox.TabIndex = 5;
            HeightRectanglesTextBox.TextChanged += HeightRectanglesTextBox_TextChanged;
            // 
            // WidthRectanglesTextBox
            // 
            WidthRectanglesTextBox.Location = new Point(89, 399);
            WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            WidthRectanglesTextBox.Size = new Size(125, 27);
            WidthRectanglesTextBox.TabIndex = 4;
            WidthRectanglesTextBox.TextChanged += WidthRectanglesTextBox_TextChanged;
            // 
            // IdRectanglesTextBox
            // 
            IdRectanglesTextBox.Enabled = false;
            IdRectanglesTextBox.Location = new Point(89, 300);
            IdRectanglesTextBox.Name = "IdRectanglesTextBox";
            IdRectanglesTextBox.ReadOnly = true;
            IdRectanglesTextBox.Size = new Size(125, 27);
            IdRectanglesTextBox.TabIndex = 3;
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.Location = new Point(6, 26);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(383, 184);
            RectangleListBox.TabIndex = 2;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.Location = new Point(6, 229);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(154, 29);
            AddRectangleButton.TabIndex = 1;
            AddRectangleButton.Text = "Add Rectangle";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.Location = new Point(236, 229);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(153, 29);
            DeleteRectangleButton.TabIndex = 0;
            DeleteRectangleButton.Text = "Delete Rectangle";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // RectanglePanel
            // 
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(407, 19);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(355, 473);
            RectanglePanel.TabIndex = 3;
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
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            ClassesTabPage.ResumeLayout(false);
            MovieGroupBox.ResumeLayout(false);
            MovieGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectanglesTabPage.ResumeLayout(false);
            RectangleGroupBox.ResumeLayout(false);
            RectangleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl RectanglesMainTabControl;
        private TabPage EnumsTabPage;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label EnumsLabel;
        private Label ValueLabel;
        private Label TextBoxLabel;
        private TextBox ValueTextBox;
        private GroupBox EnumGroupBox;
        private GroupBox WeekdayGroupBox;
        private TextBox WeekdayTextBox;
        private Button ParseButton;
        private Label WeekdayTextLabel;
        private GroupBox SeasonGroupBox;
        private Label SeasonLabel;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private TextBox ResultTextBox;
        private TabPage ClassesTabPage;
        private Button FindRectanglesButton;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private GroupBox RectanglesGroupBox;
        private ListBox RectanglesListBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private GroupBox MovieGroupBox;
        private Button FindMoviesButton;
        private TextBox GenreTextBox;
        private TextBox DurationMinutesTextBox;
        private TextBox TitleTextBox;
        private ListBox MoviesListBox;
        private TextBox RatingTextBox;
        private TextBox ReleaseYearTextBox;
        private Label TitleLabel;
        private Label RatingLabel;
        private Label ReleaseYearLabel;
        private Label DurationLabel;
        private Label GenreLabel;
        private TextBox CoordYTextBox;
        private TextBox CoordXTextBox;
        private Label CoordYLabel;
        private Label CoordXLabel;
        private TextBox IdTextBox;
        private Label Idlabel;
        private TabPage RectanglesTabPage;
        private GroupBox RectangleGroupBox;
        private Panel RectanglePanel;
        private ListBox RectangleListBox;
        private Button AddRectangleButton;
        private Button DeleteRectangleButton;
        private TextBox CoordYRectanglesTextBox;
        private TextBox CoordXRectanglesTextBox;
        private TextBox HeightRectanglesTextBox;
        private TextBox WidthRectanglesTextBox;
        private TextBox IdRectanglesTextBox;
        private Label NamesLabel;
        private Label WidthRectangleLabel;
        private Label HeightRectanglelabel;
        private Label CoordYRectangleLabel;
        private Label CoordXRectangleLabel;
        private Label IdRectangleLabel;
    }
}

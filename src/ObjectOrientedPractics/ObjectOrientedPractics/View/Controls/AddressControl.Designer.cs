namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            AddressGroupBox = new GroupBox();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            IndexTextBox = new TextBox();
            CityLabel = new Label();
            StreetLabel = new Label();
            ApartmentLabel = new Label();
            BuildingLabel = new Label();
            CountryLabel = new Label();
            PostIndexLabel = new Label();
            AddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Anchor = AnchorStyles.None;
            AddressGroupBox.Controls.Add(CountryTextBox);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(BuildingTextBox);
            AddressGroupBox.Controls.Add(CityTextBox);
            AddressGroupBox.Controls.Add(ApartmentTextBox);
            AddressGroupBox.Controls.Add(IndexTextBox);
            AddressGroupBox.Controls.Add(CityLabel);
            AddressGroupBox.Controls.Add(StreetLabel);
            AddressGroupBox.Controls.Add(ApartmentLabel);
            AddressGroupBox.Controls.Add(BuildingLabel);
            AddressGroupBox.Controls.Add(CountryLabel);
            AddressGroupBox.Controls.Add(PostIndexLabel);
            AddressGroupBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddressGroupBox.Location = new Point(0, 0);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Size = new Size(608, 211);
            AddressGroupBox.TabIndex = 0;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Delivery Address:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Font = new Font("Segoe UI", 9F);
            CountryTextBox.Location = new Point(91, 71);
            CountryTextBox.MaximumSize = new Size(215, 27);
            CountryTextBox.MinimumSize = new Size(215, 27);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(215, 27);
            CountryTextBox.TabIndex = 11;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Font = new Font("Segoe UI", 9F);
            StreetTextBox.Location = new Point(91, 106);
            StreetTextBox.MinimumSize = new Size(450, 27);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(512, 27);
            StreetTextBox.TabIndex = 10;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Font = new Font("Segoe UI", 9F);
            BuildingTextBox.Location = new Point(91, 145);
            BuildingTextBox.MaximumSize = new Size(92, 27);
            BuildingTextBox.MinimumSize = new Size(92, 27);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(92, 27);
            BuildingTextBox.TabIndex = 9;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Font = new Font("Segoe UI", 9F);
            CityTextBox.Location = new Point(371, 71);
            CityTextBox.MinimumSize = new Size(200, 27);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(232, 27);
            CityTextBox.TabIndex = 8;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTextBox.Font = new Font("Segoe UI", 9F);
            ApartmentTextBox.Location = new Point(298, 145);
            ApartmentTextBox.MinimumSize = new Size(92, 27);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(92, 27);
            ApartmentTextBox.TabIndex = 7;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // IndexTextBox
            // 
            IndexTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTextBox.Font = new Font("Segoe UI", 9F);
            IndexTextBox.Location = new Point(91, 34);
            IndexTextBox.MinimumSize = new Size(125, 27);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(125, 27);
            IndexTextBox.TabIndex = 6;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F);
            CityLabel.Location = new Point(328, 74);
            CityLabel.MinimumSize = new Size(37, 20);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 5;
            CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new Font("Segoe UI", 9F);
            StreetLabel.Location = new Point(6, 109);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Font = new Font("Segoe UI", 9F);
            ApartmentLabel.Location = new Point(209, 148);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 3;
            ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Font = new Font("Segoe UI", 9F);
            BuildingLabel.Location = new Point(6, 148);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(67, 20);
            BuildingLabel.TabIndex = 2;
            BuildingLabel.Text = "Building:";
            // 
            // CountryLabel
            // 
            CountryLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F);
            CountryLabel.Location = new Point(6, 74);
            CountryLabel.MinimumSize = new Size(63, 20);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Font = new Font("Segoe UI", 9F);
            PostIndexLabel.Location = new Point(6, 37);
            PostIndexLabel.MinimumSize = new Size(79, 20);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(79, 20);
            PostIndexLabel.TabIndex = 0;
            PostIndexLabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressGroupBox);
            Name = "AddressControl";
            Size = new Size(609, 211);
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddressGroupBox;
        private Label CityLabel;
        private Label StreetLabel;
        private Label ApartmentLabel;
        private Label BuildingLabel;
        private Label CountryLabel;
        private Label PostIndexLabel;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private TextBox IndexTextBox;
    }
}

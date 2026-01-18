namespace Vet_Clinic
{
    partial class PetDetailForm
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
            petNameLabel = new Label();
            favoriteToyLabel = new Label();
            statusLabel = new Label();
            colorLabel = new Label();
            weightLabel = new Label();
            medicalHistoryLabel = new Label();
            breedLabel = new Label();
            birthdayLabel = new Label();
            typeLabel = new Label();
            adoptButton = new Button();
            birthdayPicker = new DateTimePicker();
            statusTextBox = new TextBox();
            favoriteTextBox = new TextBox();
            colorTextBox = new TextBox();
            weightTextBox = new TextBox();
            medicalHistoryTextBox = new TextBox();
            breedTextBox = new TextBox();
            typeTextBox = new TextBox();
            petImagePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)petImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // petNameLabel
            // 
            petNameLabel.Anchor = AnchorStyles.Top;
            petNameLabel.AutoSize = true;
            petNameLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            petNameLabel.ForeColor = Color.White;
            petNameLabel.Location = new Point(390, 48);
            petNameLabel.Name = "petNameLabel";
            petNameLabel.Size = new Size(255, 65);
            petNameLabel.TabIndex = 1;
            petNameLabel.Text = "Pet's name";
            // 
            // favoriteToyLabel
            // 
            favoriteToyLabel.AutoSize = true;
            favoriteToyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            favoriteToyLabel.ForeColor = Color.White;
            favoriteToyLabel.Location = new Point(521, 291);
            favoriteToyLabel.Name = "favoriteToyLabel";
            favoriteToyLabel.Size = new Size(92, 21);
            favoriteToyLabel.TabIndex = 2;
            favoriteToyLabel.Text = "Favorite Toy";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(561, 350);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 21);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Status";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorLabel.ForeColor = Color.White;
            colorLabel.Location = new Point(565, 235);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 21);
            colorLabel.TabIndex = 4;
            colorLabel.Text = "Color";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel.ForeColor = Color.White;
            weightLabel.Location = new Point(554, 179);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(59, 21);
            weightLabel.TabIndex = 5;
            weightLabel.Text = "Weight";
            // 
            // medicalHistoryLabel
            // 
            medicalHistoryLabel.AutoSize = true;
            medicalHistoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            medicalHistoryLabel.ForeColor = Color.White;
            medicalHistoryLabel.Location = new Point(19, 350);
            medicalHistoryLabel.Name = "medicalHistoryLabel";
            medicalHistoryLabel.Size = new Size(118, 21);
            medicalHistoryLabel.TabIndex = 6;
            medicalHistoryLabel.Text = "Medical History";
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            breedLabel.ForeColor = Color.White;
            breedLabel.Location = new Point(87, 291);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new Size(50, 21);
            breedLabel.TabIndex = 7;
            breedLabel.Text = "Breed";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdayLabel.ForeColor = Color.White;
            birthdayLabel.Location = new Point(69, 235);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(68, 21);
            birthdayLabel.TabIndex = 8;
            birthdayLabel.Text = "Birthday";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel.ForeColor = Color.White;
            typeLabel.Location = new Point(95, 179);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(42, 21);
            typeLabel.TabIndex = 9;
            typeLabel.Text = "Type";
            // 
            // adoptButton
            // 
            adoptButton.BackColor = Color.FromArgb(20, 54, 66);
            adoptButton.ForeColor = Color.White;
            adoptButton.Location = new Point(722, 414);
            adoptButton.Name = "adoptButton";
            adoptButton.Size = new Size(99, 48);
            adoptButton.TabIndex = 18;
            adoptButton.Text = "Adopt";
            adoptButton.UseVisualStyleBackColor = false;
            adoptButton.Click += AdoptPetButton_Click;
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(143, 235);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(310, 23);
            birthdayPicker.TabIndex = 11;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(619, 350);
            statusTextBox.MinimumSize = new Size(310, 27);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(310, 27);
            statusTextBox.TabIndex = 17;
            // 
            // favoriteTextBox
            // 
            favoriteTextBox.Location = new Point(619, 291);
            favoriteTextBox.MinimumSize = new Size(310, 27);
            favoriteTextBox.Name = "favoriteTextBox";
            favoriteTextBox.Size = new Size(310, 27);
            favoriteTextBox.TabIndex = 16;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(619, 235);
            colorTextBox.MinimumSize = new Size(310, 27);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(310, 27);
            colorTextBox.TabIndex = 15;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(619, 179);
            weightTextBox.MinimumSize = new Size(310, 27);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(310, 27);
            weightTextBox.TabIndex = 14;
            // 
            // medicalHistoryTextBox
            // 
            medicalHistoryTextBox.Location = new Point(143, 350);
            medicalHistoryTextBox.MinimumSize = new Size(310, 60);
            medicalHistoryTextBox.Name = "medicalHistoryTextBox";
            medicalHistoryTextBox.Size = new Size(310, 60);
            medicalHistoryTextBox.TabIndex = 13;
            // 
            // breedTextBox
            // 
            breedTextBox.Location = new Point(143, 291);
            breedTextBox.MinimumSize = new Size(310, 27);
            breedTextBox.Name = "breedTextBox";
            breedTextBox.Size = new Size(310, 27);
            breedTextBox.TabIndex = 12;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(143, 179);
            typeTextBox.MinimumSize = new Size(310, 27);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(310, 27);
            typeTextBox.TabIndex = 10;
            // 
            // petImagePictureBox
            // 
            petImagePictureBox.Location = new Point(143, 34);
            petImagePictureBox.Name = "petImagePictureBox";
            petImagePictureBox.Size = new Size(190, 106);
            petImagePictureBox.TabIndex = 19;
            petImagePictureBox.TabStop = false;
            // 
            // PetDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(984, 541);
            Controls.Add(petImagePictureBox);
            Controls.Add(adoptButton);
            Controls.Add(birthdayPicker);
            Controls.Add(statusTextBox);
            Controls.Add(favoriteTextBox);
            Controls.Add(colorTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(medicalHistoryTextBox);
            Controls.Add(breedTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(favoriteToyLabel);
            Controls.Add(statusLabel);
            Controls.Add(colorLabel);
            Controls.Add(weightLabel);
            Controls.Add(medicalHistoryLabel);
            Controls.Add(breedLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(typeLabel);
            Controls.Add(petNameLabel);
            Name = "PetDetailForm";
            Text = "PetDetailForm";
            Load += FillPetInfo;
            ((System.ComponentModel.ISupportInitialize)petImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label petNameLabel;
        private Label favoriteToyLabel;
        private Label statusLabel;
        private Label colorLabel;
        private Label weightLabel;
        private Label medicalHistoryLabel;
        private Label breedLabel;
        private Label birthdayLabel;
        private Label typeLabel;
        private Button adoptButton;
        private DateTimePicker birthdayPicker;
        private TextBox statusTextBox;
        private TextBox favoriteTextBox;
        private TextBox colorTextBox;
        private TextBox weightTextBox;
        private TextBox medicalHistoryTextBox;
        private TextBox breedTextBox;
        private TextBox typeTextBox;
        private PictureBox petImagePictureBox;
    }
}
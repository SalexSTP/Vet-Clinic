using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class NewPetForm
    {
        private void InitializeComponent()
        {
            labelTitle = new Label();
            catRadioButton = new RadioButton();
            dogRadioButton = new RadioButton();
            nameLabel = new Label();
            birthdayLabel = new Label();
            breedLabel = new Label();
            medicalHistoryLabel = new Label();
            nameTextBox = new TextBox();
            breedTextBox = new TextBox();
            medicalHistoryTextBox = new TextBox();
            weightLabel = new Label();
            colorLabel = new Label();
            imageLabel = new Label();
            favoriteToyLabel = new Label();
            weightTextBox = new TextBox();
            colorTextBox = new TextBox();
            imageTextBox = new TextBox();
            favoriteToyTextBox = new TextBox();
            birthdayPicker = new DateTimePicker();
            addButton = new Button();
            nameInfoLabel = new Label();
            breedInfoLabel = new Label();
            medicalHistoryInfoLabel = new Label();
            weightInfoLabel = new Label();
            colorInfoLabel = new Label();
            imageInfoLabel = new Label();
            favoriteToyInfoLabel = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(390, 48);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(203, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "New Pet";
            // 
            // catRadioButton
            // 
            catRadioButton.AutoSize = true;
            catRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            catRadioButton.ForeColor = Color.White;
            catRadioButton.Location = new Point(220, 134);
            catRadioButton.Name = "catRadioButton";
            catRadioButton.Size = new Size(51, 25);
            catRadioButton.TabIndex = 0;
            catRadioButton.TabStop = true;
            catRadioButton.Text = "Cat";
            catRadioButton.UseVisualStyleBackColor = true;
            // 
            // dogRadioButton
            // 
            dogRadioButton.AutoSize = true;
            dogRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dogRadioButton.ForeColor = Color.White;
            dogRadioButton.Location = new Point(347, 134);
            dogRadioButton.Name = "dogRadioButton";
            dogRadioButton.Size = new Size(57, 25);
            dogRadioButton.TabIndex = 0;
            dogRadioButton.TabStop = true;
            dogRadioButton.Text = "Dog";
            dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(117, 183);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 21);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdayLabel.ForeColor = Color.White;
            birthdayLabel.Location = new Point(96, 239);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(73, 21);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthdate";
            // 
            // breedLabel
            // 
            breedLabel.AutoSize = true;
            breedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            breedLabel.ForeColor = Color.White;
            breedLabel.Location = new Point(119, 295);
            breedLabel.Name = "breedLabel";
            breedLabel.Size = new Size(50, 21);
            breedLabel.TabIndex = 0;
            breedLabel.Text = "Breed";
            // 
            // medicalHistoryLabel
            // 
            medicalHistoryLabel.AutoSize = true;
            medicalHistoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            medicalHistoryLabel.ForeColor = Color.White;
            medicalHistoryLabel.Location = new Point(51, 354);
            medicalHistoryLabel.Name = "medicalHistoryLabel";
            medicalHistoryLabel.Size = new Size(118, 21);
            medicalHistoryLabel.TabIndex = 0;
            medicalHistoryLabel.Text = "Medical History";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(175, 183);
            nameTextBox.MinimumSize = new Size(310, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(310, 27);
            nameTextBox.TabIndex = 1;
            // 
            // breedTextBox
            // 
            breedTextBox.Location = new Point(175, 295);
            breedTextBox.MinimumSize = new Size(310, 27);
            breedTextBox.Name = "breedTextBox";
            breedTextBox.Size = new Size(310, 27);
            breedTextBox.TabIndex = 3;
            // 
            // medicalHistoryTextBox
            // 
            medicalHistoryTextBox.Location = new Point(175, 354);
            medicalHistoryTextBox.MinimumSize = new Size(310, 60);
            medicalHistoryTextBox.Name = "medicalHistoryTextBox";
            medicalHistoryTextBox.Size = new Size(310, 60);
            medicalHistoryTextBox.TabIndex = 4;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel.ForeColor = Color.White;
            weightLabel.Location = new Point(586, 183);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(59, 21);
            weightLabel.TabIndex = 0;
            weightLabel.Text = "Weight";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorLabel.ForeColor = Color.White;
            colorLabel.Location = new Point(597, 239);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(48, 21);
            colorLabel.TabIndex = 0;
            colorLabel.Text = "Color";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            imageLabel.ForeColor = Color.White;
            imageLabel.Location = new Point(592, 295);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(53, 21);
            imageLabel.TabIndex = 0;
            imageLabel.Text = "Image";
            // 
            // favoriteToyLabel
            // 
            favoriteToyLabel.AutoSize = true;
            favoriteToyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            favoriteToyLabel.ForeColor = Color.White;
            favoriteToyLabel.Location = new Point(553, 354);
            favoriteToyLabel.Name = "favoriteToyLabel";
            favoriteToyLabel.Size = new Size(92, 21);
            favoriteToyLabel.TabIndex = 0;
            favoriteToyLabel.Text = "Favorite Toy";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(651, 183);
            weightTextBox.MinimumSize = new Size(310, 27);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(310, 27);
            weightTextBox.TabIndex = 5;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(651, 239);
            colorTextBox.MinimumSize = new Size(310, 27);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(310, 27);
            colorTextBox.TabIndex = 6;
            // 
            // imageTextBox
            // 
            imageTextBox.Location = new Point(651, 295);
            imageTextBox.MinimumSize = new Size(310, 27);
            imageTextBox.Name = "imageTextBox";
            imageTextBox.Size = new Size(310, 27);
            imageTextBox.TabIndex = 7;
            // 
            // favoriteToyTextBox
            // 
            favoriteToyTextBox.Location = new Point(651, 354);
            favoriteToyTextBox.MinimumSize = new Size(310, 27);
            favoriteToyTextBox.Name = "favoriteToyTextBox";
            favoriteToyTextBox.Size = new Size(310, 27);
            favoriteToyTextBox.TabIndex = 8;
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(175, 239);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(310, 23);
            birthdayPicker.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(20, 54, 66);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(754, 418);
            addButton.Name = "addButton";
            addButton.Size = new Size(99, 48);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // nameInfoLabel
            // 
            nameInfoLabel.AutoSize = true;
            nameInfoLabel.ForeColor = Color.Red;
            nameInfoLabel.Location = new Point(175, 213);
            nameInfoLabel.Name = "nameInfoLabel";
            nameInfoLabel.Size = new Size(0, 15);
            nameInfoLabel.TabIndex = 10;
            // 
            // breedInfoLabel
            // 
            breedInfoLabel.AutoSize = true;
            breedInfoLabel.ForeColor = Color.Red;
            breedInfoLabel.Location = new Point(175, 325);
            breedInfoLabel.Name = "breedInfoLabel";
            breedInfoLabel.Size = new Size(0, 15);
            breedInfoLabel.TabIndex = 11;
            // 
            // medicalHistoryInfoLabel
            // 
            medicalHistoryInfoLabel.AutoSize = true;
            medicalHistoryInfoLabel.ForeColor = Color.Red;
            medicalHistoryInfoLabel.Location = new Point(175, 418);
            medicalHistoryInfoLabel.Name = "medicalHistoryInfoLabel";
            medicalHistoryInfoLabel.Size = new Size(0, 15);
            medicalHistoryInfoLabel.TabIndex = 12;
            // 
            // weightInfoLabel
            // 
            weightInfoLabel.AutoSize = true;
            weightInfoLabel.ForeColor = Color.Red;
            weightInfoLabel.Location = new Point(651, 213);
            weightInfoLabel.Name = "weightInfoLabel";
            weightInfoLabel.Size = new Size(0, 15);
            weightInfoLabel.TabIndex = 13;
            // 
            // colorInfoLabel
            // 
            colorInfoLabel.AutoSize = true;
            colorInfoLabel.ForeColor = Color.Red;
            colorInfoLabel.Location = new Point(651, 269);
            colorInfoLabel.Name = "colorInfoLabel";
            colorInfoLabel.Size = new Size(0, 15);
            colorInfoLabel.TabIndex = 14;
            // 
            // imageInfoLabel
            // 
            imageInfoLabel.AutoSize = true;
            imageInfoLabel.ForeColor = Color.Red;
            imageInfoLabel.Location = new Point(651, 325);
            imageInfoLabel.Name = "imageInfoLabel";
            imageInfoLabel.Size = new Size(0, 15);
            imageInfoLabel.TabIndex = 15;
            // 
            // favoriteToyInfoLabel
            // 
            favoriteToyInfoLabel.AutoSize = true;
            favoriteToyInfoLabel.ForeColor = Color.Red;
            favoriteToyInfoLabel.Location = new Point(651, 384);
            favoriteToyInfoLabel.Name = "favoriteToyInfoLabel";
            favoriteToyInfoLabel.Size = new Size(0, 15);
            favoriteToyInfoLabel.TabIndex = 16;
            // 
            // NewPetForm
            // 
            BackColor = Color.PaleGreen;
            ClientSize = new Size(984, 541);
            Controls.Add(favoriteToyInfoLabel);
            Controls.Add(imageInfoLabel);
            Controls.Add(colorInfoLabel);
            Controls.Add(weightInfoLabel);
            Controls.Add(medicalHistoryInfoLabel);
            Controls.Add(breedInfoLabel);
            Controls.Add(nameInfoLabel);
            Controls.Add(addButton);
            Controls.Add(birthdayPicker);
            Controls.Add(favoriteToyTextBox);
            Controls.Add(imageTextBox);
            Controls.Add(colorTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(favoriteToyLabel);
            Controls.Add(imageLabel);
            Controls.Add(colorLabel);
            Controls.Add(weightLabel);
            Controls.Add(medicalHistoryTextBox);
            Controls.Add(breedTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(medicalHistoryLabel);
            Controls.Add(breedLabel);
            Controls.Add(birthdayLabel);
            Controls.Add(nameLabel);
            Controls.Add(dogRadioButton);
            Controls.Add(catRadioButton);
            Controls.Add(labelTitle);
            Name = "NewPetForm";
            Text = "New Pet";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label labelTitle;
        private RadioButton catRadioButton;
        private RadioButton dogRadioButton;
        private Label nameLabel;
        private Label birthdayLabel;
        private Label breedLabel;
        private Label medicalHistoryLabel;
        private TextBox nameTextBox;
        private TextBox breedTextBox;
        private TextBox medicalHistoryTextBox;
        private Label weightLabel;
        private Label colorLabel;
        private Label imageLabel;
        private Label favoriteToyLabel;
        private TextBox weightTextBox;
        private TextBox colorTextBox;
        private TextBox imageTextBox;
        private TextBox favoriteToyTextBox;
        private DateTimePicker birthdayPicker;
        private Button addButton;
        private Label nameInfoLabel;
        private Label breedInfoLabel;
        private Label medicalHistoryInfoLabel;
        private Label weightInfoLabel;
        private Label colorInfoLabel;
        private Label imageInfoLabel;
        private Label favoriteToyInfoLabel;
    }
}

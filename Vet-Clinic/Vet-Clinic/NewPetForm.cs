using Vet_Clinic.Data;
using Vet_Clinic.Data.AnimalModels;

namespace Vet_Clinic
{
    public partial class NewPetForm : Form
    {
        private string petImage;

        public NewPetForm()
        {
            InitializeComponent();

            this.breedInfoLabel.Visible = false;
            this.nameInfoLabel.Visible = false;
            this.medicalHistoryInfoLabel.Visible = false;
            this.colorInfoLabel.Visible = false;
            this.weightInfoLabel.Visible = false;
            this.imageInfoLabel.Visible = false;
            this.favoriteToyInfoLabel.Visible = false;
        }

        public IAnimal Animal { get; set; }

        private void RadioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            this.favoriteToyLabel.Visible = false;
            this.favoriteToyTextBox.Visible = false;
            this.favoriteToyInfoLabel.Visible = false;
        }

        private void CatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.favoriteToyLabel.Visible = true;
            this.favoriteToyTextBox.Visible = true;
        }

        private void AddNewPetButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }

            IAnimal newAnimal = CreateNewAnimal();

            if (newAnimal != null)
            {
                this.Animal = newAnimal;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private IAnimal CreateNewAnimal()
        {
            string name = this.nameTextBox.Text.Trim();
            string breed = this.breedTextBox.Text.Trim();
            string medicalHistory = this.medicalHistoryTextBox.Text.Trim();
            string color = this.colorTextBox.Text.Trim();
            DateTime birthday = DateTime.Parse(this.birthdayPicker.Text.Trim());
            double weight = double.Parse(this.weightTextBox.Text.Trim());

            IAnimal animal;
            if (this.catRadioButton.Checked)
            {
                animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                animal = new Dog(name, birthday, breed, medicalHistory, weight, color);
            }

            animal.Image = petImage;
            return animal;
        }

        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favoriteToy = this.favoriteToyTextBox.Text.Trim();
            if (!CheckIfValid(this.favoriteToyTextBox, 3, this.favoriteToyInfoLabel))
            {
                return null;
            }

            return new Cat(name, birthday, breed, medicalHistory, weight, color, favoriteToy);
        }

        private bool CheckIfInputsAreValid() =>
            CheckIfValid(this.nameTextBox, 3, this.nameInfoLabel) &&
            CheckIfValid(this.breedTextBox, 5, this.breedInfoLabel) &&
            CheckIfValid(this.medicalHistoryTextBox, 10, this.medicalHistoryInfoLabel) && CheckIfValid(this.colorTextBox, 3, this.colorInfoLabel) &&
            CheckIfValidDouble(this.weightTextBox, this.weightInfoLabel, 0.5) &&
            CheckIfNotEmpty(this.petImage, this.imageInfoLabel);

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Trim().Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label errorLabel, bool isValid)
        {
            errorLabel.Visible = !isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double parsedValue) && parsedValue > min;

            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value?.Trim());
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private void TextBoxPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; .bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                this.imageTextBox.Text = Path.GetFileName(petImage);
            }
        }
    }
}

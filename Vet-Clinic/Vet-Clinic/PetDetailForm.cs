using Vet_Clinic.Data;
using Vet_Clinic.Data.AnimalModels;

namespace Vet_Clinic
{
    public partial class PetDetailForm : Form
    {
        private readonly IAnimal pet;

        public PetDetailForm(IAnimal pet)
        {
            InitializeComponent();

            this.pet = pet;
        }

        private void FillPetInfo(object sender, EventArgs e)
        {
            this.petNameLabel.Text = pet.Name;
            this.typeTextBox.Text = pet.GetType().Name;
            this.birthdayPicker.Text = pet.Birthday.ToString();
            this.breedTextBox.Text = pet.Breed;
            this.colorTextBox.Text = pet.Color;
            this.weightTextBox.Text = pet.Weight.ToString();
            this.medicalHistoryTextBox.Text = pet.MedicalHistory;
            this.statusTextBox.Text = pet.Status.ToString();

            LoadPetImage();

            if (pet is Cat cat)
            {
                this.favoriteTextBox.Text = cat.FavoriteToy;
            }
            else
            {
                this.favoriteTextBox.Visible = false;
                this.favoriteToyLabel.Visible = false;
            }

            this.adoptButton.Enabled = this.pet.Status != Status.Adopted;
        }

        private void LoadPetImage()
        {
            if (string.IsNullOrEmpty(pet.Image) || !File.Exists(pet.Image))
                return;

            using var fs = new FileStream(pet.Image, FileMode.Open, FileAccess.Read);
            using var img = Image.FromStream(fs);

            petImagePictureBox.Image = new Bitmap(img);
            petImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void AdoptPetButton_Click(object sender, EventArgs e)
        {
            this.pet.Status = Status.Adopted;
            this.statusTextBox.Text = this.pet.Status.ToString();
            this.adoptButton.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (petImagePictureBox.Image != null)
            {
                petImagePictureBox.Image.Dispose();
                petImagePictureBox.Image = null;
            }

            base.OnFormClosing(e);
        }
    }
}

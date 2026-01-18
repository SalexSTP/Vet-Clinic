using Vet_Clinic.Data;
using Vet_Clinic.Data.AnimalModels;

namespace Vet_Clinic
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private readonly List<IAnimal> pets = new()
        {
            new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
            new Dog("Buddy", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 25.5, "Golden"),
        };

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            this.imageListViewPets.Clear();

            for (int i = 0; i < this.pets.Count; i++)
            {
                if (this.pets[i].Status == Status.Adopted)
                {
                    this.pets.RemoveAt(i);
                    i--;
                }
            }

            foreach (var pet in pets)
            {
                this.imageListViewPets.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }

        private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[this.imageListViewPets.SelectedItems[0].Index];

            if (selectedPet != null)
            {
                using PetDetailForm petDetailForm = new(selectedPet);
                petDetailForm.ShowDialog();
            }

            LoadAllPets();
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            using (NewPetForm newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }

            LoadAllPets();
        }
    }
}

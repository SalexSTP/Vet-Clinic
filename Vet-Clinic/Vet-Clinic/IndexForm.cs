using Vet_Clinic.Data;
using Vet_Clinic.Data.AnimalModels;

namespace Vet_Clinic
{
    public partial class AnimalsForm : Form
    {
        public AnimalsForm()
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

            foreach (var pet in pets)
            {
                this.imageListViewPets.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }
    }
}

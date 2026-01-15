namespace Vet_Clinic.Data.AnimalModels
{
    public class Cat : IAnimal
    {
        public Cat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string favoriteToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            FavoriteToy = favoriteToy;
            Status = Status.NotAdopted;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string MedicalHistory { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string FavoriteToy { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
    }
}

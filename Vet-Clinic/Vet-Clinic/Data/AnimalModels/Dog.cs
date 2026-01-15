namespace Vet_Clinic.Data.AnimalModels
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string MedicalHistory { get; set; }
        public double Weight { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public Status Status { get; set; }

        public Dog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            Status = Status.NotAdopted;
        }
    }
}

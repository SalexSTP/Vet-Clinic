namespace Vet_Clinic.Data
{
    public interface IAnimal
    {
        public string Name { get; set; }    
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
    }
}

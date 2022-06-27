namespace GarageVoxTeneo.Models
{
    public class Cars
    {
        public int IdCars { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public int Power { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Price { get; set; }
        public int Id_Garage { get; set; }
    }
}

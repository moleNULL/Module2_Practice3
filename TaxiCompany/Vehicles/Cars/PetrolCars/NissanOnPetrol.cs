namespace TaxiCompany.Vehicles.Cars.PetrolCars
{
    internal class NissanOnPetrol : PetrolCar
    {
        public NissanOnPetrol(string model, PetrolType petrolType, double petrolConsumption, decimal carPrice, int year)
            : base(brand: "Nissan", model, country: "Japan", petrolType, petrolConsumption, carPrice, year)
        {
        }
    }
}

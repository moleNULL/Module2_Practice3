namespace TaxiCompany.Vehicles.Cars.PetrolCars
{
    internal class FiatOnPetrol : PetrolCar
    {
        public FiatOnPetrol(string model, PetrolType petrolType, double petrolConsumption, decimal carPrice, int year)
            : base(brand: "Fiat", model, country: "Italy", petrolType, petrolConsumption, carPrice, year)
        {
        }
    }
}

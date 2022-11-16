namespace TaxiCompany.Vehicles.Cars.DieselCars
{
    internal class RenaultOnDiesel : DieselCar
    {
        public RenaultOnDiesel(string model, double dieselConsumption, decimal carPrice, int year)
            : base(brand: "Renault", model, country: "France", dieselConsumption, carPrice, year)
        {
        }
    }
}

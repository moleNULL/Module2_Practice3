namespace TaxiCompany.Vehicles.Cars.DieselCars
{
    internal class BmwOnDiesel : DieselCar
    {
        public BmwOnDiesel(string model, double dieselConsumption, decimal carPrice, int year)
            : base(brand: "BMW", model, country: "Germany", dieselConsumption, carPrice, year)
        {
        }
    }
}

namespace TaxiCompany.Vehicles.Cars.DieselCars
{
    internal class NissanOnDiesel : DieselCar
    {
        public NissanOnDiesel(string model, double dieselConsumption, decimal carPrice, int year)
            : base(brand: "Nissan", model, country: "Japan", dieselConsumption, carPrice, year)
        {
        }
    }
}

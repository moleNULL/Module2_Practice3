namespace TaxiCompany.Vehicles.Cars.DieselCars
{
    internal class SuzukiOnDiesel : DieselCar
    {
        public SuzukiOnDiesel(string model, double dieselConsumption, decimal carPrice, int year)
            : base(brand: "Suzuki", model, country: "Japan", dieselConsumption, carPrice, year)
        {
        }
    }
}

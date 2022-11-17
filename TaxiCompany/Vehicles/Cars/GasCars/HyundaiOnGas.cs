namespace TaxiCompany.Vehicles.Cars.GasCars
{
    internal class HyundaiOnGas : GasCar
    {
        public HyundaiOnGas(string model, GasType gasType, double gasConsumption, decimal carPrice, int year)
            : base(brand: "Hyundai", model, country: "South Korea", gasType, gasConsumption, carPrice, year)
        {
        }
    }
}

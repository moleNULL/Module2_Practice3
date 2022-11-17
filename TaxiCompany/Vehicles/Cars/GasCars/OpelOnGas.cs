namespace TaxiCompany.Vehicles.Cars.GasCars
{
    internal class OpelOnGas : GasCar
    {
        public OpelOnGas(string model, GasType gasType, double gasConsumption, decimal carPrice, int year)
            : base(brand: "Opel", model, country: "Germany", gasType, gasConsumption, carPrice, year)
        {
        }
    }
}

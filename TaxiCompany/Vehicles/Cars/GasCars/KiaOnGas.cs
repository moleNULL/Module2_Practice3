using TaxiCompany.Enums;

namespace TaxiCompany.Vehicles.Cars.GasCars
{
    internal class KiaOnGas : GasCar
    {
        public KiaOnGas(string model, GasType gasType, double gasConsumption, decimal carPrice, int year)
            : base(brand: "Kia", model, country: "South Korea", gasType, gasConsumption, carPrice, year)
        {
        }
    }
}

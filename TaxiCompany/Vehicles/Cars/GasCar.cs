namespace TaxiCompany.Vehicles.Cars
{
    internal class GasCar : Car
    {
        private GasType _gasType;
        private decimal _gasPrice;
        public GasCar(string brand, string model, string country, GasType gasType, double gasConsumption, decimal carPrice, int year)
        {
            Brand = brand;
            Model = model;
            Country = country;
            _gasType = gasType;
            FuelConsumption = gasConsumption;
            Price = carPrice;
            Year = year;

            FuelType = FuelType.Gas;
            _gasPrice = GetGasPrice();
        }

        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override string Country { get; set; }
        public override decimal FuelPrice
        {
            get => _gasPrice;
            set => _gasPrice = value;
        }

        // 1 m^3 roughly equals to 1 liter
        public override double FuelConsumption { get; set; }
        public override decimal Price { get; set; }
        public override int Year { get; set; }

        public override FuelType FuelType { get; init; }

        public override string GetDescription()
        {
            return $"Brand: {Brand} | Model: {Model} | Country: {Country} | FuelType: {FuelType} " +
                $"({_gasType} = {FuelPrice} UAH) | FuelConsumption: {FuelConsumption} litres (m^3) per 100 km | " +
                $"Price: ${Price} | Year: {Year}";
        }

        // Set default price on gas fuel depending on its type
        private decimal GetGasPrice()
        {
            switch (_gasType)
            {
                case GasType.Methane:
                    return 37.88m;
                case GasType.Propane:
                    return 28.69m;
                case GasType.Butane:
                    return 31.05m;
                default:
                    throw new NotImplementedException("Missing price for the current gas type");
            }
        }
    }
}

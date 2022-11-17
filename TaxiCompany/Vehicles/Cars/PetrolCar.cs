namespace TaxiCompany.Vehicles.Cars
{
    internal class PetrolCar : Car
    {
        private PetrolType _petrolType;
        private decimal _petrolPrice;
        public PetrolCar(string brand, string model, string country, PetrolType petrolType, double petrolConsumption, decimal carPrice, int year)
        {
            Brand = brand;
            Model = model;
            Country = country;
            _petrolType = petrolType;
            FuelConsumption = petrolConsumption;
            Price = carPrice;
            Year = year;

            FuelType = FuelType.Petrol;
            _petrolPrice = GetPetrolPrice();
        }

        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override string Country { get; set; }
        public override decimal FuelPrice
        {
            get => _petrolPrice;
            set => _petrolPrice = value;
        }

        public override double FuelConsumption { get; set; }
        public override decimal Price { get; set; }
        public override int Year { get; set; }

        public override FuelType FuelType { get; init; }

        public override string GetDescription()
        {
            return $"Brand: {Brand} | Model: {Model} | Country: {Country} | FuelType: {FuelType} " +
                $"({_petrolType} = {FuelPrice} UAH) | FuelConsumption: {FuelConsumption} litres per 100 km | " +
                $"Price: ${Price} | Year: {Year}";
        }

        // Get default price on petrol fuel depending on its type
        private decimal GetPetrolPrice()
        {
            switch (_petrolType)
            {
                case PetrolType.AI92:
                    return 47.46m;
                case PetrolType.AI95:
                    return 48.79m;
                case PetrolType.AI98:
                    return 51.00m;
                default:
                    throw new NotImplementedException("Missing price for the current petrol type");
            }
        }
    }
}

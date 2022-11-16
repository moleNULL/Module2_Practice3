using TaxiCompany.Enums;

namespace TaxiCompany.Vehicles.Cars
{
    internal class DieselCar : Car
    {
        // defined dynamically
        private DieselType _dieselType;
        public DieselCar(string brand, string model, string country, double dieselConsumption, decimal carPrice, int year)
        {
            Brand = brand;
            Model = model;
            Country = country;
            FuelConsumption = dieselConsumption;
            Price = carPrice;
            Year = year;

            FuelPrice = 54.3m;
            FuelType = FuelType.Diesel;
            _dieselType = GetDieselType();
        }

        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override string Country { get; set; }
        public override decimal FuelPrice { get; set; }
        public override double FuelConsumption { get; set; }
        public override decimal Price { get; set; }
        public override int Year { get; set; }

        public override FuelType FuelType { get; init; }

        public override string GetDescription()
        {
            return $"Brand: {Brand} | Model: {Model} | Country: {Country} | FuelType: {FuelType} " +
                $"({_dieselType} = {FuelPrice} UAH) | FuelConsumption: {FuelConsumption} litres per 100 km | " +
                $"Price: {Price} | Year: {Year}";
        }

        // get current type of diesel fuel depending on the season
        private DieselType GetDieselType()
        {
            // numbers represents months
            switch (DateTime.Now.Month)
            {
                case 11:
                case 12:
                case 1:
                case 2:
                    return DieselType.WinterDiesel;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    return DieselType.SummerDiesel;
                default:
                    throw new NotImplementedException("Incorrect month");
            }
        }
    }
}

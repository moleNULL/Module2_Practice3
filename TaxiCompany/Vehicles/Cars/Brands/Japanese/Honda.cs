using TaxiCompany.Enums;

namespace TaxiCompany.Vehicles.Cars.Brands.Japanese
{
    internal class Honda : Car
    {
        private const string CARBRAND = "Honda";

        // any type of car: on petrol, diesel or gas
        private Car _car;
        public Honda(Car car)
        {
            if (car.Brand != CARBRAND)
            {
                throw new Exception($"Invalid brand name for {CARBRAND} - {car.Brand}");
            }

            _car = car;
        }

        public override string Model
        {
            get => _car.Model;
            set => _car.Model = value;
        }

        public override decimal FuelPrice
        {
            get => _car.FuelPrice;
            set => _car.FuelPrice = value;
        }

        public override double FuelConsumption
        {
            get => _car.FuelConsumption;
            set => _car.FuelConsumption = value;
        }

        public override string Brand
        {
            get => _car.Brand;
            set => _car.Brand = value;
        }

        public override string Country
        {
            get => _car.Country;
            set => _car.Country = value;
        }

        public override decimal Price
        {
            get => _car.Price;
            set => _car.Price = value;
        }

        public override int Year
        {
            get => _car.Year;
            set => _car.Year = value;
        }

        public override FuelType FuelType
        {
            get => _car.FuelType;
            init
            {
            }
        }

        public override string GetDescription()
        {
            return _car.GetDescription();
        }
    }
}

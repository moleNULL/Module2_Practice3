global using TaxiCompany.Printers;
global using TaxiCompany.Vehicles.Cars;
global using TaxiCompany.Vehicles.Cars.Brands.French;
global using TaxiCompany.Vehicles.Cars.Brands.German;
global using TaxiCompany.Vehicles.Cars.Brands.Italian;
global using TaxiCompany.Vehicles.Cars.Brands.Japanese;
global using TaxiCompany.Vehicles.Cars.Brands.Korean;
global using TaxiCompany.Vehicles.Cars.DieselCars;
global using TaxiCompany.Vehicles.Cars.GasCars;
global using TaxiCompany.Vehicles.Cars.PetrolCars;
global using TaxiCompany.Enums;
global using TaxiCompany.Sorters;

namespace TaxiCompany
{
    internal class TaxiStation
    {
        private IPrinter _printer;
        private Car[] _cars;

        public TaxiStation()
        {
            _printer = new ConsolePrinter(); // default printer
            _cars = Array.Empty<Car>();
        }

        // Allows user to change output method any time
        public IPrinter Printer
        {
            get => _printer;
            set
            {
                if (value is null)
                {
                    Console.WriteLine("Error! IPrinter cannot be null. No changes applied");
                }
                else
                {
                    _printer = value;
                }
            }
        }

        // Allows user to get Car[] but not modify it directly
        public Car[] Cars => _cars;

        // Fill taxi station with initial cars
        public void FillStationWithInitialCars()
        {
            // Cars on petrol
            var hondaOnPetrol = new HondaOnPetrol(model: "Civic 1.5", PetrolType.AI92, petrolConsumption: 8.7, carPrice: 11500, year: 2017);
            var honda = new Honda(hondaOnPetrol);
            var fiat = new Fiat(new FiatOnPetrol(model: "Tipo 1.4 МТ", PetrolType.AI95, petrolConsumption: 5.7, carPrice: 17000, year: 2022));
            var nissan1 = new Nissan(new NissanOnPetrol(model: "Juke 1.0 DIG-T", PetrolType.AI98, petrolConsumption: 4.8, carPrice: 24200, year: 2022));

            // Cars on diesel
            var bmw = new BMW(new BmwOnDiesel(model: "X5", dieselConsumption: 13, carPrice: 35500, year: 2016));
            var renault = new Renault(new RenaultOnDiesel(model: "Megane", dieselConsumption: 6.9, carPrice: 7300, year: 2014));
            var suzuki = new Suzuki(new SuzukiOnDiesel(model: "Swift", dieselConsumption: 4.5, carPrice: 6150, year: 2011));
            var nissan2 = new Nissan(new NissanOnDiesel(model: "Primera", dieselConsumption: 7, carPrice: 3650, year: 2005));

            // Cars on gas
            var opel = new Opel(new OpelOnGas(model: "Zafira", GasType.Propane, gasConsumption: 11, carPrice: 6800, year: 2007));
            var kia = new Kia(new KiaOnGas(model: "K5", GasType.Butane, gasConsumption: 9.5, carPrice: 8000, year: 2011));
            var hyundai = new Hyundai(new HyundaiOnGas(model: "Sonata", GasType.Methane, gasConsumption: 8, carPrice: 9300, year: 2015));

            _cars = new Car[] { honda, fiat, nissan1, nissan2, bmw, renault, suzuki, opel, kia, hyundai };
        }

        // Append new cars to already existed ones
        public void AddCars(Car[] newCars)
        {
            _cars = TaxiStationResizer.AddAnimals(_cars, newCars);
        }

        // Get total price of all cars in the taxi station
        public decimal GetTotalPrice()
        {
            decimal sum = 0;

            foreach (Car car in _cars)
            {
                sum += car.Price;
            }

            return sum;
        }

        public void SortByCountry()
        {
            new CountrySorter().Sort(ref _cars);
        }

        public void SortByFuelConsumption()
        {
            new FuelConsumptionSorter().Sort(ref _cars);
        }

        public void SortByCarPrice()
        {
            new CarPriceSorter().Sort(ref _cars);
        }

        public void SortByYear()
        {
            new YearSorter().Sort(ref _cars);
        }

        // Print all cars in the taxi station
        public void PrintCars()
        {
            int i = 1;

            foreach (var car in Cars)
            {
                string data = $"{i++}. {car.GetDescription()}";
                Printer.Print(data);
            }
        }
    }
}

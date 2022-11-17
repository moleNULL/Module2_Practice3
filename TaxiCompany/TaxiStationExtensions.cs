namespace TaxiCompany
{
    // Class that provides methods to search cars by particular parameters
    // (method: PrintUserFindChoice() in Starter)
    internal static class TaxiStationExtensions
    {
        // Print cars that need the least money to be spent on fuel (fuelPrice * fuelConsumption)
        public static void PrintTheCheapestSpendingOnFuel(this TaxiStation taxiStation)
        {
            Car[] cars = new Car[taxiStation.Cars.Length];
            int count = 0;

            decimal minSpendingPrice = taxiStation.Cars[0].Price * (decimal)taxiStation.Cars[0].FuelConsumption;

            foreach (var car in taxiStation.Cars)
            {
                decimal currFuelMoneySpending = (decimal)car.FuelConsumption * car.FuelPrice;

                if (minSpendingPrice > currFuelMoneySpending)
                {
                    // if there's another min value -> clear the array and point at 0 index (count)
                    count = 0;
                    Array.Clear(cars);

                    minSpendingPrice = currFuelMoneySpending;
                    cars[count++] = car;
                }
                else if (minSpendingPrice == currFuelMoneySpending)
                {
                    cars[count++] = car;
                }
            }

            // decimal -> double: 248,000 -> 248,00
            Console.WriteLine($"\n\t\tCars that are cheapest to drive in terms of " +
                $"spending on fuel ({(double)minSpendingPrice} UAH per 100 km) [{count}] :");

            PrintData(taxiStation, cars, count);
        }

        public static void PrintTheNewestCar(this TaxiStation taxiStation)
        {
            int newestYear = taxiStation.Cars[0].Year;

            foreach (var car in taxiStation.Cars)
            {
                if (newestYear < car.Year)
                {
                    newestYear = car.Year;
                }
            }

            Car[] cars = new Car[taxiStation.Cars.Length];
            int count = 0;

            foreach (var car in taxiStation.Cars)
            {
                if (car.Year == newestYear)
                {
                    cars[count++] = car;
                }
            }

            Console.WriteLine($"\n\t\t\tThe newest cars " +
                $"in the taxi station [{count}]:");

            PrintData(taxiStation, cars, count);
        }

        public static void PrintCarsFromCountry(this TaxiStation taxiStation, string country)
        {
            Car[] cars = new Car[taxiStation.Cars.Length];
            int count = 0;

            foreach (var car in taxiStation.Cars)
            {
                if (car.Country == country)
                {
                    cars[count++] = car;
                }
            }

            Console.WriteLine($"\n\t\t\tCars from {country} [{count}]:");

            PrintData(taxiStation, cars, count);
        }

        public static void PrintCarsOnFuel(this TaxiStation taxiStation, FuelType fuelType)
        {
            Car[] cars = new Car[taxiStation.Cars.Length];
            int count = 0;

            foreach (var car in taxiStation.Cars)
            {
                if (car.FuelType == fuelType)
                {
                    cars[count++] = car;
                }
            }

            Console.WriteLine($"\n\t\t\tCars on {fuelType} [{count}]:");

            PrintData(taxiStation, cars, count);
        }

        // Print data using output method
        private static void PrintData(TaxiStation taxiStation, Car[] cars, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string data = $"{i + 1}. {cars[i].GetDescription()}";
                taxiStation.Printer.Print(data);
            }
        }
    }
}

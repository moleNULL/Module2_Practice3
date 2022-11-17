namespace TaxiCompany
{
    internal class Starter
    {
        public static void Run()
        {
            var taxiStation = new TaxiStation();
            taxiStation.Printer = new ConsolePrinter(); // Output to Console for TaxiStation
            taxiStation.FillStationWithInitialCars();
            taxiStation.AddCars(BuyNewCars());

            taxiStation.PrintCars();
            Console.WriteLine($"\n\t\t\t\tPrice of all cars in the taxi company: ${taxiStation.GetTotalPrice()}");

            Console.WriteLine();
            int userSortChoice = GetUserSortChoice();
            SortByUserChoice(taxiStation, userSortChoice);
            taxiStation.PrintCars();

            Console.WriteLine();
            int userFindChoice = GetUserFindChoice();
            PrintUserFindChoice(taxiStation, userFindChoice);
        }

        // Buy new cars for the taxi station
        public static Car[] BuyNewCars()
        {
            BMW bmw = new BMW(new BmwOnDiesel(model: "320", dieselConsumption: 7, carPrice: 3999, year: 2000));
            var mitsubishi = new PetrolCar(brand: "Mitsubishi", model: "Lancer", country: "Japan", PetrolType.Test, petrolConsumption: 7.4, carPrice: 6000, year: 2008);
            Renault renault = new Renault(new RenaultOnDiesel(model: "Laguna", dieselConsumption: 6.5, carPrice: 4800, year: 2008));
            var ford = new GasCar(brand: "Ford", model: "C-Max 2", country: "USA", GasType.Methane, gasConsumption: 8.4, carPrice: 3900, year: 2006);

            return new Car[] { bmw, mitsubishi, renault, ford };
        }

        // Ask user how to sort cars in the taxi station
        private static int GetUserSortChoice()
        {
            while (true)
            {
                Console.Write("\nSort cars by:\n 1. Country\n " +
                    "2. Fuel Consumption\n 3. Price\n 4. Year\nChoice: ");
                string? sortChoice = Console.ReadLine();

                switch (sortChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Error! Only 1, 2, 3 or 4 is a valid answer");
                        continue;
                }

                return int.Parse(sortChoice);
            }
        }

        // Sort cars by user choice
        private static void SortByUserChoice(TaxiStation taxiStation, int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    taxiStation.SortByCountry();
                    Console.WriteLine("\n\t\t\tSorted by [Country] in ascending order:");
                    break;
                case 2:
                    taxiStation.SortByFuelConsumption();
                    Console.WriteLine("\n\t\t\tSorted by [FuelConsumption] in ascending order:");
                    break;
                case 3:
                    taxiStation.SortByCarPrice();
                    Console.WriteLine("\n\t\t\tSorted by [CarPrice] in ascending order:");
                    break;
                case 4:
                    taxiStation.SortByYear();
                    Console.WriteLine("\n\t\t\tSorted by [Year] in ascending order:");
                    break;
                default:
                    Console.WriteLine("Error! Only 1, 2, 3 or 4 is a valid answer");
                    break;
            }
        }

        // Ask user what cars to find in the taxi station
        private static int GetUserFindChoice()
        {
            while (true)
            {
                Console.Write("\nFind cars:" +
                    $"\n 1. The cheapest spending on fuel" +
                    "\n 2. The newest\n 3. Only from Japan\n 4. Only on Gas" +
                    "\nChoice: ");
                string? findChoice = Console.ReadLine();

                switch (findChoice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Error! Only 1, 2, 3 or 4 is a valid answer");
                        continue;
                }

                return int.Parse(findChoice);
            }
        }

        // Print cars by parameters chosen by user
        private static void PrintUserFindChoice(TaxiStation taxiStation, int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    taxiStation.PrintTheCheapestSpendingOnFuel();
                    break;
                case 2:
                    taxiStation.PrintTheNewestCar();
                    break;
                case 3:
                    taxiStation.PrintCarsFromCountry(country: "Japan");
                    break;
                case 4:
                    taxiStation.PrintCarsOnFuel(fuelType: FuelType.Gas);
                    break;
                default:
                    Console.WriteLine("Error! Only 1, 2, 3 or 4 is a valid answer");
                    break;
            }
        }
    }
}
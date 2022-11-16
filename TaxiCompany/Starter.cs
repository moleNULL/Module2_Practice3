using TaxiCompany.Vehicles;
using TaxiCompany.Vehicles.Cars;
using TaxiCompany.Vehicles.Cars.Brands;
using TaxiCompany.Vehicles.Cars.PetrolCars;

namespace TaxiCompany
{
    internal class Starter
    {
        public static void Run()
        {
            var taxiStation = new TaxiStation();
            taxiStation.Printer = new ConsolePrinter(); // Output to Console for TaxiStation
            taxiStation.FillStationWithDefaultCars();
            taxiStation.AddCars(AddMoreCars());

            taxiStation.PrintCars();
        }

        public static Car[] AddMoreCars()
        {
            BMW bmw = new BMW(new BmwOnDiesel(model: "320", dieselConsumption: 7, carPrice: 3999, year: 2000));
            var mitsubishi = new PetrolCar(brand: "Mitsubishi", model: "Lancer", country: "Japan", PetrolType.AI95, petrolConsumption: 7.4, carPrice: 6000, year: 2008);
            Renault renault = new Renault(new RenaultOnDiesel(model: "Laguna", dieselConsumption: 6.5, carPrice: 4800, year: 2008));
            var ford = new GasCar(brand: "Ford", model: "C-Max 2", country: "USA", GasType.Methane, gasConsumption: 8.4, carPrice: 3900, year: 2006);

            return new Car[] { bmw, mitsubishi, renault, ford };
        }
    }
}

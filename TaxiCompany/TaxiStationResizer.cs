namespace TaxiCompany
{
    // Class that provides logic to Add/Remove cars
    internal class TaxiStationResizer
    {
        // Add new cars to already existed ones
        public static Car[] AddAnimals(Car[] oldCars, Car[] newCars)
        {
            int oldCarLength = oldCars.Length;
            int newCarLength = newCars.Length;
            Car[] cars = new Car[oldCarLength + newCarLength];

            Array.Copy(oldCars, cars, oldCarLength);
            Array.Copy(newCars, 0, cars, oldCarLength, newCarLength);

            return cars;
        }
    }
}

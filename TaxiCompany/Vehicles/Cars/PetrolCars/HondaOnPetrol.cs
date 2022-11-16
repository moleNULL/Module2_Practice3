using TaxiCompany.Enums;

namespace TaxiCompany.Vehicles.Cars.PetrolCars
{
    internal class HondaOnPetrol : PetrolCar
    {
        public HondaOnPetrol(string model, PetrolType petrolType, double petrolConsumption, decimal carPrice, int year)
            : base(brand: "Honda", model, country: "Japan", petrolType, petrolConsumption, carPrice, year)
        {
        }
    }
}

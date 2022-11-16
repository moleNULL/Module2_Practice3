namespace TaxiCompany.Vehicles
{
    internal abstract class Vehicle
    {
        public abstract string Brand { get; set; }
        public abstract string Country { get; set; }
        public abstract decimal Price { get; set; }
        public abstract int Year { get; set; }

        public abstract string GetDescription();
    }
}

﻿namespace TaxiCompany.Vehicles.Cars
{
    internal abstract class Car : Vehicle
    {
        public abstract string Model { get; set; }
        public abstract decimal FuelPrice { get; set; } // in UAH
        public abstract double FuelConsumption { get; set; } // in litres (m^3)

        // user should not change this value and it must be initialized only once
        public abstract FuelType FuelType { get; init; }
    }
}

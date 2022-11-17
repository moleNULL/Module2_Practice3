namespace TaxiCompany.Sorters
{
    internal class FuelConsumptionSorter : ISort
    {
        public void Sort(ref Car[] cars)
        {
            double[] fuelArr = new double[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                fuelArr[i] = cars[i].FuelConsumption;
            }

            Array.Sort(fuelArr);

            Car[] temp = new Car[cars.Length];

            // prevents duplicating the same Car N-times by checking if it was already assigned
            Car? carDuplicate = null;

            for (int i = 0; i < fuelArr.Length; i++)
            {
                foreach (var car in cars)
                {
                    if (fuelArr[i] == car.FuelConsumption)
                    {
                        if (carDuplicate != car)
                        {
                            temp[i] = car;
                            carDuplicate = car;
                            break;
                        }
                    }
                }
            }

            cars = temp;
        }
    }
}

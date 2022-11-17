namespace TaxiCompany.Sorters
{
    internal class YearSorter : ISort
    {
        public void Sort(ref Car[] cars)
        {
            int[] years = new int[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                years[i] = cars[i].Year;
            }

            Array.Sort(years);

            Car[] temp = new Car[cars.Length];

            // prevents duplicating the same Car N-times by checking if it was already assigned
            Car? carDuplicate = null;

            for (int i = 0; i < years.Length; i++)
            {
                foreach (var car in cars)
                {
                    if (years[i] == car.Year)
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

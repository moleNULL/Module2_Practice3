namespace TaxiCompany.Sorters
{
    internal class CountrySorter : ISort
    {
        public void Sort(ref Car[] cars)
        {
            string[] countries = new string[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                countries[i] = cars[i].Country;
            }

            Array.Sort(countries);

            Car[] temp = new Car[cars.Length];

            // prevents duplicating the same Car N-times by checking if it was already assigned
            Car[] carsChecked = new Car[cars.Length];
            int j = 0;

            for (int i = 0; i < countries.Length; i++)
            {
                foreach (var car in cars)
                {
                    if (countries[i] == car.Country)
                    {
                        // check if this car was already checked
                        bool exists = false;
                        foreach (var carChecked in carsChecked)
                        {
                            if (carChecked == car)
                            {
                                exists = true;
                                break;
                            }
                        }

                        // if it wasn't checked add to temp[] to prevent duplicates
                        if (!exists)
                        {
                            temp[i] = car;
                            carsChecked[j++] = car;
                            break;
                        }
                    }
                }
            }

            cars = temp;
        }
    }
}

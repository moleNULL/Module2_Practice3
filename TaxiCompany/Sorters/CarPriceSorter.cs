namespace TaxiCompany.Sorters
{
    internal class CarPriceSorter : ISort
    {
        public void Sort(ref Car[] cars)
        {
            decimal[] prices = new decimal[cars.Length];

            for (int i = 0; i < cars.Length; i++)
            {
                prices[i] = cars[i].Price;
            }

            Array.Sort(prices);

            Car[] temp = new Car[cars.Length];

            // prevents duplicating the same Car N-times by checking if it was already assigned
            Car? carDuplicate = null;

            for (int i = 0; i < prices.Length; i++)
            {
                foreach (var car in cars)
                {
                    if (prices[i] == car.Price)
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

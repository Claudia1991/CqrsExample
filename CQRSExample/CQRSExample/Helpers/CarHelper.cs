using CQRSExample.Entities;

namespace CQRSExample.Helpers
{
    public static class CarHelper
    {
        public static List<Car> Cars() 
        {
            return [
                new Car("Model 1", "Black", 4, true, false, 1200),
                new Car("Model 2", "White", 5, false, true, 1500),
                new Car("Model 3", "Red", 2, true, true, 2000),
                new Car("Model 4", "Yellow", 3, false, true, 1200),
                new Car("Model 5", "Brown", 5, true, false, 4000),
                new Car("Model 6", "Black", 4, false, true, 3000),
                new Car("Model 7", "Golden", 2, true, false, 1200),
                new Car("Model 8", "White", 3, false, true, 2650),
                new Car("Model 9", "Red", 4, true, false, 1750),
                ];
        }
    }
}

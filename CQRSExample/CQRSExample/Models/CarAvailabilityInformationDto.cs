using CQRSExample.Entities;

namespace CQRSExample.Models
{
    public class CarAvailabilityInformationDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool IsSportive { get; set; }
        public decimal Price { get; set; }

        public CarAvailabilityInformationDto(Car car)
        {
            Id = car.Id;
            Model = car.Model;
            Color = car.Color;
            Doors = car.Doors;
            Price = car.Price;
            IsSportive = car.IsSportive;
        }
    }
}

namespace CQRSExample.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsSportive { get; set; }
        public decimal Price { get; set; }

        public Car(string model, string color, int doors, bool isAvailable, bool isSportive, decimal price)
        {
            Id = Random.Shared.Next();
            Model = model;
            Color = color;
            Doors = doors;
            IsAvailable = isAvailable;
            IsSportive = isSportive;
            Price = price;
        }
    }
}

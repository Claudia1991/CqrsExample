using MediatR;

namespace CQRSExample.Commands
{
    public class CreateCarCommand : IRequest<bool>
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsSportive { get; set; }
        public decimal Price { get; set; }

        public CreateCarCommand(string model, string color, int doors, bool isAvailable, bool isSportive, decimal price)
        {
            Model = model;
            Color = color;
            Doors = doors;
            IsAvailable = isAvailable;
            IsSportive = isSportive;
            Price = price;
        }
    }
}

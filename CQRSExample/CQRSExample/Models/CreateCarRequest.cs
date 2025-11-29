namespace CQRSExample.Models
{
    public class CreateCarRequest
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool IsAvailable { get; set; } = true;
        public bool IsSportive { get; set; }
        public decimal Price { get; set; }
    }
}

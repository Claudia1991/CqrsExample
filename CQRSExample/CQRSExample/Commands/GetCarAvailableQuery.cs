using CQRSExample.Models;
using MediatR;

namespace CQRSExample.Commands
{
    public class GetCarAvailableQuery : IRequest<List<CarAvailabilityInformationDto>>
    {
        public GetCarAvailableQuery(decimal price)
        {
            Price = price;
        }
        public decimal Price { get; set; }
    }
}

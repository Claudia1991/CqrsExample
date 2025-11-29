using CQRSExample.Commands;
using CQRSExample.Helpers;
using CQRSExample.Models;
using MediatR;

namespace CQRSExample.Queries
{
    public class GetCarAvailableCommandHandler : IRequestHandler<GetCarAvailableQuery, List<CarAvailabilityInformationDto>>
    {
        public async Task<List<CarAvailabilityInformationDto>> Handle(GetCarAvailableQuery request, CancellationToken cancellationToken)
        {
            var cars = CarHelper.Cars()
                                .Where(x => x.Price <= request.Price)
                                .Select(x => { return new CarAvailabilityInformationDto(x); })
                                .ToList();
            return cars;
        }
    }
}

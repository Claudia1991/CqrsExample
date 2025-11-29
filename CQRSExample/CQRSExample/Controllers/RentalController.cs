using Microsoft.AspNetCore.Mvc;
using MediatR;
using CQRSExample.Models;
using CQRSExample.Commands;
using System.Threading.Tasks;

namespace CQRSExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalController : ControllerBase
    {
        private IMediator _mediator;

        public RentalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-cars-availability")]
        public IActionResult Get([FromQuery] decimal price) 
        {
            var result = _mediator.Send(new GetCarAvailableQuery(price), default).Result;

            if (result is null)
            {
                return BadRequest(ApiResultPattern<List<CarAvailabilityInformationDto>>.Fail("No cars available."));
            }

            return Ok(ApiResultPattern<List<CarAvailabilityInformationDto>>.Success(result));
        }

        [HttpPost("create-car")]
        public IActionResult Post([FromBody] CreateCarRequest request)
        {
            var result = _mediator.Send(new CreateCarCommand(request.Model, request.Color, request.Doors, request.IsAvailable, request.IsSportive, request.Price), default).Result;

            if (result is false)
            {
                return BadRequest(ApiResultPattern<bool>.Fail("No cars added."));
            }

            return Ok(ApiResultPattern<bool>.Success(true));
        }
    }
}

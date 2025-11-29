using CQRSExample.Commands;
using CQRSExample.Helpers;
using MediatR;

namespace CQRSExample.Handlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, bool>
    {
        private readonly CreateCarValidator _validator;

        public CreateCarCommandHandler()
        {
            _validator = new CreateCarValidator();
        }

        public async Task<bool> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            return validationResult != null && validationResult.IsValid;
        }
    }
}

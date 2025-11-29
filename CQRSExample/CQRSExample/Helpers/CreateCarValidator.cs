using CQRSExample.Commands;
using FluentValidation;

namespace CQRSExample.Helpers
{
    public class CreateCarValidator : AbstractValidator<CreateCarCommand>
    {
        public CreateCarValidator()
        {
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Invalid price.");
            RuleFor(x => x.Doors).GreaterThan(0).WithMessage("Invalid doors number.");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Invalid model.");
        }
    }
}

using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                    .NotEmpty()
                    .WithMessage("{Property} can't be empty");

                RuleFor(e => e.Surname)
                    .NotEmpty()
                    .WithMessage("{Property} can't be empty");

                RuleFor(e => e.EmployeeRole)
                    .NotEmpty()
                    .WithMessage("{Property} can't be empty");
            });
        }
    }
}

using FluentValidation;

namespace CleanArchitecture.Application.Features;


public class GetAllUsersValidator : AbstractValidator<GetAllUsersRequest>
{
    public GetAllUsersValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2);
        RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
    }
}
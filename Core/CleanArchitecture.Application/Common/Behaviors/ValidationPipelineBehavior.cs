using FluentValidation;
using MediatR;

namespace CleanArchitecture.Application.Common.Behaviors;

public class ValidationPipelineBehavior<TRequest, TResponse> :
                     IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IValidator<TRequest> validator;

    public ValidationPipelineBehavior(IValidator<TRequest> validator)
    {
        this.validator = validator;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var validataionResult = await validator.ValidateAsync(request);
        if (!validataionResult.IsValid)
            throw new ValidationException(validataionResult.Errors);

        return await next();
    }
}

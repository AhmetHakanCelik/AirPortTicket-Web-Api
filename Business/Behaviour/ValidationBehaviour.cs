using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace Business.Behaviour
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : class, IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TResponse>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TResponse>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if(_validators.Any())
            {
                return await next();
            }

            var context = new ValidationContext<TRequest>(request);

            var ErrorDictionary = _validators
                .Select(e => e.Validate(context))
                .SelectMany(e => e.Errors)
                .Where(e => e != null)
                .GroupBy(s => s.PropertyName, s => s.ErrorMessage, (propertyName, errorMesage) => new
                {
                    Key = propertyName,
                    Values = errorMesage.Distinct().ToArray(),
                })
                .ToDictionary(s => s.Values[0], s => s.Key);

            if (ErrorDictionary.Any())
            {
                var errors = ErrorDictionary.Select(s => new ValidationFailure
                {
                    PropertyName = s.Value,
                    ErrorCode = s.Key
                });

                throw new ValidationException(errors);
            }

            return await next();
        }
    }
}


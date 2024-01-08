using MediatR;

namespace Business.Features.Payments.CreatePayment
{
    public sealed record CreatePaymentCommand
        (int CardNumber, Guid CustomerId,string FullName, int SecurityCode, DateTime ExpirationDate) : IRequest<Unit>;
}

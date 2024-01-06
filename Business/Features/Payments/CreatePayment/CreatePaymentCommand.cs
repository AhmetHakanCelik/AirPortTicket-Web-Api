using MediatR;

namespace Business.Features.Payments.CreatePayment
{
    public sealed record CreatePaymentCommand
        (int CardNumber, string FullName, int SecurityCode) : IRequest;
}

using MediatR;

namespace Business.Features.Payments.UpdatePayment
{
    public sealed record UpdatePaymentCommand(int CardNumber, string FullName, int SecurityCode) : IRequest;
}

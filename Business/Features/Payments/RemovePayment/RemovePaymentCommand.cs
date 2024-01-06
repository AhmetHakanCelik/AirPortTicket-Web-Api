using MediatR;

namespace Business.Features.Payments.RemovePayment
{
    public sealed record RemovePaymentCommand(int CardNumber) : IRequest;
}

using Entities.Models;
using MediatR;

namespace Business.Features.Payments.ListPayments
{
    public sealed record ListPaymentsCommand() : IRequest<List<Payment>>;

}

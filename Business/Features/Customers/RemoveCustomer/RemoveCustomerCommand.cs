using MediatR;

namespace Business.Features.Customers.RemoveCustomer
{
    public sealed record RemoveCustomerCommand
        (string CustomerName, string LastName) : IRequest;
}

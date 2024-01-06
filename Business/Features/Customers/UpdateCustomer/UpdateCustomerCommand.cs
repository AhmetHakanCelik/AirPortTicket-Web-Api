using MediatR;
using System.ComponentModel;

namespace Business.Features.Customers.UpdateCustomer
{
    public sealed record UpdateCustomerCommand
        (Guid Id, string CustomerName, string Lastname) : IRequest;
}

using Entities.Models;
using MediatR;

namespace Business.Features.Customers.ListCustomer
{
    public sealed record ListCustomerCommand() : IRequest<List<Customer>>;
}

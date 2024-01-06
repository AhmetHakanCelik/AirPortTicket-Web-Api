using MediatR;

namespace Business.Features.Customers.CreateCustomer
{
    public sealed record CreateCustomerCommand
        (string CustomerName, string Lastname, string Email, string Address, string PhoneNumber)
        : IRequest;
}

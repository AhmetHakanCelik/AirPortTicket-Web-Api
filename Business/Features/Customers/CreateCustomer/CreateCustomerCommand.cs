using MediatR;

namespace Business.Features.Customers.CreateCustomer
{
    public sealed record CreateCustomerCommand
        (Guid CustomerId,string CustomerName, string Lastname,char Gender,string Email, string Address, int Phone)
        : IRequest;
}

using Entities.Models;
using Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Customers.ListCustomer
{
    internal sealed class ListCustomerCommandHandler : IRequestHandler<ListCustomerCommand, List<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public ListCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> Handle(ListCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetAll().OrderBy(p => p.CustomerName).ToListAsync(cancellationToken);
            
        }
    }
}

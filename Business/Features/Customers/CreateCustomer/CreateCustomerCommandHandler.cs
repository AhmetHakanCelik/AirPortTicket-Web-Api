using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Customers.CreateCustomer
{
    internal sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = new()
            {
                CustomerName = request.CustomerName,
                LastName = request.Lastname
            };

            await _customerRepository.AddAsync(customer, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

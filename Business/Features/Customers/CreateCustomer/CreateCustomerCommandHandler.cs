using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Customers.CreateCustomer
{
    internal sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand,Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = new()
            {
                CustomerId = request.CustomerId,
                CustomerName = request.CustomerName,
                LastName = request.Lastname,
                Gender = request.Gender,
                Email = request.Email,
                Address = request.Address,
                Phone = request.Phone
            };

            await _customerRepository.AddAsync(customer, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

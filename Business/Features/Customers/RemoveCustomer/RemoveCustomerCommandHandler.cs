using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Customers.RemoveCustomer
{
    internal sealed class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = await _customerRepository.GetByIdAsync
                (p => p.CustomerName == request.CustomerName && p.LastName == request.LastName, cancellationToken);

            _customerRepository.Remove(customer);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

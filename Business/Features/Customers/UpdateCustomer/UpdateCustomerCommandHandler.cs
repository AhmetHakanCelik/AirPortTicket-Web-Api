using Entities.Repositories;
using MediatR;
using Entities.Models;

namespace Business.Features.Customers.UpdateCustomer
{
    internal sealed class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = await _customerRepository.GetByIdAsync
            (p => p.CustomerName == request.CustomerName && p.LastName == request.Lastname, cancellationToken);

            customer.CustomerName = request.CustomerName;
            customer.LastName = request.Lastname;

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

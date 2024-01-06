using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Bills.RemoveBill
{
    internal sealed class RemoveBillCommandHandler : IRequestHandler<RemoveBillCommand>
    {
        private readonly IBillRepository _billRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveBillCommandHandler(IBillRepository billRepository, IUnitOfWork unitOfWork)
        {
            _billRepository = billRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(RemoveBillCommand request, CancellationToken cancellationToken)
        {
            Bill bill = await _billRepository.GetByIdAsync
                (e => e.Identification_number == request.Identification_Number, cancellationToken);

            _billRepository.Remove(bill);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Bills.UpdateBill
{
    internal sealed class UpdateBillCommandHandler : IRequestHandler<UpdateBillCommand>
    {
        private readonly IBillRepository _billRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateBillCommandHandler(IBillRepository billRepository, IUnitOfWork unitOfWork)
        {
            _billRepository = billRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(UpdateBillCommand request, CancellationToken cancellationToken)
        {
            Bill bill = await _billRepository.GetByIdAsync
                (e => e.Identification_number == request.Identification_Number, cancellationToken);

            bill.Identification_number = request.Identification_Number;
            bill.CustomerName = request.CustomerName;
            bill.CustomerLastName = request.CustomerLastName;

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

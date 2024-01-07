using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Bills.CreateBill
{
    public sealed class CreateBillCommandHandler : IRequestHandler<CreateBillCommand>
    {
        private readonly IBillRepository _billRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateBillCommandHandler(IBillRepository billRepository, IUnitOfWork unitOfWork)
        {
            _billRepository = billRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateBillCommand request, CancellationToken cancellationToken)
        {
            Bill Bill = new()
            {
                TicketId = request.TicketId,
                Identification_number = request.Identification_Number,
                CustomerName = request.CustomerName,
                CustomerLastName = request.CustomerLastName,
                Cost = request.Cost,
                Date = request.Date
            };

            await _billRepository.AddAsync(Bill, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

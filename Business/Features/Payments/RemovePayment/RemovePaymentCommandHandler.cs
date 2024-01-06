using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Payments.RemovePayment
{
    internal sealed class RemovePaymentCommandHandler : IRequestHandler<RemovePaymentCommand>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemovePaymentCommandHandler(IPaymentRepository paymentRepository, IUnitOfWork unitOfWork)
        {
            _paymentRepository = paymentRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(RemovePaymentCommand request, CancellationToken cancellationToken)
        {
            Payment payment = await _paymentRepository.GetByIdAsync
                (e => e.CardNumber == request.CardNumber, cancellationToken);

            _paymentRepository.Remove(payment);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

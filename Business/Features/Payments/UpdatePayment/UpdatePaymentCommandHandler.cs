using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Payments.UpdatePayment
{
    internal sealed class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePaymentCommandHandler(IPaymentRepository paymentRepository, IUnitOfWork unitOfWork)
        {
            _paymentRepository = paymentRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
        {
            Payment payment = await _paymentRepository.GetByIdAsync
                (e => e.CardNumber == request.CardNumber && e.SecurityCode == request.SecurityCode, cancellationToken);

            payment.CardNumber = request.CardNumber;
            payment.SecurityCode = request.SecurityCode;
            payment.FullName = request.FullName;

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

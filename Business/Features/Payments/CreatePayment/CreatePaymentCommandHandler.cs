using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Payments.CreatePayment
{
    internal sealed class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand,Unit>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePaymentCommandHandler(IPaymentRepository paymentRepository, IUnitOfWork unitOfWork)
        {
            _paymentRepository = paymentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            Payment payment = new()
            {
                CardNumber = request.CardNumber,
                CustomerId = request.CustomerId,
                FullName = request.FullName,
                SecurityCode = request.SecurityCode,
                ExpirationDate= request.ExpirationDate,
            };

            await _paymentRepository.AddAsync(payment, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

using Entities.Models;
using Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Payments.ListPayments
{
    internal sealed class ListPaymentsCommandHandler :
         IRequestHandler<ListPaymentsCommand, List<Payment>>
    {
        private readonly IPaymentRepository _paymentRepository;

        public ListPaymentsCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<List<Payment>> Handle(ListPaymentsCommand request, CancellationToken cancellationToken)
        {
            return await _paymentRepository.GetAll().ToListAsync(cancellationToken);
            
        }
    }

}

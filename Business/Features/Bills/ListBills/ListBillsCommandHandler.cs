using Entities.Models;
using Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Bills.ListBills
{
    internal sealed class ListBillsCommandHandler : IRequestHandler<ListBillsCommand, List<Bill>>
    {
        private readonly IBillRepository _billRepository;

        public ListBillsCommandHandler(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }
        public Task<List<Bill>> Handle(ListBillsCommand request, CancellationToken cancellationToken)
        {
            var response = _billRepository.GetAll().ToListAsync(cancellationToken);
            return response;
        }
    }
}

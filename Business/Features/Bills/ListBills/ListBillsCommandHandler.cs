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
        public async Task<List<Bill>> Handle(ListBillsCommand request, CancellationToken cancellationToken)
        {
            return await _billRepository.GetAll().ToListAsync(cancellationToken);
        }
    }
}

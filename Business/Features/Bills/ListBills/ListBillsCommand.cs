using Entities.Models;
using MediatR;

namespace Business.Features.Bills.ListBills
{
    public sealed record ListBillsCommand() : IRequest<List<Bill>>;
}

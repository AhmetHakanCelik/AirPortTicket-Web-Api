using MediatR;

namespace Business.Features.Bills.CreateBill
{
    public sealed record CreateBillCommand
        (Guid TicketId,int Identification_Number, string CustomerName, string CustomerLastName,decimal Cost,DateTime Date) 
        : IRequest<Unit>;
}

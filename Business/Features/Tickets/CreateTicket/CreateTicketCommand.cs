using MediatR;

namespace Business.Features.Tickets.CreateTicket
{
    public sealed record CreateTicketCommand
        (Guid TicketId,Guid CustomerId,string CustomerFullName, decimal Cost, DateTime Date) : IRequest;
}

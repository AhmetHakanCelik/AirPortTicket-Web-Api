using MediatR;

namespace Business.Features.Tickets.CreateTicket
{
    public sealed record CreateTicketCommand
        (string CustomerFullName, decimal Cost, DateTime Date) : IRequest;
}

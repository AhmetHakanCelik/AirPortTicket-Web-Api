using MediatR;

namespace Business.Features.Tickets.UpdateTicket
{
    public sealed record UpdateTicketCommand
        (string CustomerFullName, decimal Cost, DateTime Date) : IRequest;
}

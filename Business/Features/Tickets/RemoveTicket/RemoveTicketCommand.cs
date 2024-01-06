using MediatR;

namespace Business.Features.Tickets.RemoveTicket
{
    public sealed record RemoveTicketCommand(string CustomerFullName) : IRequest;
}

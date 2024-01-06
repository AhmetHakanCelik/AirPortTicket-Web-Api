using Entities.Models;
using MediatR;

namespace Business.Features.Tickets.ListTickets
{
    public sealed record ListTicketsCommand() : IRequest<List<Ticket>>;
}

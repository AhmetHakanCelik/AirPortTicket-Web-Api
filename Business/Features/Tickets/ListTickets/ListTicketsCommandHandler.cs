using Entities.Models;
using Entities.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Features.Tickets.ListTickets
{
    internal sealed class ListTicketsCommandHandler : IRequestHandler<ListTicketsCommand, List<Ticket>>
    {
        private readonly ITicketRepository _ticketRepository;

        public ListTicketsCommandHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<List<Ticket>> Handle(ListTicketsCommand request, CancellationToken cancellationToken)
        {
            var response = await _ticketRepository.GetAll().ToListAsync(cancellationToken);
            return response;
        }
    }
}

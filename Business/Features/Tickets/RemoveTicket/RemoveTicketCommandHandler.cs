using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Tickets.RemoveTicket
{
    internal sealed class RemoveTicketCommandHandler : IRequestHandler<RemoveTicketCommand>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveTicketCommandHandler(ITicketRepository ticketRepository, IUnitOfWork unitOfWork)
        {
            _ticketRepository = ticketRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(RemoveTicketCommand request, CancellationToken cancellationToken)
        {
            Ticket ticket = await _ticketRepository.GetByIdAsync
               (e => e.CustomerFullName == request.CustomerFullName, cancellationToken);

            _ticketRepository.Remove(ticket);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

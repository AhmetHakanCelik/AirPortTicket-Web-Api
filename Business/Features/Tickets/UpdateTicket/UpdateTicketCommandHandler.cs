using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Tickets.UpdateTicket
{
    internal sealed class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateTicketCommandHandler(ITicketRepository ticketRepository, IUnitOfWork unitOfWork)
        {
            _ticketRepository = ticketRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            Ticket ticket = await _ticketRepository.GetByIdAsync
                (e => e.CustomerFullName == request.CustomerFullName, cancellationToken);

            ticket.CustomerFullName = request.CustomerFullName;
            ticket.Cost = request.Cost;
            ticket.Date = request.Date;

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

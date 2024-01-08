using Entities.Models;
using Entities.Repositories;
using MediatR;

namespace Business.Features.Tickets.CreateTicket
{
    internal sealed class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand,Unit>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository, IUnitOfWork unitOfWork)
        {
            _ticketRepository = ticketRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            Ticket ticket = new()
            {
                TicketId = request.TicketId,
                CustomerId = request.CustomerId,
                CustomerFullName = request.CustomerFullName,
                Cost = request.Cost,
                Date = request.Date,
            };

            await _ticketRepository.AddAsync(ticket);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

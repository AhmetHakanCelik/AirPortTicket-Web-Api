using Business.Features.Tickets.CreateTicket;
using Business.Features.Tickets.ListTickets;
using Business.Features.Tickets.RemoveTicket;
using Business.Features.Tickets.UpdateTicket;
using DataAccess.Authorization;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirportTicket_Web_Api.Controllers
{
    public class TicketController:BaseController
    {
        public TicketController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [RoleFilter("Ticket.Add")]
        public async Task<IActionResult> CreateTicket(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Ticket.Update")]
        public async Task<IActionResult> UpdateTicket(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Ticket.Remove")]
        public async Task<IActionResult> RemoveTicket(RemoveTicketCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Ticket.GetAll")]
        public async Task<IActionResult> ListTicket(ListTicketsCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

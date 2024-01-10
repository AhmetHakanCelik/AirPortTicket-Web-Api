using Business.Features.Roles.CreateRole;
using Business.Features.Roles.GetRole;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirportTicket_Web_Api.Controllers
{
    public class RolesController : BaseController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request,cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> ListRole(ListRoleCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

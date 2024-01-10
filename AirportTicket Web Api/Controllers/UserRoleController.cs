using Business.Features.UserRoles.CreateUserRole;
using Business.Features.UserRoles.ListUserRole;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirportTicket_Web_Api.Controllers
{
    public class UserRoleController : BaseController
    {
        public UserRoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRole(CreateUserRoleCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> ListRole(ListUserRoleCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}

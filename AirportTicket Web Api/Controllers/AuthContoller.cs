using Business.Features.Auth.Login;
using Business.Features.Auth.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirportTicket_Web_Api.Controllers
{
    public class AuthContoller : BaseController
    {
        public AuthContoller(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
        {
            var response =await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }
    }
}

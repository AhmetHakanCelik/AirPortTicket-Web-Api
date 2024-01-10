using Business.Features.Customers.CreateCustomer;
using Business.Features.Customers.ListCustomer;
using Business.Features.Customers.RemoveCustomer;
using Business.Features.Customers.UpdateCustomer;
using DataAccess.Authorization;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirportTicket_Web_Api.Controllers
{
    public class CustomerController : BaseController
    {
        public CustomerController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [RoleFilter("Customer.Add")]

        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Customer.Update")]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Customer.Remove")]
        public async Task<IActionResult> RemoveCustomer(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Customer.GetAll")]
        public async Task<IActionResult> ListCustomer(ListCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

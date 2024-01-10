using Azure;
using Business.Features.Payments.CreatePayment;
using Business.Features.Payments.ListPayments;
using Business.Features.Payments.RemovePayment;
using Business.Features.Payments.UpdatePayment;
using DataAccess.Authorization;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirportTicket_Web_Api.Controllers
{
    public class PaymentController:BaseController
    {
        public PaymentController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [RoleFilter("Payment.Add")]
        public async Task<IActionResult> CreatePayment(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Payment.Update")]
        public async Task<IActionResult> UpdatePayment(UpdatePaymentCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Payment.Remove")]
        public async Task<IActionResult> RemovePayment(RemovePaymentCommand request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        [RoleFilter("Payment.GetAll")]
        public async Task<IActionResult> ListPayment(ListPaymentsCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}

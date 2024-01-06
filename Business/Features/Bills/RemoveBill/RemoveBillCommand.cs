using MediatR;

namespace Business.Features.Bills.RemoveBill
{
    public sealed record RemoveBillCommand
        (int Identification_Number) : IRequest;
}

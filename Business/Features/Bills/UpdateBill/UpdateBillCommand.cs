using MediatR;

namespace Business.Features.Bills.UpdateBill
{
    public sealed record UpdateBillCommand
        (int Identification_Number, string CustomerName, string CustomerLastName)
        : IRequest;
}

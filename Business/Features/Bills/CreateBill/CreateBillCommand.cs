using MediatR;

namespace Business.Features.Bills.CreateBill
{
    public sealed record CreateBillCommand
        (int Identification_Number, string CustomerName, string CustomerLastName) : IRequest;
}

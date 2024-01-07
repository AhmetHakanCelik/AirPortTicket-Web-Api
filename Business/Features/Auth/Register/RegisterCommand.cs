using MediatR;

namespace Business.Features.Auth.Register
{
    public sealed record RegisterCommand
        (string Name,string LastName,string Email,string Password):IRequest;
}

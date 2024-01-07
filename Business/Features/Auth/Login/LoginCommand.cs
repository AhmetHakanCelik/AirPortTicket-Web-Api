using MediatR;

namespace Business.Features.Auth.Login
{
    public sealed record LoginCommand(string Email, string Password) : IRequest;
}

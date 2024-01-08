using MediatR;

namespace Business.Features.Auth.Login
{
    public sealed record LoginCommandRepsonse(string AccesToken,Guid UserId): IRequest;
}

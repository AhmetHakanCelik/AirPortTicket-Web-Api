using MediatR;

namespace Business.Features.Roles.CreateRole
{
    public sealed record CreateRoleCommand(string Name) :IRequest;
}

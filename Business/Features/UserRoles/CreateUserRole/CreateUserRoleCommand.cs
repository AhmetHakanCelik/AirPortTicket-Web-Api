using MediatR;

namespace Business.Features.UserRoles.CreateUserRole
{
    public sealed record CreateUserRoleCommand(Guid UserId,Guid RoleId):IRequest;
}

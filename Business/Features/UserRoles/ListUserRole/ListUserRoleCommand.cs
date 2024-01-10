using Entities.Models;
using MediatR;

namespace Business.Features.UserRoles.ListUserRole
{
    public sealed record ListUserRoleCommand():IRequest<List<UserRole>>;
}

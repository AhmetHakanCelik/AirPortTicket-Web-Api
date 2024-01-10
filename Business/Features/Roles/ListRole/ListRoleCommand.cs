using Entities.Models;
using MediatR;

namespace Business.Features.Roles.GetRole
{
    public sealed record ListRoleCommand:IRequest<List<AppRole>>;
}

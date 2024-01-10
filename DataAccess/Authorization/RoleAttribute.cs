using Entities.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DataAccess.Authorization
{
    public sealed class RoleAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string _roleName;
        private readonly IUserRoleRepository _userRoleRepository;

        public RoleAttribute(string roleName, IUserRoleRepository userRoleRepository)
        {
            _roleName = roleName;
            _userRoleRepository = userRoleRepository;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var UserIdExist = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier.ToString());
            if (UserIdExist != null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var UserHasRole = _userRoleRepository
                .GetWhere(e => e.UserId.ToString() == UserIdExist.Value)
                .AsQueryable()
                .Include(e => e.Role)
                .Any(e => e.Role.Name == _roleName);

            if(UserHasRole )
            {
                context.Result = new UnauthorizedResult(); 
                return;
            }
        }
    }

}

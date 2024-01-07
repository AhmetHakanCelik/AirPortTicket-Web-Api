using DataAccess.DbContext;
using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    internal class RoleRepository : Repository<AppRole>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

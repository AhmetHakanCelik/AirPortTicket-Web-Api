using DataAccess.DbContext;
using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    internal class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

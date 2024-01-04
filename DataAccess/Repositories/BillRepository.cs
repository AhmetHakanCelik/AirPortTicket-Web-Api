using DataAccess.DbContext;
using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    internal sealed class BillRepository : Repository<Bill>, IBillRepository
    {
        public BillRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

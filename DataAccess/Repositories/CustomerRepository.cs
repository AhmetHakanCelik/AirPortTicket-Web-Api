using DataAccess.DbContext;
using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    internal sealed class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

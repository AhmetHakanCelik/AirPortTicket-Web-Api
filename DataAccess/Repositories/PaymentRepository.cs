using DataAccess.DbContext;
using Entities.Models;
using Entities.Repositories;

namespace DataAccess.Repositories
{
    internal sealed class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

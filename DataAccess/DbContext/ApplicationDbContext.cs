using DataAccess.Configs;
using Entities.Models;
using Entities.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbContext
{
    internal class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>,IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<IdentityRoleClaim<Guid>>();
            builder.Ignore<IdentityUserClaim<Guid>>();
            builder.Ignore<IdentityUserLogin<Guid>>();
            builder.Ignore<IdentityUserToken<Guid>>();
            builder.Ignore<IdentityUserRole<Guid>>();

            builder.ApplyConfiguration(new BillConfig());
            builder.ApplyConfiguration(new CustomerConfig());
            builder.ApplyConfiguration(new TicketConfig());
            builder.ApplyConfiguration(new PaymentConfig());
            builder.ApplyConfiguration(new UserRoleConfig());
        }

        public DbSet<Bill> Bill { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}

using DataAccess.Configs;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbContext
{
    internal class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>
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
        }

        public DbSet<BillConfig> BillConfig { get; set; }
        public DbSet<CustomerConfig> CustomerConfig { get; set; }
        public DbSet<PaymentConfig> PaymentConfig { get; set; }
        public DbSet<TicketConfig> TicketConfig { get; set; }
        public DbSet<UserRoleConfig> UserRoleConfig { get; set; }
    }
}

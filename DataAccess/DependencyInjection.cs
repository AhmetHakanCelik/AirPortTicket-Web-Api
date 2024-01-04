
using DataAccess.DbContext;
using DataAccess.Repositories;
using Entities.Models;
using Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            { 
                var ConnectionString = configuration.GetConnectionString("SqlServer");
                options.UseSqlServer(ConnectionString);
            });
            services.AddIdentityCore<AppUser>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IUnitOfWork>(cfg => cfg.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBillRepository,BillRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            return services;
        }
    }
}

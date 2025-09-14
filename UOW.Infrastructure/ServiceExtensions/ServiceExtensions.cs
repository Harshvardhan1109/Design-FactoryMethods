using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UOW.Infrastructure.Models;
using UOW.Infrastructure.RepositoryImplementation;
using UOW.Infrastructure.RepositoryInterfaces;

namespace UOW.Infrastructure.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDIServices_UOWInfrastucture(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DBContext>(options => {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using UOW.Infrastructure.Models;
using UOW.Services.ControllerImplementation;
using UOW.Services.ControllerInterfaces;

namespace UOW.Core
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDIServices_UOWServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}
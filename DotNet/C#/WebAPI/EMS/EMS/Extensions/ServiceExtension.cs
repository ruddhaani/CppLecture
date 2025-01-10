using EMS.Repositories.EmployeeRepositories;
using EMS.Services.EmployeeServices;

namespace EMS.Extensions
{
    public static class ServiceExtension
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}

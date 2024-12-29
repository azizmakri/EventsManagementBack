using EventManagement.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Infrastructure.Data
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<DataContext>(configuration.GetConnectionString("EMContextConnection"), null);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("EMContextConnection"), b => b.MigrationsAssembly("Presentation")));

            return services;
        }
    }
}

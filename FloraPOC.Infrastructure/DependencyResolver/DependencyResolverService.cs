using FloraPOC.Application.Contract.Repository;
using FloraPOC.Application.Contract.Service;
using FloraPOC.Infrastructure.Repository;
using FloraPOC.Infrastructure.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraPOC.Infrastructure.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ISpecieRepository, SpecieRepository>();
            services.AddScoped<ISpecieService, SpecieService>();

            return services;
        }
    }
}

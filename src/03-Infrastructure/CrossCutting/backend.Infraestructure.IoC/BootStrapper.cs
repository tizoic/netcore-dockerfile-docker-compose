using backend.Application.Services;
using backend.Domain.Repositories;
using backend.Domain.Services;
using backend.Infraestructure.Data.EF.Context;
using backend.Infraestructure.Data.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace backend.Infraestructure.IoC
{
    public static class BootStrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<PersonContext>();
            services.AddScoped<IPersonRepository, PersonRepository>();

            // Services
            services.AddScoped<IPersonService, PersonService>();

            return services;
        }
    }
}
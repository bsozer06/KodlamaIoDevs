using KodlamaIoDevs.Application.Services.Repositorties;
using KodlamaIoDevs.Persistance.Contexts;
using KodlamaIoDevs.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KodlamaIoDevs.Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("KodlamaIoDevsConnectionString")));

            services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguagesRepository>();

            return services;
        }
    }
}

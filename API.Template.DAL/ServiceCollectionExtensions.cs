using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using API.Template.DAL.Repositories.Interfaces;
using API.Template.DAL.Repositories.Implementations;

namespace API.Template.DAL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTemplateRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TemplateDbContext>(options =>
                    options.UseSqlServer(connectionString));
            services.AddScoped<ITemplateRepository, TemplateRepository>();

            return services;
        }
    }
}

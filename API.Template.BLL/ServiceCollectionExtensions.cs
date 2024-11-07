using Microsoft.Extensions.DependencyInjection;
using API.Template.BLL.Interfaces;
using API.Template.BLL.Services;
using API.Template.BLL.Mappings;

namespace API.Template.BLL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
        {
            // Register AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            // Register services
            services.AddScoped<ITemplateService, TemplateEntityService
                >();

            return services;
        }
    }
}

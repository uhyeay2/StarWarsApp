using Microsoft.Extensions.DependencyInjection;
using StarWarsApp.Domain.Models;
using StarWarsApp.ExternalService.StarWarsApi.DependencyInjection;
using StarWarsApp.ExternalService.StarWarsApi.Responses;
using StarWarsApp.Services.Interfaces;
using StarWarsApp.Services.StarWarsApi;
using StarWarsApp.Services.StarWarsApi.ModelBuilders;
using StarWarsApp.Services.StarWarsApi.Services;

namespace StarWarsApp.Services.DependencyInjection
{
    public static class ServiceInjection
    {
        public static IServiceCollection InjectServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.InjectStarWarsApiService();

            services.AddSingleton<ISWApiOrchestrator, StarWarsApiOrchestrator>();

            services.AddScoped<IModelBuilder<SWApiPerson, Person>, PersonBuilder>();
            services.AddScoped<IModelBuilder<SWApiPlanet, Planet>, PlanetBuilder>();

            services.AddScoped<ISWApiPersonService, SWApiPersonService>();
            services.AddScoped<ISWApiPlanetService, SWApiPlanetService>();

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using StarWarsApp.ExternalService.StarWarsApi.ServiceRouter;

namespace StarWarsApp.ExternalService.StarWarsApi.DependencyInjection
{
    public static class ServiceInjection
    {
        public static IServiceCollection InjectStarWarsApiService(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddSingleton<ISWApiServiceRouter, SWApiServiceRouter>();

            return services;
        }
    }
}

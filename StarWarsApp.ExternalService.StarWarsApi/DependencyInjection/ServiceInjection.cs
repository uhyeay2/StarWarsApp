using Microsoft.Extensions.DependencyInjection;

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

            services.AddScoped<ISWApiServiceRouter, ServiceRouter.SWApiServiceRouter>();

            return services;
        }
    }
}

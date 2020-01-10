using Microsoft.Extensions.DependencyInjection;

namespace NoJS.Storage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNoJSLocalStorage(this IServiceCollection services)
        {
            return services
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<ISyncLocalStorageService, LocalStorageService>();
        }
    }
}
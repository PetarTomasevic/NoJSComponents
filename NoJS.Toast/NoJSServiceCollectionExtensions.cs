using Microsoft.Extensions.DependencyInjection;
using NoJS.Toast.Services;

namespace NoJS.Toast
{
    public static class NoJSServiceCollectionExtensions
    {
        public static IServiceCollection AddNoJSToast(this IServiceCollection services)
        {
            return services.AddScoped<INoJSToastService, NoJSToastService>();
        }
    }
}

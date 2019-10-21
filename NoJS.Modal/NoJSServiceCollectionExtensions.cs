using Microsoft.Extensions.DependencyInjection;
using NoJS.Modal.Services;

namespace NoJS.Modal
{
    public static class NoJSServiceCollectionExtensions
    {
        public static IServiceCollection AddNoJSModal(this IServiceCollection services)
        {
            return services.AddScoped<INoJSModalService, NoJSModalService>();
        }
    }
}

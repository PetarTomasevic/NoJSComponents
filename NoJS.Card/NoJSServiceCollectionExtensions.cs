using Microsoft.Extensions.DependencyInjection;
using NoJS.Card.Services;

namespace NoJS.Card
{
    public static class NoJSServiceCollectionExtensions
    {
        public static IServiceCollection AddNoJSCard(this IServiceCollection services)
        {
            return services.AddScoped<INoJSCardService, NoJSCardService>();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using NoJS.Video.Data;
using NoJS.Video.Services;

namespace NoJS.Modal
{
    public static class NoJSServiceCollectionExtensions
    {
        public static IServiceCollection AddNoJSVideo(this IServiceCollection services)
        {
            return services.AddScoped<INoJSVideoService, NoJSVideoService>().AddScoped<TrackItem>();
        }
    }
}
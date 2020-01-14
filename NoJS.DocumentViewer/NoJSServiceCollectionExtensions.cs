using Microsoft.Extensions.DependencyInjection;
using NoJS.DocumentViewer.Services;

namespace NoJS.DocumentViewer
{
    public static class NoJSServiceCollectionExtensions
    {
        public static IServiceCollection AddNoJSDocumentViewer(this IServiceCollection services)
        {
            return services.AddScoped<NoJSDocumentViewerService>();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using SitecoreDemo.Feature.Content.Controllers;

namespace SitecoreDemo.Feature.Content
{
    public class ContentConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ContentController>();
        }
    }
}
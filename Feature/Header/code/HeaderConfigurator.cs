using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using SitecoreDemo.Feature.Header.Controllers;

namespace SitecoreDemo.Feature.Header
{
    public class HeaderConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<HeaderController>();
            serviceCollection.AddTransient<SearchController>();
        }
    }
}
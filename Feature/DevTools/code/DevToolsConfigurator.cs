using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using SitecoreDemo.Feature.DevTools.Controllers;

namespace SitecoreDemo.Feature.DevTools
{
public class DevToolsConfigurator : IServicesConfigurator
{
    public void Configure(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<DevToolsController>();
    }
}
}

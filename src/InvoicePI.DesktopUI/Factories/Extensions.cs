using InvoicePI.DesktopUI.Factories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace InvoicePI.DesktopUI.Factories;

public static class Extensions
{
    public static IServiceCollection AddFactories(this IServiceCollection services)
    {
        services.AddScoped<IViewFactory, ViewFactory>();

        return services;
    }
}

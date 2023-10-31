using InvoicePI.DesktopUI.Views.Modules;
using Microsoft.Extensions.DependencyInjection;
using InvoicePI.DesktopUI.Views.Modules.Customers;
using InvoicePI.DesktopUI.Views.Main;
using InvoicePI.DesktopUI.Views.Customers;
using InvoicePI.DesktopUI.Views.Products;
using InvoicePI.DesktopUI.Views.Invoices;
using InvoicePI.DesktopUI.Views.Config;

namespace InvoicePI.DesktopUI.Views;

public static class Extensions
{
    public static IServiceCollection AddViews(this IServiceCollection services)
    {
        services.AddTransient<IConnectionConfigView, ConnectionConfigView>();
        services.AddTransient<IObjectGenerationView, ObjectGenerationView>();
        services.AddTransient<IMainView, MainView>();

        services.AddTransient<ICustomersView, CustomersView>();
        services.AddTransient<ICustomerView, CustomerView>();

        services.AddTransient<IProductsView, ProductsView>();
        services.AddTransient<IProductView, ProductView>();

        services.AddTransient<IInvoicesView, InvoicesView>();
        services.AddTransient<IInvoiceView, InvoiceView>();

        return services;
    }
}
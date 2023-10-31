using FluentValidation;
using InvoicePI.Application.Commands.Customers.AddCustomer;
using InvoicePI.Application.Commands.Customers.EditCusotmer;
using InvoicePI.Application.Commands.Products.AddProduct;
using InvoicePI.Application.Validation.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace InvoicePI.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(executingAssembly));

        services.AddScoped<IValidator<AddCustomerCommand>, AddCustomerCommandValidator>();
        services.AddScoped<IValidator<EditCustomerCommand>, EditCustomerCommandValidator>();
        services.AddScoped<IValidator<AddProductCommand>, AddProductCommandValidator>();
        services.AddScoped<IValidator<EditProductCommand>, EditProductCommandValidator>();

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CommandValidationBehavior<,>));

        return services;
    }
}

﻿using InvoicePI.Domain.Abstractions;
using InvoicePI.Infrastructure.Constatns;
using InvoicePI.Infrastructure.Context;
using InvoicePI.Infrastructure.Converters;
using InvoicePI.Infrastructure.Database;
using InvoicePI.Infrastructure.DataGeneration;
using InvoicePI.Infrastructure.Reports;
using InvoicePI.Infrastructure.Repositories;
using InvoicePI.Infrastructure.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog.Web;

namespace InvoicePI.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICustomerReadOnlyRepository, CustomerReadOnlyRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICountryReadOnlyRepository, CountryReadOnlyRepository>();
        services.AddScoped<IProductReadOnlyRepository, ProductReadOnlyRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUnitReadOnlyRepository, UnitReadOnlyRepository>();
        services.AddScoped<IVatRateReadOnlyRepository, VatRateReadOnlyRepository>();
        services.AddScoped<ICurrencyReadOnlyRepository, CurrencyReadOnlyRepository>();
        services.AddScoped<ICurrencyConverter, CurrencyConverter>();
        services.AddScoped<IExchangeRateReadOnlyRepository, ExchangeRateReadOnlyRepository>();
        services.AddScoped<IInvoiceReadOnlyRepository, InvoiceReadOnlyRepository>();
        services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        services.AddScoped<IReportRepository, ReportRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<InvoiceDbContext>(ctx => ctx.UseSqlServer(GetConnectionString(configuration)));
        services.AddScoped<DatabaseInitializer>();
        services.AddScoped<DataGenerator>();
        services.AddScoped<IReportGenerator, PdfReportGenerator>();
        services.AddHtmlToPdf();
        services.AddRazorLightEngine();

        return services;
    }

    public static string GetConnectionString(IConfiguration configuration)
    {
        string server = configuration[ConnectionStringConstatns.Server];
        string database = configuration[ConnectionStringConstatns.Database];
        bool integratedLogin = bool.Parse(configuration[ConnectionStringConstatns.IntegratedLogin]);
        string user = configuration[ConnectionStringConstatns.User];
        string password = PasswordEncryptor.DecryptPassword(configuration[ConnectionStringConstatns.Password]);

        if (string.IsNullOrEmpty(server) && string.IsNullOrEmpty(database))
            return string.Empty;

        if (integratedLogin)
            return $"Server={server};Initial Catalog={database};Integrated Security=True;TrustServerCertificate=True";
        else
            return $"Server={server};Initial Catalog={database};User Id={user};Password={password};TrustServerCertificate=True;";
    }

}

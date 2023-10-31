using DevExpress.Mvvm.POCO;
using DevExpress.Xpo.Logger.Transport;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using InvoicePI.DesktopUI.Handlers.Enums;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.Infrastructure.Database;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace InvoicePI.DesktopUI.Handlers;

public class DatabaseStructureHandler : IHandler
{
    public IHost Host { get; }
    public IConfiguration Configuration { get; }

    private IHandler _nextHandler;
    private readonly DatabaseInitializer _databaseInitializer;

    public DatabaseStructureHandler(IHost host, IConfiguration configuration)
    {
        Host = host;
        Configuration = configuration;

        _databaseInitializer = Host.Services.GetRequiredService<DatabaseInitializer>();
    }

    public IHandler SetNextHandler(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public void HandleRequest()
    {
        if (CanHandle())
        {
            _databaseInitializer.MigrateDatabase();

            _nextHandler.HandleRequest();
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest();
        }
    }


    private bool CanHandle()
        => _databaseInitializer.AnyMigrationsPending();
}
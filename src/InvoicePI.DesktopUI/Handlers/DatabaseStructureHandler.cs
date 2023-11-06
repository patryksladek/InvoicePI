using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Handlers;

public class DatabaseStructureHandler : IHandler
{
    private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

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
            try
            {
                _databaseInitializer.MigrateDatabase();
            }
            catch (Exception ex)
            {
                _logger.Error($"Message:{ex.Message}, StackTrace:{ex.StackTrace}");
                XtraMessageBox.Show(Resources.UnexpectedErrorText, Resources.UnexpectedErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
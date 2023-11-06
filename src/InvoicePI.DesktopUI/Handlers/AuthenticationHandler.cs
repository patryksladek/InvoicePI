using DevExpress.XtraEditors;
using DevExpress.XtraReports.Serialization;
using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using NLog.Fluent;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;

namespace InvoicePI.DesktopUI.Handlers;

public class AuthenticationHandler : IHandler
{
    private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();
   
    public IHost Host { get; }
    public IConfiguration Configuration { get; }
    
    private IHandler _nextHandler;

    public AuthenticationHandler(IHost host, IConfiguration configuration)
    {
        Host = host;
        Configuration = configuration;
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
            var viewFactory = Host.Services.GetRequiredService<IViewFactory>();
            var connectionConfigView = viewFactory.GetView(ModuleType.ConnectionConfig) as IConnectionConfigView;

            try
            {
                WinForms.Application.Run((ConnectionConfigView)connectionConfigView);
            }
            catch (Exception ex)
            {
                _logger.Error($"Message:{ex.Message}, StackTrace:{ex.StackTrace}");
                XtraMessageBox.Show(Resources.UnexpectedErrorText, Resources.UnexpectedErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //If the user enters the correct authentication data into the database server,
            //we must restart the application in order to properly configure the DbContext class.
            if (connectionConfigView.IsAuthentication)
            {
                WinForms.Application.Restart();
                Environment.Exit(0);
            }
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest();
        }
    }

    private bool CanHandle()
    {
        var settingsManager = Host.Services.GetRequiredService<SettingsManager>();
        return !settingsManager.IsConnectionStringInitialized();
    }
}

using DevExpress.XtraEditors;
using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;

namespace InvoicePI.DesktopUI.Handlers;

public class MainFormHandler : IHandler
{
    private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

    public IHost Host { get; }
    public IConfiguration Configuration { get; }

    private IHandler _nextHandler;

    public MainFormHandler(IHost host, IConfiguration configuration)
    {
        Host = host;
        Configuration = configuration;
    }

    public IHandler SetNextHandler(IHandler handler)
    {
        throw new NotImplementedException("This is the last handler in the chain.");
    }

    public void HandleRequest()
    {
        var viewFactory = Host.Services.GetRequiredService<IViewFactory>();
        var mainView = viewFactory.GetView(ModuleType.Main);

        try
        {
            WinForms.Application.Run((MainView)mainView);
        }
        catch (Exception ex)
        {
            _logger.Error($"Message:{ex.Message}, StackTrace:{ex.StackTrace}");
            XtraMessageBox.Show(Resources.UnexpectedErrorText, Resources.UnexpectedErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

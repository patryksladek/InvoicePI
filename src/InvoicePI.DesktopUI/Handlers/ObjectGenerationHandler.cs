using DevExpress.XtraEditors;
using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Views.Config;
using InvoicePI.Infrastructure.DataGeneration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;

namespace InvoicePI.DesktopUI.Handlers;

public class ObjectGenerationHandler : IHandler
{
    private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

    public IHost Host { get; }
    public IConfiguration Configuration { get; }

    private IHandler _nextHandler;
    private readonly DataGenerator _dataGenerator;

    public ObjectGenerationHandler(IHost host, IConfiguration configuration)
    {
        Host = host;
        Configuration = configuration;

        _dataGenerator = Host.Services.GetRequiredService<DataGenerator>();
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
            var objectGenerationView = viewFactory.GetView(ModuleType.ObjectGeneration) as IObjectGenerationView;
            objectGenerationView.DataGenerator = _dataGenerator;

            try
            {
                WinForms.Application.Run((ObjectGenerationView)objectGenerationView);
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
        => _dataGenerator.IsNoData();
}

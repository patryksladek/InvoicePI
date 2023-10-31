using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using InvoicePI.DesktopUI.Handlers.Enums;
using InvoicePI.DesktopUI.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WinForms = System.Windows.Forms;

namespace InvoicePI.DesktopUI.Handlers;

public class MainFormHandler : IHandler
{
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

        WinForms.Application.Run((MainView)mainView);
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace InvoicePI.DesktopUI.Handlers.Abstractions;

public interface IHandler
{
    IHost Host { get; }
    IConfiguration Configuration { get; }
    IHandler SetNextHandler(IHandler handler);
    void HandleRequest();
}

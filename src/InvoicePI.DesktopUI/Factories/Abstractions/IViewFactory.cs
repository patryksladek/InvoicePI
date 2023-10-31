using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Views.Abstractions;

namespace InvoicePI.DesktopUI.Factories.Abstractions;

public interface IViewFactory
{
    IView GetView(ModuleType moduleType);
}
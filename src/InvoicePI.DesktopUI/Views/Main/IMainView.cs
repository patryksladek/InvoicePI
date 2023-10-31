using InvoicePI.DesktopUI.Views.Abstractions;
using System;

namespace InvoicePI.DesktopUI.Views.Main;

public interface IMainView : IView
{
    event EventHandler OfficeNavigationBarItemClickedEventRaised;
}

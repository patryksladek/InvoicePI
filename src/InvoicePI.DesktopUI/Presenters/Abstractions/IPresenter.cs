using InvoicePI.DesktopUI.Views.Abstractions;

namespace InvoicePI.DesktopUI.Presenters.Abstractions;

public interface IPresenter<TView>
    where TView : IView
{
    TView View { get; }
}

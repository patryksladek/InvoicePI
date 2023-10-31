using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Views.Main;
using InvoicePI.DesktopUI.Views.Modules;
using MediatR;
using System;
using InvoicePI.DesktopUI.Factories.Abstractions;
using DevExpress.XtraBars.Navigation;
using InvoicePI.DesktopUI.Views;
using InvoicePI.DesktopUI.Extensions;
using InvoicePI.DesktopUI.Views.Products;
using InvoicePI.DesktopUI.Views.Invoices;
using InvoicePI.DesktopUI.Settings;

namespace InvoicePI.DesktopUI.Presenters.Main;

public class MainPresenter : IPresenter<IMainView>
{
    private readonly IMainView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public IMainView View => _view;

    public MainPresenter(IMainView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
        OpenDefaultTab();
    }

    private void SubscribeToEventsSetup()
    {
        _view.OfficeNavigationBarItemClickedEventRaised += new EventHandler(OnOfficeNavigationBarItemClickedEventRaised);
    }

    private void OnOfficeNavigationBarItemClickedEventRaised(object sender, EventArgs e)
    {
        ModuleType moduleType = (ModuleType)Enum.Parse(typeof(ModuleType), (e as NavigationBarItemEventArgs).Item.Tag.ToString(), true);
        var view = _viewFactory.GetView(moduleType);
        switch (moduleType)
        {
            case ModuleType.Invoices:
                ((MainView)sender).OpenTab(view as InvoicesView);
                break;
            case ModuleType.Customers:
                ((MainView)sender).OpenTab(view as CustomersView);
                break;
            case ModuleType.Products:
                ((MainView)sender).OpenTab(view as ProductsView);
                break;
        }
    }

    private void OpenDefaultTab()
        => ((MainView)_view).OpenTab(_viewFactory.GetView(ModuleType.Invoices) as InvoicesView);
}

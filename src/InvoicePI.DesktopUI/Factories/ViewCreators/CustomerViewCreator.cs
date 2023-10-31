using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Customers;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.DesktopUI.Views.Customers;
using MediatR;
using System;

namespace InvoicePI.DesktopUI.Factories.ViewCreators;

public class CustomerViewCreator : ViewCreatorBase
{
    public CustomerViewCreator(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider) : base(mediator, viewFactory, serviceProvider)
    {
    }

    public override IView GetView()
        => CreateView<ICustomerView, CustomerPresenter>();

}

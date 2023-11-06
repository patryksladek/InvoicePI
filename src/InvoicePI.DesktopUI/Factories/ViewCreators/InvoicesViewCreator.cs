using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Invoices;
using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.DesktopUI.Views.Invoices;
using MediatR;
using System;

namespace InvoicePI.DesktopUI.Factories.ViewCreators;

public class InvoicesViewCreator : ViewCreatorBase
{
    public InvoicesViewCreator(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider) : base(mediator, viewFactory, serviceProvider)
    {
    }
    public override IView GetView()
        => CreateView<IInvoicesView, InvoicesPresenter>();
}

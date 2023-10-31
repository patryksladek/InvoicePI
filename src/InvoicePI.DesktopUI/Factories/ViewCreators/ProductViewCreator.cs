using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Customers;
using InvoicePI.DesktopUI.Presenters.Products;
using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.DesktopUI.Views.Customers;
using InvoicePI.DesktopUI.Views.Modules;
using InvoicePI.DesktopUI.Views.Products;
using MediatR;
using System;

namespace InvoicePI.DesktopUI.Factories.ViewCreators;

public class ProductViewCreator : ViewCreatorBase
{
    public ProductViewCreator(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider) : base(mediator, viewFactory, serviceProvider)
    {
    }
    public override IView GetView()
        => CreateView<IProductView, ProductPresenter>();

}

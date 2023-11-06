using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Products;
using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.DesktopUI.Views.Products;
using MediatR;
using System;

namespace InvoicePI.DesktopUI.Factories.ViewCreators;

public class ProductsViewCreator : ViewCreatorBase
{
    public ProductsViewCreator(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider) : base(mediator, viewFactory, serviceProvider)
    {
    }
    public override IView GetView()
        => CreateView<IProductsView, ProductsPresenter>();
}

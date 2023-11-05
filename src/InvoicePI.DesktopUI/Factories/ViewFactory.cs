using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Factories.ViewCreators;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Abstractions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InvoicePI.DesktopUI.Factories;

public class ViewFactory : IViewFactory
{
    private readonly IMediator _mediator;
    private readonly IServiceProvider _serviceProvider;

    public ViewFactory(IMediator mediator, IServiceProvider serviceProvider)
    {
        _mediator = mediator;
        _serviceProvider = serviceProvider;
    }

    public IView GetView(ModuleType moduleType)
    {
        ViewCreatorBase viewCreatorBase;

        switch (moduleType)
        {
            case ModuleType.ConnectionConfig:
                viewCreatorBase = new ConnectionConfigCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.ObjectGeneration:
                viewCreatorBase = new ObjectGenerationCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Main:
                viewCreatorBase = new MainViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Invoices:
                viewCreatorBase = new InvoicesViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Invoice:
                viewCreatorBase = new InvoiceViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.InvoiceItem:
                viewCreatorBase = new InvoiceItemViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Customers:
                viewCreatorBase = new CustomersViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Customer:
                viewCreatorBase = new CustomerViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Products:
                viewCreatorBase = new ProductsViewCreator(_mediator, this, _serviceProvider);
                break;
            case ModuleType.Product:
                viewCreatorBase = new ProductViewCreator(_mediator, this, _serviceProvider);
                break;
            default:
                throw new ArgumentException("Invalid argument");
        }

        return viewCreatorBase.GetView();
    }
}

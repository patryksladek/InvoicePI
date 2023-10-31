using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Config;
using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.DesktopUI.Views.Config;
using MediatR;
using System;

namespace InvoicePI.DesktopUI.Factories.ViewCreators;

public class ObjectGenerationCreator : ViewCreatorBase
{
    public ObjectGenerationCreator(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider) : base(mediator, viewFactory, serviceProvider)
    {
    }

    public override IView GetView()
        => CreateView<IObjectGenerationView, ObjectGenerationPresenter>();

}
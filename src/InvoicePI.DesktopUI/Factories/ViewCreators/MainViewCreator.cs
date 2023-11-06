using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Main;
using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.DesktopUI.Views.Main;
using MediatR;
using System;

namespace InvoicePI.DesktopUI.Factories.ViewCreators;

public class MainViewCreator : ViewCreatorBase
{
    public MainViewCreator(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider) : base(mediator, viewFactory, serviceProvider)
    {
    }

    public override IView GetView()
        => CreateView<IMainView, MainPresenter>();
}

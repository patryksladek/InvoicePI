using InvoicePI.DesktopUI.Presenters.Abstractions;
using MediatR;
using System;
using Microsoft.Extensions.DependencyInjection;
using InvoicePI.DesktopUI.Views.Abstractions;

namespace InvoicePI.DesktopUI.Factories.Abstractions;

public abstract class ViewCreatorBase
{
    private readonly IMediator _mediator = null;
    private readonly IViewFactory _viewFactory = null;
    private readonly IServiceProvider _serviceProvider = null;

    public ViewCreatorBase(IMediator mediator, IViewFactory viewFactory, IServiceProvider serviceProvider)
    {
        _mediator = mediator;
        _viewFactory = viewFactory;
        _serviceProvider = serviceProvider;
    }

    public TView CreateView<TView, TPresenter>()
        where TView : IView
        where TPresenter : class, IPresenter<TView>
    {
        var view = _serviceProvider.GetRequiredService<TView>();
        var presenter = Activator.CreateInstance(typeof(TPresenter), view, _viewFactory, _mediator, _serviceProvider) as IPresenter<TView>;
        return presenter.View;
    }

    public abstract IView GetView();
}

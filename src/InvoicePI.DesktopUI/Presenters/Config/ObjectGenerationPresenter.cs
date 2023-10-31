using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Config;
using InvoicePI.Infrastructure.Context;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Presenters.Config;

public class ObjectGenerationPresenter : IPresenter<IObjectGenerationView>
{
    private readonly IObjectGenerationView _view;
    private readonly IServiceProvider _serviceProvider;

    public IObjectGenerationView View => _view;

    public ObjectGenerationPresenter(IObjectGenerationView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _serviceProvider = serviceProvider;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.BtnGenerateDataClickedEventRaised += new EventHandler(OnBtnGenerateDataClickedEventRaised);
        _view.BtnSkipClickedEventRaised += new EventHandler(OnBtnSkipClickedEventRaised);
    }

    private void OnBtnGenerateDataClickedEventRaised(object sender, EventArgs e)
    {
        try
        {
            int customersCount = _view.CustomersCount;
            int productsCount = _view.ProductsCount;
            int invoicesCount = _view.InvoicesCount;

            _view.DataGenerator.GenerateData(customersCount, productsCount, invoicesCount);
            _view.ShowMessage(Resources.DataGenerationSuccessfully, Resources.ObjectGenerationCaption, MessageBoxIcon.Information);
            _view.IsObjectGenerated = true;
        }
        catch (Exception)
        {
            _view.ShowErrorMessage(Resources.DataGenerationFailed);
        }
    }

    private void OnBtnSkipClickedEventRaised(object sender, EventArgs e)
    {
        _view.IsObjectGenerated = true;
    }
}

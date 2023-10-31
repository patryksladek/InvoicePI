using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using FluentValidation.Results;
using InvoicePI.Application.Commands.Customers.AddCustomer;
using InvoicePI.Application.Commands.Customers.EditCusotmer;
using InvoicePI.Application.Commands.Customers.RemoveCustomer;
using InvoicePI.Application.Commands.Invoices.AddInvoice;
using InvoicePI.Application.Commands.Invoices.EditInvoice;
using InvoicePI.Application.Commands.Invoices.RemoveInvoice;
using InvoicePI.Application.Commands.Products.AddProduct;
using InvoicePI.Application.Queries.Customers.GetCustomers;
using InvoicePI.Application.Queries.Invoices.GetProductById;
using InvoicePI.Application.Queries.Products.GetProductById;
using InvoicePI.Application.Queries.Units.GetUnits;
using InvoicePI.Application.Queries.VatRates.GetVatRates;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Helpers;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Invoices;
using InvoicePI.Domain.Entities.Invoices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Presenters.Invoices;

public class InvoicePresenter : IPresenter<IInvoiceView>
{
    private readonly IInvoiceView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public IInvoiceView View => _view;

    public InvoicePresenter(IInvoiceView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.InvoiceViewLoadedEventRaised += new AsyncEventHandler(OnCustomerViewLoadedEventRaised);
        
        _view.BtnSaveItemClickedEventRaised += new AsyncEventHandler(OnBtnSaveItemClickedEventRaised);
        _view.BtnResetChangesItemClickedEventRaised += new AsyncEventHandler(OnBtnResetChangesItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new AsyncEventHandler(OnBtnDeleteItemClickedEventRaised);
        
        _view.TeDateValidatingEventRaised += new AsyncEventHandler(OnTeDateValidatingEventRaised);
        _view.GlueCustomerValidatingEventRaised += new AsyncEventHandler(OnGlueCustomerValidatingEventRaised);

        _view.TeDateEditValueChangedEventRaised += new EventHandler(OnTeDateEditValueChangedEventRaised);
        _view.TeGlueCustomerEditValueChangedEventRaised += new EventHandler(OnTeGlueCustomerEditValueChangedEventRaised);
    }

    private async Task OnCustomerViewLoadedEventRaised(object sender, EventArgs e)
    {
        await InitializeLists();
        await InitializeInvoice();
    }

    private async Task OnBtnSaveItemClickedEventRaised(object sender, EventArgs e)
    {
        if (!_view.InvoiceId.HasValue)
            await AddInvoice();
        else
            await EditInvoice(_view.InvoiceId.Value);

        _view.IsResettableChanges = true;
        _view.IsDeletable = true;
    }

    private async Task OnBtnResetChangesItemClickedEventRaised(object sender, EventArgs e)
    {
        await InitializeInvoice(_view.InvoiceId.Value);
    }

    private async Task OnBtnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        string text = string.Format(Resources.RemoveInvoiceText, _view.InvoiceNumber);
        string caption = string.Format(Resources.RemoveInvoiceCaption);

        DialogResult result = XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            await RemoveInvoice(_view.InvoiceId.Value);
        }
    }

    private async Task InitializeLists()
    {
        _view.InvoiceStatusList = new List<string>()
        {
            InvoiceStatusConstants.Buffer,
            InvoiceStatusConstants.Confirmed
        };
        _view.InvoiceStatus = InvoiceStatusConstants.Buffer;

        var customers = await _mediator.Send(new GetCustomersQuery());
        _view.CustomerList = customers.ToList();

        var currencies = await _mediator.Send(new GetCurrenciesQuery());
        _view.CurrencyList = currencies.ToList();
    }

    private async Task InitializeInvoice()
    {
        if (!_view.InvoiceId.HasValue)
        {
            await InitializeNewInvoice();
            _view.IsResettableChanges = false;
            _view.IsDeletable = false;
        }
        else
        {
            await InitializeInvoice(_view.InvoiceId.Value);

            _view.IsResettableChanges = true;
            _view.IsDeletable = true;
        }

        _view.IsSavable = IsSavable();
    }

    private async Task InitializeNewInvoice()
    {
        _view.InvoiceDate = DateOnly.FromDateTime(DateTime.Today);
        _view.CustomerId = null;

        _view.IsResettableChanges = false;
        _view.IsDeletable = false;

        await Task.CompletedTask;
    }

    private async Task InitializeInvoice(int invoiceId)
    {
        var invoice = await _mediator.Send(new GetInvoiceByIdQuery(_view.InvoiceId.Value));
        
        _view.InvoiceNumber = invoice.Number;
        _view.InvoiceDate = invoice.Date;
        _view.CustomerId = invoice.CustomerId;
        _view.Description = invoice.Description;
        _view.InvoiceStatus = invoice.IsApproved ? InvoiceStatusConstants.Confirmed : InvoiceStatusConstants.Buffer;
        _view.CurrencyId = invoice.CurrencyId;

        var invoiceItems = invoice.InvoiceItems.ToList();
        _view.InvoiceItemList = invoiceItems;
        _view.Net = invoiceItems.Sum(x => x.Net);
        _view.Vat = invoiceItems.Sum(x => x.Vat);
        _view.Gross = invoiceItems.Sum(x => x.Gross);
    }

    private async Task AddInvoice()
    {
        var command = new AddInvoiceCommand()
        {
            Number = _view.InvoiceNumber,
            Date = _view.InvoiceDate,
            CustomerId = _view.CustomerId.Value,
            Description = _view.Description,
            Net = _view.Net,
            Vat = _view.Vat,
            Gross = _view.Gross,
            IsApproved = _view.InvoiceStatus == InvoiceStatusConstants.Confirmed ? true : false,
        };

        try
        {
            var invoice = await _mediator.Send(command);
            _view.InvoiceId = invoice.Id;
            _view.InvoiceNumber = invoice.Number;
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private async Task EditInvoice(int invoiceId)
    {
        var command = new EditInvoiceCommand()
        {
            Id = invoiceId,
            Date = _view.InvoiceDate,
            CustomerId = _view.CustomerId.Value,
            Description = _view.Description,
            Net = _view.Net,
            Vat = _view.Vat,
            Gross = _view.Gross,
            IsApproved = _view.InvoiceStatus == InvoiceStatusConstants.Confirmed ? true : false,
        };

        try
        {
            await _mediator.Send(command);
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private async Task RemoveInvoice(int invoiceId)
    {
        var command = new RemoveInvoiceCommand(invoiceId);

        try
        {
            await _mediator.Send(command);
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private void OnTeDateEditValueChangedEventRaised(object sender, EventArgs e)
        => _view.IsSavable = IsSavable();

    private void OnTeGlueCustomerEditValueChangedEventRaised(object sender, EventArgs e)
        => _view.IsSavable = IsSavable();

    private bool IsSavable()
    {
        if (_view.InvoiceStatus == InvoiceStatusConstants.Confirmed)
            return false;

        return true;
    }

    private async Task OnGlueCustomerValidatingEventRaised(object sender, EventArgs e)
    {
        await Task.CompletedTask;
    }

    private async Task OnTeDateValidatingEventRaised(object sender, EventArgs e)
    {
        await Task.CompletedTask;
    }
}

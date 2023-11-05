using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using InvoicePI.Application.Commands.Invoices.AddInvoice;
using InvoicePI.Application.Commands.Invoices.EditInvoice;
using InvoicePI.Application.Commands.Invoices.RemoveInvoice;
using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Currencies.ConvertCurrency;
using InvoicePI.Application.Queries.Customers.GetCustomers;
using InvoicePI.Application.Queries.Invoices.GetProductById;
using InvoicePI.Application.Queries.VatRates.GetVatRates;
using InvoicePI.Application.Validation.Constatns;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Helpers;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Views.Invoices;
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
        _view.BtnConfirmAndCloseItemClicedEventRaised += new AsyncEventHandler(OnBtnConfirmAndCloseItemClicedEventRaised);
        _view.BtnResetChangesItemClickedEventRaised += new AsyncEventHandler(OnBtnResetChangesItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new AsyncEventHandler(OnBtnDeleteItemClickedEventRaised);

        _view.GlueCustomerValidatingEventRaised += new EventHandler(OnGlueCustomerValidatingEventRaised);
        _view.GvInvoiceItemsRowCountChanged += new EventHandler(OnGcInvoiceItemsDataSourceChanged);
        _view.GlueCustomerEditValueChanged += new EventHandler(OnGlueCustomerEditValueChangedEventRaised);

        _view.BtnNewItemClickedEventRaised += new EventHandler(OnBtnNewItemClickedEventRaised);
        _view.BtnOpenItemClickedEventRaised += new EventHandler(OnBtnOpenItemClickedEventRaised);
        _view.BtnRemoveItemClickedEventRaised += new EventHandler(OnRemoveItemClickedEventRaised);
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

    private async Task OnBtnConfirmAndCloseItemClicedEventRaised(object sender, EventArgs e)
    {
        _view.InvoiceStatus = InvoiceStatusConstants.Confirmed;
        await OnBtnSaveItemClickedEventRaised(sender, e);
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

    private void OnBtnNewItemClickedEventRaised(object sender, EventArgs e)
    {
        var view = _viewFactory.GetView(ModuleType.InvoiceItem) as InvoiceItemView;
        view.ViewName = string.Format(Resources.AddInvoiceItemCaption);
        view.InvoiceDate = _view.InvoiceDate;
        view.InvoiceItemList = _view.InvoiceItemList;
        view.CalculateInvoiceItemsSummary += CalculateSummary;
        view.ShowDialog();
    }

    private void OnBtnOpenItemClickedEventRaised(object sender, EventArgs e)
    {
        var invoiceItemDetail = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as InvoiceItemDetailDto;

        var view = _viewFactory.GetView(ModuleType.InvoiceItem) as InvoiceItemView;
        view.ViewName = string.Format(Resources.EditInvoiceItemCaption, invoiceItemDetail.OrdinalNumber, invoiceItemDetail.Product);
        view.InvoiceItem = invoiceItemDetail;
        view.InvoiceDate = _view.InvoiceDate;
        view.InvoiceItemList = _view.InvoiceItemList;
        view.CalculateInvoiceItemsSummary += CalculateSummary;
        view.ShowDialog();
    }

    private void OnRemoveItemClickedEventRaised(object sender, EventArgs e)
    {
        var invoiceItemDetail = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as InvoiceItemDetailDto;

        string text = string.Format(Resources.RemoveInvoiceItemText, invoiceItemDetail.OrdinalNumber, invoiceItemDetail.Product);
        string caption = string.Format(Resources.RemoveInvoiceItemCaption);

        DialogResult result = XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
            _view.InvoiceItemList.Remove(invoiceItemDetail);

        int ordinalNumber = 1;
        foreach (var invoiceItem in _view.InvoiceItemList)
        {
            invoiceItem.OrdinalNumber = ordinalNumber;
            ordinalNumber++;
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
        _view.CurrencyId = currencies.Single(x => x.Symbol == DefaultValueConstants.CurrencySymbol).Id;
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

            if (_view.InvoiceStatus == InvoiceStatusConstants.Confirmed)
            {
                _view.IsDeletable = false;
                _view.IsResettableChanges = false;
            }
            else
            {
                _view.IsDeletable = true;
                _view.IsResettableChanges = true;
            }
        }

        _view.IsSavable = IsSavable();
        _view.IsEditableItems = IsEditableItems();
    }

    private async Task InitializeNewInvoice()
    {
        _view.InvoiceDate = DateOnly.FromDateTime(DateTime.Today);
        _view.CustomerId = 0;

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
        _view.InvoiceItemList = invoice.InvoiceItems.ToList();

        await CalculateSummary();
    }

    private async Task AddInvoice()
    {
        var command = new AddInvoiceCommand()
        {
            Date = _view.InvoiceDate,
            CustomerId = _view.CustomerId,
            Description = _view.Description,
            Net = _view.Net,
            Vat = _view.Vat,
            Gross = _view.Gross,
            IsApproved = _view.InvoiceStatus == InvoiceStatusConstants.Confirmed ? true : false,
            CurrencyId = _view.CurrencyId,
            InvoiceItems = _view.InvoiceItemList.Select(x => new AddInvoiceItemCommand()
            {
                OrdinalNumber = x.OrdinalNumber,
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                Price = x.Price,
                Net = x.Net,
                Gross = x.Gross,
                CurrencyId = x.CurrencyId,
                VatRateId = x.VatRateId,
            })
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
            CustomerId = _view.CustomerId,
            Description = _view.Description,
            Net = _view.Net,
            Vat = _view.Vat,
            Gross = _view.Gross,
            IsApproved = _view.InvoiceStatus == InvoiceStatusConstants.Confirmed ? true : false,
            InvoiceItems = _view.InvoiceItemList.Select(x => new EditInvoiceItemCommand()
            {
                Id = x.Id,
                OrdinalNumber = x.OrdinalNumber,
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                Price = x.Price,
                Net = x.Net,
                Gross = x.Gross,
                CurrencyId = x.CurrencyId,
                VatRateId = x.VatRateId,
            })
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

    private void OnGcInvoiceItemsDataSourceChanged(object sender, EventArgs e)
    {
        _view.IsSavable = IsSavable();
        _view.IsEditableItems = IsEditableItems();
    }

    private void OnGlueCustomerEditValueChangedEventRaised(object sender, EventArgs e)
        => _view.IsSavable = IsSavable();

    private bool IsSavable()
    {
        if (_view.InvoiceStatus == InvoiceStatusConstants.Confirmed)
            return false;

        if (_view.CustomerId == 0)
            return false;

        if (_view.InvoiceItemList.Count == 0)
            return false;

        return true;
    }

    private bool IsEditableItems()
    {
        if (_view.InvoiceStatus == InvoiceStatusConstants.Confirmed)
            return false;

        if (_view.InvoiceItemList.Count == 0)
            return false;

        return true;
    }
        

    private void OnGlueCustomerValidatingEventRaised(object sender, EventArgs e)
    {
        if (_view.CustomerId == 0)
            ErrorHelper.SetErrorMessage(ValidationMessageConstans.NotEmpty, _view, ErrorType.Critical, sender, e);
        else
            ErrorHelper.SetErrorMessage(string.Empty, _view, ErrorType.Critical, sender, e);
    }

    private async Task CalculateSummary()
    {
        decimal summaryNet = 0;
        decimal summaryVat = 0;
        decimal summaryGross = 0;

        foreach (var invoiceItem in _view.InvoiceItemList)
        {
            string fromCurrencySymbol = _view.CurrencyList.Single(x => x.Id == invoiceItem.CurrencyId).Symbol;
            string toCurrencySymbol = _view.CurrencyList.Single(x => x.Id == _view.CurrencyId).Symbol;
            DateTime date = _view.InvoiceDate.ToDateTime(TimeOnly.Parse("00:00"));

            decimal converter = await _mediator.Send(new ConvertCurrencyQuery(fromCurrencySymbol, toCurrencySymbol, date));

            decimal net = invoiceItem.Net * converter;
            summaryNet += net;

            decimal gross = invoiceItem.Gross * converter;
            summaryGross += gross;

            decimal vat = gross - net;
            summaryVat += vat;
        }

        _view.Net = summaryNet;
        _view.Vat = summaryVat;
        _view.Gross = summaryGross;
    }
}

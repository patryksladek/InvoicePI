using DevExpress.XtraEditors;
using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Currencies.ConvertCurrency;
using InvoicePI.Application.Queries.Products.GetProductById;
using InvoicePI.Application.Queries.Products.GetProducts;
using InvoicePI.Application.Queries.VatRates.GetVatRates;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Views.Invoices;
using MediatR;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Presenters.Invoices;

public class InvoiceItemPresenter : IPresenter<IInvoiceItemView>
{
    private readonly IInvoiceItemView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public IInvoiceItemView View => _view;

    public InvoiceItemPresenter(IInvoiceItemView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.InvoiceItemViewLoadedEventRaised += new AsyncEventHandler(OnInvoiceItemViewLoadedEventRaised);

        _view.BtnOKItemClickedEventRaised += new EventHandler(OnBtnSaveItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new EventHandler(OnBtnDeleteItemClickedEventRaised);

        _view.GlueProductEditValueChangedEventRaised += new AsyncEventHandler(OnGlueProductEditValueChangedEventRaised);
        _view.TePriceValidatingEventRaised += new AsyncEventHandler(OnTePriceValidatingEventRaised);
        _view.GlueCurrencyEditValueChanged += new AsyncEventHandler(OnGlueCurrencyEditValueChanged);
        _view.SeQuantityEditValueChanged += new AsyncEventHandler(OnSeQuantityEditValueChanged);

    }

    private async Task OnInvoiceItemViewLoadedEventRaised(object sender, EventArgs e)
    {
        await InitializeLists();
        await InitializeInvoiceItem();
    }

    private void OnBtnSaveItemClickedEventRaised(object sender, EventArgs e)
    {
        if (_view.InvoiceItem is null)
        {
            AddInvoiceItem();
            _view.IsDeletable = false;
        }
        else
        {
            EditInvoiceItem(_view.InvoiceItem);
            _view.IsDeletable = true;
        }
    }

    private void OnBtnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        string text = string.Format(Resources.RemoveInvoiceItemText, _view.OrdinalNumber, _view.ProductName);
        string caption = string.Format(Resources.RemoveInvoiceItemCaption);

        DialogResult result = XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            RemoveInvoiceItem(_view.InvoiceItem.OrdinalNumber);
        }
    }

    private async Task InitializeLists()
    {
        var products = await _mediator.Send(new GetProductsQuery());
        _view.ProductList = products.ToList();

        var vatRates = await _mediator.Send(new GetVatRatesQuery());
        _view.VatRateList = vatRates.ToList();

        var currencies = await _mediator.Send(new GetCurrenciesQuery());
        _view.CurrencyList = currencies.ToList();

        var currencySummary = currencies.Single(x => x.Symbol == DefaultValueConstants.CurrencySymbol);
        _view.CurrencySummaryList = currencies.ToList();
        _view.CurrencySummaryId = currencySummary.Id;
    }

    private async Task InitializeInvoiceItem()
    {
        if (_view.InvoiceItem is null)
        {
            _view.IsDeletable = false;
        }
        else
        {
            await InitializeInvoiceItem(_view.InvoiceItem);
            _view.IsDeletable = true;
        }

        _view.IsSavable = IsSavable();
    }

    private async Task InitializeInvoiceItem(InvoiceItemDetailDto invoiceItem)
    {
        _view.TePriceValidatingEventRaised -= new AsyncEventHandler(OnTePriceValidatingEventRaised);
        _view.GlueCurrencyEditValueChanged -= new AsyncEventHandler(OnGlueCurrencyEditValueChanged);
        _view.SeQuantityEditValueChanged -= new AsyncEventHandler(OnSeQuantityEditValueChanged);


        _view.ProductId = invoiceItem.ProductId;
        _view.Quantity = invoiceItem.Quantity;
        _view.CurrencyId = invoiceItem.CurrencyId;
        _view.VatRateId = invoiceItem.VatRateId;

        _view.TePriceValidatingEventRaised += new AsyncEventHandler(OnTePriceValidatingEventRaised);
        _view.GlueCurrencyEditValueChanged += new AsyncEventHandler(OnGlueCurrencyEditValueChanged);
        _view.SeQuantityEditValueChanged += new AsyncEventHandler(OnSeQuantityEditValueChanged);

        await CalculateSummary();
    }

    private void AddInvoiceItem()
    {
        VatRateDto vatRate = _view.VatRateList.Single(x => x.Id == _view.VatRateId);

        InvoiceItemDetailDto invoiceItem = new InvoiceItemDetailDto()
        {
            OrdinalNumber = _view.OrdinalNumber,
            ProductId = _view.ProductId,
            Product = _view.ProductList.Single(x => x.Id == _view.ProductId).Name,
            Quantity = _view.Quantity,
            Price = _view.NetPrice,
            Net = _view.NetPrice * _view.Quantity,
            Gross = (_view.NetPrice * _view.Quantity) + ((_view.NetPrice * _view.Quantity) * vatRate.Value),
            CurrencyId = _view.CurrencyId,
            Currency = _view.CurrencyList.Single(x => x.Id == _view.CurrencyId).Symbol,
            VatRateId = _view.VatRateId,
            VatRate = vatRate.Symbol
        };
        
        _view.InvoiceItemList.Add(invoiceItem);
    }

    private void EditInvoiceItem(InvoiceItemDetailDto invoiceItem)
    {
        VatRateDto vatRate = _view.VatRateList.Single(x => x.Id == _view.VatRateId);

        invoiceItem.ProductId = _view.ProductId;
        invoiceItem.Product = _view.ProductList.Single(x => x.Id == _view.ProductId).Name;
        invoiceItem.Quantity = _view.Quantity;
        invoiceItem.Price = _view.NetPrice;
        invoiceItem.Net = _view.NetPrice * _view.Quantity;
        invoiceItem.Gross = (_view.NetPrice * _view.Quantity) + ((_view.NetPrice * _view.Quantity) * vatRate.Value);
        invoiceItem.CurrencyId = _view.CurrencyId;
        invoiceItem.Currency = _view.CurrencyList.Single(x => x.Id == _view.CurrencyId).Symbol;
        invoiceItem.VatRateId = _view.VatRateId;
        invoiceItem.VatRate = vatRate.Symbol;
    }

    private void RemoveInvoiceItem(int invoiceItemOrdinalNumber)
    {
        InvoiceItemDetailDto invoiceItem = _view.InvoiceItemList.Single(x => x.OrdinalNumber == invoiceItemOrdinalNumber);
        _view.InvoiceItemList.Remove(invoiceItem);

        int ordinalNumber = 1;
        foreach (var invItem in _view.InvoiceItemList)
        {
            invItem.OrdinalNumber = ordinalNumber;
            ordinalNumber++;
        }
    }


    private bool IsSavable()
    {
        return _view.ProductId != 0;
    }

    private async Task OnGlueProductEditValueChangedEventRaised(object sender, EventArgs e)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(_view.ProductId));

        _view.TePriceValidatingEventRaised -= new AsyncEventHandler(OnTePriceValidatingEventRaised);
        _view.GlueCurrencyEditValueChanged -= new AsyncEventHandler(OnGlueCurrencyEditValueChanged);
        _view.SeQuantityEditValueChanged -= new AsyncEventHandler(OnSeQuantityEditValueChanged);

        _view.VatRateId = product.VatRateId;
        _view.CurrencyId = product.CurrencyId;
        _view.NetPrice = product.Price;

        _view.TePriceValidatingEventRaised += new AsyncEventHandler(OnTePriceValidatingEventRaised);
        _view.GlueCurrencyEditValueChanged += new AsyncEventHandler(OnGlueCurrencyEditValueChanged);
        _view.SeQuantityEditValueChanged += new AsyncEventHandler(OnSeQuantityEditValueChanged);

        await CalculateSummary();

        _view.IsSavable = IsSavable();
    }

    private async Task OnSeQuantityEditValueChanged(object sender, EventArgs e)
    {
        await CalculateSummary();
    }

    private async Task OnGlueCurrencyEditValueChanged(object sender, EventArgs e)
    {
        await CalculateSummary();
    }

    private async Task OnTePriceValidatingEventRaised(object sender, EventArgs e)
    {
        await CalculateSummary();
    }

    private async Task CalculateSummary()
    {
        int amount = _view.Quantity;
        string fromCurrencySymbol = _view.CurrencyList.Single(x => x.Id == _view.CurrencyId).Symbol;
        string toCurrencySymbol = _view.CurrencySummaryList.Single(x => x.Id == _view.CurrencySummaryId).Symbol;
        DateTime date = _view.InvoiceDate.ToDateTime(TimeOnly.Parse("00:00"));

        decimal converter = await _mediator.Send(new ConvertCurrencyQuery(fromCurrencySymbol, toCurrencySymbol, date, amount));
        decimal net = _view.NetPrice * converter;
        _view.SummaryNet = net;

        decimal vatRate = _view.VatRateList.Single(x => x.Id == _view.VatRateId).Value;
        decimal vat = net * vatRate;
        _view.SummaryVat = vat;

        decimal gross = net + vat;
        _view.SummaryGross = gross;
    }
}

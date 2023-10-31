using DevExpress.XtraEditors;
using FluentValidation.Results;
using InvoicePI.Application.Commands.Customers.AddCustomer;
using InvoicePI.Application.Commands.Customers.EditCusotmer;
using InvoicePI.Application.Commands.Customers.RemoveCustomer;
using InvoicePI.Application.Commands.Products.AddProduct;
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
using InvoicePI.DesktopUI.Views.Products;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Presenters.Products;

public class ProductPresenter : IPresenter<IProductView>
{
    private readonly IProductView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public IProductView View => _view;

    public ProductPresenter(IProductView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.ProductViewLoadedEventRaised += new AsyncEventHandler(OnCustomerViewLoadedEventRaised);
        
        _view.BtnSaveItemClickedEventRaised += new AsyncEventHandler(OnBtnSaveItemClickedEventRaised);
        _view.BtnResetChangesItemClickedEventRaised += new AsyncEventHandler(OnBtnResetChangesItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new AsyncEventHandler(OnBtnDeleteItemClickedEventRaised);
        
        _view.TeCodeValidatingEventRaised += new AsyncEventHandler(OnTeCodeValidatingEventRaised);
        _view.TeNameValidatingEventRaised += new AsyncEventHandler(OnTeNameValidatingEventRaised);

        _view.TeCodeEditValueChangedEventRaised += new EventHandler(OnTeCodeEditValueChangedEventRaised);
        _view.TeNameEditValueChangedEventRaised += new EventHandler(OnTeNameEditValueChangedEventRaised);
    }

    private async Task OnCustomerViewLoadedEventRaised(object sender, EventArgs e)
    {
        await InitializeLists();
        await InitializeProduct();
    }

    private async Task OnBtnSaveItemClickedEventRaised(object sender, EventArgs e)
    {
        if (!_view.ProductId.HasValue)
            await AddProduct();
        else
            await EditProduct(_view.ProductId.Value);

        _view.IsResettableChanges = true;
        _view.IsDeletable = true;
    }

    private async Task OnBtnResetChangesItemClickedEventRaised(object sender, EventArgs e)
    {
        await InitializeProduct(_view.ProductId.Value);
    }

    private async Task OnBtnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        string text = string.Format(Resources.RemoveCustomerText, _view.ProductName, _view.ProductCode);
        string caption = string.Format(Resources.RemoveCustomerCaption);

        DialogResult result = XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            await RemoveProduct(_view.ProductId.Value);
        }
    }

    private async Task InitializeLists()
    {
        _view.ProductTypeList = new List<string>()
        {
            ProductTypeConstants.Product,
            ProductTypeConstants.Service
        };
        _view.ProductType = ProductTypeConstants.Product;

        _view.ProductBarcodeTypeList = new List<string>()
        {
            ProductBarcodeTypeConstants.EAN13,
            ProductBarcodeTypeConstants.Other,
        };
        _view.ProductBarcodeType = ProductBarcodeTypeConstants.EAN13;

        var units = await _mediator.Send(new GetUnitsQuery());
        _view.UnitList = units.ToList();

        var currencies = await _mediator.Send(new GetCurrenciesQuery());
        _view.CurrencyList = currencies.ToList();

        var vatRates = await _mediator.Send(new GetVatRatesQuery());
        _view.VatRateList = vatRates.ToList();
    }

    private async Task InitializeProduct()
    {
        if (!_view.ProductId.HasValue)
        {
            await InitializeNewProduct();
            _view.IsResettableChanges = false;
            _view.IsDeletable = false;
        }
        else
        {
            await InitializeProduct(_view.ProductId.Value);

            _view.IsResettableChanges = true;
            _view.IsDeletable = true;
        }

        _view.IsSavable = IsSavable();
    }

    private async Task InitializeNewProduct()
    {
        _view.ProductCode = CodeConstants.Next;
        _view.CurrencyId = _view.CurrencyList.Single(x => x.Symbol == DefaultValueConstants.CurrencySymbol).Id;
        _view.UnitId = _view.UnitList.Single(x => x.Code == DefaultValueConstants.UnitCode).Id;
        _view.VatRateId = _view.VatRateList.Single(x => x.Symbol == DefaultValueConstants.VatRateSymbol).Id;

        _view.IsResettableChanges = false;
        _view.IsDeletable = false;

        await Task.CompletedTask;
    }

    private async Task InitializeProduct(int productId)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(_view.ProductId.Value));
        _view.ProductCode = product.Code;
        _view.ProductName = product.Name;
        _view.ProductType = product.ProductType;
        _view.Barcode = product.Barcode;
        _view.ProductBarcodeType = product.ProductBarcodeType;
        _view.CurrencyId = product.CurrencyId;
        _view.UnitId = product.UnitId;
        _view.VatRateId = product.VatRateId;
        _view.NetPrice = product.Price;
    }

    private async Task AddProduct()
    {
        var command = new AddProductCommand()
        {
            Name = _view.ProductName,
            Code = _view.ProductCode,
            ProductType = ProductTypeConstants.GetValue(_view.ProductType),
            Barcode = _view.Barcode,
            ProductBarcodeType = ProductBarcodeTypeConstants.GetValue(_view.ProductBarcodeType),
            CurrencyId = _view.CurrencyId,
            UnitId = _view.UnitId,
            VatRateId = _view.VatRateId,
            Price = _view.NetPrice
        };

        try
        {
            var product = await _mediator.Send(command);
            _view.ProductId = product.Id;
            _view.ProductCode = product.Code;
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private async Task EditProduct(int productId)
    {
        var command = new EditProductCommand()
        {
            Id = productId,
            Name = _view.ProductName,
            Code = _view.ProductCode,
            ProductType = ProductTypeConstants.GetValue(_view.ProductType),
            Barcode = _view.Barcode,
            ProductBarcodeType = ProductBarcodeTypeConstants.GetValue(_view.ProductBarcodeType),
            CurrencyId = _view.CurrencyId,
            UnitId = _view.UnitId,
            VatRateId = _view.VatRateId,
            Price = _view.NetPrice
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

    private async Task RemoveProduct(int customerId)
    {
        var command = new RemoveCustomerCommand(customerId);

        try
        {
            await _mediator.Send(command);
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private void OnTeCodeEditValueChangedEventRaised(object sender, EventArgs e)
        => _view.IsSavable = IsSavable();

    private void OnTeNameEditValueChangedEventRaised(object sender, EventArgs e)
        => _view.IsSavable = IsSavable();

    private bool IsSavable()
        => (!string.IsNullOrEmpty(_view.ProductCode) &&
             !string.IsNullOrEmpty(_view.ProductName));

    private async Task OnTeNameValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.ProductId.HasValue)
            result = await ValidationHelper<AddProductCommand, AddProductCommandValidator>
                .ValidateAsync(x => x.Name, _view.ProductName);
        else
            result = await ValidationHelper<EditProductCommand, EditProductCommandValidator>
                .ValidateAsync(x => x.Name, _view.ProductName);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeCodeValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.ProductId.HasValue)
            result = await ValidationHelper<AddProductCommand, AddProductCommandValidator>
                .ValidateAsync(x => x.Code, _view.ProductCode);
        else
            result = await ValidationHelper<EditProductCommand, EditProductCommandValidator>
                .ValidateAsync(x => x.Code, _view.ProductCode);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }
}

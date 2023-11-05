using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Invoices;

public interface IInvoiceItemView : IView, IError
{
    event AsyncEventHandler InvoiceItemViewLoadedEventRaised;
    event EventHandler BtnOKItemClickedEventRaised;
    event EventHandler BtnDeleteItemClickedEventRaised;

    event AsyncEventHandler GlueProductEditValueChangedEventRaised;
    event AsyncEventHandler TePriceValidatingEventRaised;
    event AsyncEventHandler GlueCurrencyEditValueChanged;
    event AsyncEventHandler SeQuantityEditValueChanged;

    IList<ProductDto> ProductList { get; set; }
    IList<VatRateDto> VatRateList { get; set; }
    IList<CurrencyDto> CurrencyList { get; set; }
    IList<CurrencyDto> CurrencySummaryList { get; set; }

    InvoiceItemDetailDto InvoiceItem { get; set; }
    DateOnly InvoiceDate { get; set; }
    IList<InvoiceItemDetailDto> InvoiceItemList { get; set; }

    int OrdinalNumber { get; set; }
    int ProductId { get; set; }
    string ProductName { get; }
    int VatRateId { get; set; }
    decimal NetPrice { get; set; }
    int CurrencyId { get; set; }
    int Quantity { get; set; }
    decimal SummaryNet { get; set; }
    decimal SummaryVat { get; set; }
    decimal SummaryGross { get; set; }
    int CurrencySummaryId { get; set; }

    // Buttons

    bool IsSavable { set; }
    bool IsDeletable { set; }
}

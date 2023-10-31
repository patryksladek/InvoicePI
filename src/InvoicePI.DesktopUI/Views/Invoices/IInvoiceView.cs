using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Invoices;

public interface IInvoiceView : IView, IError
{
    event AsyncEventHandler InvoiceViewLoadedEventRaised;
    event AsyncEventHandler BtnSaveItemClickedEventRaised;
    event AsyncEventHandler BtnResetChangesItemClickedEventRaised;
    event AsyncEventHandler BtnDeleteItemClickedEventRaised;

    event AsyncEventHandler TeDateValidatingEventRaised;
    event AsyncEventHandler GlueCustomerValidatingEventRaised;

    event EventHandler TeDateEditValueChangedEventRaised;
    event EventHandler TeGlueCustomerEditValueChangedEventRaised;

    public ICollection InvoiceStatusList { get; set; }
    IList<CustomerDto> CustomerList { get; set; }
    IList<CurrencyDto> CurrencyList { get; set; }
    IList<InvoiceItemDetailDto> InvoiceItemList { get; set; }


    int? InvoiceId { get; set; }
    string InvoiceNumber { get; set; }
    DateOnly InvoiceDate { get; set; }
    int? CustomerId { get; set; }
    string Description { get; set; }
    decimal Net { get; set; }
    decimal Vat { get; set; }
    decimal Gross { get; set; }
    string InvoiceStatus { get; set; }
    int CurrencyId { get; set; }


    // Buttons

    bool IsSavable { set; }
    bool IsResettableChanges { set; }
    bool IsDeletable { set; }
}

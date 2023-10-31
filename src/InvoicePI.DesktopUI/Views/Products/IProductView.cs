using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Products;

public interface IProductView : IView, IError
{
    event AsyncEventHandler ProductViewLoadedEventRaised;
    event AsyncEventHandler BtnSaveItemClickedEventRaised;
    event AsyncEventHandler BtnResetChangesItemClickedEventRaised;
    event AsyncEventHandler BtnDeleteItemClickedEventRaised;

    event AsyncEventHandler TeCodeValidatingEventRaised;
    event AsyncEventHandler TeNameValidatingEventRaised;
    event AsyncEventHandler TePriceValidatingEventRaised;

    event EventHandler TeCodeEditValueChangedEventRaised;
    event EventHandler TeNameEditValueChangedEventRaised;
    event EventHandler TePriceEditValueChangedEventRaised;

    IList<UnitDto> UnitList { get; set; }
    IList<CurrencyDto> CurrencyList { get; set; }
    IList<VatRateDto> VatRateList { get; set; }
    ICollection ProductTypeList { get; set; }
    ICollection ProductBarcodeTypeList { get; set; }

    int? ProductId { get; set; }
    string ProductName { get; set; }
    string ProductCode { get; set; }
    string ProductType { get; set; }
    string Barcode { get; set; }
    string ProductBarcodeType { get; set; }
    int CurrencyId { get; set; }
    int UnitId { get; set; }
    int VatRateId { get; set; }
    public decimal NetPrice { get; set; }

    // Buttons

    bool IsSavable { set; }
    bool IsResettableChanges { set; }
    bool IsDeletable { set; }
}

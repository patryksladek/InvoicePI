using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Products;

public interface IProductsView : IView
{
    event EventHandler ProductsViewLoadedEventRaised;
    event EventHandler BtnAddItemClickedEventRaised;
    event EventHandler BtnEditItemClickedEventRaised;
    event EventHandler BtnDeleteItemClickedEventRaised;

    event EventHandler BtnExportXmlItemClickedEventRaised;
    event EventHandler BtnExportCsvItemClickedEventRaised;
    event EventHandler BtnExportXlsxItemClickedEventRaised;
    event EventHandler BtnExportTxtItemClickedEventRaised;

    IList<ProductDto> ProductList { get; set; }
}

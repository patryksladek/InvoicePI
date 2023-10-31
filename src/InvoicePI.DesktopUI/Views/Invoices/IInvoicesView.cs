using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Invoices;

public interface IInvoicesView : IView
{
    event EventHandler InvoicesViewLoadedEventRaised;
    event EventHandler BtnAddItemClickedEventRaised;
    event EventHandler BtnEditItemClickedEventRaised;
    event EventHandler BtnDeleteItemClickedEventRaised;

    event EventHandler BtnExportXmlItemClickedEventRaised;
    event EventHandler BtnExportCsvItemClickedEventRaised;
    event EventHandler BtnExportXlsxItemClickedEventRaised;
    event EventHandler BtnExportTxtItemClickedEventRaised;

    IList<InvoiceDto> InvoiceList { get; set; }
}

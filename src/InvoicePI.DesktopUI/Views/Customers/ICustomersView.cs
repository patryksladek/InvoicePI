using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Customers;

public interface ICustomersView : IView
{
    event AsyncEventHandler CustomersViewLoadedEventRaised;

    event EventHandler BtnAddItemClickedEventRaised;
    event EventHandler BtnEditItemClickedEventRaised;
    event EventHandler BtnDeleteItemClickedEventRaised;

    event EventHandler BtnExportXmlItemClickedEventRaised;
    event EventHandler BtnExportCsvItemClickedEventRaised;

    event AsyncEventHandler BtnGenerateNumberOfContractorsInCountryReportItemClickedEventRaised;
   
    IList<CustomerDto> CustomerList { get; set; }
}

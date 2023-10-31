using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Customers;

public interface ICustomerView : IView, IError
{
    event AsyncEventHandler CustomerViewLoadedEventRaised;
    event AsyncEventHandler BtnSaveItemClickedEventRaised;
    event AsyncEventHandler BtnResetChangesItemClickedEventRaised;
    event AsyncEventHandler BtnDeleteItemClickedEventRaised;

    event AsyncEventHandler TeCodeValidatingEventRaised;
    event AsyncEventHandler TeNameValidatingEventRaised;
    event AsyncEventHandler TeNipValidatingEventRaised;
    event AsyncEventHandler TeStreetValidatingEventRaised;
    event AsyncEventHandler TeStreetNumberValidatingEventRaised;
    event AsyncEventHandler TeBuildingValidatingEventRaised;
    event AsyncEventHandler TeCityValidatingEventRaised;
    event AsyncEventHandler TePostalCodeValidatingEventRaised;
    event AsyncEventHandler TePhoneValidatingEventRaised;
    event AsyncEventHandler TeMobileValidatingEventRaised;
    event AsyncEventHandler TeEmailValidatingEventRaised;
    event AsyncEventHandler TeFaxValidatingEventRaised;

    event EventHandler TeCodeEditValueChangedEventRaised;
    event EventHandler TeNameEditValueChangedEventRaised;

    IList<InvoiceDto> InvoiceList { get; set; }
    IList<CountryDto> CountryList { get; set; }
    ICollection SegmentList { get; set; }
    ICollection StatusList { get; set; }

    int? CustomerId { get; set; }
    string CustomerName { get; set; }
    string CustomerCode { get; set; }
    string CustomerNIP { get; set; }
    string CustomerSegment { get; set; }
    bool CustomerIsActive { get; set; }
    string Street { get; set; }
    string StreetNumber { get; set; }
    string Building { get; set; }
    string PostalCode { get; set; }
    string City { get; set; }
    int CountryId { get; set; }
    string Phone { get; set; }
    string Mobile { get; set; }
    string Email { get; set; }
    string Fax { get; set; }

    // Buttons

    bool IsSavable { set; }
    bool IsResettableChanges { set; }
    bool IsDeletable { set; }

}

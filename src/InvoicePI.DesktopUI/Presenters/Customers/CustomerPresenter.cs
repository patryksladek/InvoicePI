using DevExpress.XtraEditors;
using FluentValidation.Results;
using InvoicePI.Application.Commands.Customers.AddCustomer;
using InvoicePI.Application.Commands.Customers.EditCusotmer;
using InvoicePI.Application.Commands.Customers.RemoveCustomer;
using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Countries.GetCountries;
using InvoicePI.Application.Queries.Customers.GetCustomerById;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Helpers;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Customers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Presenters.Customers;

public class CustomerPresenter : IPresenter<ICustomerView>
{
    private readonly ICustomerView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public ICustomerView View => _view;

    public CustomerPresenter(ICustomerView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.CustomerViewLoadedEventRaised += new AsyncEventHandler(OnCustomerViewLoadedEventRaised);
        
        _view.BtnSaveItemClickedEventRaised += new AsyncEventHandler(OnBtnSaveItemClickedEventRaised);
        _view.BtnResetChangesItemClickedEventRaised += new AsyncEventHandler(OnBtnResetChangesItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new AsyncEventHandler(OnBtnDeleteItemClickedEventRaised);
        
        _view.TeCodeValidatingEventRaised += new AsyncEventHandler(OnTeCodeValidatingEventRaised);
        _view.TeNameValidatingEventRaised += new AsyncEventHandler(OnTeNameValidatingEventRaised);
        _view.TeNipValidatingEventRaised += new AsyncEventHandler(OnTeNipValidatingEventRaised);
        _view.TeStreetValidatingEventRaised += new AsyncEventHandler(OnTeStreetValidatingEventRaised);
        _view.TeStreetNumberValidatingEventRaised += new AsyncEventHandler(OnTeStreetNumberValidatingEventRaised);
        _view.TeBuildingValidatingEventRaised += new AsyncEventHandler(OnTeBuildingValidatingEventRaised);
        _view.TeCityValidatingEventRaised += new AsyncEventHandler(OnTeCityValidatingEventRaised);
        _view.TePostalCodeValidatingEventRaised += new AsyncEventHandler(OnTePostalCodeValidatingEventRaised);
        _view.TePhoneValidatingEventRaised += new AsyncEventHandler(OnTePhoneValidatingEventRaised);
        _view.TeMobileValidatingEventRaised += new AsyncEventHandler(OnTeMobileValidatingEventRaised);
        _view.TeEmailValidatingEventRaised += new AsyncEventHandler(OnTeEmailValidatingEventRaised);
        _view.TeFaxValidatingEventRaised += new AsyncEventHandler(OnTeFaxValidatingEventRaised);

        _view.TeCodeEditValueChangedEventRaised += new EventHandler(OnTeCodeEditValueChangedEventRaised);
        _view.TeNameEditValueChangedEventRaised += new EventHandler(OnTeNameEditValueChangedEventRaised);
    }

    private async Task OnCustomerViewLoadedEventRaised(object sender, EventArgs e)
    {
        await InitializeLists();
        await InitializeCustomer();
    }

    private async Task OnBtnSaveItemClickedEventRaised(object sender, EventArgs e)
    {
        if (!_view.CustomerId.HasValue)
            await AddCustomer();
        else
            await EditCustomer(_view.CustomerId.Value);

        _view.IsResettableChanges = true;
        _view.IsDeletable = true;
    }

    private async Task OnBtnResetChangesItemClickedEventRaised(object sender, EventArgs e)
    {
        await InitializeCustomer(_view.CustomerId.Value);
    }

    private async Task OnBtnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        string text = string.Format(Resources.RemoveCustomerText, _view.CustomerName, _view.CustomerCode);
        string caption = string.Format(Resources.RemoveCustomerCaption);

        DialogResult result = XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            await RemoveCustomer(_view.CustomerId.Value);
        }
    }

    private async Task InitializeLists()
    {
        _view.SegmentList = new List<string>()
        {
            SegmentConstans.Corporate,
            SegmentConstans.Consumer,
            SegmentConstans.HomeOffice,
            SegmentConstans.SmallBusiness
        };

        _view.StatusList = new List<string>()
        {
            StatusConstants.Active,
            StatusConstants.Inactive,
        };

        var countries = await _mediator.Send(new GetCountriesQuery());
        _view.CountryList = countries.ToList();
    }

    private async Task InitializeCustomer()
    {
        if (!_view.CustomerId.HasValue)
        {
            await InitializeNewCustomer();
            _view.IsResettableChanges = false;
            _view.IsDeletable = false;
        }
        else
        {
            await InitializeCustomer(_view.CustomerId.Value);
            _view.IsResettableChanges = true;
            _view.IsDeletable = true;
        }

        _view.IsSavable = IsSavable();
    }

    private async Task InitializeNewCustomer()
    {
        _view.CustomerCode = CodeConstants.Next;
        _view.CustomerIsActive = true;
        _view.CountryId = _view.CountryList.Single(x => x.Symbol == "PL").Id;

        _view.IsResettableChanges = false;
        _view.IsDeletable = false;

        await Task.CompletedTask;
    }

    private async Task InitializeCustomer(int customerId)
    {
        var customer = await _mediator.Send(new GetCustomerByIdQuery(_view.CustomerId.Value));
        _view.CustomerCode = customer.Code;
        _view.CustomerName = customer.Name;
        _view.CustomerNIP = customer.NIP;
        _view.CustomerSegment = customer.Segment;
        _view.CustomerIsActive = customer.IsActive;
        _view.Street = customer.Street;
        _view.StreetNumber = customer.StreetNumber;
        _view.Building = customer.Building;
        _view.City = customer.City;
        _view.PostalCode = customer.PostalCode;
        _view.CountryId = customer.CountryId;
        _view.Phone = customer.Phone;
        _view.Mobile = customer.Mobile;
        _view.Email = customer.Email;
        _view.Fax = customer.Fax;
    }

    private async Task AddCustomer()
    {
        var command = new AddCustomerCommand()
        {
            Name = _view.CustomerName,
            Code = _view.CustomerCode,
            NIP = _view.CustomerNIP,
            Segment = SegmentConstans.GetValue(_view.CustomerSegment),
            IsActive = _view.CustomerIsActive,
            Street = _view.Street,
            StreetNumber = _view.StreetNumber,
            Building = _view.Building,
            City = _view.City,
            PostalCode = _view.PostalCode,
            CountryId = _view.CountryId,
            Phone = _view.Phone,
            Mobile = _view.Mobile,
            Email = _view.Email,
            Fax = _view.Fax
        };

        try
        {
            var customer = await _mediator.Send(command);
            _view.CustomerId = customer.Id;
            _view.CustomerCode = customer.Code;
        }
        catch (Exception ex)
        {
            _view.ShowErrorMessage(ex.Message);
        }
    }

    private async Task EditCustomer(int customerId)
    {
        var command = new EditCustomerCommand()
        {
            Id = customerId,
            Name = _view.CustomerName,
            Code = _view.CustomerCode,
            NIP = _view.CustomerNIP,
            Segment = SegmentConstans.GetValue(_view.CustomerSegment),
            IsActive = _view.CustomerIsActive,
            Street = _view.Street,
            StreetNumber = _view.StreetNumber,
            Building = _view.Building,
            City = _view.City,
            PostalCode = _view.PostalCode,
            CountryId = _view.CountryId,
            Phone = _view.Phone,
            Mobile = _view.Mobile,
            Email = _view.Email,
            Fax = _view.Fax
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

    private async Task RemoveCustomer(int customerId)
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
        => (!string.IsNullOrEmpty(_view.CustomerCode) &&
             !string.IsNullOrEmpty(_view.CustomerName));

    private async Task OnTeNameValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Name, _view.CustomerName);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Name, _view.CustomerName);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeCodeValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Code, _view.CustomerCode);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Code, _view.CustomerCode);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeNipValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.NIP, _view.CustomerNIP);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.NIP, _view.CustomerNIP);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeStreetValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Street, _view.Street);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Street, _view.Street);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeStreetNumberValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.StreetNumber, _view.StreetNumber);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.StreetNumber, _view.StreetNumber);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeBuildingValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Building, _view.Building);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Building, _view.Building);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeCityValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.City, _view.City);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.City, _view.City);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTePostalCodeValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.PostalCode, _view.PostalCode);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.PostalCode, _view.PostalCode);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTePhoneValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Phone, _view.Phone);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Phone, _view.Phone);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeMobileValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Mobile, _view.Mobile);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Mobile, _view.Mobile);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeEmailValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Email, _view.Email);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Email, _view.Email);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

    private async Task OnTeFaxValidatingEventRaised(object sender, EventArgs e)
    {
        ValidationResult result = null;

        if (!_view.CustomerId.HasValue)
            result = await ValidationHelper<AddCustomerCommand, AddCustomerCommandValidator>
                .ValidateAsync(x => x.Fax, _view.Fax);
        else
            result = await ValidationHelper<EditCustomerCommand, EditCustomerCommandValidator>
                .ValidateAsync(x => x.Fax, _view.Fax);

        ErrorHelper.SetErrorMessage(result, _view, sender, e);
    }

}

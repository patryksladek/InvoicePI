using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.DesktopUI.Views.Config;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Presenters.Config;

public class ConnectionConfigPresenter : IPresenter<IConnectionConfigView>
{
    private readonly IConnectionConfigView _view;
    private readonly IServiceProvider _serviceProvider;

    public IConnectionConfigView View => _view;

    public ConnectionConfigPresenter(IConnectionConfigView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _serviceProvider = serviceProvider;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.ConnectionConfigLoadedEventRaised += new EventHandler(OnConnectionConfigLoadedEventRaised);

        _view.BtnValidateConnectionClickedEventRaised += new EventHandler(OnBtnValidateConnectionClickedEventRaised);
        _view.BtnConnectClickedEventRaised += new EventHandler(OnBtnConnectClickedEventRaised);
        _view.CbeAuthenticationEditValueChangedRaised += new EventHandler(OnCbeAuthenticationEditValueChangedRaised);
    }

    private void OnConnectionConfigLoadedEventRaised(object sender, EventArgs e)
    {
        _view.Server = ServerConstants.Localhost;

        _view.AuthenticationList = new List<string>()
        {
            AuthenticationConstants.Windows,
            AuthenticationConstants.SqlServer
        };
        _view.Authentication = AuthenticationConstants.Windows;
    }

    private void OnBtnValidateConnectionClickedEventRaised(object sender, EventArgs e)
    {
        if (!IsValid((ConnectionConfigView)sender))
            return;

        if (IsConnectedToDatabaseServer())
            _view.ShowMessage(Resources.ServerIsConnected, Resources.ValidateConnectionCaption, MessageBoxIcon.Information);
        else
            _view.ShowMessage(Resources.ServerIsNotConnected, Resources.ValidateConnectionCaption, MessageBoxIcon.Error);
    }

    private void OnBtnConnectClickedEventRaised(object sender, EventArgs e)
    {
        if (!IsValid((ConnectionConfigView)sender))
            return;

        if (!IsConnectedToDatabaseServer())
        {
            _view.ShowErrorMessage("The connection to the database server failed. Work with the program is not possible.");
            _view.IsAuthentication = false;
            return;
        }
        
        var settingsManager = _serviceProvider.GetRequiredService<SettingsManager>();
        settingsManager.SetConnectionStringSettings(_view.Server, _view.Authentication, _view.User, _view.Password);
        
        _view.IsAuthentication = true;
    }

    private void OnCbeAuthenticationEditValueChangedRaised(object sender, EventArgs e)
    {
        if (((ComboBoxEdit)sender).EditValue.ToString() == AuthenticationConstants.Windows)
            _view.Authentication = AuthenticationConstants.Windows;
        else
            _view.Authentication = AuthenticationConstants.SqlServer;
    }

    private bool IsConnectedToDatabaseServer()
    {
        try
        {
            string connectionString = null;

            if (_view.Authentication == AuthenticationConstants.Windows)
                connectionString = $"Server={_view.Server};Integrated Security=True;TrustServerCertificate=True";
            else
                connectionString = $"Server={_view.Server};User Id={_view.User};Password={_view.Password};TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }

            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }

    private bool IsValid(ConnectionConfigView connectionConfigView)
    {
        if (string.IsNullOrEmpty(_view.Server))
        {
            Control teServer = connectionConfigView.Controls["teServer"];
            _view.SetErrorMessage(teServer, "Field SERVER NAME is required.", ErrorType.Critical);
            return false;
        }

        if (_view.Authentication == AuthenticationConstants.SqlServer && string.IsNullOrEmpty(_view.User))
        {
            Control teUser = connectionConfigView.Controls["teUser"];
            _view.SetErrorMessage(teUser, "Field USER is required.", ErrorType.Critical);
            return false;
        }

        return true;
    }
}

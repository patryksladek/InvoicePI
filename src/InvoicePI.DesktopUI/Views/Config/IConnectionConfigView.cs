using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Abstractions;
using System;
using System.Collections;

namespace InvoicePI.DesktopUI.Views.Config;

public interface IConnectionConfigView : IView, IMessage, IError
{
    event EventHandler ConnectionConfigLoadedEventRaised;
    event EventHandler BtnValidateConnectionClickedEventRaised;
    event EventHandler BtnConnectClickedEventRaised;
    event EventHandler CbeAuthenticationEditValueChangedRaised;

    ICollection AuthenticationList { get; set; }
    string Server { get; set; }
    string Authentication { get; set; }
    string User { get; set; }
    string Password { get; set; }

    bool IsAuthentication { get; set; }
}

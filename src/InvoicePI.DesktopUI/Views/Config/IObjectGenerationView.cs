using InvoicePI.DesktopUI.Views.Abstractions;
using InvoicePI.Infrastructure.DataGeneration;
using System;

namespace InvoicePI.DesktopUI.Views.Config;

public interface IObjectGenerationView : IView, IMessage, IError
{
    event EventHandler BtnGenerateDataClickedEventRaised;
    event EventHandler BtnSkipClickedEventRaised;

    DataGenerator DataGenerator { get; set; }

    int CustomersCount { get; set; }
    int ProductsCount { get; set; }
    int InvoicesCount { get; set; }

    bool IsObjectGenerated { get; set; }
}

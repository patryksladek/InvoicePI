using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Views.Modules.Customers;
using InvoicePI.Application.Queries.Customers.GetCustomers;
using MediatR;
using System;
using System.Linq;
using System.Threading.Tasks;
using InvoicePI.DesktopUI.Views.Customers;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using InvoicePI.Application.Dto;
using DevExpress.XtraEditors;
using InvoicePI.Application.Commands.Customers.RemoveCustomer;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.Domain.Entities;
using InvoicePI.DesktopUI.Events;
using InvoicePI.Infrastructure.DataExport.Strategies;
using InvoicePI.Infrastructure.DataExport;
using System.Collections.Generic;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.Application.Queries.Reports.GenerateNumberOfCustomersInCountry;
using System.IO;

namespace InvoicePI.DesktopUI.Presenters.Customers;

public class CustomersPresenter : IPresenter<ICustomersView>
{
    private readonly ICustomersView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public ICustomersView View => _view;

    public CustomersPresenter(ICustomersView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.CustomersViewLoadedEventRaised += new AsyncEventHandler(OnCustomersViewLoadedEventRaised);
        
        _view.BtnAddItemClickedEventRaised += new EventHandler(OnBtnAddItemClickedEventRaised);
        _view.BtnEditItemClickedEventRaised += new EventHandler(OnBtnEditItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new EventHandler(OnDeleteItemClickedEventRaised);

        _view.BtnExportXmlItemClickedEventRaised += new EventHandler(OnBtnExportXmlItemClickedEventRaised);
        _view.BtnExportCsvItemClickedEventRaised += new EventHandler(OnBtnExportCsvItemClickedEventRaised);

        _view.BtnGenerateNumberOfContractorsInCountryReportItemClickedEventRaised += new AsyncEventHandler(OnBtnGenerateNumberOfContractorsInCountryReportItemClickedEventRaised);
    }

    private async Task OnCustomersViewLoadedEventRaised(object sender, EventArgs e)
    {
        await UpdateCustomerListViewAsync();
    }

    private void OnBtnAddItemClickedEventRaised(object sender, EventArgs e)
    {
        var view = _viewFactory.GetView(ModuleType.Customer) as CustomerView;
        view.ViewName = string.Format(Resources.AddCustomerCaption);
        view.UpdateCustomerListView += UpdateCustomerListViewAsync;
        view.ShowDialog();
    }

    private void OnBtnEditItemClickedEventRaised(object sender, EventArgs e)
    {
        var customer = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as CustomerDto;

        var view = _viewFactory.GetView(ModuleType.Customer) as CustomerView;
        view.ViewName = string.Format(Resources.EditCustomerCaption, customer.Name);
        view.CustomerId = customer.Id;
        view.UpdateCustomerListView += UpdateCustomerListViewAsync;
        view.ShowDialog();
    }

    private async void OnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        var customer = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as CustomerDto;

        string text = string.Format(Resources.RemoveCustomerText, customer.Name, customer.Code);
        string caption = string.Format(Resources.RemoveCustomerCaption);

        DialogResult result =  XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            await _mediator.Send(new RemoveCustomerCommand(customer.Id));
            await UpdateCustomerListViewAsync();
        }
    }

    private async Task UpdateCustomerListViewAsync()
    {
        var customerList = await _mediator.Send(new GetCustomersQuery());
        _view.CustomerList = customerList.ToList();
    }

    private void OnBtnExportXmlItemClickedEventRaised(object sender, EventArgs e)
    {
        using (XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog())
        {
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataExporter exporter = new DataExporter(new XmlExportStrategy());
                exporter.ExportData(_view.CustomerList, filePath);
            }
        }
    }

    private void OnBtnExportCsvItemClickedEventRaised(object sender, EventArgs e)
    {
        using (XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog())
        {
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataExporter exporter = new DataExporter(new CsvExportStrategy());
                exporter.ExportData(_view.CustomerList, filePath);
            }
        }
    }

    private async Task OnBtnGenerateNumberOfContractorsInCountryReportItemClickedEventRaised(object sender, EventArgs e)
    {
        byte[] pdfBytes = await _mediator.Send(new GenerateCustomersInCountryQuery());

        using (XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog())
        {
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Customers_in_country_{DateTime.Now.ToShortDateString().Replace('.', '_')}";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllBytes(filePath, pdfBytes); ;
            }
        }
    }
}

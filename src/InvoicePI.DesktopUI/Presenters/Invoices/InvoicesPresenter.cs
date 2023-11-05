using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using MediatR;
using System;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using InvoicePI.Application.Dto;
using DevExpress.XtraEditors;
using InvoicePI.Application.Commands.Customers.RemoveCustomer;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Views.Invoices;
using InvoicePI.Application.Queries.Invoices.GetProducts;
using InvoicePI.Application.Commands.Invoices.RemoveInvoice;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.Infrastructure.DataExport.Strategies;
using InvoicePI.Infrastructure.DataExport;

namespace InvoicePI.DesktopUI.Presenters.Invoices;

public class InvoicesPresenter : IPresenter<IInvoicesView>
{
    private readonly IInvoicesView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public IInvoicesView View => _view;

    public InvoicesPresenter(IInvoicesView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.InvoicesViewLoadedEventRaised += new EventHandler(OnCustomersViewLoadedEventRaised);
        _view.BtnAddItemClickedEventRaised += new EventHandler(OnBtnAddItemClickedEventRaised);
        _view.BtnEditItemClickedEventRaised += new EventHandler(OnBtnEditItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new EventHandler(OnDeleteItemClickedEventRaised);
        _view.GvInvoicesFocusedRowChangedEventRaised += new EventHandler(OnGvInvoicesFocusedRowChangedEventRaised);

        _view.BtnExportXmlItemClickedEventRaised += new EventHandler(OnBtnExportXmlItemClickedEventRaised);
        _view.BtnExportCsvItemClickedEventRaised += new EventHandler(OnBtnExportCsvItemClickedEventRaised);
        _view.BtnExportXlsxItemClickedEventRaised += new EventHandler(OnBtnExportXlsxItemClickedEventRaised);
        _view.BtnExportTxtItemClickedEventRaised += new EventHandler(OnBtnExportTxtItemClickedEventRaised);
    }

    private async void OnCustomersViewLoadedEventRaised(object sender, EventArgs e)
    {
        await UpdateInvoiceListViewAsync();
    }

    private void OnBtnAddItemClickedEventRaised(object sender, EventArgs e)
    {
        var view = _viewFactory.GetView(ModuleType.Invoice) as InvoiceView;
        view.ViewName = string.Format(Resources.AddInvoiceCaption);
        view.UpdateInvoiceListView += UpdateInvoiceListViewAsync;
        view.ShowDialog();
    }

    private void OnBtnEditItemClickedEventRaised(object sender, EventArgs e)
    {
        var invoice = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as InvoiceDto;

        var view = _viewFactory.GetView(ModuleType.Invoice) as InvoiceView;
        view.ViewName = string.Format(Resources.EditInvoiceCaption, invoice.Number);
        view.InvoiceId = invoice.Id;
        view.UpdateInvoiceListView += UpdateInvoiceListViewAsync;
        view.ShowDialog();
    }

    private async void OnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        var invoice = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as InvoiceDto;

        string text = string.Format(Resources.RemoveInvoiceText, invoice.Number);
        string caption = string.Format(Resources.RemoveInvoiceCaption);

        DialogResult result =  XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            await _mediator.Send(new RemoveInvoiceCommand(invoice.Id));
            await UpdateInvoiceListViewAsync();
        }
    }

    private void OnGvInvoicesFocusedRowChangedEventRaised(object sender, EventArgs e)
    {
        var invoice = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as InvoiceDto;
        if (invoice != null && invoice.IsApproved)
            _view.IsDeletable = false;
        else
            _view.IsDeletable = true;
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
                exporter.ExportData(_view.InvoiceList, filePath);
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
                exporter.ExportData(_view.InvoiceList, filePath);
            }
        }
    }

    private void OnBtnExportXlsxItemClickedEventRaised(object sender, EventArgs e)
    {
        using (XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog())
        {
            saveFileDialog.Filter = "XLS files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataExporter exporter = new DataExporter(new XlsExportStrategy());
                exporter.ExportData(_view.InvoiceList, filePath);
            }
        }
    }

    private void OnBtnExportTxtItemClickedEventRaised(object sender, EventArgs e)
    {
        using (XtraSaveFileDialog saveFileDialog = new XtraSaveFileDialog())
        {
            saveFileDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataExporter exporter = new DataExporter(new TxtExportStrategy());
                exporter.ExportData(_view.InvoiceList, filePath);
            }
        }
    }

    private async Task UpdateInvoiceListViewAsync()
    {
        var invoiceList = await _mediator.Send(new GetInvoicesQuery());
        _view.InvoiceList = invoiceList.ToList();
    }
}

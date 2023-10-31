using InvoicePI.DesktopUI.Enums;
using InvoicePI.DesktopUI.Factories.Abstractions;
using InvoicePI.DesktopUI.Presenters.Abstractions;
using InvoicePI.DesktopUI.Views.Modules.Customers;
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
using InvoicePI.DesktopUI.Views.Products;
using InvoicePI.Application.Queries.Products.GetProducts;
using InvoicePI.DesktopUI.Settings;
using InvoicePI.Infrastructure.DataExport.Strategies;
using InvoicePI.Infrastructure.DataExport;

namespace InvoicePI.DesktopUI.Presenters.Products;

public class ProductsPresenter : IPresenter<IProductsView>
{
    private readonly IProductsView _view;
    private readonly IViewFactory _viewFactory;
    private readonly IMediator _mediator;

    public IProductsView View => _view;

    public ProductsPresenter(IProductsView view, IViewFactory viewFactory, IMediator mediator, IServiceProvider serviceProvider)
    {
        _view = view;
        _viewFactory = viewFactory;
        _mediator = mediator;

        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _view.ProductsViewLoadedEventRaised += new EventHandler(OnCustomersViewLoadedEventRaised);
        _view.BtnAddItemClickedEventRaised += new EventHandler(OnBtnAddItemClickedEventRaised);
        _view.BtnEditItemClickedEventRaised += new EventHandler(OnBtnEditItemClickedEventRaised);
        _view.BtnDeleteItemClickedEventRaised += new EventHandler(OnDeleteItemClickedEventRaised);

        _view.BtnExportXmlItemClickedEventRaised += new EventHandler(OnBtnExportXmlItemClickedEventRaised);
        _view.BtnExportCsvItemClickedEventRaised += new EventHandler(OnBtnExportCsvItemClickedEventRaised);
        _view.BtnExportXlsxItemClickedEventRaised += new EventHandler(OnBtnExportXlsxItemClickedEventRaised);
        _view.BtnExportTxtItemClickedEventRaised += new EventHandler(OnBtnExportTxtItemClickedEventRaised);
    }

    private async void OnCustomersViewLoadedEventRaised(object sender, EventArgs e)
    {
        await UpdateProductListViewAsync();
    }

    private void OnBtnAddItemClickedEventRaised(object sender, EventArgs e)
    {
        var view = _viewFactory.GetView(ModuleType.Product) as ProductView;
        view.ViewName = string.Format(Resources.AddProductCaption);
        view.UpdateProductListView += UpdateProductListViewAsync;
        view.ShowDialog();
    }

    private void OnBtnEditItemClickedEventRaised(object sender, EventArgs e)
    {
        var product = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as ProductDto;

        var view = _viewFactory.GetView(ModuleType.Product) as ProductView;
        view.ViewName = string.Format(Resources.EditProductCaption, product.Name);
        view.ProductId = product.Id;
        view.UpdateProductListView += UpdateProductListViewAsync;
        view.ShowDialog();
    }

    private async void OnDeleteItemClickedEventRaised(object sender, EventArgs e)
    {
        var product = ((GridView)sender).GetRow(((GridView)sender).FocusedRowHandle) as ProductDto;

        string text = string.Format(Resources.RemoveProductText, product.Name, product.Code);
        string caption = string.Format(Resources.RemoveProductCaption);

        DialogResult result =  XtraMessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        if (result == DialogResult.Yes)
        {
            await _mediator.Send(new RemoveProductCommand(product.Id));
            await UpdateProductListViewAsync();
        }
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
                exporter.ExportData(_view.ProductList, filePath);
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
                exporter.ExportData(_view.ProductList, filePath);
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
                exporter.ExportData(_view.ProductList, filePath);
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
                exporter.ExportData(_view.ProductList, filePath);
            }
        }
    }

    private async Task UpdateProductListViewAsync()
    {
        var productList = await _mediator.Send(new GetProductsQuery());
        _view.ProductList = productList.ToList();
    }
}

using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Base;

namespace InvoicePI.DesktopUI.Views.Invoices
{
    public partial class InvoicesView : RibbonForm, IInvoicesView
    {
        private const int GvInvoicesRelationCount = 1;
        private const string GvInvoicesRelationName = "Items";

        public event EventHandler InvoicesViewLoadedEventRaised;
        public event EventHandler BtnAddItemClickedEventRaised;
        public event EventHandler BtnEditItemClickedEventRaised;
        public event EventHandler BtnDeleteItemClickedEventRaised;
        public event EventHandler GvInvoicesFocusedRowChangedEventRaised;

        public event EventHandler BtnExportXmlItemClickedEventRaised;
        public event EventHandler BtnExportCsvItemClickedEventRaised;
        public event EventHandler BtnExportXlsxItemClickedEventRaised;
        public event EventHandler BtnExportTxtItemClickedEventRaised;

        public event AsyncEventHandler BtnGenerateInvoiceMonthlySummariesItemClickedEventRaised;

        public Func<Task> HideInvoiceView;

        public bool IsDeletable
        {
            set { btnDelete.Enabled = value; }
        }

        public InvoicesView()
        {
            InitializeComponent();
        }

        public IList<InvoiceDto> InvoiceList
        {
            get { return (IList<InvoiceDto>)invoiceDtoBindingSource.DataSource; }
            set { invoiceDtoBindingSource.DataSource = value; }
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        private void InvoicesView_Load(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: InvoicesViewLoadedEventRaised, eventArgs: e);

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnAddItemClickedEventRaised, eventArgs: e);

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnEditItemClickedEventRaised, eventArgs: e);

        private void gridControl_DoubleClick_1(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnEditItemClickedEventRaised, eventArgs: e);

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);

        private void gridControl_DoubleClick(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnEditItemClickedEventRaised, eventArgs: e);

        private void gvInvoices_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            InvoiceDto invoice = view.GetRow(e.RowHandle) as InvoiceDto;
            if (invoice != null)
                e.IsEmpty = !invoice.InvoiceItems.Any();
        }

        private void gvInvoices_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            InvoiceDto invoice = view.GetRow(e.RowHandle) as InvoiceDto;
            if (invoice != null)
                e.ChildList = invoice.InvoiceItems.ToList();
        }

        private void gvInvoices_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
            => e.RelationCount = GvInvoicesRelationCount;

        private void gvInvoices_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
            => e.RelationName = GvInvoicesRelationName;

        private void btnExportXML_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnExportXmlItemClickedEventRaised, eventArgs: e);

        private void btnExportCSV_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnExportCsvItemClickedEventRaised, eventArgs: e);

        private void btnExportXLSX_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnExportXlsxItemClickedEventRaised, eventArgs: e);

        private void btnExportTXT_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: BtnExportTxtItemClickedEventRaised, eventArgs: e);

        private void gvInvoices_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoices, eventHandlerRaised: GvInvoicesFocusedRowChangedEventRaised, eventArgs: e);

        private async void btnGenerateInvoiceMonthlySummaries_ItemClick(object sender, ItemClickEventArgs e)
            => await EventHelper.RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnGenerateInvoiceMonthlySummariesItemClickedEventRaised, eventArgs: e);

    }
}
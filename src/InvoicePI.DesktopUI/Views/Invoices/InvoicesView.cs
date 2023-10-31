using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace InvoicePI.DesktopUI.Views.Invoices
{
    public partial class InvoicesView : RibbonForm, IInvoicesView
    {
        public event EventHandler InvoicesViewLoadedEventRaised;
        public event EventHandler BtnAddItemClickedEventRaised;
        public event EventHandler BtnEditItemClickedEventRaised;
        public event EventHandler BtnDeleteItemClickedEventRaised;

        public event EventHandler BtnExportXmlItemClickedEventRaised;
        public event EventHandler BtnExportCsvItemClickedEventRaised;
        public event EventHandler BtnExportXlsxItemClickedEventRaised;
        public event EventHandler BtnExportTxtItemClickedEventRaised;

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
        {
            e.RelationCount = 1;
        }

        private void gvInvoices_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Items";
        }

        private void btnExportXML_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoiceItems, eventHandlerRaised: BtnExportXmlItemClickedEventRaised, eventArgs: e);

        private void btnExportCSV_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoiceItems, eventHandlerRaised: BtnExportCsvItemClickedEventRaised, eventArgs: e);

        private void btnExportXLSX_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoiceItems, eventHandlerRaised: BtnExportXlsxItemClickedEventRaised, eventArgs: e);

        private void btnExportTXT_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gvInvoiceItems, eventHandlerRaised: BtnExportTxtItemClickedEventRaised, eventArgs: e);
    }
}
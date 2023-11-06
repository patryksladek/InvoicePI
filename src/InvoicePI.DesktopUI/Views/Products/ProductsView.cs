using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using System;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Products
{
    public partial class ProductsView : RibbonForm, IProductsView
    {
        public event EventHandler ProductsViewLoadedEventRaised;
        public event EventHandler BtnAddItemClickedEventRaised;
        public event EventHandler BtnEditItemClickedEventRaised;
        public event EventHandler BtnDeleteItemClickedEventRaised;

        public event EventHandler BtnExportXmlItemClickedEventRaised;
        public event EventHandler BtnExportCsvItemClickedEventRaised;
        public event EventHandler BtnExportXlsxItemClickedEventRaised;
        public event EventHandler BtnExportTxtItemClickedEventRaised;

        public ProductsView()
        {
            InitializeComponent();
        }

        public IList<ProductDto> ProductList
        {
            get { return (IList<ProductDto>)productDtoBindingSource.DataSource; }
            set { productDtoBindingSource.DataSource = value; }
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        private void InvoicesView_Load(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: ProductsViewLoadedEventRaised, eventArgs: e);

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnAddItemClickedEventRaised, eventArgs: e);

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnEditItemClickedEventRaised, eventArgs: e);

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);

        private void gridControl_DoubleClick(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnEditItemClickedEventRaised, eventArgs: e);

        private void btnExportXML_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnExportXmlItemClickedEventRaised, eventArgs: e);

        private void btnExportCSV_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnExportCsvItemClickedEventRaised, eventArgs: e);

        private void btnExportXLSX_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnExportXlsxItemClickedEventRaised, eventArgs: e);

        private void btnExportTXT_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: gridView, eventHandlerRaised: BtnExportTxtItemClickedEventRaised, eventArgs: e);
    }
}
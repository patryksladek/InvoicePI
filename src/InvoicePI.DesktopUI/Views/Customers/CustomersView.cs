using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Customers;
using System;
using System.Collections.Generic;

namespace InvoicePI.DesktopUI.Views.Modules
{
    public partial class CustomersView : RibbonForm, ICustomersView
    {
        public event AsyncEventHandler CustomersViewLoadedEventRaised;

        public event EventHandler BtnAddItemClickedEventRaised;
        public event EventHandler BtnEditItemClickedEventRaised;
        public event EventHandler BtnDeleteItemClickedEventRaised;

        public event EventHandler BtnExportXmlItemClickedEventRaised;
        public event EventHandler BtnExportCsvItemClickedEventRaised;

        public event AsyncEventHandler BtnGenerateNumberOfContractorsInCountryReportItemClickedEventRaised;


        public CustomersView()
        {
            InitializeComponent();
        }

        public IList<CustomerDto> CustomerList
        {
            get { return (IList<CustomerDto>)customerListDtoBindingSource.DataSource; }
            set { customerListDtoBindingSource.DataSource = value; }
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        private async void CustomersView_Load(object sender, EventArgs e)
            => await EventHelper.RaiseEventAsync(objectRaisingEvent: this, eventHandlerRaised: CustomersViewLoadedEventRaised, eventArgs: e);

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

        private async void btnGenerateNumberOfContractorsInCountryReport_ItemClick(object sender, ItemClickEventArgs e)
            => await EventHelper.RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnGenerateNumberOfContractorsInCountryReportItemClickedEventRaised, eventArgs: e);
    }
}
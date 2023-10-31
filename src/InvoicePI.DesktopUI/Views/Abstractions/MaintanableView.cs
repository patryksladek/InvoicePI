using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.TextEditController.IME;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Customers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Views.Modules.Customers
{
    public partial class MaintanableView : RibbonForm
    {
        public event EventHandler CustomerViewLoadedEventRaised;

        public event EventHandler BtnSaveItemClickedEventRaised;

        public event EventHandler BtnSaveAndCloseItemClickedEventRaised;

        public event EventHandler BtnResetChangesItemClickedEventRaised;

        public event EventHandler BtnDeleteItemClickedEventRaised;

        public event EventHandler TeNameValidatingEventRaised;

        public event EventHandler TeCodeValidatingEventRaised;

        public MaintanableView()
        {
            InitializeComponent();
        }

        public void SetErrorMessage(Control control, string errorMessage, ErrorType errorType)
            => errorProvider.SetError(control, errorMessage, errorType);

        private void CustomerView_Load(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: CustomerViewLoadedEventRaised, eventArgs: e);
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);

        private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveAndCloseItemClickedEventRaised, eventArgs: e);

        private void btnResetChanges_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: BtnResetChangesItemClickedEventRaised, eventArgs: e);

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);

        private void teName_Validating(object sender, CancelEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TeNameValidatingEventRaised, eventArgs: e);

        private void teCode_Validating(object sender, CancelEventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TeCodeValidatingEventRaised, eventArgs: e);






    }
}
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InvoicePI.DesktopUI.Events.EventHelper;
using Microsoft.EntityFrameworkCore;
using InvoicePI.DesktopUI.Constatns;
using System.Linq;

namespace InvoicePI.DesktopUI.Views.Invoices
{
    public partial class InvoiceView : RibbonForm, IInvoiceView
    {
        public event AsyncEventHandler InvoiceViewLoadedEventRaised;
        public event AsyncEventHandler BtnSaveItemClickedEventRaised;
        public event AsyncEventHandler BtnResetChangesItemClickedEventRaised;
        public event AsyncEventHandler BtnDeleteItemClickedEventRaised;

        public event AsyncEventHandler TeDateValidatingEventRaised;
        public event AsyncEventHandler GlueCustomerValidatingEventRaised;

        public event EventHandler TeDateEditValueChangedEventRaised;
        public event EventHandler TeGlueCustomerEditValueChangedEventRaised;

        public Func<Task> UpdateInvoiceListView;

        public InvoiceView()
        {
            InitializeComponent();
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public IList<CustomerDto> CustomerList
        {
            get { return (IList<CustomerDto>)customerDtoBindingSource.DataSource; }
            set { customerDtoBindingSource.DataSource = value; }
        }

        public IList<CurrencyDto> CurrencyList
        {
            get { return (IList<CurrencyDto>)currencyDtoBindingSource.DataSource; }
            set { currencyDtoBindingSource.DataSource = value; }
        }

        public IList<InvoiceItemDetailDto> InvoiceItemList
        {
            get { return (IList<InvoiceItemDetailDto>)invoiceItemDetailDtoBindingSource.DataSource; }
            set { invoiceItemDetailDtoBindingSource.DataSource = value; }
        }


        public ICollection InvoiceStatusList
        {
            get { return cbeStatus.Properties.Items; }
            set { cbeStatus.Properties.Items.AddRange(value); }
        }

        public int? InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }

        public DateOnly InvoiceDate
        {
            get { return (DateOnly)deDate.EditValue; }
            set { deDate.EditValue = value; }
        }
        public int? CustomerId
        {
            get { return Convert.ToInt32(glueCustomer.EditValue); }
            set { glueCustomer.EditValue = value; }
        }

        public string Description
        {
            get { return meDescription.Text; }
            set { meDescription.Text = value; }
        }

        public decimal Net
        {
            get { return decimal.Parse(seNet.Text); }
            set { seNet.Text = value.ToString(); }
        }

        public decimal Vat
        {
            get { return decimal.Parse(seVat.Text); }
            set { seVat.Text = value.ToString(); }
        }

        public decimal Gross
        {
            get { return decimal.Parse(seGross.Text); }
            set { seGross.Text = value.ToString(); }
        }

        public string InvoiceStatus
        {
            get { return cbeStatus.SelectedItem as string; }
            set
            {
                cbeStatus.SelectedItem = value;

                if (value == InvoiceStatusConstants.Confirmed)
                {
                    deDate.ReadOnly = true;
                    glueCustomer.ReadOnly = true;
                    gvInvoiceItems.OptionsBehavior.ReadOnly = true;
                    btnNewItem.Enabled = false;
                    btnEditItem.Enabled = false;
                    btnRemoveItem.Enabled = false;
                    meDescription.ReadOnly = true;
                }
                else
                {
                    deDate.ReadOnly = false;
                    glueCustomer.ReadOnly = false;
                    gvInvoiceItems.OptionsBehavior.ReadOnly = false;
                    btnNewItem.Enabled = true;
                    btnEditItem.Enabled = true;
                    btnRemoveItem.Enabled = true;
                    meDescription.ReadOnly = false;
                }
            }
        }

        public int CurrencyId
        {
            get { return Convert.ToInt32(glueCurrency.EditValue); }
            set { glueCurrency.EditValue = value; }
        }

        public bool IsSavable
        {
            set
            {
                btnSave.Enabled = value;
                btnConfirmAndClose.Enabled = value;
            }
        }

        public bool IsResettableChanges
        {
            set { btnResetChanges.Enabled = value; }
        }

        public bool IsDeletable
        {
            set { btnDelete.Enabled = value; }
        }


        public void SetErrorMessage(Control control, string errorMessage, ErrorType errorType)
            => errorProvider.SetError(control, errorMessage, errorType);

        public void ShowErrorMessage(string errorMessage)
        {
            XtraMessageBox.Show(errorMessage, Resources.OperationFaildCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void CustomerView_Load(object sender, EventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: this, eventHandlerRaised: InvoiceViewLoadedEventRaised, eventArgs: e);
        }

        private async void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);
            await UpdateInvoiceListView?.Invoke();
        }

        private async void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);
            await UpdateInvoiceListView?.Invoke();
            Close();
        }

        private async void btnResetChanges_ItemClick(object sender, ItemClickEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnResetChangesItemClickedEventRaised, eventArgs: e);

        private async void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);
            await UpdateInvoiceListView?.Invoke();
            Close();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
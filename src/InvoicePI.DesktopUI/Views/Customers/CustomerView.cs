using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using InvoicePI.Application.Dto;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.DesktopUI.Views.Customers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InvoicePI.DesktopUI.Events.EventHelper;

namespace InvoicePI.DesktopUI.Views.Modules.Customers
{
    public partial class CustomerView : RibbonForm, ICustomerView
    {
        public event AsyncEventHandler CustomerViewLoadedEventRaised;
        public event AsyncEventHandler BtnSaveItemClickedEventRaised;
        public event AsyncEventHandler BtnResetChangesItemClickedEventRaised;
        public event AsyncEventHandler BtnDeleteItemClickedEventRaised;

        public event AsyncEventHandler TeCodeValidatingEventRaised;
        public event AsyncEventHandler TeNameValidatingEventRaised;
        public event AsyncEventHandler TeNipValidatingEventRaised;
        public event AsyncEventHandler TeStreetValidatingEventRaised;
        public event AsyncEventHandler TeStreetNumberValidatingEventRaised;
        public event AsyncEventHandler TeBuildingValidatingEventRaised;
        public event AsyncEventHandler TeCityValidatingEventRaised;
        public event AsyncEventHandler TePostalCodeValidatingEventRaised;
        public event AsyncEventHandler TePhoneValidatingEventRaised;
        public event AsyncEventHandler TeMobileValidatingEventRaised;
        public event AsyncEventHandler TeEmailValidatingEventRaised;
        public event AsyncEventHandler TeFaxValidatingEventRaised;

        public event EventHandler TeCodeEditValueChangedEventRaised;
        public event EventHandler TeNameEditValueChangedEventRaised;

        public Func<Task> UpdateCustomerListView;

        public CustomerView()
        {
            InitializeComponent();
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public IList<InvoiceDto> InvoiceList
        {
            get { return (IList<InvoiceDto>)invoiceDtoBindingSource.DataSource; }
            set { invoiceDtoBindingSource.DataSource = value; }
        }

        public IList<CountryDto> CountryList
        {
            get { return (IList<CountryDto>)countryDtoBindingSource.DataSource; }
            set { countryDtoBindingSource.DataSource = value; }
        }

        public ICollection SegmentList
        {
            get { return cbeSegment.Properties.Items; }
            set { cbeSegment.Properties.Items.AddRange(value); }
        }

        public ICollection StatusList
        {
            get { return cbeStatus.Properties.Items; }
            set { cbeStatus.Properties.Items.AddRange(value); }
        }

        public ICollection Segment
        {
            get { return cbeSegment.Properties.Items; }
            set { cbeSegment.Properties.Items.AddRange(value); }
        }

        public int? CustomerId { get; set; }

        public string CustomerName
        {
            get { return teName.Text; }
            set { teName.Text = value; }
        }

        public string CustomerCode
        {
            get { return teCode.Text; }
            set { teCode.Text = value; teCode.SelectAll(); }
        }

        public string CustomerNIP
        {
            get { return teNIP.Text; }
            set { teNIP.Text = value; }
        }

        public string CustomerSegment
        {
            get { return cbeSegment.SelectedItem as string; }
            set { cbeSegment.SelectedItem = value; }
        }

        public bool CustomerIsActive
        {
            get { return cbeStatus.SelectedItem.ToString().Equals(StatusConstants.Active) ? true : false; }
            set { cbeStatus.SelectedItem = value ? StatusConstants.Active : StatusConstants.Inactive; }
        }

        public string Street
        {
            get { return teStreet.Text; }
            set { teStreet.Text = value; }
        }

        public string StreetNumber
        {
            get { return teNumber.Text; }
            set { teNumber.Text = value; }
        }

        public string Building
        {
            get { return teBuilding.Text; }
            set { teBuilding.Text = value; }
        }

        public string PostalCode
        {
            get { return tePostalCode.Text; }
            set { tePostalCode.Text = value; }
        }

        public string City
        {
            get { return teCity.Text; }
            set { teCity.Text = value; }
        }

        public int CountryId
        {
            get { return Convert.ToInt32(glueCountry.EditValue); }
            set { glueCountry.EditValue = value; }
        }

        public string Phone
        {
            get { return tePhone.Text; }
            set { tePhone.Text = value; }
        }

        public string Mobile
        {
            get { return teMobile.Text; }
            set { teMobile.Text = value; }
        }

        public string Email
        {
            get { return teEmail.Text; }
            set { teEmail.Text = value; }
        }

        public string Fax
        {
            get { return teFax.Text; }
            set { teFax.Text = value; }
        }

        public bool IsSavable
        {
            set
            {
                btnSave.Enabled = value;
                btnSaveAndClose.Enabled = value;
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
            await RaiseEventAsync(objectRaisingEvent: this, eventHandlerRaised: CustomerViewLoadedEventRaised, eventArgs: e);
        }

        private async void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);
            await UpdateCustomerListView?.Invoke();
        }

        private async void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);
            await UpdateCustomerListView?.Invoke();
            Close();
        }

        private async void btnResetChanges_ItemClick(object sender, ItemClickEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnResetChangesItemClickedEventRaised, eventArgs: e);

        private async void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);
            await UpdateCustomerListView?.Invoke();
            Close();
        }

        private async void teCode_Validating(object sender, CancelEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeCodeValidatingEventRaised, eventArgs: e);

        private async void teName_Validating(object sender, CancelEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeNameValidatingEventRaised, eventArgs: e);

        private async void teNIP_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeNipValidatingEventRaised, eventArgs: e);

        private async void teStreet_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeStreetValidatingEventRaised, eventArgs: e);

        private async void teStreetNumber_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeStreetNumberValidatingEventRaised, eventArgs: e);

        private async void teBuilding_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeBuildingValidatingEventRaised, eventArgs: e);

        private async void teCity_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeCityValidatingEventRaised, eventArgs: e);

        private async void tePostalCode_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TePostalCodeValidatingEventRaised, eventArgs: e);

        private async void tePhone_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TePhoneValidatingEventRaised, eventArgs: e);

        private async void teMobile_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeMobileValidatingEventRaised, eventArgs: e);

        private async void teEmail_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeEmailValidatingEventRaised, eventArgs: e);

        private async void teFax_Validating(object sender, CancelEventArgs e)
           => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeFaxValidatingEventRaised, eventArgs: e);

        private void teCode_EditValueChanged(object sender, EventArgs e)
            => RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TeCodeEditValueChangedEventRaised, eventArgs: e);

        private void teName_EditValueChanged(object sender, EventArgs e)
            => RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TeNameEditValueChangedEventRaised, eventArgs: e);
    }
}
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

namespace InvoicePI.DesktopUI.Views.Products
{
    public partial class ProductView : RibbonForm, IProductView
    {
        public event AsyncEventHandler ProductViewLoadedEventRaised;
        public event AsyncEventHandler BtnSaveItemClickedEventRaised;
        public event AsyncEventHandler BtnResetChangesItemClickedEventRaised;
        public event AsyncEventHandler BtnDeleteItemClickedEventRaised;

        public event AsyncEventHandler TeCodeValidatingEventRaised;
        public event AsyncEventHandler TeNameValidatingEventRaised;
        public event AsyncEventHandler TePriceValidatingEventRaised;

        public event EventHandler TeCodeEditValueChangedEventRaised;
        public event EventHandler TeNameEditValueChangedEventRaised;
        public event EventHandler TePriceEditValueChangedEventRaised;

        public Func<Task> UpdateProductListView;

        public ProductView()
        {
            InitializeComponent();
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public IList<CurrencyDto> CurrencyList
        {
            get { return (IList<CurrencyDto>)currencyDtoBindingSource.DataSource; }
            set { currencyDtoBindingSource.DataSource = value; }
        }

        public IList<UnitDto> UnitList
        {
            get { return (IList<UnitDto>)unitDtoBindingSource.DataSource; }
            set { unitDtoBindingSource.DataSource = value; }
        }

        public IList<VatRateDto> VatRateList
        {
            get { return (IList<VatRateDto>)vatRateDtoBindingSource.DataSource; }
            set { vatRateDtoBindingSource.DataSource = value; }
        }

        public ICollection ProductTypeList
        {
            get { return cbeType.Properties.Items; }
            set { cbeType.Properties.Items.AddRange(value); }
        }

        public ICollection ProductBarcodeTypeList
        {
            get { return cbeBarcodeType.Properties.Items; }
            set { cbeBarcodeType.Properties.Items.AddRange(value); }
        }

        public int? ProductId { get; set; }

        public string ProductName
        {
            get { return teName.Text; }
            set { teName.Text = value; }
        }

        public string ProductCode
        {
            get { return teCode.Text; }
            set { teCode.Text = value; }
        }

        public string ProductType
        {
            get { return cbeType.SelectedItem as string; }
            set { cbeType.SelectedItem = value; }
        }

        public string Barcode
        {
            get { return teBarcode.Text; }
            set { teBarcode.Text = value; }
        }

        public string ProductBarcodeType
        {
            get { return cbeBarcodeType.SelectedItem as string; }
            set { cbeBarcodeType.SelectedItem = value; }
        }

        public int CurrencyId
        {
            get { return Convert.ToInt32(glueCurrency.EditValue); }
            set { glueCurrency.EditValue = value; }
        }

        public int UnitId
        {
            get { return Convert.ToInt32(glueUnit.EditValue); }
            set { glueUnit.EditValue = value; }
        }

        public int VatRateId
        {
            get { return Convert.ToInt32(glueVatRate.EditValue); }
            set { glueVatRate.EditValue = value; }
        }
        public decimal NetPrice
        {
            get { return decimal.Parse(tePrice.Text); }
            set { tePrice.Text = value.ToString(); }
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
            await RaiseEventAsync(objectRaisingEvent: this, eventHandlerRaised: ProductViewLoadedEventRaised, eventArgs: e);
        }

        private async void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);
            await UpdateProductListView?.Invoke();
        }

        private async void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnSaveItemClickedEventRaised, eventArgs: e);
            await UpdateProductListView?.Invoke();
            Close();
        }

        private async void btnResetChanges_ItemClick(object sender, ItemClickEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnResetChangesItemClickedEventRaised, eventArgs: e);

        private async void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);
            await UpdateProductListView?.Invoke();
            Close();
        }

        private async void teCode_Validating(object sender, CancelEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeCodeValidatingEventRaised, eventArgs: e);

        private async void teName_Validating(object sender, CancelEventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TeNameValidatingEventRaised, eventArgs: e);

        private async void tePrice_EditValueChanged(object sender, EventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TePriceValidatingEventRaised, eventArgs: e);

        private void teCode_EditValueChanged(object sender, EventArgs e)
            => RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TeCodeEditValueChangedEventRaised, eventArgs: e);

        private void teName_EditValueChanged(object sender, EventArgs e)
            => RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TeNameEditValueChangedEventRaised, eventArgs: e);

        private void tePrice_Validating(object sender, CancelEventArgs e)
            => RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: TePriceEditValueChangedEventRaised, eventArgs: e);

    }
}
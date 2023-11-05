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

namespace InvoicePI.DesktopUI.Views.Invoices
{
    public partial class InvoiceItemView : RibbonForm, IInvoiceItemView
    {
        public event AsyncEventHandler InvoiceItemViewLoadedEventRaised;
        public event EventHandler BtnOKItemClickedEventRaised;
        public event EventHandler BtnDeleteItemClickedEventRaised;

        public event AsyncEventHandler GlueProductEditValueChangedEventRaised;
        public event AsyncEventHandler TePriceValidatingEventRaised;
        public event AsyncEventHandler GlueCurrencyEditValueChanged;
        public event AsyncEventHandler SeQuantityEditValueChanged;

        public Func<Task> CalculateInvoiceItemsSummary;

        public InvoiceItemView()
        {
            InitializeComponent();
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public IList<ProductDto> ProductList
        {
            get { return (IList<ProductDto>)productDtoBindingSource.DataSource; }
            set { productDtoBindingSource.DataSource = value; }
        }

        public IList<VatRateDto> VatRateList
        {
            get { return (IList<VatRateDto>)vatRateDtoBindingSource.DataSource; }
            set { vatRateDtoBindingSource.DataSource = value; }
        }

        public IList<CurrencyDto> CurrencyList
        {
            get { return (IList<CurrencyDto>)currencyDtoBindingSource.DataSource; }
            set { currencyDtoBindingSource.DataSource = value; }
        }

        public IList<CurrencyDto> CurrencySummaryList
        {
            get { return (IList<CurrencyDto>)summaryCurrencyDtoBindingSource.DataSource; }
            set { summaryCurrencyDtoBindingSource.DataSource = value; }
        }

        public InvoiceItemDetailDto InvoiceItem { get; set; }
        public DateOnly InvoiceDate { get; set; }
        public IList<InvoiceItemDetailDto> InvoiceItemList { get; set; }

        public int OrdinalNumber
        {
            get { return InvoiceItemList.Count + 1; }
            set { OrdinalNumber = value; }
        }

        public int ProductId
        {
            get { return Convert.ToInt32(glueProduct.EditValue); }
            set { glueProduct.EditValue = value; }
        }

        public string ProductName
        {
            get { return glueProduct.Text as string; }
        }

        public int CurrencyId
        {
            get { return Convert.ToInt32(glueCurrency.EditValue); }
            set { glueCurrency.EditValue = value; }
        }

        public int Quantity
        {
            get { return Convert.ToInt32(seQuantity.EditValue); }
            set { seQuantity.EditValue = value; }
        }

        public int UnitId
        {
            get { return Convert.ToInt32(glueProduct.EditValue); }
            set { glueProduct.EditValue = value; }
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

        public int CurrencySummaryId
        {
            get { return Convert.ToInt32(glueSummaryCurrency.EditValue); }
            set { glueSummaryCurrency.EditValue = value; }
        }

        public decimal SummaryNet
        {
            get { return decimal.Parse(seSummaryNet.Text); }
            set { seSummaryNet.Text = value.ToString(); }
        }

        public decimal SummaryVat
        {
            get { return decimal.Parse(seSummaryVat.Text); }
            set { seSummaryVat.Text = value.ToString(); }
        }

        public decimal SummaryGross
        {
            get { return decimal.Parse(seSummaryGross.Text); }
            set { seSummaryGross.Text = value.ToString(); }
        }

        public bool IsSavable
        { 
            set { btnOK.Enabled = value; }
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

        private async void InvoiceItemView_Load(object sender, EventArgs e)
        {
            await RaiseEventAsync(objectRaisingEvent: this, eventHandlerRaised: InvoiceItemViewLoadedEventRaised, eventArgs: e);
        }

        private void btnOK_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: BtnOKItemClickedEventRaised, eventArgs: e);
            CalculateInvoiceItemsSummary?.Invoke();
            Close();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: BtnDeleteItemClickedEventRaised, eventArgs: e);
            CalculateInvoiceItemsSummary?.Invoke();
            Close();
        }

        private async void glueProduct_EditValueChanged(object sender, EventArgs e)
             => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: GlueProductEditValueChangedEventRaised, eventArgs: e);

        private async void tePrice_EditValueChanged(object sender, EventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: TePriceValidatingEventRaised, eventArgs: e);

        private async void glueCurrency_EditValueChanged(object sender, EventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: GlueCurrencyEditValueChanged, eventArgs: e);

        private async void seQuantity_EditValueChanged(object sender, EventArgs e)
            => await RaiseEventAsync(objectRaisingEvent: sender, eventHandlerRaised: SeQuantityEditValueChanged, eventArgs: e);

    }
}
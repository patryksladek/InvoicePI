using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Properties;
using InvoicePI.Infrastructure.DataGeneration;
using System;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Views.Config
{
    public partial class ObjectGenerationView : XtraForm, IObjectGenerationView
    {
        public event EventHandler BtnGenerateDataClickedEventRaised;
        public event EventHandler BtnSkipClickedEventRaised;

        public ObjectGenerationView()
        {
            InitializeComponent();
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public DataGenerator DataGenerator { get; set; }

        public int CustomersCount
        {
            get { return int.Parse(nudCustomersCount.Text); }
            set { nudCustomersCount.Text = value.ToString(); }
        }

        public int ProductsCount
        {
            get { return int.Parse(nudProductsCount.Text); }
            set { nudProductsCount.Text = value.ToString(); }
        }
        public int InvoicesCount
        {
            get { return int.Parse(nudInvoicesCount.Text); }
            set { nudInvoicesCount.Text = value.ToString(); }
        }

        public bool IsObjectGenerated { get; set; }

        public void ShowMessage(string message, string caption, MessageBoxIcon icon)
            => XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, icon);

        public void SetErrorMessage(Control control, string errorMessage, ErrorType errorType)
            => errorProvider.SetError(control, errorMessage, errorType);

        public void ShowErrorMessage(string errorMessage)
            => XtraMessageBox.Show(errorMessage, Resources.OperationFaildCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void btnSkip_Click(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: BtnSkipClickedEventRaised, eventArgs: e);
            Close();
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: BtnGenerateDataClickedEventRaised, eventArgs: e);

            if (IsObjectGenerated)
                Close();
        }
    }
}
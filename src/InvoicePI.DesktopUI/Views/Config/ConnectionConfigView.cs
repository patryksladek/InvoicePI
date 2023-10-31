using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using InvoicePI.DesktopUI.Constatns;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Properties;
using System;
using System.Collections;
using System.Windows.Forms;

namespace InvoicePI.DesktopUI.Views.Config
{
    public partial class ConnectionConfigView : XtraForm, IConnectionConfigView
    {
        public event EventHandler ConnectionConfigLoadedEventRaised;
        public event EventHandler BtnValidateConnectionClickedEventRaised;
        public event EventHandler BtnConnectClickedEventRaised;
        public event EventHandler CbeAuthenticationEditValueChangedRaised;

        public ConnectionConfigView()
        {
            InitializeComponent();
        }

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public ICollection AuthenticationList
        {
            get { return cbeAuthentication.Properties.Items; }
            set { cbeAuthentication.Properties.Items.AddRange(value); }
        }

        public string Server
        {
            get { return teServer.Text; }
            set { teServer.Text = value; }
        }

        public string Authentication
        {
            get { return cbeAuthentication.SelectedItem as string; }
            set
            {
                cbeAuthentication.SelectedItem = value;

                if (cbeAuthentication.SelectedItem.ToString() == AuthenticationConstants.Windows)
                {
                    teUser.Text = string.Empty;
                    tePassword.Text = string.Empty;

                    teUser.Enabled = false;
                    tePassword.Enabled = false;
                }
                else
                {
                    teUser.Enabled = true;
                    tePassword.Enabled = true;
                }
            }
        }

        public string User
        {
            get { return teUser.Text; }
            set { teUser.Text = value; }
        }

        public string Password
        {
            get { return tePassword.Text; }
            set { tePassword.Text = value; }
        }

        public bool IsAuthentication { get; set; }

        public void ShowMessage(string message, string caption, MessageBoxIcon icon)
            => XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, icon);

        public void SetErrorMessage(Control control, string errorMessage, ErrorType errorType)
            => errorProvider.SetError(control, errorMessage, errorType);

        public void ShowErrorMessage(string errorMessage)
            => XtraMessageBox.Show(errorMessage, Resources.OperationFaildCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void ConnectionConfigView_Load(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: ConnectionConfigLoadedEventRaised, eventArgs: e);

        private void btnValidateConnection_Click(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: BtnValidateConnectionClickedEventRaised, eventArgs: e);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: BtnConnectClickedEventRaised, eventArgs: e);

            if (IsAuthentication)
                Close();
        }

        private void cbeAuthentication_EditValueChanged(object sender, EventArgs e)
            => EventHelper.RaiseEvent(objectRaisingEvent: sender, eventHandlerRaised: CbeAuthenticationEditValueChangedRaised, eventArgs: e);
    }
}
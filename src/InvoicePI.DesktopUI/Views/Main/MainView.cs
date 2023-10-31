using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using InvoicePI.DesktopUI.Events;
using InvoicePI.DesktopUI.Views.Main;
using System;

namespace InvoicePI.DesktopUI.Views
{
    public partial class MainView : RibbonForm, IMainView
    {
        public event EventHandler OfficeNavigationBarItemClickedEventRaised;

        public string ViewName
        {
            get { return Text; }
            set { Text = value; }
        }

        public MainView()
        {
            InitializeComponent();
        }

        private void officeNavigationBar_ItemClick(object sender, NavigationBarItemEventArgs e)
             => EventHelper.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: OfficeNavigationBarItemClickedEventRaised, eventArgs: e);

    }
}
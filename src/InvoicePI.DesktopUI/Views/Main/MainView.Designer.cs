namespace InvoicePI.DesktopUI.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barAndDockingController = new DevExpress.XtraBars.BarAndDockingController(components);
            rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            nbiInvoices = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            nbiCustomers = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            nbiProducts = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            ((System.ComponentModel.ISupportInitialize)tabbedView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barAndDockingController).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)officeNavigationBar).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.Controller = barAndDockingController;
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 4;
            ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpHome });
            ribbon.Size = new System.Drawing.Size(1100, 158);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barAndDockingController
            // 
            barAndDockingController.PropertiesBar.AllowLinkLighting = false;
            // 
            // rpHome
            // 
            rpHome.Name = "rpHome";
            rpHome.Text = "HOME";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 623);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1100, 27);
            // 
            // documentManager
            // 
            documentManager.BarAndDockingController = barAndDockingController;
            documentManager.MdiParent = this;
            documentManager.MenuManager = ribbon;
            documentManager.View = tabbedView;
            documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView });
            // 
            // officeNavigationBar
            // 
            officeNavigationBar.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] { nbiInvoices, nbiCustomers, nbiProducts });
            officeNavigationBar.Location = new System.Drawing.Point(0, 577);
            officeNavigationBar.Name = "officeNavigationBar";
            officeNavigationBar.Size = new System.Drawing.Size(1100, 46);
            officeNavigationBar.TabIndex = 3;
            officeNavigationBar.Text = "onbMain";
            officeNavigationBar.ItemClick += officeNavigationBar_ItemClick;
            // 
            // nbiInvoices
            // 
            nbiInvoices.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("nbiInvoices.ImageOptions.Image");
            nbiInvoices.Name = "nbiInvoices";
            nbiInvoices.Tag = "INVOICES";
            nbiInvoices.Text = "Invoices";
            // 
            // nbiCustomers
            // 
            nbiCustomers.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("nbiCustomers.ImageOptions.Image");
            nbiCustomers.Name = "nbiCustomers";
            nbiCustomers.Tag = "CUSTOMERS";
            nbiCustomers.Text = "Customers";
            // 
            // nbiProducts
            // 
            nbiProducts.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("nbiProducts.ImageOptions.Image");
            nbiProducts.Name = "nbiProducts";
            nbiProducts.Tag = "PRODUCTS";
            nbiProducts.Text = "Products";
            // 
            // MainView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1100, 650);
            Controls.Add(officeNavigationBar);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainView";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Invoice Platige Image";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)tabbedView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)barAndDockingController).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)officeNavigationBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHome;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiCustomers;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiProducts;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiInvoices;
    }
}
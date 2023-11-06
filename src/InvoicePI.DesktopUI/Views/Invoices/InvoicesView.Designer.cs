using InvoicePI.Application.Dto;

namespace InvoicePI.DesktopUI.Views.Invoices
{
    partial class InvoicesView
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesView));
            gvInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            colSubProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl = new DevExpress.XtraGrid.GridControl();
            invoiceDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            colIsApproved = new DevExpress.XtraGrid.Columns.GridColumn();
            colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            colGross = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnEdit = new DevExpress.XtraBars.BarButtonItem();
            btnExportXML = new DevExpress.XtraBars.BarButtonItem();
            btnExportCSV = new DevExpress.XtraBars.BarButtonItem();
            btnGenerate = new DevExpress.XtraBars.BarSubItem();
            btnGenerateInvoiceMonthlySummaries = new DevExpress.XtraBars.BarButtonItem();
            rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)gvInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // gvInvoiceItems
            // 
            gvInvoiceItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colSubProduct });
            gvInvoiceItems.GridControl = gridControl;
            gvInvoiceItems.Name = "gvInvoiceItems";
            gvInvoiceItems.OptionsView.ShowIndicator = false;
            // 
            // colSubProduct
            // 
            colSubProduct.Caption = "PRODUCT";
            colSubProduct.FieldName = "Product";
            colSubProduct.Name = "colSubProduct";
            colSubProduct.OptionsColumn.AllowFocus = false;
            colSubProduct.Visible = true;
            colSubProduct.VisibleIndex = 0;
            // 
            // gridControl
            // 
            gridControl.DataSource = invoiceDtoBindingSource;
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = gvInvoiceItems;
            gridLevelNode1.RelationName = "SubView";
            gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridControl.Location = new System.Drawing.Point(0, 158);
            gridControl.MainView = gvInvoices;
            gridControl.MenuManager = ribbon;
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(442, 291);
            gridControl.TabIndex = 7;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvInvoices, gvInvoiceItems });
            gridControl.DoubleClick += gridControl_DoubleClick_1;
            // 
            // invoiceDtoBindingSource
            // 
            invoiceDtoBindingSource.DataSource = typeof(InvoiceDto);
            // 
            // gvInvoices
            // 
            gvInvoices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colIsApproved, colNumber, colDate, colCustomer, colNet, colVat, colGross, colCurrency });
            gvInvoices.GridControl = gridControl;
            gvInvoices.Name = "gvInvoices";
            gvInvoices.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
            gvInvoices.OptionsBehavior.AutoExpandAllGroups = true;
            gvInvoices.OptionsBehavior.Editable = false;
            gvInvoices.OptionsBehavior.ReadOnly = true;
            gvInvoices.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            gvInvoices.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            gvInvoices.OptionsDetail.SmartDetailHeight = true;
            gvInvoices.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel;
            gvInvoices.OptionsFind.AlwaysVisible = true;
            gvInvoices.OptionsFind.FindNullPrompt = "Search Customers (Ctrl + F)";
            gvInvoices.OptionsFind.ShowClearButton = false;
            gvInvoices.OptionsFind.ShowFindButton = false;
            gvInvoices.OptionsView.ShowIndicator = false;
            gvInvoices.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gvInvoices.MasterRowEmpty += gvInvoices_MasterRowEmpty;
            gvInvoices.MasterRowGetChildList += gvInvoices_MasterRowGetChildList;
            gvInvoices.MasterRowGetRelationName += gvInvoices_MasterRowGetRelationName;
            gvInvoices.MasterRowGetRelationCount += gvInvoices_MasterRowGetRelationCount;
            gvInvoices.FocusedRowChanged += gvInvoices_FocusedRowChanged;
            // 
            // colIsApproved
            // 
            colIsApproved.Caption = "APPROVED";
            colIsApproved.FieldName = "IsApproved";
            colIsApproved.MaxWidth = 30;
            colIsApproved.Name = "colIsApproved";
            colIsApproved.OptionsColumn.AllowFocus = false;
            colIsApproved.Visible = true;
            colIsApproved.VisibleIndex = 0;
            colIsApproved.Width = 30;
            // 
            // colNumber
            // 
            colNumber.Caption = "NUMBER";
            colNumber.FieldName = "Number";
            colNumber.Name = "colNumber";
            colNumber.OptionsColumn.AllowFocus = false;
            colNumber.Visible = true;
            colNumber.VisibleIndex = 1;
            colNumber.Width = 58;
            // 
            // colDate
            // 
            colDate.Caption = "DATE";
            colDate.FieldName = "Date";
            colDate.Name = "colDate";
            colDate.OptionsColumn.AllowFocus = false;
            colDate.Visible = true;
            colDate.VisibleIndex = 2;
            colDate.Width = 58;
            // 
            // colCustomer
            // 
            colCustomer.Caption = "CUSTOMER";
            colCustomer.FieldName = "Customer";
            colCustomer.Name = "colCustomer";
            colCustomer.OptionsColumn.AllowFocus = false;
            colCustomer.Visible = true;
            colCustomer.VisibleIndex = 3;
            colCustomer.Width = 58;
            // 
            // colNet
            // 
            colNet.Caption = "NET";
            colNet.FieldName = "Net";
            colNet.Name = "colNet";
            colNet.OptionsColumn.AllowFocus = false;
            colNet.Visible = true;
            colNet.VisibleIndex = 4;
            colNet.Width = 58;
            // 
            // colVat
            // 
            colVat.Caption = "VAT";
            colVat.FieldName = "Vat";
            colVat.Name = "colVat";
            colVat.OptionsColumn.AllowFocus = false;
            colVat.Visible = true;
            colVat.VisibleIndex = 5;
            colVat.Width = 58;
            // 
            // colGross
            // 
            colGross.Caption = "GROSS";
            colGross.FieldName = "Gross";
            colGross.Name = "colGross";
            colGross.OptionsColumn.AllowFocus = false;
            colGross.Visible = true;
            colGross.VisibleIndex = 6;
            colGross.Width = 58;
            // 
            // colCurrency
            // 
            colCurrency.Caption = "CURRNECY";
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.OptionsColumn.AllowFocus = false;
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 7;
            colCurrency.Width = 62;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnAdd, btnDelete, btnEdit, btnExportXML, btnExportCSV, btnGenerate, btnGenerateInvoiceMonthlySummaries });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 12;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpHome });
            ribbon.Size = new System.Drawing.Size(442, 158);
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Add";
            btnAdd.Hint = "Add customer";
            btnAdd.Id = 1;
            btnAdd.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnAdd.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnAdd.ImageOptions.LargeImage");
            btnAdd.Name = "btnAdd";
            btnAdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnAdd.ItemClick += btnAdd_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Delete";
            btnDelete.Hint = "Delete customer";
            btnDelete.Id = 2;
            btnDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.Name = "btnDelete";
            btnDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnEdit
            // 
            btnEdit.Caption = "Edit";
            btnEdit.Hint = "Edit customer";
            btnEdit.Id = 3;
            btnEdit.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnEdit.ImageOptions.Image");
            btnEdit.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnEdit.ImageOptions.LargeImage");
            btnEdit.Name = "btnEdit";
            btnEdit.ItemClick += btnEdit_ItemClick;
            // 
            // btnExportXML
            // 
            btnExportXML.Caption = "XML";
            btnExportXML.Hint = "Export to XML";
            btnExportXML.Id = 4;
            btnExportXML.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnExportXML.ImageOptions.Image");
            btnExportXML.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnExportXML.ImageOptions.LargeImage");
            btnExportXML.Name = "btnExportXML";
            btnExportXML.ItemClick += btnExportXML_ItemClick;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Caption = "CSV";
            btnExportCSV.Hint = "Export to CSV";
            btnExportCSV.Id = 5;
            btnExportCSV.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnExportCSV.ImageOptions.Image");
            btnExportCSV.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnExportCSV.ImageOptions.LargeImage");
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.ItemClick += btnExportCSV_ItemClick;
            // 
            // btnGenerate
            // 
            btnGenerate.Caption = "Generate";
            btnGenerate.Hint = "Generate reports";
            btnGenerate.Id = 10;
            btnGenerate.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGenerate.ImageOptions.Image");
            btnGenerate.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnGenerate.ImageOptions.LargeImage");
            btnGenerate.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnGenerateInvoiceMonthlySummaries) });
            btnGenerate.Name = "btnGenerate";
            // 
            // btnGenerateInvoiceMonthlySummaries
            // 
            btnGenerateInvoiceMonthlySummaries.Caption = "Invoices monthly summaries";
            btnGenerateInvoiceMonthlySummaries.Id = 11;
            btnGenerateInvoiceMonthlySummaries.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGenerateInvoiceMonthlySummaries.ImageOptions.Image");
            btnGenerateInvoiceMonthlySummaries.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnGenerateInvoiceMonthlySummaries.ImageOptions.LargeImage");
            btnGenerateInvoiceMonthlySummaries.Name = "btnGenerateInvoiceMonthlySummaries";
            btnGenerateInvoiceMonthlySummaries.ItemClick += btnGenerateInvoiceMonthlySummaries_ItemClick;
            // 
            // rpHome
            // 
            rpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { rpgActions, rpgExport, rpgReports });
            rpHome.Name = "rpHome";
            rpHome.Text = "HOME";
            // 
            // rpgActions
            // 
            rpgActions.ItemLinks.Add(btnAdd);
            rpgActions.ItemLinks.Add(btnEdit);
            rpgActions.ItemLinks.Add(btnDelete);
            rpgActions.Name = "rpgActions";
            rpgActions.Text = "Actions";
            // 
            // rpgExport
            // 
            rpgExport.ItemLinks.Add(btnExportXML);
            rpgExport.ItemLinks.Add(btnExportCSV);
            rpgExport.Name = "rpgExport";
            rpgExport.Text = "Export";
            // 
            // rpgReports
            // 
            rpgReports.ItemLinks.Add(btnGenerate);
            rpgReports.Name = "rpgReports";
            rpgReports.Text = "Reports";
            // 
            // InvoicesView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 449);
            Controls.Add(gridControl);
            Controls.Add(ribbon);
            Name = "InvoicesView";
            Ribbon = ribbon;
            Text = "Invoices";
            Load += InvoicesView_Load;
            ((System.ComponentModel.ISupportInitialize)gvInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private System.Windows.Forms.BindingSource invoiceDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIsApproved;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colGross;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceItems;
        private DevExpress.XtraGrid.Columns.GridColumn colSubProduct;
        private DevExpress.XtraBars.BarButtonItem btnExportXML;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.BarButtonItem btnExportCSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReports;
        private DevExpress.XtraBars.BarSubItem btnGenerate;
        private DevExpress.XtraBars.BarButtonItem btnGenerateInvoiceMonthlySummaries;
    }
}
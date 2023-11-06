using InvoicePI.Application.Dto;

namespace InvoicePI.DesktopUI.Views.Products
{
    partial class ProductsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnEdit = new DevExpress.XtraBars.BarButtonItem();
            btnExportXML = new DevExpress.XtraBars.BarButtonItem();
            btnExportCSV = new DevExpress.XtraBars.BarButtonItem();
            rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            productDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnAdd, btnDelete, btnEdit, btnExportXML, btnExportCSV });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 385;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpHome });
            ribbon.Size = new System.Drawing.Size(516, 193);
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
            btnExportXML.Hint = "Export records to XML";
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
            // rpHome
            // 
            rpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { rpgActions, rpgExport });
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
            // productDtoBindingSource
            // 
            productDtoBindingSource.DataSource = typeof(ProductDto);
            // 
            // gridControl
            // 
            gridControl.DataSource = productDtoBindingSource;
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridControl.Location = new System.Drawing.Point(0, 193);
            gridControl.MainView = gridView;
            gridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridControl.MenuManager = ribbon;
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(516, 360);
            gridControl.TabIndex = 7;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName, colCode, colBarcode, colPrice, colCurrency });
            gridView.DetailHeight = 431;
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel;
            gridView.OptionsFind.AlwaysVisible = true;
            gridView.OptionsFind.FindNullPrompt = "Search Customers (Ctrl + F)";
            gridView.OptionsFind.ShowClearButton = false;
            gridView.OptionsFind.ShowFindButton = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colName
            // 
            colName.Caption = "NAME";
            colName.FieldName = "Name";
            colName.MinWidth = 23;
            colName.Name = "colName";
            colName.OptionsColumn.AllowFocus = false;
            colName.Visible = true;
            colName.VisibleIndex = 0;
            colName.Width = 108;
            // 
            // colCode
            // 
            colCode.Caption = "CODE";
            colCode.FieldName = "Code";
            colCode.MinWidth = 23;
            colCode.Name = "colCode";
            colCode.OptionsColumn.AllowFocus = false;
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            colCode.Width = 54;
            // 
            // colBarcode
            // 
            colBarcode.Caption = "BARCODE";
            colBarcode.FieldName = "Barcode";
            colBarcode.MinWidth = 23;
            colBarcode.Name = "colBarcode";
            colBarcode.OptionsColumn.AllowFocus = false;
            colBarcode.Visible = true;
            colBarcode.VisibleIndex = 2;
            colBarcode.Width = 54;
            // 
            // colPrice
            // 
            colPrice.Caption = "PRICE";
            colPrice.FieldName = "Price";
            colPrice.MinWidth = 23;
            colPrice.Name = "colPrice";
            colPrice.OptionsColumn.AllowFocus = false;
            colPrice.Visible = true;
            colPrice.VisibleIndex = 3;
            colPrice.Width = 54;
            // 
            // colCurrency
            // 
            colCurrency.Caption = "CURRENCY";
            colCurrency.FieldName = "Currency";
            colCurrency.MinWidth = 23;
            colCurrency.Name = "colCurrency";
            colCurrency.OptionsColumn.AllowFocus = false;
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 4;
            colCurrency.Width = 87;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 553);
            Controls.Add(gridControl);
            Controls.Add(ribbon);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "ProductsView";
            Ribbon = ribbon;
            Text = "Products";
            Load += InvoicesView_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
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
        private System.Windows.Forms.BindingSource productDtoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private DevExpress.XtraBars.BarButtonItem btnExportXML;
        private DevExpress.XtraBars.BarButtonItem btnExportCSV;
    }
}
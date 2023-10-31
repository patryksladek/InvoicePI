using InvoicePI.Application.Dto;

namespace InvoicePI.DesktopUI.Views.Modules
{
    partial class CustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnEdit = new DevExpress.XtraBars.BarButtonItem();
            btnExportCSV = new DevExpress.XtraBars.BarButtonItem();
            btnExportXML = new DevExpress.XtraBars.BarButtonItem();
            btnExportTXT = new DevExpress.XtraBars.BarButtonItem();
            btnExportXLSX = new DevExpress.XtraBars.BarButtonItem();
            rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gridControl = new DevExpress.XtraGrid.GridControl();
            customerListDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colNIP = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerListDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnAdd, btnDelete, btnEdit, btnExportCSV, btnExportXML, btnExportTXT, btnExportXLSX });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpHome });
            ribbon.Size = new System.Drawing.Size(535, 158);
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
            // btnExportCSV
            // 
            btnExportCSV.Caption = "CSV";
            btnExportCSV.Hint = "Export records to CSV";
            btnExportCSV.Id = 4;
            btnExportCSV.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnExportCSV.ImageOptions.Image");
            btnExportCSV.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnExportCSV.ImageOptions.LargeImage");
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.ItemClick += btnExportCSV_ItemClick;
            // 
            // btnExportXML
            // 
            btnExportXML.Caption = "XML";
            btnExportXML.Hint = "Export records to XML";
            btnExportXML.Id = 5;
            btnExportXML.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnExportXML.ImageOptions.Image");
            btnExportXML.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnExportXML.ImageOptions.LargeImage");
            btnExportXML.Name = "btnExportXML";
            btnExportXML.ItemClick += btnExportXML_ItemClick;
            // 
            // btnExportTXT
            // 
            btnExportTXT.Caption = "TXT";
            btnExportTXT.Hint = "Export records to TXT";
            btnExportTXT.Id = 6;
            btnExportTXT.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnExportTXT.ImageOptions.Image");
            btnExportTXT.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnExportTXT.ImageOptions.LargeImage");
            btnExportTXT.Name = "btnExportTXT";
            btnExportTXT.ItemClick += btnExportTXT_ItemClick;
            // 
            // btnExportXLSX
            // 
            btnExportXLSX.Caption = "XLSX";
            btnExportXLSX.Hint = "Export records to XLSX";
            btnExportXLSX.Id = 7;
            btnExportXLSX.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnExportXLS.ImageOptions.Image");
            btnExportXLSX.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnExportXLS.ImageOptions.LargeImage");
            btnExportXLSX.Name = "btnExportXLSX";
            btnExportXLSX.ItemClick += btnExportXLSX_ItemClick;
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
            rpgExport.ItemLinks.Add(btnExportXLSX);
            rpgExport.ItemLinks.Add(btnExportTXT);
            rpgExport.Name = "rpgExport";
            rpgExport.Text = "Export";
            // 
            // gridControl
            // 
            gridControl.DataSource = customerListDtoBindingSource;
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl.Location = new System.Drawing.Point(0, 158);
            gridControl.MainView = gridView;
            gridControl.MenuManager = ribbon;
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(535, 291);
            gridControl.TabIndex = 5;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            gridControl.DoubleClick += gridControl_DoubleClick;
            // 
            // customerListDtoBindingSource
            // 
            customerListDtoBindingSource.DataSource = typeof(CustomerDto);
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName, colCode, colNIP, colAddress, colCity, colCountry, colPhone, colEmail });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.ReadOnly = true;
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
            colName.Name = "colName";
            colName.OptionsColumn.AllowFocus = false;
            colName.Visible = true;
            colName.VisibleIndex = 0;
            colName.Width = 93;
            // 
            // colCode
            // 
            colCode.Caption = "CODE";
            colCode.FieldName = "Code";
            colCode.Name = "colCode";
            colCode.OptionsColumn.AllowFocus = false;
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            colCode.Width = 46;
            // 
            // colNIP
            // 
            colNIP.Caption = "NIP";
            colNIP.FieldName = "NIP";
            colNIP.Name = "colNIP";
            colNIP.OptionsColumn.AllowFocus = false;
            colNIP.Visible = true;
            colNIP.VisibleIndex = 2;
            colNIP.Width = 46;
            // 
            // colAddress
            // 
            colAddress.Caption = "ADDRESS";
            colAddress.FieldName = "Address";
            colAddress.Name = "colAddress";
            colAddress.OptionsColumn.AllowFocus = false;
            colAddress.Visible = true;
            colAddress.VisibleIndex = 3;
            colAddress.Width = 93;
            // 
            // colCity
            // 
            colCity.Caption = "CITY";
            colCity.FieldName = "City";
            colCity.Name = "colCity";
            colCity.OptionsColumn.AllowFocus = false;
            colCity.Visible = true;
            colCity.VisibleIndex = 4;
            colCity.Width = 46;
            // 
            // colCountry
            // 
            colCountry.Caption = "COUNTRY";
            colCountry.FieldName = "Country";
            colCountry.Name = "colCountry";
            colCountry.OptionsColumn.AllowFocus = false;
            colCountry.Visible = true;
            colCountry.VisibleIndex = 5;
            colCountry.Width = 46;
            // 
            // colPhone
            // 
            colPhone.Caption = "PHONE";
            colPhone.FieldName = "Phone";
            colPhone.Name = "colPhone";
            colPhone.OptionsColumn.AllowFocus = false;
            colPhone.Visible = true;
            colPhone.VisibleIndex = 6;
            colPhone.Width = 46;
            // 
            // colEmail
            // 
            colEmail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            colEmail.AppearanceCell.Options.UseFont = true;
            colEmail.Caption = "EMAIL";
            colEmail.FieldName = "Email";
            colEmail.Name = "colEmail";
            colEmail.OptionsColumn.AllowFocus = false;
            colEmail.Visible = true;
            colEmail.VisibleIndex = 7;
            colEmail.Width = 50;
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(535, 449);
            Controls.Add(gridControl);
            Controls.Add(ribbon);
            Name = "CustomersView";
            Ribbon = ribbon;
            Text = "Customers";
            Load += CustomersView_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerListDtoBindingSource).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource customerListDtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNIP;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnExportCSV;
        private DevExpress.XtraBars.BarButtonItem btnExportXML;
        private DevExpress.XtraBars.BarButtonItem btnExportTXT;
        private DevExpress.XtraBars.BarButtonItem btnExportXLSX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExport;
    }
}
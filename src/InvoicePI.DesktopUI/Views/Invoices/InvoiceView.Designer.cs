namespace InvoicePI.DesktopUI.Views.Invoices
{
    partial class InvoiceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnConfirmAndClose = new DevExpress.XtraBars.BarButtonItem();
            btnResetChanges = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            rpCustomer = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgDelete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            lblDate = new DevExpress.XtraEditors.LabelControl();
            lblNameRequired = new DevExpress.XtraEditors.LabelControl();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            glueCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            customerDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colNIP = new DevExpress.XtraGrid.Columns.GridColumn();
            glueCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            currencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            lblCustomer = new DevExpress.XtraEditors.LabelControl();
            deDate = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblGeneral = new System.Windows.Forms.Label();
            cbeStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            label1 = new System.Windows.Forms.Label();
            separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            invoiceItemDetailDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            colGross = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            colVatRate = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnRemoveItem = new DevExpress.XtraEditors.SimpleButton();
            btnEditItem = new DevExpress.XtraEditors.SimpleButton();
            btnNewItem = new DevExpress.XtraEditors.SimpleButton();
            label2 = new System.Windows.Forms.Label();
            separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            seNet = new DevExpress.XtraEditors.SpinEdit();
            seVat = new DevExpress.XtraEditors.SpinEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            seGross = new DevExpress.XtraEditors.SpinEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            lblCurrency = new DevExpress.XtraEditors.LabelControl();
            label3 = new System.Windows.Forms.Label();
            separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            meDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbeStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceItemDetailDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seNet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seVat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seGross.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meDescription.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnSave, btnConfirmAndClose, btnResetChanges, btnDelete });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpCustomer });
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.Size = new System.Drawing.Size(616, 158);
            ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnSave
            // 
            btnSave.Caption = "Save";
            btnSave.Id = 1;
            btnSave.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSave.ImageOptions.LargeImage");
            btnSave.Name = "btnSave";
            btnSave.ItemClick += btnSave_ItemClick;
            // 
            // btnConfirmAndClose
            // 
            btnConfirmAndClose.Caption = "Confirm && Close";
            btnConfirmAndClose.Id = 2;
            btnConfirmAndClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnConfirmAndClose.ImageOptions.Image");
            btnConfirmAndClose.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnConfirmAndClose.ImageOptions.LargeImage");
            btnConfirmAndClose.Name = "btnConfirmAndClose";
            btnConfirmAndClose.ItemClick += btnSaveAndClose_ItemClick;
            // 
            // btnResetChanges
            // 
            btnResetChanges.Caption = "Reset Changes";
            btnResetChanges.Id = 3;
            btnResetChanges.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnResetChanges.ImageOptions.Image");
            btnResetChanges.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnResetChanges.ImageOptions.LargeImage");
            btnResetChanges.Name = "btnResetChanges";
            btnResetChanges.ItemClick += btnResetChanges_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Delete";
            btnDelete.Id = 4;
            btnDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.Name = "btnDelete";
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // rpCustomer
            // 
            rpCustomer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { rpgSave, rpgEdit, rpgDelete });
            rpCustomer.Name = "rpCustomer";
            rpCustomer.Text = "CUSTOMER";
            // 
            // rpgSave
            // 
            rpgSave.ItemLinks.Add(btnSave);
            rpgSave.ItemLinks.Add(btnConfirmAndClose);
            rpgSave.Name = "rpgSave";
            rpgSave.Text = "Save";
            // 
            // rpgEdit
            // 
            rpgEdit.ItemLinks.Add(btnResetChanges);
            rpgEdit.Name = "rpgEdit";
            rpgEdit.Text = "Edit";
            // 
            // rpgDelete
            // 
            rpgDelete.ItemLinks.Add(btnDelete);
            rpgDelete.Name = "rpgDelete";
            rpgDelete.Text = "Delete";
            // 
            // lblDate
            // 
            lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDate.Location = new System.Drawing.Point(34, 196);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(23, 13);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // lblNameRequired
            // 
            lblNameRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblNameRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblNameRequired.Appearance.Options.UseForeColor = true;
            lblNameRequired.Location = new System.Drawing.Point(61, 193);
            lblNameRequired.Name = "lblNameRequired";
            lblNameRequired.Size = new System.Drawing.Size(6, 13);
            lblNameRequired.TabIndex = 35;
            lblNameRequired.Text = "*";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // glueCustomer
            // 
            errorProvider.SetIconAlignment(glueCustomer, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueCustomer.Location = new System.Drawing.Point(291, 193);
            glueCustomer.MenuManager = ribbon;
            glueCustomer.Name = "glueCustomer";
            glueCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCustomer.Properties.DataSource = customerDtoBindingSource;
            glueCustomer.Properties.DisplayMember = "Name";
            glueCustomer.Properties.NullText = "";
            glueCustomer.Properties.PopupView = gridView2;
            glueCustomer.Properties.ValueMember = "Id";
            glueCustomer.Size = new System.Drawing.Size(302, 20);
            glueCustomer.TabIndex = 7;
            // 
            // customerDtoBindingSource
            // 
            customerDtoBindingSource.DataSource = typeof(Application.Dto.CustomerDto);
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName, colCode, colNIP });
            gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowIndicator = false;
            // 
            // colName
            // 
            colName.CustomizationCaption = "NAME";
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 0;
            // 
            // colCode
            // 
            colCode.CustomizationCaption = "CODE";
            colCode.FieldName = "Code";
            colCode.Name = "colCode";
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            // 
            // colNIP
            // 
            colNIP.CustomizationCaption = "NIP";
            colNIP.FieldName = "NIP";
            colNIP.Name = "colNIP";
            colNIP.Visible = true;
            colNIP.VisibleIndex = 2;
            // 
            // glueCurrency
            // 
            errorProvider.SetIconAlignment(glueCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueCurrency.Location = new System.Drawing.Point(518, 589);
            glueCurrency.MenuManager = ribbon;
            glueCurrency.Name = "glueCurrency";
            glueCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCurrency.Properties.DataSource = currencyDtoBindingSource;
            glueCurrency.Properties.DisplayMember = "Symbol";
            glueCurrency.Properties.NullText = "";
            glueCurrency.Properties.PopupView = gridView3;
            glueCurrency.Properties.ReadOnly = true;
            glueCurrency.Properties.ValueMember = "Id";
            glueCurrency.Size = new System.Drawing.Size(75, 20);
            glueCurrency.TabIndex = 93;
            // 
            // currencyDtoBindingSource
            // 
            currencyDtoBindingSource.DataSource = typeof(Application.Dto.CurrencyDto);
            // 
            // gridView3
            // 
            gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn2 });
            gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView3.Name = "gridView3";
            gridView3.OptionsBehavior.Editable = false;
            gridView3.OptionsBehavior.ReadOnly = true;
            gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            gridView3.OptionsView.ShowIndicator = false;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "SYMBOL";
            gridColumn2.FieldName = "Symbol";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCustomer.Location = new System.Drawing.Point(213, 196);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(46, 13);
            lblCustomer.TabIndex = 66;
            lblCustomer.Text = "Customer";
            // 
            // deDate
            // 
            deDate.EditValue = null;
            deDate.Location = new System.Drawing.Point(77, 193);
            deDate.MenuManager = ribbon;
            deDate.Name = "deDate";
            deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deDate.Size = new System.Drawing.Size(108, 20);
            deDate.TabIndex = 72;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(265, 193);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(6, 13);
            labelControl1.TabIndex = 74;
            labelControl1.Text = "*";
            // 
            // separatorControl1
            // 
            separatorControl1.Location = new System.Drawing.Point(61, 164);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new System.Drawing.Size(363, 23);
            separatorControl1.TabIndex = 75;
            // 
            // lblGeneral
            // 
            lblGeneral.AutoSize = true;
            lblGeneral.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGeneral.ForeColor = System.Drawing.Color.Navy;
            lblGeneral.Location = new System.Drawing.Point(25, 167);
            lblGeneral.Name = "lblGeneral";
            lblGeneral.Size = new System.Drawing.Size(51, 16);
            lblGeneral.TabIndex = 76;
            lblGeneral.Text = "General";
            // 
            // cbeStatus
            // 
            cbeStatus.Location = new System.Drawing.Point(462, 164);
            cbeStatus.MenuManager = ribbon;
            cbeStatus.Name = "cbeStatus";
            cbeStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbeStatus.Properties.ReadOnly = true;
            cbeStatus.Size = new System.Drawing.Size(131, 20);
            cbeStatus.TabIndex = 77;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.Location = new System.Drawing.Point(430, 167);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(26, 13);
            lblStatus.TabIndex = 78;
            lblStatus.Text = "State";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Navy;
            label1.Location = new System.Drawing.Point(25, 234);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 16);
            label1.TabIndex = 81;
            label1.Text = "Items";
            // 
            // separatorControl2
            // 
            separatorControl2.Location = new System.Drawing.Point(61, 231);
            separatorControl2.Name = "separatorControl2";
            separatorControl2.Size = new System.Drawing.Size(532, 23);
            separatorControl2.TabIndex = 80;
            // 
            // gridControl
            // 
            gridControl.DataSource = invoiceItemDetailDtoBindingSource;
            gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridControl.Location = new System.Drawing.Point(2, 42);
            gridControl.MainView = gvInvoiceItems;
            gridControl.MenuManager = ribbon;
            gridControl.Name = "gridControl";
            gridControl.Size = new System.Drawing.Size(564, 262);
            gridControl.TabIndex = 82;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvInvoiceItems });
            // 
            // invoiceItemDetailDtoBindingSource
            // 
            invoiceItemDetailDtoBindingSource.DataSource = typeof(Application.Dto.InvoiceItemDetailDto);
            // 
            // gvInvoiceItems
            // 
            gvInvoiceItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colProduct, colQuantity, colNet, colVat, colGross, colCurrency, colVatRate });
            gvInvoiceItems.GridControl = gridControl;
            gvInvoiceItems.Name = "gvInvoiceItems";
            gvInvoiceItems.OptionsBehavior.Editable = false;
            gvInvoiceItems.OptionsBehavior.ReadOnly = true;
            gvInvoiceItems.OptionsCustomization.AllowFilter = false;
            gvInvoiceItems.OptionsCustomization.AllowGroup = false;
            gvInvoiceItems.OptionsCustomization.AllowSort = false;
            gvInvoiceItems.OptionsFilter.AllowFilterEditor = false;
            gvInvoiceItems.OptionsView.ShowGroupExpandCollapseButtons = false;
            gvInvoiceItems.OptionsView.ShowGroupPanel = false;
            gvInvoiceItems.OptionsView.ShowIndicator = false;
            // 
            // colProduct
            // 
            colProduct.Caption = "PRODUCT";
            colProduct.FieldName = "Product";
            colProduct.Name = "colProduct";
            colProduct.Visible = true;
            colProduct.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "QUANTITY";
            colQuantity.FieldName = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 1;
            // 
            // colNet
            // 
            colNet.Caption = "NET";
            colNet.FieldName = "Net";
            colNet.Name = "colNet";
            colNet.Visible = true;
            colNet.VisibleIndex = 2;
            // 
            // colVat
            // 
            colVat.Caption = "VAT";
            colVat.FieldName = "Vat";
            colVat.Name = "colVat";
            colVat.Visible = true;
            colVat.VisibleIndex = 3;
            // 
            // colGross
            // 
            colGross.Caption = "GROSS";
            colGross.FieldName = "Gross";
            colGross.Name = "colGross";
            colGross.Visible = true;
            colGross.VisibleIndex = 4;
            // 
            // colCurrency
            // 
            colCurrency.Caption = "CURRENCY";
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 5;
            // 
            // colVatRate
            // 
            colVatRate.Caption = "VAT RATE";
            colVatRate.FieldName = "VatRate";
            colVatRate.Name = "colVatRate";
            colVatRate.Visible = true;
            colVatRate.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.Options.UseForeColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl1.Controls.Add(btnRemoveItem);
            panelControl1.Controls.Add(btnEditItem);
            panelControl1.Controls.Add(btnNewItem);
            panelControl1.Controls.Add(gridControl);
            panelControl1.Location = new System.Drawing.Point(25, 253);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(568, 306);
            panelControl1.TabIndex = 83;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnRemoveItem.ImageOptions.Image");
            btnRemoveItem.Location = new System.Drawing.Point(214, 0);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new System.Drawing.Size(101, 42);
            btnRemoveItem.TabIndex = 85;
            btnRemoveItem.Text = "Remove";
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnEditItem.ImageOptions.Image");
            btnEditItem.Location = new System.Drawing.Point(107, 0);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new System.Drawing.Size(101, 42);
            btnEditItem.TabIndex = 84;
            btnEditItem.Text = "Edit";
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnNewItem
            // 
            btnNewItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnNewItem.ImageOptions.Image");
            btnNewItem.Location = new System.Drawing.Point(0, 0);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new System.Drawing.Size(101, 42);
            btnNewItem.TabIndex = 83;
            btnNewItem.Text = "New (Item)";
            btnNewItem.Click += btnNewItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(23, 564);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 16);
            label2.TabIndex = 86;
            label2.Text = "Summary";
            // 
            // separatorControl3
            // 
            separatorControl3.Location = new System.Drawing.Point(77, 561);
            separatorControl3.Name = "separatorControl3";
            separatorControl3.Size = new System.Drawing.Size(514, 23);
            separatorControl3.TabIndex = 85;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl3.Location = new System.Drawing.Point(34, 592);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(17, 13);
            labelControl3.TabIndex = 87;
            labelControl3.Text = "Net";
            // 
            // seNet
            // 
            seNet.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seNet.Location = new System.Drawing.Point(77, 589);
            seNet.MenuManager = ribbon;
            seNet.Name = "seNet";
            seNet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seNet.Properties.DisplayFormat.FormatString = "N2";
            seNet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seNet.Properties.ReadOnly = true;
            seNet.Size = new System.Drawing.Size(75, 20);
            seNet.TabIndex = 88;
            // 
            // seVat
            // 
            seVat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seVat.Location = new System.Drawing.Point(213, 589);
            seVat.MenuManager = ribbon;
            seVat.Name = "seVat";
            seVat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seVat.Properties.DisplayFormat.FormatString = "N2";
            seVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seVat.Properties.ReadOnly = true;
            seVat.Size = new System.Drawing.Size(75, 20);
            seVat.TabIndex = 90;
            // 
            // labelControl4
            // 
            labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl4.Location = new System.Drawing.Point(170, 592);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(16, 13);
            labelControl4.TabIndex = 89;
            labelControl4.Text = "Vat";
            // 
            // seGross
            // 
            seGross.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seGross.Location = new System.Drawing.Point(349, 589);
            seGross.MenuManager = ribbon;
            seGross.Name = "seGross";
            seGross.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seGross.Properties.DisplayFormat.FormatString = "N2";
            seGross.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seGross.Properties.ReadOnly = true;
            seGross.Size = new System.Drawing.Size(75, 20);
            seGross.TabIndex = 92;
            // 
            // labelControl5
            // 
            labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl5.Location = new System.Drawing.Point(306, 592);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(27, 13);
            labelControl5.TabIndex = 91;
            labelControl5.Text = "Gross";
            // 
            // lblCurrency
            // 
            lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCurrency.Location = new System.Drawing.Point(452, 592);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(44, 13);
            lblCurrency.TabIndex = 94;
            lblCurrency.Text = "Currency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(23, 627);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 16);
            label3.TabIndex = 96;
            label3.Text = "Description";
            // 
            // separatorControl4
            // 
            separatorControl4.Location = new System.Drawing.Point(88, 624);
            separatorControl4.Name = "separatorControl4";
            separatorControl4.Size = new System.Drawing.Size(503, 23);
            separatorControl4.TabIndex = 95;
            // 
            // meDescription
            // 
            meDescription.Location = new System.Drawing.Point(27, 653);
            meDescription.MenuManager = ribbon;
            meDescription.Name = "meDescription";
            meDescription.Size = new System.Drawing.Size(564, 82);
            meDescription.TabIndex = 97;
            // 
            // InvoiceView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 762);
            Controls.Add(meDescription);
            Controls.Add(label3);
            Controls.Add(separatorControl4);
            Controls.Add(glueCurrency);
            Controls.Add(lblCurrency);
            Controls.Add(seGross);
            Controls.Add(labelControl5);
            Controls.Add(seVat);
            Controls.Add(labelControl4);
            Controls.Add(seNet);
            Controls.Add(labelControl3);
            Controls.Add(label2);
            Controls.Add(separatorControl3);
            Controls.Add(panelControl1);
            Controls.Add(label1);
            Controls.Add(separatorControl2);
            Controls.Add(lblStatus);
            Controls.Add(cbeStatus);
            Controls.Add(lblGeneral);
            Controls.Add(separatorControl1);
            Controls.Add(labelControl1);
            Controls.Add(deDate);
            Controls.Add(glueCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(lblNameRequired);
            Controls.Add(lblDate);
            Controls.Add(ribbon);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "InvoiceView";
            Ribbon = ribbon;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Sales Invoice";
            Load += CustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbeStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceItemDetailDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)separatorControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)seNet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seVat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seGross.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl4).EndInit();
            ((System.ComponentModel.ISupportInitialize)meDescription.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSave;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnConfirmAndClose;
        private DevExpress.XtraBars.BarButtonItem btnResetChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblNameRequired;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraEditors.GridLookUpEdit glueCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private System.Windows.Forms.BindingSource currencyDtoBindingSource;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cbeStatus;
        private System.Windows.Forms.Label lblGeneral;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceItems;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnRemoveItem;
        private DevExpress.XtraEditors.SimpleButton btnEditItem;
        private DevExpress.XtraEditors.SimpleButton btnNewItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.SpinEdit seGross;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit seVat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit seNet;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.GridLookUpEdit glueCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private System.Windows.Forms.BindingSource customerDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNIP;
        private System.Windows.Forms.BindingSource invoiceItemDetailDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colGross;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colVatRate;
    }
}
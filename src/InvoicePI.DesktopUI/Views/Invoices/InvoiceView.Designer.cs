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
            lblDateRequired = new DevExpress.XtraEditors.LabelControl();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            glueCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            customerDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colNIP = new DevExpress.XtraGrid.Columns.GridColumn();
            glueCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            currencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCurrencySymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            lblCustomer = new DevExpress.XtraEditors.LabelControl();
            deDate = new DevExpress.XtraEditors.DateEdit();
            lblCustomerRequired = new DevExpress.XtraEditors.LabelControl();
            scGeneral = new DevExpress.XtraEditors.SeparatorControl();
            lblGeneral = new System.Windows.Forms.Label();
            cbeStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            lblItems = new System.Windows.Forms.Label();
            scItems = new DevExpress.XtraEditors.SeparatorControl();
            gcInvoiceItems = new DevExpress.XtraGrid.GridControl();
            invoiceItemDetailDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            colOrdinalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            colGross = new DevExpress.XtraGrid.Columns.GridColumn();
            colVatRate = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl = new DevExpress.XtraEditors.PanelControl();
            btnRemoveItem = new DevExpress.XtraEditors.SimpleButton();
            btnOpenItem = new DevExpress.XtraEditors.SimpleButton();
            btnNewItem = new DevExpress.XtraEditors.SimpleButton();
            lblSummary = new System.Windows.Forms.Label();
            scSummary = new DevExpress.XtraEditors.SeparatorControl();
            lblSummaryNet = new DevExpress.XtraEditors.LabelControl();
            seNet = new DevExpress.XtraEditors.SpinEdit();
            seVat = new DevExpress.XtraEditors.SpinEdit();
            lblSummaryVat = new DevExpress.XtraEditors.LabelControl();
            seGross = new DevExpress.XtraEditors.SpinEdit();
            lblSummaryGross = new DevExpress.XtraEditors.LabelControl();
            lblSummaryCurrency = new DevExpress.XtraEditors.LabelControl();
            lblDescription = new System.Windows.Forms.Label();
            scDescription = new DevExpress.XtraEditors.SeparatorControl();
            meDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scGeneral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbeStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceItemDetailDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seNet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seVat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seGross.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scDescription).BeginInit();
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
            btnConfirmAndClose.ItemClick += btnConfirmAndClose_ItemClick;
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
            // lblDateRequired
            // 
            lblDateRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblDateRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblDateRequired.Appearance.Options.UseForeColor = true;
            lblDateRequired.Location = new System.Drawing.Point(61, 193);
            lblDateRequired.Name = "lblDateRequired";
            lblDateRequired.Size = new System.Drawing.Size(6, 13);
            lblDateRequired.TabIndex = 35;
            lblDateRequired.Text = "*";
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
            glueCustomer.Properties.PopupView = gvCustomer;
            glueCustomer.Properties.ValueMember = "Id";
            glueCustomer.Size = new System.Drawing.Size(302, 20);
            glueCustomer.TabIndex = 1;
            glueCustomer.EditValueChanged += glueCustomer_EditValueChanged;
            glueCustomer.Validating += glueCustomer_Validating;
            // 
            // customerDtoBindingSource
            // 
            customerDtoBindingSource.DataSource = typeof(Application.Dto.CustomerDto);
            // 
            // gvCustomer
            // 
            gvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName, colCode, colNIP });
            gvCustomer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gvCustomer.Name = "gvCustomer";
            gvCustomer.OptionsBehavior.Editable = false;
            gvCustomer.OptionsBehavior.ReadOnly = true;
            gvCustomer.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvCustomer.OptionsView.ShowGroupPanel = false;
            gvCustomer.OptionsView.ShowIndicator = false;
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
            glueCurrency.Properties.PopupView = gvCurrency;
            glueCurrency.Properties.ReadOnly = true;
            glueCurrency.Properties.ValueMember = "Id";
            glueCurrency.Size = new System.Drawing.Size(75, 20);
            glueCurrency.TabIndex = 93;
            // 
            // currencyDtoBindingSource
            // 
            currencyDtoBindingSource.DataSource = typeof(Application.Dto.CurrencyDto);
            // 
            // gvCurrency
            // 
            gvCurrency.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCurrencySymbol });
            gvCurrency.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gvCurrency.Name = "gvCurrency";
            gvCurrency.OptionsBehavior.Editable = false;
            gvCurrency.OptionsBehavior.ReadOnly = true;
            gvCurrency.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvCurrency.OptionsView.ShowGroupPanel = false;
            gvCurrency.OptionsView.ShowIndicator = false;
            // 
            // colCurrencySymbol
            // 
            colCurrencySymbol.Caption = "SYMBOL";
            colCurrencySymbol.FieldName = "Symbol";
            colCurrencySymbol.Name = "colCurrencySymbol";
            colCurrencySymbol.Visible = true;
            colCurrencySymbol.VisibleIndex = 0;
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
            deDate.TabIndex = 0;
            // 
            // lblCustomerRequired
            // 
            lblCustomerRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCustomerRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblCustomerRequired.Appearance.Options.UseForeColor = true;
            lblCustomerRequired.Location = new System.Drawing.Point(265, 193);
            lblCustomerRequired.Name = "lblCustomerRequired";
            lblCustomerRequired.Size = new System.Drawing.Size(6, 13);
            lblCustomerRequired.TabIndex = 74;
            lblCustomerRequired.Text = "*";
            // 
            // scGeneral
            // 
            scGeneral.Location = new System.Drawing.Point(61, 164);
            scGeneral.Name = "scGeneral";
            scGeneral.Size = new System.Drawing.Size(363, 23);
            scGeneral.TabIndex = 75;
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
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblItems.ForeColor = System.Drawing.Color.Navy;
            lblItems.Location = new System.Drawing.Point(25, 234);
            lblItems.Name = "lblItems";
            lblItems.Size = new System.Drawing.Size(39, 16);
            lblItems.TabIndex = 81;
            lblItems.Text = "Items";
            // 
            // scItems
            // 
            scItems.Location = new System.Drawing.Point(61, 231);
            scItems.Name = "scItems";
            scItems.Size = new System.Drawing.Size(532, 23);
            scItems.TabIndex = 80;
            // 
            // gcInvoiceItems
            // 
            gcInvoiceItems.DataSource = invoiceItemDetailDtoBindingSource;
            gcInvoiceItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            gcInvoiceItems.Location = new System.Drawing.Point(2, 42);
            gcInvoiceItems.MainView = gvInvoiceItems;
            gcInvoiceItems.MenuManager = ribbon;
            gcInvoiceItems.Name = "gcInvoiceItems";
            gcInvoiceItems.Size = new System.Drawing.Size(564, 262);
            gcInvoiceItems.TabIndex = 3;
            gcInvoiceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvInvoiceItems });
            // 
            // invoiceItemDetailDtoBindingSource
            // 
            invoiceItemDetailDtoBindingSource.DataSource = typeof(Application.Dto.InvoiceItemDetailDto);
            // 
            // gvInvoiceItems
            // 
            gvInvoiceItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOrdinalNumber, colProduct, colQuantity, colPrice, colCurrency, colNet, colGross, colVatRate });
            gvInvoiceItems.GridControl = gcInvoiceItems;
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
            gvInvoiceItems.RowCountChanged += gvInvoiceItems_RowCountChanged;
            // 
            // colOrdinalNumber
            // 
            colOrdinalNumber.Caption = "NO.";
            colOrdinalNumber.FieldName = "OrdinalNumber";
            colOrdinalNumber.Name = "colOrdinalNumber";
            colOrdinalNumber.OptionsColumn.AllowFocus = false;
            colOrdinalNumber.Visible = true;
            colOrdinalNumber.VisibleIndex = 0;
            // 
            // colProduct
            // 
            colProduct.Caption = "PRODUCT";
            colProduct.FieldName = "Product";
            colProduct.Name = "colProduct";
            colProduct.OptionsColumn.AllowFocus = false;
            colProduct.Visible = true;
            colProduct.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "QUANTITY";
            colQuantity.FieldName = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.OptionsColumn.AllowFocus = false;
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 2;
            // 
            // colPrice
            // 
            colPrice.Caption = "PRICE";
            colPrice.FieldName = "Price";
            colPrice.Name = "colPrice";
            colPrice.OptionsColumn.AllowFocus = false;
            colPrice.Visible = true;
            colPrice.VisibleIndex = 3;
            // 
            // colCurrency
            // 
            colCurrency.Caption = "CURRENCY";
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.OptionsColumn.AllowFocus = false;
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 4;
            // 
            // colNet
            // 
            colNet.Caption = "NET";
            colNet.FieldName = "Net";
            colNet.Name = "colNet";
            colNet.OptionsColumn.AllowFocus = false;
            colNet.Visible = true;
            colNet.VisibleIndex = 5;
            // 
            // colGross
            // 
            colGross.Caption = "GROSS";
            colGross.FieldName = "Gross";
            colGross.Name = "colGross";
            colGross.OptionsColumn.AllowFocus = false;
            colGross.Visible = true;
            colGross.VisibleIndex = 6;
            // 
            // colVatRate
            // 
            colVatRate.Caption = "VAT RATE";
            colVatRate.FieldName = "VatRate";
            colVatRate.Name = "colVatRate";
            colVatRate.OptionsColumn.AllowFocus = false;
            colVatRate.Visible = true;
            colVatRate.VisibleIndex = 7;
            // 
            // panelControl
            // 
            panelControl.Appearance.Options.UseForeColor = true;
            panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl.Controls.Add(btnRemoveItem);
            panelControl.Controls.Add(btnOpenItem);
            panelControl.Controls.Add(btnNewItem);
            panelControl.Controls.Add(gcInvoiceItems);
            panelControl.Location = new System.Drawing.Point(25, 253);
            panelControl.Name = "panelControl";
            panelControl.Size = new System.Drawing.Size(568, 306);
            panelControl.TabIndex = 83;
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
            // btnOpenItem
            // 
            btnOpenItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOpenItem.ImageOptions.Image");
            btnOpenItem.Location = new System.Drawing.Point(107, 0);
            btnOpenItem.Name = "btnOpenItem";
            btnOpenItem.Size = new System.Drawing.Size(101, 42);
            btnOpenItem.TabIndex = 84;
            btnOpenItem.Text = "Open";
            btnOpenItem.Click += btnOpenItem_Click;
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
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSummary.ForeColor = System.Drawing.Color.Navy;
            lblSummary.Location = new System.Drawing.Point(23, 564);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new System.Drawing.Size(62, 16);
            lblSummary.TabIndex = 86;
            lblSummary.Text = "Summary";
            // 
            // scSummary
            // 
            scSummary.Location = new System.Drawing.Point(77, 561);
            scSummary.Name = "scSummary";
            scSummary.Size = new System.Drawing.Size(514, 23);
            scSummary.TabIndex = 85;
            // 
            // lblSummaryNet
            // 
            lblSummaryNet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSummaryNet.Location = new System.Drawing.Point(34, 592);
            lblSummaryNet.Name = "lblSummaryNet";
            lblSummaryNet.Size = new System.Drawing.Size(17, 13);
            lblSummaryNet.TabIndex = 87;
            lblSummaryNet.Text = "Net";
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
            // lblSummaryVat
            // 
            lblSummaryVat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSummaryVat.Location = new System.Drawing.Point(170, 592);
            lblSummaryVat.Name = "lblSummaryVat";
            lblSummaryVat.Size = new System.Drawing.Size(16, 13);
            lblSummaryVat.TabIndex = 89;
            lblSummaryVat.Text = "Vat";
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
            // lblSummaryGross
            // 
            lblSummaryGross.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSummaryGross.Location = new System.Drawing.Point(306, 592);
            lblSummaryGross.Name = "lblSummaryGross";
            lblSummaryGross.Size = new System.Drawing.Size(27, 13);
            lblSummaryGross.TabIndex = 91;
            lblSummaryGross.Text = "Gross";
            // 
            // lblSummaryCurrency
            // 
            lblSummaryCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSummaryCurrency.Location = new System.Drawing.Point(452, 592);
            lblSummaryCurrency.Name = "lblSummaryCurrency";
            lblSummaryCurrency.Size = new System.Drawing.Size(44, 13);
            lblSummaryCurrency.TabIndex = 94;
            lblSummaryCurrency.Text = "Currency";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDescription.ForeColor = System.Drawing.Color.Navy;
            lblDescription.Location = new System.Drawing.Point(23, 627);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(70, 16);
            lblDescription.TabIndex = 96;
            lblDescription.Text = "Description";
            // 
            // scDescription
            // 
            scDescription.Location = new System.Drawing.Point(88, 624);
            scDescription.Name = "scDescription";
            scDescription.Size = new System.Drawing.Size(503, 23);
            scDescription.TabIndex = 95;
            // 
            // meDescription
            // 
            meDescription.Location = new System.Drawing.Point(27, 653);
            meDescription.MenuManager = ribbon;
            meDescription.Name = "meDescription";
            meDescription.Size = new System.Drawing.Size(564, 82);
            meDescription.TabIndex = 4;
            // 
            // InvoiceView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 762);
            Controls.Add(meDescription);
            Controls.Add(lblDescription);
            Controls.Add(scDescription);
            Controls.Add(glueCurrency);
            Controls.Add(lblSummaryCurrency);
            Controls.Add(seGross);
            Controls.Add(lblSummaryGross);
            Controls.Add(seVat);
            Controls.Add(lblSummaryVat);
            Controls.Add(seNet);
            Controls.Add(lblSummaryNet);
            Controls.Add(lblSummary);
            Controls.Add(scSummary);
            Controls.Add(panelControl);
            Controls.Add(lblItems);
            Controls.Add(scItems);
            Controls.Add(lblStatus);
            Controls.Add(cbeStatus);
            Controls.Add(lblGeneral);
            Controls.Add(scGeneral);
            Controls.Add(lblCustomerRequired);
            Controls.Add(deDate);
            Controls.Add(glueCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(lblDateRequired);
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
            ((System.ComponentModel.ISupportInitialize)gvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)deDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)scGeneral).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbeStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)scItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceItemDetailDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl).EndInit();
            panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)seNet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seVat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seGross.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)scDescription).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblDateRequired;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraEditors.GridLookUpEdit glueCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private System.Windows.Forms.BindingSource currencyDtoBindingSource;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.LabelControl lblCustomerRequired;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cbeStatus;
        private System.Windows.Forms.Label lblGeneral;
        private DevExpress.XtraEditors.SeparatorControl scGeneral;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraGrid.GridControl gcInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceItems;
        private System.Windows.Forms.Label lblItems;
        private DevExpress.XtraEditors.SeparatorControl scItems;
        private DevExpress.XtraEditors.SimpleButton btnRemoveItem;
        private DevExpress.XtraEditors.SimpleButton btnOpenItem;
        private DevExpress.XtraEditors.SimpleButton btnNewItem;
        private DevExpress.XtraEditors.LabelControl lblSummaryNet;
        private System.Windows.Forms.Label lblSummary;
        private DevExpress.XtraEditors.SeparatorControl scSummary;
        private DevExpress.XtraEditors.SpinEdit seGross;
        private DevExpress.XtraEditors.LabelControl lblSummaryGross;
        private DevExpress.XtraEditors.SpinEdit seVat;
        private DevExpress.XtraEditors.LabelControl lblSummaryVat;
        private DevExpress.XtraEditors.SpinEdit seNet;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.SeparatorControl scDescription;
        private DevExpress.XtraEditors.GridLookUpEdit glueCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencySymbol;
        private DevExpress.XtraEditors.LabelControl lblSummaryCurrency;
        private System.Windows.Forms.BindingSource customerDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNIP;
        private System.Windows.Forms.BindingSource invoiceItemDetailDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colGross;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colVatRate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdinalNumber;
    }
}
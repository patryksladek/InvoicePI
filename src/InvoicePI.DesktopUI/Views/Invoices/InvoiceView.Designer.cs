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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnRemoveItem = new DevExpress.XtraEditors.SimpleButton();
            btnOpenItem = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)gcInvoiceItems).BeginInit();
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
            ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnSave, btnConfirmAndClose, btnResetChanges, btnDelete });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.Margin = new System.Windows.Forms.Padding(4);
            ribbon.MaxItemId = 8;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 385;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpCustomer });
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.Size = new System.Drawing.Size(719, 193);
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
            lblDate.Location = new System.Drawing.Point(40, 241);
            lblDate.Margin = new System.Windows.Forms.Padding(4);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(26, 16);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // lblNameRequired
            // 
            lblNameRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblNameRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblNameRequired.Appearance.Options.UseForeColor = true;
            lblNameRequired.Location = new System.Drawing.Point(71, 238);
            lblNameRequired.Margin = new System.Windows.Forms.Padding(4);
            lblNameRequired.Name = "lblNameRequired";
            lblNameRequired.Size = new System.Drawing.Size(8, 16);
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
            glueCustomer.Location = new System.Drawing.Point(340, 238);
            glueCustomer.Margin = new System.Windows.Forms.Padding(4);
            glueCustomer.MenuManager = ribbon;
            glueCustomer.Name = "glueCustomer";
            glueCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCustomer.Properties.DataSource = customerDtoBindingSource;
            glueCustomer.Properties.DisplayMember = "Name";
            glueCustomer.Properties.NullText = "";
            glueCustomer.Properties.PopupView = gridView2;
            glueCustomer.Properties.ValueMember = "Id";
            glueCustomer.Size = new System.Drawing.Size(352, 22);
            glueCustomer.TabIndex = 1;
            glueCustomer.EditValueChanged += glueCustomer_EditValueChanged;
            glueCustomer.Validating += glueCustomer_Validating;
            // 
            // customerDtoBindingSource
            // 
            customerDtoBindingSource.DataSource = typeof(Application.Dto.CustomerDto);
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName, colCode, colNIP });
            gridView2.DetailHeight = 431;
            gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsEditForm.PopupEditFormWidth = 933;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowIndicator = false;
            // 
            // colName
            // 
            colName.CustomizationCaption = "NAME";
            colName.FieldName = "Name";
            colName.MinWidth = 23;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 0;
            colName.Width = 87;
            // 
            // colCode
            // 
            colCode.CustomizationCaption = "CODE";
            colCode.FieldName = "Code";
            colCode.MinWidth = 23;
            colCode.Name = "colCode";
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            colCode.Width = 87;
            // 
            // colNIP
            // 
            colNIP.CustomizationCaption = "NIP";
            colNIP.FieldName = "NIP";
            colNIP.MinWidth = 23;
            colNIP.Name = "colNIP";
            colNIP.Visible = true;
            colNIP.VisibleIndex = 2;
            colNIP.Width = 87;
            // 
            // glueCurrency
            // 
            errorProvider.SetIconAlignment(glueCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueCurrency.Location = new System.Drawing.Point(604, 725);
            glueCurrency.Margin = new System.Windows.Forms.Padding(4);
            glueCurrency.MenuManager = ribbon;
            glueCurrency.Name = "glueCurrency";
            glueCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCurrency.Properties.DataSource = currencyDtoBindingSource;
            glueCurrency.Properties.DisplayMember = "Symbol";
            glueCurrency.Properties.NullText = "";
            glueCurrency.Properties.PopupView = gridView3;
            glueCurrency.Properties.ReadOnly = true;
            glueCurrency.Properties.ValueMember = "Id";
            glueCurrency.Size = new System.Drawing.Size(88, 22);
            glueCurrency.TabIndex = 93;
            // 
            // currencyDtoBindingSource
            // 
            currencyDtoBindingSource.DataSource = typeof(Application.Dto.CurrencyDto);
            // 
            // gridView3
            // 
            gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn2 });
            gridView3.DetailHeight = 431;
            gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView3.Name = "gridView3";
            gridView3.OptionsBehavior.Editable = false;
            gridView3.OptionsBehavior.ReadOnly = true;
            gridView3.OptionsEditForm.PopupEditFormWidth = 933;
            gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            gridView3.OptionsView.ShowIndicator = false;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "SYMBOL";
            gridColumn2.FieldName = "Symbol";
            gridColumn2.MinWidth = 23;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            gridColumn2.Width = 87;
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCustomer.Location = new System.Drawing.Point(248, 241);
            lblCustomer.Margin = new System.Windows.Forms.Padding(4);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(55, 16);
            lblCustomer.TabIndex = 66;
            lblCustomer.Text = "Customer";
            // 
            // deDate
            // 
            deDate.EditValue = null;
            deDate.Location = new System.Drawing.Point(90, 238);
            deDate.Margin = new System.Windows.Forms.Padding(4);
            deDate.MenuManager = ribbon;
            deDate.Name = "deDate";
            deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            deDate.Size = new System.Drawing.Size(126, 22);
            deDate.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(309, 238);
            labelControl1.Margin = new System.Windows.Forms.Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(8, 16);
            labelControl1.TabIndex = 74;
            labelControl1.Text = "*";
            // 
            // separatorControl1
            // 
            separatorControl1.Location = new System.Drawing.Point(71, 202);
            separatorControl1.Margin = new System.Windows.Forms.Padding(4);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            separatorControl1.Size = new System.Drawing.Size(424, 28);
            separatorControl1.TabIndex = 75;
            // 
            // lblGeneral
            // 
            lblGeneral.AutoSize = true;
            lblGeneral.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGeneral.ForeColor = System.Drawing.Color.Navy;
            lblGeneral.Location = new System.Drawing.Point(29, 206);
            lblGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGeneral.Name = "lblGeneral";
            lblGeneral.Size = new System.Drawing.Size(67, 21);
            lblGeneral.TabIndex = 76;
            lblGeneral.Text = "General";
            // 
            // cbeStatus
            // 
            cbeStatus.Location = new System.Drawing.Point(539, 202);
            cbeStatus.Margin = new System.Windows.Forms.Padding(4);
            cbeStatus.MenuManager = ribbon;
            cbeStatus.Name = "cbeStatus";
            cbeStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbeStatus.Properties.ReadOnly = true;
            cbeStatus.Size = new System.Drawing.Size(153, 22);
            cbeStatus.TabIndex = 77;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.Location = new System.Drawing.Point(502, 206);
            lblStatus.Margin = new System.Windows.Forms.Padding(4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(30, 16);
            lblStatus.TabIndex = 78;
            lblStatus.Text = "State";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Navy;
            label1.Location = new System.Drawing.Point(29, 288);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 21);
            label1.TabIndex = 81;
            label1.Text = "Items";
            // 
            // separatorControl2
            // 
            separatorControl2.Location = new System.Drawing.Point(71, 284);
            separatorControl2.Margin = new System.Windows.Forms.Padding(4);
            separatorControl2.Name = "separatorControl2";
            separatorControl2.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            separatorControl2.Size = new System.Drawing.Size(621, 28);
            separatorControl2.TabIndex = 80;
            // 
            // gcInvoiceItems
            // 
            gcInvoiceItems.DataSource = invoiceItemDetailDtoBindingSource;
            gcInvoiceItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            gcInvoiceItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gcInvoiceItems.Location = new System.Drawing.Point(2, 53);
            gcInvoiceItems.MainView = gvInvoiceItems;
            gcInvoiceItems.Margin = new System.Windows.Forms.Padding(4);
            gcInvoiceItems.MenuManager = ribbon;
            gcInvoiceItems.Name = "gcInvoiceItems";
            gcInvoiceItems.Size = new System.Drawing.Size(659, 322);
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
            gvInvoiceItems.DetailHeight = 431;
            gvInvoiceItems.GridControl = gcInvoiceItems;
            gvInvoiceItems.Name = "gvInvoiceItems";
            gvInvoiceItems.OptionsBehavior.Editable = false;
            gvInvoiceItems.OptionsBehavior.ReadOnly = true;
            gvInvoiceItems.OptionsCustomization.AllowFilter = false;
            gvInvoiceItems.OptionsCustomization.AllowGroup = false;
            gvInvoiceItems.OptionsCustomization.AllowSort = false;
            gvInvoiceItems.OptionsEditForm.PopupEditFormWidth = 933;
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
            colOrdinalNumber.MinWidth = 23;
            colOrdinalNumber.Name = "colOrdinalNumber";
            colOrdinalNumber.OptionsColumn.AllowFocus = false;
            colOrdinalNumber.Visible = true;
            colOrdinalNumber.VisibleIndex = 0;
            colOrdinalNumber.Width = 87;
            // 
            // colProduct
            // 
            colProduct.Caption = "PRODUCT";
            colProduct.FieldName = "Product";
            colProduct.MinWidth = 23;
            colProduct.Name = "colProduct";
            colProduct.OptionsColumn.AllowFocus = false;
            colProduct.Visible = true;
            colProduct.VisibleIndex = 1;
            colProduct.Width = 87;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "QUANTITY";
            colQuantity.FieldName = "Quantity";
            colQuantity.MinWidth = 23;
            colQuantity.Name = "colQuantity";
            colQuantity.OptionsColumn.AllowFocus = false;
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 2;
            colQuantity.Width = 87;
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
            colPrice.Width = 87;
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
            // colNet
            // 
            colNet.Caption = "NET";
            colNet.FieldName = "Net";
            colNet.MinWidth = 23;
            colNet.Name = "colNet";
            colNet.OptionsColumn.AllowFocus = false;
            colNet.Visible = true;
            colNet.VisibleIndex = 5;
            colNet.Width = 87;
            // 
            // colGross
            // 
            colGross.Caption = "GROSS";
            colGross.FieldName = "Gross";
            colGross.MinWidth = 23;
            colGross.Name = "colGross";
            colGross.OptionsColumn.AllowFocus = false;
            colGross.Visible = true;
            colGross.VisibleIndex = 6;
            colGross.Width = 87;
            // 
            // colVatRate
            // 
            colVatRate.Caption = "VAT RATE";
            colVatRate.FieldName = "VatRate";
            colVatRate.MinWidth = 23;
            colVatRate.Name = "colVatRate";
            colVatRate.OptionsColumn.AllowFocus = false;
            colVatRate.Visible = true;
            colVatRate.VisibleIndex = 7;
            colVatRate.Width = 87;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.Options.UseForeColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl1.Controls.Add(btnRemoveItem);
            panelControl1.Controls.Add(btnOpenItem);
            panelControl1.Controls.Add(btnNewItem);
            panelControl1.Controls.Add(gcInvoiceItems);
            panelControl1.Location = new System.Drawing.Point(29, 311);
            panelControl1.Margin = new System.Windows.Forms.Padding(4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(663, 377);
            panelControl1.TabIndex = 83;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnRemoveItem.ImageOptions.Image");
            btnRemoveItem.Location = new System.Drawing.Point(250, 0);
            btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new System.Drawing.Size(118, 52);
            btnRemoveItem.TabIndex = 85;
            btnRemoveItem.Text = "Remove";
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnOpenItem
            // 
            btnOpenItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOpenItem.ImageOptions.Image");
            btnOpenItem.Location = new System.Drawing.Point(125, 0);
            btnOpenItem.Margin = new System.Windows.Forms.Padding(4);
            btnOpenItem.Name = "btnOpenItem";
            btnOpenItem.Size = new System.Drawing.Size(118, 52);
            btnOpenItem.TabIndex = 84;
            btnOpenItem.Text = "Open";
            btnOpenItem.Click += btnOpenItem_Click;
            // 
            // btnNewItem
            // 
            btnNewItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnNewItem.ImageOptions.Image");
            btnNewItem.Location = new System.Drawing.Point(0, 0);
            btnNewItem.Margin = new System.Windows.Forms.Padding(4);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new System.Drawing.Size(118, 52);
            btnNewItem.TabIndex = 83;
            btnNewItem.Text = "New (Item)";
            btnNewItem.Click += btnNewItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(27, 694);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 21);
            label2.TabIndex = 86;
            label2.Text = "Summary";
            // 
            // separatorControl3
            // 
            separatorControl3.Location = new System.Drawing.Point(90, 690);
            separatorControl3.Margin = new System.Windows.Forms.Padding(4);
            separatorControl3.Name = "separatorControl3";
            separatorControl3.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            separatorControl3.Size = new System.Drawing.Size(600, 28);
            separatorControl3.TabIndex = 85;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl3.Location = new System.Drawing.Point(40, 729);
            labelControl3.Margin = new System.Windows.Forms.Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(19, 16);
            labelControl3.TabIndex = 87;
            labelControl3.Text = "Net";
            // 
            // seNet
            // 
            seNet.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seNet.Location = new System.Drawing.Point(90, 725);
            seNet.Margin = new System.Windows.Forms.Padding(4);
            seNet.MenuManager = ribbon;
            seNet.Name = "seNet";
            seNet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seNet.Properties.DisplayFormat.FormatString = "N2";
            seNet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seNet.Properties.ReadOnly = true;
            seNet.Size = new System.Drawing.Size(88, 24);
            seNet.TabIndex = 88;
            // 
            // seVat
            // 
            seVat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seVat.Location = new System.Drawing.Point(248, 725);
            seVat.Margin = new System.Windows.Forms.Padding(4);
            seVat.MenuManager = ribbon;
            seVat.Name = "seVat";
            seVat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seVat.Properties.DisplayFormat.FormatString = "N2";
            seVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seVat.Properties.ReadOnly = true;
            seVat.Size = new System.Drawing.Size(88, 24);
            seVat.TabIndex = 90;
            // 
            // labelControl4
            // 
            labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl4.Location = new System.Drawing.Point(198, 729);
            labelControl4.Margin = new System.Windows.Forms.Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(19, 16);
            labelControl4.TabIndex = 89;
            labelControl4.Text = "Vat";
            // 
            // seGross
            // 
            seGross.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seGross.Location = new System.Drawing.Point(407, 725);
            seGross.Margin = new System.Windows.Forms.Padding(4);
            seGross.MenuManager = ribbon;
            seGross.Name = "seGross";
            seGross.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seGross.Properties.DisplayFormat.FormatString = "N2";
            seGross.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seGross.Properties.ReadOnly = true;
            seGross.Size = new System.Drawing.Size(88, 24);
            seGross.TabIndex = 92;
            // 
            // labelControl5
            // 
            labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl5.Location = new System.Drawing.Point(357, 729);
            labelControl5.Margin = new System.Windows.Forms.Padding(4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(32, 16);
            labelControl5.TabIndex = 91;
            labelControl5.Text = "Gross";
            // 
            // lblCurrency
            // 
            lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCurrency.Location = new System.Drawing.Point(527, 729);
            lblCurrency.Margin = new System.Windows.Forms.Padding(4);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(51, 16);
            lblCurrency.TabIndex = 94;
            lblCurrency.Text = "Currency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(27, 772);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 21);
            label3.TabIndex = 96;
            label3.Text = "Description";
            // 
            // separatorControl4
            // 
            separatorControl4.Location = new System.Drawing.Point(103, 768);
            separatorControl4.Margin = new System.Windows.Forms.Padding(4);
            separatorControl4.Name = "separatorControl4";
            separatorControl4.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            separatorControl4.Size = new System.Drawing.Size(587, 28);
            separatorControl4.TabIndex = 95;
            // 
            // meDescription
            // 
            meDescription.Location = new System.Drawing.Point(31, 804);
            meDescription.Margin = new System.Windows.Forms.Padding(4);
            meDescription.MenuManager = ribbon;
            meDescription.Name = "meDescription";
            meDescription.Size = new System.Drawing.Size(658, 101);
            meDescription.TabIndex = 4;
            // 
            // InvoiceView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(719, 938);
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
            Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)gcInvoiceItems).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceItems;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnRemoveItem;
        private DevExpress.XtraEditors.SimpleButton btnOpenItem;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colGross;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colVatRate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdinalNumber;
    }
}
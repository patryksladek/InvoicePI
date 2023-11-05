namespace InvoicePI.DesktopUI.Views.Invoices
{
    partial class InvoiceItemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceItemView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnOK = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            rpCustomer = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgDelete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            lblNameRequired = new DevExpress.XtraEditors.LabelControl();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            glueVatRate = new DevExpress.XtraEditors.GridLookUpEdit();
            vatRateDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            glueProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            productDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            glueCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            currencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            glueSummaryCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            summaryCurrencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            lblQuantity = new DevExpress.XtraEditors.LabelControl();
            lblVatRate = new DevExpress.XtraEditors.LabelControl();
            lblPrice = new DevExpress.XtraEditors.LabelControl();
            tePrice = new DevExpress.XtraEditors.SpinEdit();
            lblCurrency = new DevExpress.XtraEditors.LabelControl();
            seQuantity = new DevExpress.XtraEditors.SpinEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            seSummaryGross = new DevExpress.XtraEditors.SpinEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            seSummaryVat = new DevExpress.XtraEditors.SpinEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            seSummaryNet = new DevExpress.XtraEditors.SpinEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            label2 = new System.Windows.Forms.Label();
            separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueVatRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatRateDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueProduct.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueSummaryCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryCurrencyDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryGross.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryVat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryNet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl3).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnOK, btnDelete });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.Margin = new System.Windows.Forms.Padding(4);
            ribbon.MaxItemId = 9;
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
            // btnOK
            // 
            btnOK.Caption = "OK";
            btnOK.Id = 1;
            btnOK.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnOK.ImageOptions.Image");
            btnOK.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnOK.ImageOptions.LargeImage");
            btnOK.Name = "btnOK";
            btnOK.ItemClick += btnOK_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Delete";
            btnDelete.Id = 8;
            btnDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("bbiDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("bbiDelete.ImageOptions.LargeImage");
            btnDelete.Name = "btnDelete";
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // rpCustomer
            // 
            rpCustomer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { rpgSave, rpgDelete });
            rpCustomer.Name = "rpCustomer";
            rpCustomer.Text = "CUSTOMER";
            // 
            // rpgSave
            // 
            rpgSave.ItemLinks.Add(btnOK);
            rpgSave.Name = "rpgSave";
            rpgSave.Text = "Save";
            // 
            // rpgDelete
            // 
            rpgDelete.ItemLinks.Add(btnDelete);
            rpgDelete.Name = "rpgDelete";
            rpgDelete.Text = "Delete";
            // 
            // lblNameRequired
            // 
            lblNameRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblNameRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblNameRequired.Appearance.Options.UseForeColor = true;
            lblNameRequired.Location = new System.Drawing.Point(85, 206);
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
            // glueVatRate
            // 
            errorProvider.SetIconAlignment(glueVatRate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueVatRate.Location = new System.Drawing.Point(573, 202);
            glueVatRate.Margin = new System.Windows.Forms.Padding(4);
            glueVatRate.MenuManager = ribbon;
            glueVatRate.Name = "glueVatRate";
            glueVatRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueVatRate.Properties.DataSource = vatRateDtoBindingSource;
            glueVatRate.Properties.DisplayMember = "Symbol";
            glueVatRate.Properties.NullText = "";
            glueVatRate.Properties.PopupView = gridView1;
            glueVatRate.Properties.ReadOnly = true;
            glueVatRate.Properties.ValueMember = "Id";
            glueVatRate.Size = new System.Drawing.Size(114, 22);
            glueVatRate.TabIndex = 6;
            // 
            // vatRateDtoBindingSource
            // 
            vatRateDtoBindingSource.DataSource = typeof(Application.Dto.VatRateDto);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            gridView1.DetailHeight = 431;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "SYMBOL";
            gridColumn1.FieldName = "Symbol";
            gridColumn1.MinWidth = 23;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 87;
            // 
            // glueProduct
            // 
            errorProvider.SetIconAlignment(glueProduct, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueProduct.Location = new System.Drawing.Point(127, 202);
            glueProduct.Margin = new System.Windows.Forms.Padding(4);
            glueProduct.MenuManager = ribbon;
            glueProduct.Name = "glueProduct";
            glueProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueProduct.Properties.DataSource = productDtoBindingSource;
            glueProduct.Properties.DisplayMember = "Name";
            glueProduct.Properties.NullText = "";
            glueProduct.Properties.PopupView = gridView2;
            glueProduct.Properties.ValueMember = "Id";
            glueProduct.Size = new System.Drawing.Size(310, 22);
            glueProduct.TabIndex = 1;
            glueProduct.EditValueChanged += glueProduct_EditValueChanged;
            // 
            // productDtoBindingSource
            // 
            productDtoBindingSource.DataSource = typeof(Application.Dto.ProductDto);
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName });
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
            colName.FieldName = "Name";
            colName.MinWidth = 23;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 0;
            colName.Width = 87;
            // 
            // glueCurrency
            // 
            errorProvider.SetIconAlignment(glueCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueCurrency.Location = new System.Drawing.Point(573, 234);
            glueCurrency.Margin = new System.Windows.Forms.Padding(4);
            glueCurrency.MenuManager = ribbon;
            glueCurrency.Name = "glueCurrency";
            glueCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCurrency.Properties.DataSource = currencyDtoBindingSource;
            glueCurrency.Properties.DisplayMember = "Symbol";
            glueCurrency.Properties.NullText = "";
            glueCurrency.Properties.PopupView = gridView3;
            glueCurrency.Properties.ValueMember = "Id";
            glueCurrency.Size = new System.Drawing.Size(114, 22);
            glueCurrency.TabIndex = 3;
            glueCurrency.EditValueChanged += glueCurrency_EditValueChanged;
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
            // glueSummaryCurrency
            // 
            errorProvider.SetIconAlignment(glueSummaryCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueSummaryCurrency.Location = new System.Drawing.Point(600, 347);
            glueSummaryCurrency.Margin = new System.Windows.Forms.Padding(4);
            glueSummaryCurrency.MenuManager = ribbon;
            glueSummaryCurrency.Name = "glueSummaryCurrency";
            glueSummaryCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueSummaryCurrency.Properties.DataSource = summaryCurrencyDtoBindingSource;
            glueSummaryCurrency.Properties.DisplayMember = "Symbol";
            glueSummaryCurrency.Properties.NullText = "";
            glueSummaryCurrency.Properties.PopupView = gridView4;
            glueSummaryCurrency.Properties.ReadOnly = true;
            glueSummaryCurrency.Properties.ValueMember = "Id";
            glueSummaryCurrency.Size = new System.Drawing.Size(88, 22);
            glueSummaryCurrency.TabIndex = 103;
            glueSummaryCurrency.TabStop = false;
            // 
            // summaryCurrencyDtoBindingSource
            // 
            summaryCurrencyDtoBindingSource.DataSource = typeof(Application.Dto.CurrencyDto);
            // 
            // gridView4
            // 
            gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn4 });
            gridView4.DetailHeight = 431;
            gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView4.Name = "gridView4";
            gridView4.OptionsBehavior.Editable = false;
            gridView4.OptionsBehavior.ReadOnly = true;
            gridView4.OptionsEditForm.PopupEditFormWidth = 933;
            gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView4.OptionsView.ShowGroupPanel = false;
            gridView4.OptionsView.ShowIndicator = false;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "SYMBOL";
            gridColumn4.FieldName = "Symbol";
            gridColumn4.MinWidth = 23;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 0;
            gridColumn4.Width = 87;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblQuantity.Location = new System.Drawing.Point(35, 270);
            lblQuantity.Margin = new System.Windows.Forms.Padding(4);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(47, 16);
            lblQuantity.TabIndex = 53;
            lblQuantity.Text = "Quantity";
            // 
            // lblVatRate
            // 
            lblVatRate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVatRate.Location = new System.Drawing.Point(481, 206);
            lblVatRate.Margin = new System.Windows.Forms.Padding(4);
            lblVatRate.Name = "lblVatRate";
            lblVatRate.Size = new System.Drawing.Size(51, 16);
            lblVatRate.TabIndex = 59;
            lblVatRate.Text = "VAT rate";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPrice.Location = new System.Drawing.Point(35, 238);
            lblPrice.Margin = new System.Windows.Forms.Padding(4);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(28, 16);
            lblPrice.TabIndex = 64;
            lblPrice.Text = "Price";
            // 
            // tePrice
            // 
            tePrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            tePrice.Location = new System.Drawing.Point(127, 234);
            tePrice.Margin = new System.Windows.Forms.Padding(4);
            tePrice.MenuManager = ribbon;
            tePrice.Name = "tePrice";
            tePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tePrice.Properties.DisplayFormat.FormatString = "N2";
            tePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tePrice.Size = new System.Drawing.Size(310, 24);
            tePrice.TabIndex = 2;
            tePrice.EditValueChanged += tePrice_EditValueChanged;
            // 
            // lblCurrency
            // 
            lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCurrency.Location = new System.Drawing.Point(481, 238);
            lblCurrency.Margin = new System.Windows.Forms.Padding(4);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(51, 16);
            lblCurrency.TabIndex = 70;
            lblCurrency.Text = "Currency";
            // 
            // seQuantity
            // 
            seQuantity.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            seQuantity.Location = new System.Drawing.Point(127, 266);
            seQuantity.Margin = new System.Windows.Forms.Padding(4);
            seQuantity.MenuManager = ribbon;
            seQuantity.Name = "seQuantity";
            seQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seQuantity.Properties.MaxValue = new decimal(new int[] { 1000, 0, 0, 0 });
            seQuantity.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            seQuantity.Size = new System.Drawing.Size(114, 24);
            seQuantity.TabIndex = 4;
            seQuantity.EditValueChanged += seQuantity_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelControl1.Location = new System.Drawing.Point(523, 351);
            labelControl1.Margin = new System.Windows.Forms.Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(51, 16);
            labelControl1.TabIndex = 104;
            labelControl1.Text = "Currency";
            // 
            // seSummaryGross
            // 
            seSummaryGross.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seSummaryGross.Location = new System.Drawing.Point(402, 347);
            seSummaryGross.Margin = new System.Windows.Forms.Padding(4);
            seSummaryGross.MenuManager = ribbon;
            seSummaryGross.Name = "seSummaryGross";
            seSummaryGross.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seSummaryGross.Properties.DisplayFormat.FormatString = "N2";
            seSummaryGross.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seSummaryGross.Properties.ReadOnly = true;
            seSummaryGross.Size = new System.Drawing.Size(88, 24);
            seSummaryGross.TabIndex = 102;
            seSummaryGross.TabStop = false;
            // 
            // labelControl4
            // 
            labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl4.Location = new System.Drawing.Point(352, 351);
            labelControl4.Margin = new System.Windows.Forms.Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(32, 16);
            labelControl4.TabIndex = 101;
            labelControl4.Text = "Gross";
            // 
            // seSummaryVat
            // 
            seSummaryVat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seSummaryVat.Location = new System.Drawing.Point(244, 347);
            seSummaryVat.Margin = new System.Windows.Forms.Padding(4);
            seSummaryVat.MenuManager = ribbon;
            seSummaryVat.Name = "seSummaryVat";
            seSummaryVat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seSummaryVat.Properties.DisplayFormat.FormatString = "N2";
            seSummaryVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seSummaryVat.Properties.ReadOnly = true;
            seSummaryVat.Size = new System.Drawing.Size(88, 24);
            seSummaryVat.TabIndex = 100;
            seSummaryVat.TabStop = false;
            // 
            // labelControl6
            // 
            labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl6.Location = new System.Drawing.Point(194, 351);
            labelControl6.Margin = new System.Windows.Forms.Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(19, 16);
            labelControl6.TabIndex = 99;
            labelControl6.Text = "Vat";
            // 
            // seSummaryNet
            // 
            seSummaryNet.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seSummaryNet.Location = new System.Drawing.Point(85, 347);
            seSummaryNet.Margin = new System.Windows.Forms.Padding(4);
            seSummaryNet.MenuManager = ribbon;
            seSummaryNet.Name = "seSummaryNet";
            seSummaryNet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seSummaryNet.Properties.DisplayFormat.FormatString = "N2";
            seSummaryNet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seSummaryNet.Properties.ReadOnly = true;
            seSummaryNet.Size = new System.Drawing.Size(88, 24);
            seSummaryNet.TabIndex = 98;
            seSummaryNet.TabStop = false;
            // 
            // labelControl7
            // 
            labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl7.Location = new System.Drawing.Point(35, 351);
            labelControl7.Margin = new System.Windows.Forms.Padding(4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(19, 16);
            labelControl7.TabIndex = 97;
            labelControl7.Text = "Net";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Navy;
            label2.Location = new System.Drawing.Point(22, 316);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 21);
            label2.TabIndex = 96;
            label2.Text = "Summary";
            // 
            // separatorControl3
            // 
            separatorControl3.Location = new System.Drawing.Point(85, 313);
            separatorControl3.Margin = new System.Windows.Forms.Padding(4);
            separatorControl3.Name = "separatorControl3";
            separatorControl3.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            separatorControl3.Size = new System.Drawing.Size(600, 28);
            separatorControl3.TabIndex = 95;
            // 
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelControl2.Location = new System.Drawing.Point(35, 206);
            labelControl2.Margin = new System.Windows.Forms.Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(43, 16);
            labelControl2.TabIndex = 106;
            labelControl2.Text = "Product";
            // 
            // InvoiceItemView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(719, 399);
            Controls.Add(labelControl2);
            Controls.Add(glueSummaryCurrency);
            Controls.Add(labelControl1);
            Controls.Add(seSummaryGross);
            Controls.Add(labelControl4);
            Controls.Add(seSummaryVat);
            Controls.Add(labelControl6);
            Controls.Add(seSummaryNet);
            Controls.Add(labelControl7);
            Controls.Add(label2);
            Controls.Add(separatorControl3);
            Controls.Add(seQuantity);
            Controls.Add(glueCurrency);
            Controls.Add(lblCurrency);
            Controls.Add(tePrice);
            Controls.Add(glueProduct);
            Controls.Add(lblPrice);
            Controls.Add(glueVatRate);
            Controls.Add(lblVatRate);
            Controls.Add(lblQuantity);
            Controls.Add(lblNameRequired);
            Controls.Add(ribbon);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "InvoiceItemView";
            Ribbon = ribbon;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "InvoiceItem";
            Load += InvoiceItemView_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueVatRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatRateDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueProduct.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueSummaryCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryCurrencyDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryGross.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryVat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryNet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSave;
        private DevExpress.XtraBars.BarButtonItem btnOK;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit teCode;
        private DevExpress.XtraEditors.LabelControl lblNameRequired;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraEditors.LabelControl lblQuantity;
        private DevExpress.XtraEditors.GridLookUpEdit glueVatRate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl lblVatRate;
        private DevExpress.XtraEditors.GridLookUpEdit glueProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private System.Windows.Forms.BindingSource vatRateDtoBindingSource;
        private DevExpress.XtraEditors.SpinEdit tePrice;
        private DevExpress.XtraEditors.GridLookUpEdit glueCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private System.Windows.Forms.BindingSource currencyDtoBindingSource;
        private DevExpress.XtraEditors.SpinEdit seQuantity;
        private DevExpress.XtraEditors.GridLookUpEdit glueSummaryCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seSummaryGross;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit seSummaryVat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit seSummaryNet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource productDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.BindingSource summaryCurrencyDtoBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
    }
}
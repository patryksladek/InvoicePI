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
            lblProductRequired = new DevExpress.XtraEditors.LabelControl();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            glueVatRate = new DevExpress.XtraEditors.GridLookUpEdit();
            vatRateDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvVatRate = new DevExpress.XtraGrid.Views.Grid.GridView();
            colVatRateSymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            glueProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            productDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            glueCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            currencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCurrencySymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            glueSummaryCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            summaryCurrencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvSummaryCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            colSummaryCurrencySymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            lblQuantity = new DevExpress.XtraEditors.LabelControl();
            lblVatRate = new DevExpress.XtraEditors.LabelControl();
            lblPrice = new DevExpress.XtraEditors.LabelControl();
            tePrice = new DevExpress.XtraEditors.SpinEdit();
            lblCurrency = new DevExpress.XtraEditors.LabelControl();
            seQuantity = new DevExpress.XtraEditors.SpinEdit();
            lblSummaryCurrency = new DevExpress.XtraEditors.LabelControl();
            seSummaryGross = new DevExpress.XtraEditors.SpinEdit();
            lblSummaryGross = new DevExpress.XtraEditors.LabelControl();
            seSummaryVat = new DevExpress.XtraEditors.SpinEdit();
            lblSummaryVat = new DevExpress.XtraEditors.LabelControl();
            seSummaryNet = new DevExpress.XtraEditors.SpinEdit();
            lblSummaryNet = new DevExpress.XtraEditors.LabelControl();
            lblSummary = new System.Windows.Forms.Label();
            scSummary = new DevExpress.XtraEditors.SeparatorControl();
            lblProduct = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueVatRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatRateDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvVatRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueProduct.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueSummaryCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)summaryCurrencyDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvSummaryCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryGross.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryVat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryNet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scSummary).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnOK, btnDelete });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 9;
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
            btnDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
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
            // lblProductRequired
            // 
            lblProductRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblProductRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblProductRequired.Appearance.Options.UseForeColor = true;
            lblProductRequired.Location = new System.Drawing.Point(73, 167);
            lblProductRequired.Name = "lblProductRequired";
            lblProductRequired.Size = new System.Drawing.Size(6, 13);
            lblProductRequired.TabIndex = 35;
            lblProductRequired.Text = "*";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // glueVatRate
            // 
            errorProvider.SetIconAlignment(glueVatRate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueVatRate.Location = new System.Drawing.Point(491, 164);
            glueVatRate.MenuManager = ribbon;
            glueVatRate.Name = "glueVatRate";
            glueVatRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueVatRate.Properties.DataSource = vatRateDtoBindingSource;
            glueVatRate.Properties.DisplayMember = "Symbol";
            glueVatRate.Properties.NullText = "";
            glueVatRate.Properties.PopupView = gvVatRate;
            glueVatRate.Properties.ReadOnly = true;
            glueVatRate.Properties.ValueMember = "Id";
            glueVatRate.Size = new System.Drawing.Size(98, 20);
            glueVatRate.TabIndex = 6;
            // 
            // vatRateDtoBindingSource
            // 
            vatRateDtoBindingSource.DataSource = typeof(Application.Dto.VatRateDto);
            // 
            // gvVatRate
            // 
            gvVatRate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colVatRateSymbol });
            gvVatRate.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gvVatRate.Name = "gvVatRate";
            gvVatRate.OptionsBehavior.Editable = false;
            gvVatRate.OptionsBehavior.ReadOnly = true;
            gvVatRate.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvVatRate.OptionsView.ShowGroupPanel = false;
            gvVatRate.OptionsView.ShowIndicator = false;
            // 
            // colVatRateSymbol
            // 
            colVatRateSymbol.Caption = "SYMBOL";
            colVatRateSymbol.FieldName = "Symbol";
            colVatRateSymbol.Name = "colVatRateSymbol";
            colVatRateSymbol.Visible = true;
            colVatRateSymbol.VisibleIndex = 0;
            // 
            // glueProduct
            // 
            errorProvider.SetIconAlignment(glueProduct, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueProduct.Location = new System.Drawing.Point(109, 164);
            glueProduct.MenuManager = ribbon;
            glueProduct.Name = "glueProduct";
            glueProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueProduct.Properties.DataSource = productDtoBindingSource;
            glueProduct.Properties.DisplayMember = "Name";
            glueProduct.Properties.NullText = "";
            glueProduct.Properties.PopupView = gvProducts;
            glueProduct.Properties.ValueMember = "Id";
            glueProduct.Size = new System.Drawing.Size(266, 20);
            glueProduct.TabIndex = 1;
            glueProduct.EditValueChanged += glueProduct_EditValueChanged;
            // 
            // productDtoBindingSource
            // 
            productDtoBindingSource.DataSource = typeof(Application.Dto.ProductDto);
            // 
            // gvProducts
            // 
            gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colName });
            gvProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gvProducts.Name = "gvProducts";
            gvProducts.OptionsBehavior.Editable = false;
            gvProducts.OptionsBehavior.ReadOnly = true;
            gvProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvProducts.OptionsView.ShowGroupPanel = false;
            gvProducts.OptionsView.ShowIndicator = false;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 0;
            // 
            // glueCurrency
            // 
            errorProvider.SetIconAlignment(glueCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueCurrency.Location = new System.Drawing.Point(491, 190);
            glueCurrency.MenuManager = ribbon;
            glueCurrency.Name = "glueCurrency";
            glueCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCurrency.Properties.DataSource = currencyDtoBindingSource;
            glueCurrency.Properties.DisplayMember = "Symbol";
            glueCurrency.Properties.NullText = "";
            glueCurrency.Properties.PopupView = gvCurrency;
            glueCurrency.Properties.ValueMember = "Id";
            glueCurrency.Size = new System.Drawing.Size(98, 20);
            glueCurrency.TabIndex = 3;
            glueCurrency.EditValueChanged += glueCurrency_EditValueChanged;
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
            // glueSummaryCurrency
            // 
            errorProvider.SetIconAlignment(glueSummaryCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueSummaryCurrency.Location = new System.Drawing.Point(514, 282);
            glueSummaryCurrency.MenuManager = ribbon;
            glueSummaryCurrency.Name = "glueSummaryCurrency";
            glueSummaryCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueSummaryCurrency.Properties.DataSource = summaryCurrencyDtoBindingSource;
            glueSummaryCurrency.Properties.DisplayMember = "Symbol";
            glueSummaryCurrency.Properties.NullText = "";
            glueSummaryCurrency.Properties.PopupView = gvSummaryCurrency;
            glueSummaryCurrency.Properties.ReadOnly = true;
            glueSummaryCurrency.Properties.ValueMember = "Id";
            glueSummaryCurrency.Size = new System.Drawing.Size(75, 20);
            glueSummaryCurrency.TabIndex = 103;
            glueSummaryCurrency.TabStop = false;
            // 
            // summaryCurrencyDtoBindingSource
            // 
            summaryCurrencyDtoBindingSource.DataSource = typeof(Application.Dto.CurrencyDto);
            // 
            // gvSummaryCurrency
            // 
            gvSummaryCurrency.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colSummaryCurrencySymbol });
            gvSummaryCurrency.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gvSummaryCurrency.Name = "gvSummaryCurrency";
            gvSummaryCurrency.OptionsBehavior.Editable = false;
            gvSummaryCurrency.OptionsBehavior.ReadOnly = true;
            gvSummaryCurrency.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvSummaryCurrency.OptionsView.ShowGroupPanel = false;
            gvSummaryCurrency.OptionsView.ShowIndicator = false;
            // 
            // colSummaryCurrencySymbol
            // 
            colSummaryCurrencySymbol.Caption = "SYMBOL";
            colSummaryCurrencySymbol.FieldName = "Symbol";
            colSummaryCurrencySymbol.Name = "colSummaryCurrencySymbol";
            colSummaryCurrencySymbol.Visible = true;
            colSummaryCurrencySymbol.VisibleIndex = 0;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblQuantity.Location = new System.Drawing.Point(30, 219);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(42, 13);
            lblQuantity.TabIndex = 53;
            lblQuantity.Text = "Quantity";
            // 
            // lblVatRate
            // 
            lblVatRate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblVatRate.Location = new System.Drawing.Point(412, 167);
            lblVatRate.Name = "lblVatRate";
            lblVatRate.Size = new System.Drawing.Size(42, 13);
            lblVatRate.TabIndex = 59;
            lblVatRate.Text = "VAT rate";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPrice.Location = new System.Drawing.Point(30, 193);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(23, 13);
            lblPrice.TabIndex = 64;
            lblPrice.Text = "Price";
            // 
            // tePrice
            // 
            tePrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            tePrice.Location = new System.Drawing.Point(109, 190);
            tePrice.MenuManager = ribbon;
            tePrice.Name = "tePrice";
            tePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tePrice.Properties.DisplayFormat.FormatString = "N2";
            tePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tePrice.Size = new System.Drawing.Size(266, 20);
            tePrice.TabIndex = 2;
            tePrice.EditValueChanged += tePrice_EditValueChanged;
            // 
            // lblCurrency
            // 
            lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCurrency.Location = new System.Drawing.Point(412, 193);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(44, 13);
            lblCurrency.TabIndex = 70;
            lblCurrency.Text = "Currency";
            // 
            // seQuantity
            // 
            seQuantity.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            seQuantity.Location = new System.Drawing.Point(109, 216);
            seQuantity.MenuManager = ribbon;
            seQuantity.Name = "seQuantity";
            seQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seQuantity.Properties.MaxValue = new decimal(new int[] { 1000, 0, 0, 0 });
            seQuantity.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            seQuantity.Size = new System.Drawing.Size(98, 20);
            seQuantity.TabIndex = 4;
            seQuantity.EditValueChanged += seQuantity_EditValueChanged;
            // 
            // lblSummaryCurrency
            // 
            lblSummaryCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSummaryCurrency.Location = new System.Drawing.Point(448, 285);
            lblSummaryCurrency.Name = "lblSummaryCurrency";
            lblSummaryCurrency.Size = new System.Drawing.Size(44, 13);
            lblSummaryCurrency.TabIndex = 104;
            lblSummaryCurrency.Text = "Currency";
            // 
            // seSummaryGross
            // 
            seSummaryGross.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seSummaryGross.Location = new System.Drawing.Point(345, 282);
            seSummaryGross.MenuManager = ribbon;
            seSummaryGross.Name = "seSummaryGross";
            seSummaryGross.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seSummaryGross.Properties.DisplayFormat.FormatString = "N2";
            seSummaryGross.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seSummaryGross.Properties.ReadOnly = true;
            seSummaryGross.Size = new System.Drawing.Size(75, 20);
            seSummaryGross.TabIndex = 102;
            seSummaryGross.TabStop = false;
            // 
            // lblSummaryGross
            // 
            lblSummaryGross.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSummaryGross.Location = new System.Drawing.Point(302, 285);
            lblSummaryGross.Name = "lblSummaryGross";
            lblSummaryGross.Size = new System.Drawing.Size(27, 13);
            lblSummaryGross.TabIndex = 101;
            lblSummaryGross.Text = "Gross";
            // 
            // seSummaryVat
            // 
            seSummaryVat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seSummaryVat.Location = new System.Drawing.Point(209, 282);
            seSummaryVat.MenuManager = ribbon;
            seSummaryVat.Name = "seSummaryVat";
            seSummaryVat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seSummaryVat.Properties.DisplayFormat.FormatString = "N2";
            seSummaryVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seSummaryVat.Properties.ReadOnly = true;
            seSummaryVat.Size = new System.Drawing.Size(75, 20);
            seSummaryVat.TabIndex = 100;
            seSummaryVat.TabStop = false;
            // 
            // lblSummaryVat
            // 
            lblSummaryVat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSummaryVat.Location = new System.Drawing.Point(166, 285);
            lblSummaryVat.Name = "lblSummaryVat";
            lblSummaryVat.Size = new System.Drawing.Size(16, 13);
            lblSummaryVat.TabIndex = 99;
            lblSummaryVat.Text = "Vat";
            // 
            // seSummaryNet
            // 
            seSummaryNet.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seSummaryNet.Location = new System.Drawing.Point(73, 282);
            seSummaryNet.MenuManager = ribbon;
            seSummaryNet.Name = "seSummaryNet";
            seSummaryNet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seSummaryNet.Properties.DisplayFormat.FormatString = "N2";
            seSummaryNet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            seSummaryNet.Properties.ReadOnly = true;
            seSummaryNet.Size = new System.Drawing.Size(75, 20);
            seSummaryNet.TabIndex = 98;
            seSummaryNet.TabStop = false;
            // 
            // lblSummaryNet
            // 
            lblSummaryNet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSummaryNet.Location = new System.Drawing.Point(30, 285);
            lblSummaryNet.Name = "lblSummaryNet";
            lblSummaryNet.Size = new System.Drawing.Size(17, 13);
            lblSummaryNet.TabIndex = 97;
            lblSummaryNet.Text = "Net";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSummary.ForeColor = System.Drawing.Color.Navy;
            lblSummary.Location = new System.Drawing.Point(19, 257);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new System.Drawing.Size(62, 16);
            lblSummary.TabIndex = 96;
            lblSummary.Text = "Summary";
            // 
            // scSummary
            // 
            scSummary.Location = new System.Drawing.Point(73, 254);
            scSummary.Name = "scSummary";
            scSummary.Size = new System.Drawing.Size(514, 23);
            scSummary.TabIndex = 95;
            // 
            // lblProduct
            // 
            lblProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblProduct.Location = new System.Drawing.Point(30, 167);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new System.Drawing.Size(37, 13);
            lblProduct.TabIndex = 106;
            lblProduct.Text = "Product";
            // 
            // InvoiceItemView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 324);
            Controls.Add(lblProduct);
            Controls.Add(glueSummaryCurrency);
            Controls.Add(lblSummaryCurrency);
            Controls.Add(seSummaryGross);
            Controls.Add(lblSummaryGross);
            Controls.Add(seSummaryVat);
            Controls.Add(lblSummaryVat);
            Controls.Add(seSummaryNet);
            Controls.Add(lblSummaryNet);
            Controls.Add(lblSummary);
            Controls.Add(scSummary);
            Controls.Add(seQuantity);
            Controls.Add(glueCurrency);
            Controls.Add(lblCurrency);
            Controls.Add(tePrice);
            Controls.Add(glueProduct);
            Controls.Add(lblPrice);
            Controls.Add(glueVatRate);
            Controls.Add(lblVatRate);
            Controls.Add(lblQuantity);
            Controls.Add(lblProductRequired);
            Controls.Add(ribbon);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "InvoiceItemView";
            Ribbon = ribbon;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "InvoiceItem";
            Load += InvoiceItemView_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueVatRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatRateDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvVatRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueProduct.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueSummaryCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)summaryCurrencyDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvSummaryCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)tePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryGross.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryVat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seSummaryNet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)scSummary).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblProductRequired;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraEditors.LabelControl lblQuantity;
        private DevExpress.XtraEditors.GridLookUpEdit glueVatRate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVatRate;
        private DevExpress.XtraGrid.Columns.GridColumn colVatRateSymbol;
        private DevExpress.XtraEditors.LabelControl lblVatRate;
        private DevExpress.XtraEditors.GridLookUpEdit glueProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private System.Windows.Forms.BindingSource vatRateDtoBindingSource;
        private DevExpress.XtraEditors.SpinEdit tePrice;
        private DevExpress.XtraEditors.GridLookUpEdit glueCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencySymbol;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private System.Windows.Forms.BindingSource currencyDtoBindingSource;
        private DevExpress.XtraEditors.SpinEdit seQuantity;
        private DevExpress.XtraEditors.GridLookUpEdit glueSummaryCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummaryCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colSummaryCurrencySymbol;
        private DevExpress.XtraEditors.LabelControl lblSummaryCurrency;
        private DevExpress.XtraEditors.SpinEdit seSummaryGross;
        private DevExpress.XtraEditors.LabelControl lblSummaryGross;
        private DevExpress.XtraEditors.SpinEdit seSummaryVat;
        private DevExpress.XtraEditors.LabelControl lblSummaryVat;
        private DevExpress.XtraEditors.SpinEdit seSummaryNet;
        private DevExpress.XtraEditors.LabelControl lblSummaryNet;
        private System.Windows.Forms.Label lblSummary;
        private DevExpress.XtraEditors.SeparatorControl scSummary;
        private DevExpress.XtraEditors.LabelControl lblProduct;
        private System.Windows.Forms.BindingSource productDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.Windows.Forms.BindingSource summaryCurrencyDtoBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
    }
}
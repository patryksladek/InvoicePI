namespace InvoicePI.DesktopUI.Views.Products
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            btnResetChanges = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            rpCustomer = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            rpgDelete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            lblName = new DevExpress.XtraEditors.LabelControl();
            lblCode = new DevExpress.XtraEditors.LabelControl();
            teCode = new DevExpress.XtraEditors.TextEdit();
            teName = new DevExpress.XtraEditors.TextEdit();
            teBarcode = new DevExpress.XtraEditors.TextEdit();
            lblNip = new DevExpress.XtraEditors.LabelControl();
            lblNameRequired = new DevExpress.XtraEditors.LabelControl();
            lblCodeRequired = new DevExpress.XtraEditors.LabelControl();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            cbeType = new DevExpress.XtraEditors.ComboBoxEdit();
            cbeBarcodeType = new DevExpress.XtraEditors.ComboBoxEdit();
            glueVatRate = new DevExpress.XtraEditors.GridLookUpEdit();
            vatRateDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            glueUnit = new DevExpress.XtraEditors.GridLookUpEdit();
            unitDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            glueCurrency = new DevExpress.XtraEditors.GridLookUpEdit();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            tePrice = new DevExpress.XtraEditors.SpinEdit();
            lblCurrency = new DevExpress.XtraEditors.LabelControl();
            currencyDtoBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teBarcode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbeType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbeBarcodeType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueVatRate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatRateDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueUnit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tePrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnSave, btnSaveAndClose, btnResetChanges, btnDelete });
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
            // btnSaveAndClose
            // 
            btnSaveAndClose.Caption = "Save && Close";
            btnSaveAndClose.Id = 2;
            btnSaveAndClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSaveAndClose.ImageOptions.Image");
            btnSaveAndClose.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnSaveAndClose.ImageOptions.LargeImage");
            btnSaveAndClose.Name = "btnSaveAndClose";
            btnSaveAndClose.ItemClick += btnSaveAndClose_ItemClick;
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
            rpgSave.ItemLinks.Add(btnSaveAndClose);
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
            // lblName
            // 
            lblName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblName.Location = new System.Drawing.Point(43, 193);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(27, 13);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblCode
            // 
            lblCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCode.Location = new System.Drawing.Point(43, 167);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(25, 13);
            lblCode.TabIndex = 5;
            lblCode.Text = "Code";
            // 
            // teCode
            // 
            teCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            errorProvider.SetIconAlignment(teCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            teCode.Location = new System.Drawing.Point(122, 164);
            teCode.MenuManager = ribbon;
            teCode.Name = "teCode";
            teCode.Size = new System.Drawing.Size(251, 20);
            teCode.TabIndex = 0;
            teCode.EditValueChanged += teCode_EditValueChanged;
            teCode.Validating += teCode_Validating;
            // 
            // teName
            // 
            teName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            errorProvider.SetIconAlignment(teName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            teName.Location = new System.Drawing.Point(122, 190);
            teName.MenuManager = ribbon;
            teName.Name = "teName";
            teName.Size = new System.Drawing.Size(445, 20);
            teName.TabIndex = 2;
            teName.EditValueChanged += teName_EditValueChanged;
            teName.Validating += teName_Validating;
            // 
            // teBarcode
            // 
            errorProvider.SetIconAlignment(teBarcode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            teBarcode.Location = new System.Drawing.Point(122, 215);
            teBarcode.MenuManager = ribbon;
            teBarcode.Name = "teBarcode";
            teBarcode.Size = new System.Drawing.Size(341, 20);
            teBarcode.TabIndex = 3;
            // 
            // lblNip
            // 
            lblNip.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNip.Location = new System.Drawing.Point(43, 218);
            lblNip.Name = "lblNip";
            lblNip.Size = new System.Drawing.Size(39, 13);
            lblNip.TabIndex = 10;
            lblNip.Text = "Barcode";
            // 
            // lblNameRequired
            // 
            lblNameRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblNameRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblNameRequired.Appearance.Options.UseForeColor = true;
            lblNameRequired.Location = new System.Drawing.Point(74, 167);
            lblNameRequired.Name = "lblNameRequired";
            lblNameRequired.Size = new System.Drawing.Size(6, 13);
            lblNameRequired.TabIndex = 35;
            lblNameRequired.Text = "*";
            // 
            // lblCodeRequired
            // 
            lblCodeRequired.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblCodeRequired.Appearance.ForeColor = System.Drawing.Color.Red;
            lblCodeRequired.Appearance.Options.UseForeColor = true;
            lblCodeRequired.Location = new System.Drawing.Point(74, 193);
            lblCodeRequired.Name = "lblCodeRequired";
            lblCodeRequired.Size = new System.Drawing.Size(6, 13);
            lblCodeRequired.TabIndex = 36;
            lblCodeRequired.Text = "*";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cbeType
            // 
            errorProvider.SetIconAlignment(cbeType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            cbeType.Location = new System.Drawing.Point(469, 164);
            cbeType.MenuManager = ribbon;
            cbeType.Name = "cbeType";
            cbeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbeType.Size = new System.Drawing.Size(98, 20);
            cbeType.TabIndex = 1;
            // 
            // cbeBarcodeType
            // 
            errorProvider.SetIconAlignment(cbeBarcodeType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            cbeBarcodeType.Location = new System.Drawing.Point(469, 215);
            cbeBarcodeType.MenuManager = ribbon;
            cbeBarcodeType.Name = "cbeBarcodeType";
            cbeBarcodeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbeBarcodeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbeBarcodeType.Size = new System.Drawing.Size(98, 20);
            cbeBarcodeType.TabIndex = 4;
            // 
            // glueVatRate
            // 
            errorProvider.SetIconAlignment(glueVatRate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueVatRate.Location = new System.Drawing.Point(365, 267);
            glueVatRate.MenuManager = ribbon;
            glueVatRate.Name = "glueVatRate";
            glueVatRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueVatRate.Properties.DataSource = vatRateDtoBindingSource;
            glueVatRate.Properties.DisplayMember = "Symbol";
            glueVatRate.Properties.NullText = "";
            glueVatRate.Properties.PopupView = gridView1;
            glueVatRate.Properties.ValueMember = "Id";
            glueVatRate.Size = new System.Drawing.Size(98, 20);
            glueVatRate.TabIndex = 6;
            // 
            // vatRateDtoBindingSource
            // 
            vatRateDtoBindingSource.DataSource = typeof(Application.Dto.VatRateDto);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "SYMBOL";
            gridColumn1.FieldName = "Symbol";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // glueUnit
            // 
            errorProvider.SetIconAlignment(glueUnit, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueUnit.Location = new System.Drawing.Point(122, 267);
            glueUnit.MenuManager = ribbon;
            glueUnit.Name = "glueUnit";
            glueUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueUnit.Properties.DataSource = unitDtoBindingSource;
            glueUnit.Properties.DisplayMember = "Code";
            glueUnit.Properties.NullText = "";
            glueUnit.Properties.PopupView = gridView2;
            glueUnit.Properties.ValueMember = "Id";
            glueUnit.Size = new System.Drawing.Size(98, 20);
            glueUnit.TabIndex = 7;
            // 
            // unitDtoBindingSource
            // 
            unitDtoBindingSource.DataSource = typeof(Application.Dto.UnitDto);
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn3 });
            gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowIndicator = false;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "CODE";
            gridColumn3.FieldName = "Code";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 0;
            // 
            // glueCurrency
            // 
            errorProvider.SetIconAlignment(glueCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            glueCurrency.Location = new System.Drawing.Point(469, 241);
            glueCurrency.MenuManager = ribbon;
            glueCurrency.Name = "glueCurrency";
            glueCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            glueCurrency.Properties.DataSource = currencyDtoBindingSource;
            glueCurrency.Properties.DisplayMember = "Symbol";
            glueCurrency.Properties.NullText = "";
            glueCurrency.Properties.PopupView = gridView3;
            glueCurrency.Properties.ValueMember = "Id";
            glueCurrency.Size = new System.Drawing.Size(98, 20);
            glueCurrency.TabIndex = 69;
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
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl2.Location = new System.Drawing.Point(390, 167);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(24, 13);
            labelControl2.TabIndex = 53;
            labelControl2.Text = "Type";
            // 
            // labelControl3
            // 
            labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelControl3.Location = new System.Drawing.Point(286, 270);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(42, 13);
            labelControl3.TabIndex = 59;
            labelControl3.Text = "VAT rate";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelControl5.Location = new System.Drawing.Point(43, 244);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(23, 13);
            labelControl5.TabIndex = 64;
            labelControl5.Text = "Price";
            // 
            // labelControl6
            // 
            labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelControl6.Location = new System.Drawing.Point(43, 270);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(19, 13);
            labelControl6.TabIndex = 66;
            labelControl6.Text = "Unit";
            // 
            // labelControl7
            // 
            labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            labelControl7.Appearance.Options.UseForeColor = true;
            labelControl7.Location = new System.Drawing.Point(74, 244);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(6, 13);
            labelControl7.TabIndex = 67;
            labelControl7.Text = "*";
            // 
            // tePrice
            // 
            tePrice.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            tePrice.Location = new System.Drawing.Point(122, 241);
            tePrice.MenuManager = ribbon;
            tePrice.Name = "tePrice";
            tePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tePrice.Properties.DisplayFormat.FormatString = "N2";
            tePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tePrice.Size = new System.Drawing.Size(251, 20);
            tePrice.TabIndex = 5;
            tePrice.EditValueChanged += tePrice_EditValueChanged;
            tePrice.Validating += tePrice_Validating;
            // 
            // lblCurrency
            // 
            lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCurrency.Location = new System.Drawing.Point(390, 244);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(44, 13);
            lblCurrency.TabIndex = 70;
            lblCurrency.Text = "Currency";
            // 
            // currencyDtoBindingSource
            // 
            currencyDtoBindingSource.DataSource = typeof(Application.Dto.CurrencyDto);
            // 
            // ProductView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 318);
            Controls.Add(glueCurrency);
            Controls.Add(lblCurrency);
            Controls.Add(tePrice);
            Controls.Add(labelControl7);
            Controls.Add(glueUnit);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(glueVatRate);
            Controls.Add(labelControl3);
            Controls.Add(cbeBarcodeType);
            Controls.Add(cbeType);
            Controls.Add(labelControl2);
            Controls.Add(lblCodeRequired);
            Controls.Add(lblNameRequired);
            Controls.Add(teBarcode);
            Controls.Add(lblNip);
            Controls.Add(teName);
            Controls.Add(teCode);
            Controls.Add(lblCode);
            Controls.Add(lblName);
            Controls.Add(ribbon);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "ProductView";
            Ribbon = ribbon;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Product";
            Load += CustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)teCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teBarcode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbeType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbeBarcodeType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueVatRate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatRateDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueUnit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)glueCurrency.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tePrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)currencyDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSave;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraBars.BarButtonItem btnResetChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDelete;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.TextEdit teCode;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teBarcode;
        private DevExpress.XtraEditors.LabelControl lblNip;
        private DevExpress.XtraEditors.LabelControl lblNameRequired;
        private DevExpress.XtraEditors.LabelControl lblCodeRequired;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private DevExpress.XtraEditors.ComboBoxEdit cbeType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbeBarcodeType;
        private DevExpress.XtraEditors.GridLookUpEdit glueVatRate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit glueUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource unitDtoBindingSource;
        private System.Windows.Forms.BindingSource vatRateDtoBindingSource;
        private DevExpress.XtraEditors.SpinEdit tePrice;
        private DevExpress.XtraEditors.GridLookUpEdit glueCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private System.Windows.Forms.BindingSource currencyDtoBindingSource;
    }
}
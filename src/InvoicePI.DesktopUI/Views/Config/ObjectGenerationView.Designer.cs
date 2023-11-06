namespace InvoicePI.DesktopUI.Views.Config
{
    partial class ObjectGenerationView
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
            panel = new System.Windows.Forms.Panel();
            lblObjectGeneration = new System.Windows.Forms.Label();
            pbCustomers = new System.Windows.Forms.PictureBox();
            pbInvoices = new System.Windows.Forms.PictureBox();
            pbProducts = new System.Windows.Forms.PictureBox();
            lblMessage1 = new System.Windows.Forms.Label();
            lblMessage2 = new System.Windows.Forms.Label();
            btnSkip = new DevExpress.XtraEditors.SimpleButton();
            btnGenerateData = new DevExpress.XtraEditors.SimpleButton();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            nudCustomersCount = new System.Windows.Forms.NumericUpDown();
            nudProductsCount = new System.Windows.Forms.NumericUpDown();
            nudInvoicesCount = new System.Windows.Forms.NumericUpDown();
            lblCustomersCount = new System.Windows.Forms.Label();
            lblProductsCount = new System.Windows.Forms.Label();
            lblInvoicesCount = new System.Windows.Forms.Label();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCustomersCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProductsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInvoicesCount).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = System.Drawing.Color.FromArgb(78, 109, 156);
            panel.Controls.Add(lblObjectGeneration);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(387, 76);
            panel.TabIndex = 0;
            // 
            // lblObjectGeneration
            // 
            lblObjectGeneration.AutoSize = true;
            lblObjectGeneration.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblObjectGeneration.ForeColor = System.Drawing.Color.White;
            lblObjectGeneration.Location = new System.Drawing.Point(12, 22);
            lblObjectGeneration.Name = "lblObjectGeneration";
            lblObjectGeneration.Size = new System.Drawing.Size(227, 33);
            lblObjectGeneration.TabIndex = 0;
            lblObjectGeneration.Text = "Object generation";
            // 
            // pbCustomers
            // 
            pbCustomers.Image = Properties.Resources.Customers;
            pbCustomers.Location = new System.Drawing.Point(12, 146);
            pbCustomers.Name = "pbCustomers";
            pbCustomers.Size = new System.Drawing.Size(33, 35);
            pbCustomers.TabIndex = 2;
            pbCustomers.TabStop = false;
            // 
            // pbInvoices
            // 
            pbInvoices.Image = Properties.Resources.Invoices;
            pbInvoices.Location = new System.Drawing.Point(12, 250);
            pbInvoices.Name = "pbInvoices";
            pbInvoices.Size = new System.Drawing.Size(33, 35);
            pbInvoices.TabIndex = 3;
            pbInvoices.TabStop = false;
            // 
            // pbProducts
            // 
            pbProducts.Image = Properties.Resources.Products;
            pbProducts.Location = new System.Drawing.Point(12, 199);
            pbProducts.Name = "pbProducts";
            pbProducts.Size = new System.Drawing.Size(33, 35);
            pbProducts.TabIndex = 9;
            pbProducts.TabStop = false;
            // 
            // lblMessage1
            // 
            lblMessage1.AutoSize = true;
            lblMessage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMessage1.Location = new System.Drawing.Point(12, 94);
            lblMessage1.Name = "lblMessage1";
            lblMessage1.Size = new System.Drawing.Size(355, 19);
            lblMessage1.TabIndex = 11;
            lblMessage1.Text = "Fill an empty database with demo data to quickly";
            // 
            // lblMessage2
            // 
            lblMessage2.AutoSize = true;
            lblMessage2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMessage2.Location = new System.Drawing.Point(12, 113);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(367, 19);
            lblMessage2.TabIndex = 12;
            lblMessage2.Text = "familiarize yourself with the program's capabilities.";
            // 
            // btnSkip
            // 
            btnSkip.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSkip.Appearance.Options.UseFont = true;
            btnSkip.Location = new System.Drawing.Point(12, 302);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new System.Drawing.Size(160, 37);
            btnSkip.TabIndex = 5;
            btnSkip.Text = "Skip";
            btnSkip.Click += btnSkip_Click;
            // 
            // btnGenerateData
            // 
            btnGenerateData.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGenerateData.Appearance.Options.UseFont = true;
            btnGenerateData.Location = new System.Drawing.Point(200, 302);
            btnGenerateData.Name = "btnGenerateData";
            btnGenerateData.Size = new System.Drawing.Size(167, 37);
            btnGenerateData.TabIndex = 4;
            btnGenerateData.Text = "Generate data";
            btnGenerateData.Click += btnGenerateData_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // nudCustomersCount
            // 
            nudCustomersCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudCustomersCount.Location = new System.Drawing.Point(247, 154);
            nudCustomersCount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCustomersCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCustomersCount.Name = "nudCustomersCount";
            nudCustomersCount.Size = new System.Drawing.Size(120, 27);
            nudCustomersCount.TabIndex = 1;
            nudCustomersCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudProductsCount
            // 
            nudProductsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudProductsCount.Location = new System.Drawing.Point(247, 207);
            nudProductsCount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudProductsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudProductsCount.Name = "nudProductsCount";
            nudProductsCount.Size = new System.Drawing.Size(120, 27);
            nudProductsCount.TabIndex = 2;
            nudProductsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudInvoicesCount
            // 
            nudInvoicesCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudInvoicesCount.Location = new System.Drawing.Point(247, 258);
            nudInvoicesCount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudInvoicesCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInvoicesCount.Name = "nudInvoicesCount";
            nudInvoicesCount.Size = new System.Drawing.Size(120, 27);
            nudInvoicesCount.TabIndex = 3;
            nudInvoicesCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCustomersCount
            // 
            lblCustomersCount.AutoSize = true;
            lblCustomersCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCustomersCount.Location = new System.Drawing.Point(62, 156);
            lblCustomersCount.Name = "lblCustomersCount";
            lblCustomersCount.Size = new System.Drawing.Size(134, 19);
            lblCustomersCount.TabIndex = 19;
            lblCustomersCount.Text = "Customers count:";
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProductsCount.Location = new System.Drawing.Point(62, 209);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new System.Drawing.Size(120, 19);
            lblProductsCount.TabIndex = 20;
            lblProductsCount.Text = "Products count:";
            // 
            // lblInvoicesCount
            // 
            lblInvoicesCount.AutoSize = true;
            lblInvoicesCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInvoicesCount.Location = new System.Drawing.Point(62, 258);
            lblInvoicesCount.Name = "lblInvoicesCount";
            lblInvoicesCount.Size = new System.Drawing.Size(117, 19);
            lblInvoicesCount.TabIndex = 21;
            lblInvoicesCount.Text = "Invoices count:";
            // 
            // ObjectGenerationView
            // 
            Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(387, 356);
            Controls.Add(lblInvoicesCount);
            Controls.Add(lblProductsCount);
            Controls.Add(lblCustomersCount);
            Controls.Add(nudInvoicesCount);
            Controls.Add(nudProductsCount);
            Controls.Add(nudCustomersCount);
            Controls.Add(btnGenerateData);
            Controls.Add(btnSkip);
            Controls.Add(lblMessage2);
            Controls.Add(lblMessage1);
            Controls.Add(pbProducts);
            Controls.Add(pbInvoices);
            Controls.Add(pbCustomers);
            Controls.Add(panel);
            IconOptions.ShowIcon = false;
            Name = "ObjectGenerationView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Invoice Platige Image";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCustomersCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProductsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInvoicesCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblObjectGeneration;
        private System.Windows.Forms.PictureBox pbCustomers;
        private System.Windows.Forms.PictureBox pbInvoices;
        private System.Windows.Forms.PictureBox pbProducts;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
        private DevExpress.XtraEditors.SimpleButton btnSkip;
        private DevExpress.XtraEditors.SimpleButton btnGenerateData;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown nudInvoicesCount;
        private System.Windows.Forms.NumericUpDown nudProductsCount;
        private System.Windows.Forms.NumericUpDown nudCustomersCount;
        private System.Windows.Forms.Label lblInvoicesCount;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label lblCustomersCount;
    }
}
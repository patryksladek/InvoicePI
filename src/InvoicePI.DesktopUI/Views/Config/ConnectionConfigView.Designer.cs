namespace InvoicePI.DesktopUI.Views.Config
{
    partial class ConnectionConfigView
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
            lblConfig = new System.Windows.Forms.Label();
            pbServer = new System.Windows.Forms.PictureBox();
            pbUser = new System.Windows.Forms.PictureBox();
            pbPassword = new System.Windows.Forms.PictureBox();
            teServer = new DevExpress.XtraEditors.TextEdit();
            teUser = new DevExpress.XtraEditors.TextEdit();
            tePassword = new DevExpress.XtraEditors.TextEdit();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblMessage1 = new System.Windows.Forms.Label();
            lblMessage2 = new System.Windows.Forms.Label();
            cbeAuthentication = new DevExpress.XtraEditors.ComboBoxEdit();
            btnValidateConnection = new DevExpress.XtraEditors.SimpleButton();
            btnConnect = new DevExpress.XtraEditors.SimpleButton();
            errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teServer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teUser.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbeAuthentication.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = System.Drawing.Color.FromArgb(78, 109, 156);
            panel.Controls.Add(lblConfig);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(448, 76);
            panel.TabIndex = 0;
            // 
            // lblConfig
            // 
            lblConfig.AutoSize = true;
            lblConfig.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblConfig.ForeColor = System.Drawing.Color.White;
            lblConfig.Location = new System.Drawing.Point(12, 22);
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new System.Drawing.Size(311, 33);
            lblConfig.TabIndex = 0;
            lblConfig.Text = "Connection configuration";
            // 
            // pbServer
            // 
            pbServer.Image = Properties.Resources.server_32;
            pbServer.Location = new System.Drawing.Point(12, 145);
            pbServer.Name = "pbServer";
            pbServer.Size = new System.Drawing.Size(33, 34);
            pbServer.TabIndex = 2;
            pbServer.TabStop = false;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.user_32;
            pbUser.Location = new System.Drawing.Point(12, 224);
            pbUser.Name = "pbUser";
            pbUser.Size = new System.Drawing.Size(33, 33);
            pbUser.TabIndex = 3;
            pbUser.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.key_32;
            pbPassword.Location = new System.Drawing.Point(12, 263);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new System.Drawing.Size(33, 33);
            pbPassword.TabIndex = 4;
            pbPassword.TabStop = false;
            // 
            // teServer
            // 
            errorProvider.SetIconAlignment(teServer, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            teServer.Location = new System.Drawing.Point(65, 153);
            teServer.Name = "teServer";
            teServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            teServer.Properties.Appearance.Options.UseFont = true;
            teServer.Size = new System.Drawing.Size(371, 26);
            teServer.TabIndex = 5;
            teServer.ToolTip = "Server name";
            // 
            // teUser
            // 
            errorProvider.SetIconAlignment(teUser, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            teUser.Location = new System.Drawing.Point(65, 231);
            teUser.Name = "teUser";
            teUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            teUser.Properties.Appearance.Options.UseFont = true;
            teUser.Size = new System.Drawing.Size(371, 26);
            teUser.TabIndex = 7;
            teUser.ToolTip = "User";
            // 
            // tePassword
            // 
            errorProvider.SetIconAlignment(tePassword, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            tePassword.Location = new System.Drawing.Point(65, 270);
            tePassword.Name = "tePassword";
            tePassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tePassword.Properties.Appearance.Options.UseFont = true;
            tePassword.Properties.PasswordChar = '*';
            tePassword.Size = new System.Drawing.Size(371, 26);
            tePassword.TabIndex = 8;
            tePassword.ToolTip = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.authorization_32;
            pictureBox1.Location = new System.Drawing.Point(12, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(33, 33);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblMessage1
            // 
            lblMessage1.AutoSize = true;
            lblMessage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMessage1.Location = new System.Drawing.Point(12, 94);
            lblMessage1.Name = "lblMessage1";
            lblMessage1.Size = new System.Drawing.Size(376, 19);
            lblMessage1.TabIndex = 11;
            lblMessage1.Text = "To start working with the program, you must enter ";
            // 
            // lblMessage2
            // 
            lblMessage2.AutoSize = true;
            lblMessage2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMessage2.Location = new System.Drawing.Point(12, 113);
            lblMessage2.Name = "lblMessage2";
            lblMessage2.Size = new System.Drawing.Size(337, 19);
            lblMessage2.TabIndex = 12;
            lblMessage2.Text = "the connection settings to the database server.";
            // 
            // cbeAuthentication
            // 
            errorProvider.SetIconAlignment(cbeAuthentication, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            cbeAuthentication.Location = new System.Drawing.Point(65, 192);
            cbeAuthentication.Name = "cbeAuthentication";
            cbeAuthentication.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbeAuthentication.Properties.Appearance.Options.UseFont = true;
            cbeAuthentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbeAuthentication.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbeAuthentication.Size = new System.Drawing.Size(371, 26);
            cbeAuthentication.TabIndex = 13;
            cbeAuthentication.ToolTip = "Authentication";
            cbeAuthentication.EditValueChanged += cbeAuthentication_EditValueChanged;
            // 
            // btnValidateConnection
            // 
            btnValidateConnection.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnValidateConnection.Appearance.Options.UseFont = true;
            btnValidateConnection.Location = new System.Drawing.Point(12, 313);
            btnValidateConnection.Name = "btnValidateConnection";
            btnValidateConnection.Size = new System.Drawing.Size(202, 37);
            btnValidateConnection.TabIndex = 14;
            btnValidateConnection.Text = "Validate Connection";
            btnValidateConnection.Click += btnValidateConnection_Click;
            // 
            // btnConnect
            // 
            btnConnect.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConnect.Appearance.Options.UseFont = true;
            btnConnect.Location = new System.Drawing.Point(234, 313);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(202, 37);
            btnConnect.TabIndex = 15;
            btnConnect.Text = "Connect";
            btnConnect.Click += btnConnect_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ConnectionConfigView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 366);
            Controls.Add(btnConnect);
            Controls.Add(btnValidateConnection);
            Controls.Add(cbeAuthentication);
            Controls.Add(lblMessage2);
            Controls.Add(lblMessage1);
            Controls.Add(pictureBox1);
            Controls.Add(tePassword);
            Controls.Add(teUser);
            Controls.Add(teServer);
            Controls.Add(pbPassword);
            Controls.Add(pbUser);
            Controls.Add(pbServer);
            Controls.Add(panel);
            IconOptions.ShowIcon = false;
            Name = "ConnectionConfigView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Invoice Platige Image";
            Load += ConnectionConfigView_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)teServer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teUser.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tePassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbeAuthentication.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.PictureBox pbServer;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPassword;
        private DevExpress.XtraEditors.TextEdit teServer;
        private DevExpress.XtraEditors.TextEdit teUser;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
        private DevExpress.XtraEditors.ComboBoxEdit cbeAuthentication;
        private DevExpress.XtraEditors.SimpleButton btnValidateConnection;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}
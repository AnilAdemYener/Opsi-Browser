namespace OpsiBrowser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.bttnSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.bttnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettings = new MaterialSkin.Controls.MaterialLabel();
            this.chckNightMode = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.imgBack = new System.Windows.Forms.PictureBox();
            this.imgNext = new System.Windows.Forms.PictureBox();
            this.imgHome = new System.Windows.Forms.PictureBox();
            this.imgGo = new System.Windows.Forms.PictureBox();
            this.txtHomePage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblHomePage = new MaterialSkin.Controls.MaterialLabel();
            this.bttnSaveSettings = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGo)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(1, 66);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(795, 530);
            this.webBrowser.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Depth = 0;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVersion.Location = new System.Drawing.Point(116, 33);
            this.lblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(66, 19);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "[version]";
            // 
            // bttnSettings
            // 
            this.bttnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSettings.AutoSize = true;
            this.bttnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnSettings.Depth = 0;
            this.bttnSettings.Location = new System.Drawing.Point(728, 28);
            this.bttnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttnSettings.Name = "bttnSettings";
            this.bttnSettings.Primary = false;
            this.bttnSettings.Size = new System.Drawing.Size(72, 36);
            this.bttnSettings.TabIndex = 2;
            this.bttnSettings.Text = "Ayarlar";
            this.bttnSettings.UseVisualStyleBackColor = false;
            this.bttnSettings.Click += new System.EventHandler(this.BttnSettings_Click);
            // 
            // bttnLogin
            // 
            this.bttnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnLogin.AutoSize = true;
            this.bttnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnLogin.Depth = 0;
            this.bttnLogin.Location = new System.Drawing.Point(652, 28);
            this.bttnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Primary = false;
            this.bttnLogin.Size = new System.Drawing.Size(76, 36);
            this.bttnLogin.TabIndex = 3;
            this.bttnLogin.Text = "Giriş Yap";
            this.bttnLogin.UseVisualStyleBackColor = false;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.BackColor = System.Drawing.Color.White;
            this.pnlSettings.Controls.Add(this.bttnSaveSettings);
            this.pnlSettings.Controls.Add(this.lblHomePage);
            this.pnlSettings.Controls.Add(this.txtHomePage);
            this.pnlSettings.Controls.Add(this.lblSettings);
            this.pnlSettings.Controls.Add(this.chckNightMode);
            this.pnlSettings.Location = new System.Drawing.Point(0, 63);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(800, 537);
            this.pnlSettings.TabIndex = 4;
            // 
            // lblSettings
            // 
            this.lblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSettings.AutoSize = true;
            this.lblSettings.Depth = 0;
            this.lblSettings.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSettings.Location = new System.Drawing.Point(330, 12);
            this.lblSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(56, 19);
            this.lblSettings.TabIndex = 2;
            this.lblSettings.Text = "Ayarlar";
            // 
            // chckNightMode
            // 
            this.chckNightMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chckNightMode.AutoSize = true;
            this.chckNightMode.Depth = 0;
            this.chckNightMode.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckNightMode.Location = new System.Drawing.Point(30, 92);
            this.chckNightMode.Margin = new System.Windows.Forms.Padding(0);
            this.chckNightMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckNightMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckNightMode.Name = "chckNightMode";
            this.chckNightMode.Ripple = true;
            this.chckNightMode.Size = new System.Drawing.Size(100, 30);
            this.chckNightMode.TabIndex = 1;
            this.chckNightMode.Text = "Gece Modu";
            this.chckNightMode.UseVisualStyleBackColor = true;
            this.chckNightMode.CheckedChanged += new System.EventHandler(this.ChckNightMode_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(296, 33);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(263, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // imgBack
            // 
            this.imgBack.BackColor = System.Drawing.Color.Transparent;
            this.imgBack.Image = ((System.Drawing.Image)(resources.GetObject("imgBack.Image")));
            this.imgBack.Location = new System.Drawing.Point(188, 26);
            this.imgBack.Name = "imgBack";
            this.imgBack.Size = new System.Drawing.Size(30, 30);
            this.imgBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBack.TabIndex = 6;
            this.imgBack.TabStop = false;
            // 
            // imgNext
            // 
            this.imgNext.BackColor = System.Drawing.Color.Transparent;
            this.imgNext.Image = ((System.Drawing.Image)(resources.GetObject("imgNext.Image")));
            this.imgNext.Location = new System.Drawing.Point(224, 26);
            this.imgNext.Name = "imgNext";
            this.imgNext.Size = new System.Drawing.Size(30, 30);
            this.imgNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNext.TabIndex = 7;
            this.imgNext.TabStop = false;
            // 
            // imgHome
            // 
            this.imgHome.BackColor = System.Drawing.Color.Transparent;
            this.imgHome.Image = ((System.Drawing.Image)(resources.GetObject("imgHome.Image")));
            this.imgHome.Location = new System.Drawing.Point(260, 26);
            this.imgHome.Name = "imgHome";
            this.imgHome.Size = new System.Drawing.Size(30, 30);
            this.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHome.TabIndex = 8;
            this.imgHome.TabStop = false;
            this.imgHome.Click += new System.EventHandler(this.İmgHome_Click);
            // 
            // imgGo
            // 
            this.imgGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgGo.BackColor = System.Drawing.Color.Transparent;
            this.imgGo.Image = ((System.Drawing.Image)(resources.GetObject("imgGo.Image")));
            this.imgGo.Location = new System.Drawing.Point(565, 26);
            this.imgGo.Name = "imgGo";
            this.imgGo.Size = new System.Drawing.Size(30, 30);
            this.imgGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGo.TabIndex = 9;
            this.imgGo.TabStop = false;
            this.imgGo.Click += new System.EventHandler(this.İmgGo_Click);
            // 
            // txtHomePage
            // 
            this.txtHomePage.Depth = 0;
            this.txtHomePage.Hint = "";
            this.txtHomePage.Location = new System.Drawing.Point(136, 146);
            this.txtHomePage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.PasswordChar = '\0';
            this.txtHomePage.SelectedText = "";
            this.txtHomePage.SelectionLength = 0;
            this.txtHomePage.SelectionStart = 0;
            this.txtHomePage.Size = new System.Drawing.Size(263, 23);
            this.txtHomePage.TabIndex = 10;
            this.txtHomePage.UseSystemPasswordChar = false;
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Depth = 0;
            this.lblHomePage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHomePage.Location = new System.Drawing.Point(52, 150);
            this.lblHomePage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(78, 19);
            this.lblHomePage.TabIndex = 11;
            this.lblHomePage.Text = "Ev Sayfası";
            // 
            // bttnSaveSettings
            // 
            this.bttnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bttnSaveSettings.AutoSize = true;
            this.bttnSaveSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnSaveSettings.Depth = 0;
            this.bttnSaveSettings.Location = new System.Drawing.Point(296, 486);
            this.bttnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bttnSaveSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttnSaveSettings.Name = "bttnSaveSettings";
            this.bttnSaveSettings.Primary = false;
            this.bttnSaveSettings.Size = new System.Drawing.Size(131, 36);
            this.bttnSaveSettings.TabIndex = 12;
            this.bttnSaveSettings.Text = "Ayarları Kaydet";
            this.bttnSaveSettings.UseVisualStyleBackColor = true;
            this.bttnSaveSettings.Click += new System.EventHandler(this.BttnSaveSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.imgGo);
            this.Controls.Add(this.imgHome);
            this.Controls.Add(this.imgNext);
            this.Controls.Add(this.imgBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.bttnSettings);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.webBrowser);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opsi Browser";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
        private MaterialSkin.Controls.MaterialFlatButton bttnSettings;
        private MaterialSkin.Controls.MaterialFlatButton bttnLogin;
        private System.Windows.Forms.Panel pnlSettings;
        private MaterialSkin.Controls.MaterialCheckBox chckNightMode;
        private MaterialSkin.Controls.MaterialLabel lblSettings;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.PictureBox imgBack;
        private System.Windows.Forms.PictureBox imgNext;
        private System.Windows.Forms.PictureBox imgHome;
        private System.Windows.Forms.PictureBox imgGo;
        private MaterialSkin.Controls.MaterialFlatButton bttnSaveSettings;
        private MaterialSkin.Controls.MaterialLabel lblHomePage;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHomePage;
    }
}
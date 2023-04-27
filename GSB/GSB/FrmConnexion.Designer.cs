namespace GSB {
    partial class FrmConnexion {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgGsb = new System.Windows.Forms.PictureBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.lblErreurConnexion = new System.Windows.Forms.Label();
            this.bulleLogin = new System.Windows.Forms.ToolTip(this.components);
            this.bulleMdp = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.impPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGsb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMdp
            // 
            this.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMdp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(50, 15);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(164, 19);
            this.txtMdp.TabIndex = 7;
            this.txtMdp.UseSystemPasswordChar = true;
            this.txtMdp.Enter += new System.EventHandler(this.txtMdp_Enter);
            this.txtMdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMdp_KeyDown);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(50, 14);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(190, 19);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            // 
            // btnQuitter
            // 
            this.btnQuitter.AutoSize = true;
            this.btnQuitter.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(0, 360);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(586, 50);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter l\'application";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Accès visiteur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgGsb
            // 
            this.imgGsb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgGsb.BackgroundImage")));
            this.imgGsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgGsb.Location = new System.Drawing.Point(15, 36);
            this.imgGsb.Margin = new System.Windows.Forms.Padding(2);
            this.imgGsb.Name = "imgGsb";
            this.imgGsb.Size = new System.Drawing.Size(255, 179);
            this.imgGsb.TabIndex = 11;
            this.imgGsb.TabStop = false;
            // 
            // btnConnecter
            // 
            this.btnConnecter.AutoSize = true;
            this.btnConnecter.BackColor = System.Drawing.Color.SlateGray;
            this.btnConnecter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnecter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConnecter.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecter.ForeColor = System.Drawing.Color.White;
            this.btnConnecter.Location = new System.Drawing.Point(0, 310);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(586, 50);
            this.btnConnecter.TabIndex = 17;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // lblErreurConnexion
            // 
            this.lblErreurConnexion.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreurConnexion.ForeColor = System.Drawing.Color.Red;
            this.lblErreurConnexion.Location = new System.Drawing.Point(12, 235);
            this.lblErreurConnexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErreurConnexion.Name = "lblErreurConnexion";
            this.lblErreurConnexion.Size = new System.Drawing.Size(549, 72);
            this.lblErreurConnexion.TabIndex = 18;
            this.lblErreurConnexion.Text = "msg";
            this.lblErreurConnexion.Visible = false;
            // 
            // bulleLogin
            // 
            this.bulleLogin.BackColor = System.Drawing.Color.Red;
            this.bulleLogin.ForeColor = System.Drawing.Color.LightGray;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgLogin);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(291, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 45);
            this.panel1.TabIndex = 31;
            // 
            // imgLogin
            // 
            this.imgLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.Location = new System.Drawing.Point(0, 0);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(44, 43);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogin.TabIndex = 28;
            this.imgLogin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.impPassword);
            this.panel2.Controls.Add(this.txtMdp);
            this.panel2.Location = new System.Drawing.Point(289, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 46);
            this.panel2.TabIndex = 32;
            // 
            // impPassword
            // 
            this.impPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.impPassword.Image = ((System.Drawing.Image)(resources.GetObject("impPassword.Image")));
            this.impPassword.Location = new System.Drawing.Point(0, 0);
            this.impPassword.Name = "impPassword";
            this.impPassword.Size = new System.Drawing.Size(44, 44);
            this.impPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.impPassword.TabIndex = 29;
            this.impPassword.TabStop = false;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErreurConnexion);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.imgGsb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratoire pharmaceutique Galaxy-Swiss Bourdin - Gestion des visites";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConnexion_FormClosing);
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConnexion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgGsb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgGsb;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label lblErreurConnexion;
        private System.Windows.Forms.ToolTip bulleLogin;
        private System.Windows.Forms.ToolTip bulleMdp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox impPassword;
    }
}


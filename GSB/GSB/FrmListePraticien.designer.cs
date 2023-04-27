namespace GSB {
    partial class FrmListePraticien {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvPraticiens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(1297, 64);
            this.lblTitre.Text = "Liste des praticiens";
            // 
            // dgvPraticiens
            // 
            this.dgvPraticiens.AllowUserToAddRows = false;
            this.dgvPraticiens.AllowUserToDeleteRows = false;
            this.dgvPraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPraticiens.Location = new System.Drawing.Point(20, 100);
            this.dgvPraticiens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPraticiens.Name = "dgvPraticiens";
            this.dgvPraticiens.ReadOnly = true;
            this.dgvPraticiens.RowHeadersWidth = 82;
            this.dgvPraticiens.RowTemplate.Height = 33;
            this.dgvPraticiens.Size = new System.Drawing.Size(1252, 572);
            this.dgvPraticiens.TabIndex = 13;
            // 
            // FrmListePraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 727);
            this.Controls.Add(this.dgvPraticiens);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListePraticien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPraticienListe";
            this.Load += new System.EventHandler(this.FrmPraticienListe_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.dgvPraticiens, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPraticiens;
    }
}
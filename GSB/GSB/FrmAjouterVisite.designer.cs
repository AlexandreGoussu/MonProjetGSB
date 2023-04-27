namespace GSB {
    partial class FrmAjouterVisite {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVisites = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lesPraticiens = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lesMotifs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEtHeure = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Size = new System.Drawing.Size(1275, 64);
            this.lblTitre.Text = "Enregistrer un nouveau rendez-vous";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Liste des rendez-vous déjà enregistrés";
            // 
            // dgvVisites
            // 
            this.dgvVisites.AllowUserToAddRows = false;
            this.dgvVisites.AllowUserToDeleteRows = false;
            this.dgvVisites.AllowUserToResizeColumns = false;
            this.dgvVisites.AllowUserToResizeRows = false;
            this.dgvVisites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVisites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisites.Location = new System.Drawing.Point(6, 132);
            this.dgvVisites.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVisites.Name = "dgvVisites";
            this.dgvVisites.ReadOnly = true;
            this.dgvVisites.RowHeadersWidth = 82;
            this.dgvVisites.RowTemplate.Height = 33;
            this.dgvVisites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisites.Size = new System.Drawing.Size(878, 541);
            this.dgvVisites.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1037, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nouveau rendez vous";
            // 
            // lesPraticiens
            // 
            this.lesPraticiens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesPraticiens.FormattingEnabled = true;
            this.lesPraticiens.Location = new System.Drawing.Point(1073, 179);
            this.lesPraticiens.Margin = new System.Windows.Forms.Padding(2);
            this.lesPraticiens.Name = "lesPraticiens";
            this.lesPraticiens.Size = new System.Drawing.Size(191, 21);
            this.lesPraticiens.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(966, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Praticien";
            // 
            // lesMotifs
            // 
            this.lesMotifs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesMotifs.FormattingEnabled = true;
            this.lesMotifs.Location = new System.Drawing.Point(1073, 235);
            this.lesMotifs.Margin = new System.Windows.Forms.Padding(2);
            this.lesMotifs.Name = "lesMotifs";
            this.lesMotifs.Size = new System.Drawing.Size(191, 21);
            this.lesMotifs.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(966, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Motif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date et heure";
            // 
            // dateEtHeure
            // 
            this.dateEtHeure.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateEtHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEtHeure.Location = new System.Drawing.Point(1073, 300);
            this.dateEtHeure.Margin = new System.Windows.Forms.Padding(2);
            this.dateEtHeure.Name = "dateEtHeure";
            this.dateEtHeure.Size = new System.Drawing.Size(187, 20);
            this.dateEtHeure.TabIndex = 21;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1041, 381);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(146, 31);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmAjouterVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 749);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dateEtHeure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lesMotifs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lesPraticiens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVisites);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjouterVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisiteAjout";
            this.Load += new System.EventHandler(this.FrmVisiteAjout_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvVisites, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lesPraticiens, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lesMotifs, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dateEtHeure, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVisites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lesPraticiens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lesMotifs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateEtHeure;
        private System.Windows.Forms.Button btnAjouter;
    }
}
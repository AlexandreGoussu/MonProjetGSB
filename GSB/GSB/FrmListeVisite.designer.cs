
using System;

namespace GSB
{
    partial class FrmListeVisite
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.medicamentBox = new System.Windows.Forms.ListView();
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.bilanBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.motifLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.typePraticienLabel = new System.Windows.Forms.Label();
            this.labelSpecialite = new System.Windows.Forms.Label();
            this.specialiteLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.rueLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomPrenomLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVisites = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(1621, 64);
            this.lblTitre.Text = "Consultation des Visites";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.medicamentBox);
            this.panel2.Controls.Add(this.dgvEchantillons);
            this.panel2.Controls.Add(this.bilanBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.motifLabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.typePraticienLabel);
            this.panel2.Controls.Add(this.labelSpecialite);
            this.panel2.Controls.Add(this.specialiteLabel);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.telephoneLabel);
            this.panel2.Controls.Add(this.rueLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nomPrenomLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvVisites);
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1607, 695);
            this.panel2.TabIndex = 13;
            // 
            // medicamentBox
            // 
            this.medicamentBox.HideSelection = false;
            this.medicamentBox.Location = new System.Drawing.Point(573, 515);
            this.medicamentBox.Margin = new System.Windows.Forms.Padding(2);
            this.medicamentBox.Name = "medicamentBox";
            this.medicamentBox.Size = new System.Drawing.Size(420, 105);
            this.medicamentBox.TabIndex = 36;
            this.medicamentBox.UseCompatibleStateImageBehavior = false;
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.AllowUserToAddRows = false;
            this.dgvEchantillons.AllowUserToDeleteRows = false;
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Location = new System.Drawing.Point(1063, 294);
            this.dgvEchantillons.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.ReadOnly = true;
            this.dgvEchantillons.RowHeadersWidth = 82;
            this.dgvEchantillons.RowTemplate.Height = 33;
            this.dgvEchantillons.Size = new System.Drawing.Size(509, 326);
            this.dgvEchantillons.TabIndex = 35;
            // 
            // bilanBox
            // 
            this.bilanBox.Location = new System.Drawing.Point(573, 307);
            this.bilanBox.Margin = new System.Windows.Forms.Padding(2);
            this.bilanBox.Multiline = true;
            this.bilanBox.Name = "bilanBox";
            this.bilanBox.ReadOnly = true;
            this.bilanBox.Size = new System.Drawing.Size(420, 109);
            this.bilanBox.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Motif";
            // 
            // motifLabel
            // 
            this.motifLabel.AutoSize = true;
            this.motifLabel.Location = new System.Drawing.Point(615, 167);
            this.motifLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motifLabel.Name = "motifLabel";
            this.motifLabel.Size = new System.Drawing.Size(38, 13);
            this.motifLabel.TabIndex = 31;
            this.motifLabel.Text = "leMotif";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Bilan de la visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 488);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Médicaments présentés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1060, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Echantillons fournis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1134, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Type praticien";
            // 
            // typePraticienLabel
            // 
            this.typePraticienLabel.AutoSize = true;
            this.typePraticienLabel.Location = new System.Drawing.Point(1212, 32);
            this.typePraticienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typePraticienLabel.Name = "typePraticienLabel";
            this.typePraticienLabel.Size = new System.Drawing.Size(68, 13);
            this.typePraticienLabel.TabIndex = 26;
            this.typePraticienLabel.Text = "typePraticien";
            // 
            // labelSpecialite
            // 
            this.labelSpecialite.AutoSize = true;
            this.labelSpecialite.Location = new System.Drawing.Point(1134, 103);
            this.labelSpecialite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpecialite.Name = "labelSpecialite";
            this.labelSpecialite.Size = new System.Drawing.Size(53, 13);
            this.labelSpecialite.TabIndex = 25;
            this.labelSpecialite.Text = "Spécialité";
            // 
            // specialiteLabel
            // 
            this.specialiteLabel.AutoSize = true;
            this.specialiteLabel.Location = new System.Drawing.Point(1212, 103);
            this.specialiteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specialiteLabel.Name = "specialiteLabel";
            this.specialiteLabel.Size = new System.Drawing.Size(51, 13);
            this.specialiteLabel.TabIndex = 24;
            this.specialiteLabel.Text = "specialité";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(915, 103);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(915, 32);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(58, 13);
            this.telephoneLabel.TabIndex = 22;
            this.telephoneLabel.Text = "Téléphone";
            // 
            // rueLabel
            // 
            this.rueLabel.AutoSize = true;
            this.rueLabel.Location = new System.Drawing.Point(615, 103);
            this.rueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rueLabel.Name = "rueLabel";
            this.rueLabel.Size = new System.Drawing.Size(27, 13);
            this.rueLabel.TabIndex = 21;
            this.rueLabel.Text = "Rue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Praticien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // nomPrenomLabel
            // 
            this.nomPrenomLabel.AutoSize = true;
            this.nomPrenomLabel.Location = new System.Drawing.Point(615, 32);
            this.nomPrenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomPrenomLabel.Name = "nomPrenomLabel";
            this.nomPrenomLabel.Size = new System.Drawing.Size(63, 13);
            this.nomPrenomLabel.TabIndex = 16;
            this.nomPrenomLabel.Text = "nomPrenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sélectionner la visite pour afficher le détail";
            // 
            // dgvVisites
            // 
            this.dgvVisites.AllowUserToAddRows = false;
            this.dgvVisites.AllowUserToDeleteRows = false;
            this.dgvVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisites.Location = new System.Drawing.Point(8, 47);
            this.dgvVisites.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVisites.Name = "dgvVisites";
            this.dgvVisites.ReadOnly = true;
            this.dgvVisites.RowHeadersWidth = 82;
            this.dgvVisites.RowTemplate.Height = 33;
            this.dgvVisites.Size = new System.Drawing.Size(505, 573);
            this.dgvVisites.TabIndex = 15;
            this.dgvVisites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellClick);
            this.dgvVisites.SelectionChanged += new System.EventHandler(this.onSelectionChanged);
            // 
            // FrmListeVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 817);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmListeVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisites";
            this.Load += new System.EventHandler(this.FrmVisites_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVisites;
        private System.Windows.Forms.ListView medicamentBox;
        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.TextBox bilanBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label motifLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label typePraticienLabel;
        private System.Windows.Forms.Label labelSpecialite;
        private System.Windows.Forms.Label specialiteLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label rueLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomPrenomLabel;
    }
}
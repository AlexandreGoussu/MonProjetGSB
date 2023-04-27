namespace GSB
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.lblTitre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerRendezVous = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierRendezVous = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerRendezvous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerBilan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consulterVisite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.medicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheMédicament = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listePraticien = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauPraticien = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPraticien = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.labelGsb = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(0, 29);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(534, 64);
            this.lblTitre.TabIndex = 9;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.medicamentToolStripMenuItem,
            this.visiteurToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(534, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmerRendezVous,
            this.modifierRendezVous,
            this.imprimerRendezvous,
            this.toolStripSeparator1,
            this.enregistrerBilan,
            this.toolStripSeparator2,
            this.consulterVisite,
            this.toolStripSeparator3});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.fichierToolStripMenuItem.Text = "Visite";
            // 
            // programmerRendezVous
            // 
            this.programmerRendezVous.Name = "programmerRendezVous";
            this.programmerRendezVous.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.programmerRendezVous.ShowShortcutKeys = false;
            this.programmerRendezVous.Size = new System.Drawing.Size(258, 22);
            this.programmerRendezVous.Text = "Nouveau &Rendez-vous";
            this.programmerRendezVous.Click += new System.EventHandler(this.programmerRendezVous_Click);
            // 
            // modifierRendezVous
            // 
            this.modifierRendezVous.Name = "modifierRendezVous";
            this.modifierRendezVous.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.modifierRendezVous.ShowShortcutKeys = false;
            this.modifierRendezVous.Size = new System.Drawing.Size(258, 22);
            this.modifierRendezVous.Text = "&Déplacer ou annuler un rendez-vous";
            this.modifierRendezVous.Click += new System.EventHandler(this.modifierRendezVous_Click);
            // 
            // imprimerRendezvous
            // 
            this.imprimerRendezvous.Name = "imprimerRendezvous";
            this.imprimerRendezvous.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.imprimerRendezvous.ShowShortcutKeys = false;
            this.imprimerRendezvous.Size = new System.Drawing.Size(258, 22);
            this.imprimerRendezvous.Text = "&Imprimer les rendez-vous";
            this.imprimerRendezvous.Click += new System.EventHandler(this.imprimerRendezvous_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // enregistrerBilan
            // 
            this.enregistrerBilan.Name = "enregistrerBilan";
            this.enregistrerBilan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.enregistrerBilan.ShowShortcutKeys = false;
            this.enregistrerBilan.Size = new System.Drawing.Size(258, 22);
            this.enregistrerBilan.Text = "&Enregistrer un bilan";
            this.enregistrerBilan.Click += new System.EventHandler(this.enregistrerBilan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // consulterVisite
            // 
            this.consulterVisite.Name = "consulterVisite";
            this.consulterVisite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.consulterVisite.ShowShortcutKeys = false;
            this.consulterVisite.Size = new System.Drawing.Size(258, 22);
            this.consulterVisite.Text = "&Liste des Visites";
            this.consulterVisite.Click += new System.EventHandler(this.consulterVisite_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(255, 6);
            // 
            // medicamentToolStripMenuItem
            // 
            this.medicamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheMédicament});
            this.medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            this.medicamentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.medicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.medicamentToolStripMenuItem.Text = "Médicament";
            // 
            // ficheMédicament
            // 
            this.ficheMédicament.Name = "ficheMédicament";
            this.ficheMédicament.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.ficheMédicament.ShowShortcutKeys = false;
            this.ficheMédicament.Size = new System.Drawing.Size(165, 22);
            this.ficheMédicament.Text = "&Fiche médicament";
            this.ficheMédicament.Click += new System.EventHandler(this.ficheMédicamentToolStripMenuItem_Click);
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listePraticien,
            this.nouveauPraticien,
            this.modifierPraticien});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.visiteurToolStripMenuItem.Text = "Praticien";
            // 
            // listePraticien
            // 
            this.listePraticien.Name = "listePraticien";
            this.listePraticien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.listePraticien.ShowShortcutKeys = false;
            this.listePraticien.Size = new System.Drawing.Size(135, 22);
            this.listePraticien.Text = "&Liste";
            this.listePraticien.Click += new System.EventHandler(this.listePraticien_Click);
            // 
            // nouveauPraticien
            // 
            this.nouveauPraticien.Name = "nouveauPraticien";
            this.nouveauPraticien.ShortcutKeyDisplayString = " ";
            this.nouveauPraticien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.nouveauPraticien.ShowShortcutKeys = false;
            this.nouveauPraticien.Size = new System.Drawing.Size(135, 22);
            this.nouveauPraticien.Text = "&Ajouter";
            this.nouveauPraticien.Click += new System.EventHandler(this.nouveauPraticien_Click);
            // 
            // modifierPraticien
            // 
            this.modifierPraticien.Name = "modifierPraticien";
            this.modifierPraticien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.modifierPraticien.ShowShortcutKeys = false;
            this.modifierPraticien.Size = new System.Drawing.Size(135, 22);
            this.modifierPraticien.Text = "&Mettre à jour";
            this.modifierPraticien.Click += new System.EventHandler(this.modifierPraticien_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.déconnexionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.déconnexionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblVisiteur);
            this.panel1.Controls.Add(this.labelGsb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 37);
            this.panel1.TabIndex = 12;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteur.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVisiteur.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.Location = new System.Drawing.Point(321, 0);
            this.lblVisiteur.Margin = new System.Windows.Forms.Padding(0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(221, 37);
            this.lblVisiteur.TabIndex = 12;
            this.lblVisiteur.Text = "Visiteur";
            this.lblVisiteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGsb
            // 
            this.labelGsb.BackColor = System.Drawing.Color.Transparent;
            this.labelGsb.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGsb.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGsb.Location = new System.Drawing.Point(0, 0);
            this.labelGsb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGsb.Name = "labelGsb";
            this.labelGsb.Size = new System.Drawing.Size(321, 37);
            this.labelGsb.TabIndex = 9;
            this.labelGsb.Text = "GSB - Galaxy Swiss Bourdin - Visiteur connecté :";
            this.labelGsb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBase";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBase_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVisite;
        private System.Windows.Forms.ToolStripMenuItem programmerRendezVous;
        protected System.Windows.Forms.ToolStripMenuItem modifierRendezVous;
        private System.Windows.Forms.ToolStripMenuItem enregistrerBilan;
        private System.Windows.Forms.ToolStripMenuItem imprimerRendezvous;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheMédicament;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauPraticien;
        private System.Windows.Forms.ToolStripMenuItem modifierPraticien;
        private System.Windows.Forms.ToolStripMenuItem listePraticien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label labelGsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
    }
}
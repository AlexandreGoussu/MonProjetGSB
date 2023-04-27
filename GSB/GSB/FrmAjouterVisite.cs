using lesClasses;
using System;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmAjouterVisite : FrmBase {
        public FrmAjouterVisite() {
            InitializeComponent();
        }

        private void FrmVisiteAjout_Load(object sender, EventArgs e) {
            

            this.lblTitre.Text = "Enregistrer un nouveau rendez-vous";

            // Réinitialiser l'interface du composant
            dgvVisites.ClearSelection();
            dgvVisites.Rows.Clear();
            lesPraticiens.Items.Clear();
            lesMotifs.Items.Clear();
            dateEtHeure.Value = DateTime.Today;

            // Pour afficher les heures en format 24h et non en format am/pm
            dateEtHeure.Format = DateTimePickerFormat.Custom;
            dateEtHeure.CustomFormat = "dd/MM/yyyy HH:mm";

            // Création des colonnes 
            dgvVisites.RowHeadersVisible = false;
            dgvVisites.ColumnCount = 5;

            dgvVisites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cette colonne sert à stocker l'id de l'objet pour le manipuler après
            // Il n'est donc pas utile de l'afficher, on a juste besoin de la donnée
            dgvVisites.Columns[0].Visible = false;
            dgvVisites.Columns[0].Name = "Id";

            dgvVisites.Columns[1].Name = "programmée le";
            dgvVisites.Columns[1].Width = 150;
            dgvVisites.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[2].Name = "à";
            dgvVisites.Columns[2].Width = 25;
            dgvVisites.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[3].Name = "sur";
            dgvVisites.Columns[3].Width = 50;
            dgvVisites.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[4].Name = "chez";
            dgvVisites.Columns[4].Width = 100;
            dgvVisites.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // On remplit les données
            Globale.mesVisites.ForEach(visite => {
                string date = visite.DateEtHeure.ToString("dddd d MMMM yyyy");
                string heuresEtMinutes = visite.DateEtHeure.ToString("HH:mm");

                Praticien praticien = visite.LePraticien;
                string ville = praticien.Ville;
                string nomPrenom = praticien.NomPrenom;

                dgvVisites.Rows.Add(visite.Id, date, heuresEtMinutes, ville, nomPrenom);
            });

            Globale.mesPraticiens.ForEach(praticien => lesPraticiens.Items.Add(praticien));
            Globale.lesMotifs.ForEach(motif => lesMotifs.Items.Add(motif));
        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            // On vérifie que l'utilisateur a bien sélectionné un praticien
            if (lesPraticiens.SelectedItem == null) {
                Text = ("Vous devez sélectionner un praticien");
                return;
            }

            // On vérifie que l'utilisateur a bien sélectionné un motif
            if (lesMotifs.SelectedItem == null) {
                Text = ("Vous devez sélectionner un motif");
                return;
            }

            Praticien praticien = (Praticien)lesPraticiens.SelectedItem;
            Motif motif = (Motif)lesMotifs.SelectedItem;
            DateTime date = dateEtHeure.Value;

            Passerelle.ajouterRendezVous(praticien.Id, motif.Id, date, out string message);

            // L'opération s'est déroulée avec succès
            if (result.isSuccessful()) {
                int idVisite = result.getResponse();

                // On crée l'objet Visite et l'ajoute à la liste "mesVisites" de l'utilisateur
                Visite visite = new Visite(idVisite, praticien, motif, date);
                Globale.mesVisites.Add(visite);

                // On recharge les données pour afficher le nouveau rendez-vous ajouté
                FrmVisiteAjout_Load(sender, e);

                MessageBox.Show(this, "Visite ajoutée !");
                return;
            }

            Text = message;
        }
    }
}
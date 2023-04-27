using lesClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmListeVisite : FrmBase
    {
        public object GetEnumerator { get; private set; }

        public FrmListeVisite()
        {
            InitializeComponent();
        }

        private void FrmVisites_Load(object sender, EventArgs e)
        {
            // Parametrage du datagridview
            parametrerDgvVisites();

            // On initialise le data grid view des échantillons
            parametrerDgvEchantillons();

            // On alimente le datagridview avec les visites
            Globale.mesVisites.ForEach(visite =>
            {
                string date = visite.DateEtHeure.ToString("dddd d MMMM yyyy");
                string heuresEtMinutes = visite.DateEtHeure.ToString("HH:mm");
                string ville = visite.LePraticien.Ville;

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell visiteCell = new DataGridViewTextBoxCell();
                visiteCell.Value = visite;

                DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                dateCell.Value = date;

                DataGridViewCell heureCell = new DataGridViewTextBoxCell();
                heureCell.Value = heuresEtMinutes;

                DataGridViewCell lieuCell = new DataGridViewTextBoxCell();
                lieuCell.Value = ville;

                // Le bilan a été renseigné
                if (visite.Bilan != null)
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }

                row.Cells.AddRange(visiteCell, dateCell, heureCell, lieuCell);
                dgvVisites.Rows.Add(row);
            });

            // Par défaut, sélectionner la première visite si elle existe
            if (dgvVisites.RowCount > 0)
            {
                // On force le clique sur la cellule de la première ligne de première colonne
                onCellClick(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void parametrerDgvVisites()
        {


            dgvVisites.AllowUserToResizeColumns = false;
            dgvVisites.AllowUserToResizeRows = false;
            dgvVisites.AllowUserToAddRows = false;
            dgvVisites.AllowUserToDeleteRows = false;
            dgvVisites.MultiSelect = false;

            dgvVisites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvVisites.RowHeadersVisible = false;
            dgvVisites.ColumnCount = 4;

            dgvVisites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cette colonne sert à stocker l'object Visite pour le manipuler après
            // Il n'est donc pas utile de l'afficher, on a juste besoin de la donnée
            dgvVisites.Columns[0].Visible = false;
            dgvVisites.Columns[0].Name = "Visite";

            dgvVisites.Columns[1].Name = "programmée le";
            dgvVisites.Columns[1].Width = 150;
            dgvVisites.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[2].Name = "à";
            dgvVisites.Columns[2].Width = 50;
            dgvVisites.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[3].Name = "sur";
            dgvVisites.Columns[3].Width = 150;
            dgvVisites.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void parametrerDgvEchantillons()
        {

            dgvEchantillons.AllowUserToResizeColumns = false;
            dgvEchantillons.AllowUserToResizeRows = false;
            dgvEchantillons.AllowUserToAddRows = false;
            dgvEchantillons.AllowUserToDeleteRows = false;
            dgvEchantillons.MultiSelect = false;

            dgvEchantillons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEchantillons.RowHeadersVisible = false;
            dgvEchantillons.ColumnCount = 2;

            dgvEchantillons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEchantillons.Columns[0].Name = "Médicament";
            dgvEchantillons.Columns[0].Width = 100;
            dgvEchantillons.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEchantillons.Columns[1].Name = "Quantité";
            dgvEchantillons.Columns[1].Width = 100;
            dgvEchantillons.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si on clique sur la ligne des colonnes (index = -1) on annule
            if (e.RowIndex <= -1)
            {
                return;
            }

            // On remet les valeurs par défaut
            nomPrenomLabel.Text = "";
            rueLabel.Text = "";
            telephoneLabel.Text = "";
            emailLabel.Text = "";
            typePraticienLabel.Text = "";
            specialiteLabel.Text = "";
            motifLabel.Text = "";
            bilanBox.Text = "";
            medicamentBox.Items.Clear();
            dgvEchantillons.Rows.Clear();

            // On récupère la ligne sélectionnée
            DataGridViewRow row = dgvVisites.Rows[e.RowIndex];

            // On récupère la première cell de la ligne
            // Première cell (0) = id 
            DataGridViewCell visiteCell = row.Cells[0];
            Visite visite = (Visite)visiteCell.Value;

            // On alimente les champs
            Praticien praticien = visite.LePraticien;

            nomPrenomLabel.Text = praticien.NomPrenom;
            rueLabel.Text = praticien.Rue;
            telephoneLabel.Text = praticien.Telephone;
            emailLabel.Text = praticien.Email;
            typePraticienLabel.Text = praticien.Type.Libelle;
            motifLabel.Text = visite.LeMotif.Libelle;
            bilanBox.Text = visite.Bilan ?? "";

            Specialite specialite = praticien.Specialite;
            labelSpecialite.Visible = specialite != null;

            specialiteLabel.Visible = specialite != null;
            specialiteLabel.Text = specialite == null ? "" : specialite.Libelle;

            if (visite.PremierMedicament != null)
            {
                Console.WriteLine(visite.PremierMedicament.Nom);
                medicamentBox.Items.Add(visite.PremierMedicament.Nom);
            }

            if (visite.SecondMedicament != null)
            {
                Console.WriteLine(visite.SecondMedicament.Nom);
                medicamentBox.Items.Add(visite.SecondMedicament.Nom);
            }
            if (visite is IEnumerable<NewsStyleUriParser >)
            {
                foreach (object o in visite)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            // On alimente le data grid view des échantillons fournis
            foreach(KeyValuePair<Medicament, int> echantillon in visite)
            {
                Medicament medicament = echantillon.Key;
                int quantite = echantillon.Value;

                dgvEchantillons.Rows.Add(medicament, quantite);
            }

            // On selectionne la ligne
            row.Selected = true;
        }

        private void onSelectionChanged(object sender, EventArgs e)
        {
            // Aucune ligne n'est sélectionnée
            if (dgvVisites.SelectedRows.Count == 0)
            {
                return;
            }

            // On récupère la premiere ligne sélectionnée
            DataGridViewRow row = dgvVisites.SelectedRows[0];

            // On force le clique sur la cellule de la ligne sur la première colonne
            onCellClick(sender, new DataGridViewCellEventArgs(0, row.Index));
        }
    }
}
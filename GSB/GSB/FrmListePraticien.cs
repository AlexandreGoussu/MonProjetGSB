using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmListePraticien : FrmBase
    {
        public FrmListePraticien()
        {
            InitializeComponent();
        }

        private void FrmPraticienListe_Load(object sender, EventArgs e)
        {

            // Parametrage du datagridview
            dgvPraticiens.AllowUserToResizeColumns = false;
            dgvPraticiens.AllowUserToResizeRows = false;
            dgvPraticiens.AllowUserToAddRows = false;
            dgvPraticiens.AllowUserToDeleteRows = false;
            dgvPraticiens.MultiSelect = false;

            dgvPraticiens.RowHeadersVisible = false;
            dgvPraticiens.ColumnCount = 5;

            dgvPraticiens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPraticiens.Columns[0].Name = "Nom et prénom";
            dgvPraticiens.Columns[0].Width = 50;
            dgvPraticiens.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[1].Name = "Téléphone";
            dgvPraticiens.Columns[1].Width = 50;
            dgvPraticiens.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[2].Name = "Email";
            dgvPraticiens.Columns[2].Width = 100;
            dgvPraticiens.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[3].Name = "Adresse";
            dgvPraticiens.Columns[3].Width = 300;
            dgvPraticiens.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPraticiens.Columns[4].Name = "Date dernière visite";
            dgvPraticiens.Columns[4].Width = 200;
            dgvPraticiens.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // On alimente le data grid view avec les praticiens
            Globale.mesPraticiens.ForEach(praticien =>
            {
                // Ordre d'affichage
                // NomPrenom - Telephone - Email - Rue + CodePostal + Ville - Date dernière visite

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell nomPrenomCell = new DataGridViewTextBoxCell();
                nomPrenomCell.Value = praticien.NomPrenom;

                DataGridViewCell telephoneCell = new DataGridViewTextBoxCell();
                telephoneCell.Value = praticien.Telephone;

                DataGridViewCell emailCell = new DataGridViewTextBoxCell();
                emailCell.Value = praticien.Email;

                DataGridViewCell adresseCell = new DataGridViewTextBoxCell();
                adresseCell.Value = praticien.Rue + " \n" + praticien.CodePostal + " " + praticien.Ville;

                DataGridViewCell derniereVisiteCell = new DataGridViewTextBoxCell();

                // On récupère les visites du praticien et on les trie dans l'ordre du plus grand au plus petit
                // C'est à dire de la plus récente à la moins récente
                List<DateTime> orderedVisites = Globale.mesVisites
                    .Where(visite => visite.LePraticien.Id.Equals(praticien.Id))
                    .Select(visite => visite.DateEtHeure)
                    .OrderByDescending(time => time.Date)
                    .ToList();

                bool aDejaVisite = orderedVisites.Count > 0;

                // Le praticien a au moins 1 visite
                if (aDejaVisite)
                {
                    // On prend la première car c'est la plus récente
                    derniereVisiteCell.Value = orderedVisites[0].ToString("dddd d MMMM yyyy");
                }
                else
                {
                    // Le praticien n'a aucune visite
                    derniereVisiteCell.Value = "Aucune visite";

                    // On met en rouge la ligne
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

                row.Cells.AddRange(nomPrenomCell, telephoneCell, emailCell, adresseCell, derniereVisiteCell);
                dgvPraticiens.Rows.Add(row);
            });
        }
    }
}

using lesClasses;
using System;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmFicheMedicament : FrmBase
    {
        public FrmFicheMedicament()
        {
            InitializeComponent();
        }

        private void FrmFicheMedicament_Load(object sender, EventArgs e)
        {
            // On charge les données à partir de Global.cs
            // Il y'a autocompletion pour les médicaments

            Globale.lesMedicaments.ForEach(medicament => lesMedicaments.Items.Add(medicament));
            lesMedicaments.DropDownStyle = ComboBoxStyle.DropDown;
            lesMedicaments.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lesMedicaments.AutoCompleteSource = AutoCompleteSource.ListItems;

            // La proprité ReadOnly permet d'empêcher l'utilisateur de modifier la valeur
            familleMedoc.ReadOnly = true;
            compoMedoc.ReadOnly = true;
            effetMedoc.ReadOnly = true;
            contreIndicMedoc.ReadOnly = true;

            // Par défaut on selectionne le premier médicament si il existe
            if (lesMedicaments.Items.Count > 0)
            {
                lesMedicaments.SelectedIndex = 0;
            }
        }

        private void lesMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mesure de sécurité
            if (lesMedicaments.SelectedItem == null)
            {
                return;
            }

            Medicament medicament = (Medicament)lesMedicaments.SelectedItem;

            familleMedoc.Text = medicament.LaFamille.Libelle;
            compoMedoc.Text = medicament.Composition;
            effetMedoc.Text = medicament.Effets;
            contreIndicMedoc.Text = medicament.ContreIndication;
        }
    }
}

// ------------------------------------------
// Nom du fichier : FrmMenu.cs
// Objet : Formulaire affichant la page d'accueil qui ne propose que le menu hérité
// Auteur : M. Verghote
// Date mise à jour : 17/11/2022
// ------------------------------------------

using System;

namespace GSB
{
    public partial class FrmMenu : FrmBase
    {
        public FrmMenu() => InitializeComponent();

        private void FrmMenu_Load(object sender, EventArgs e) => lblTitre.Text = "Bienvenue sur l'application de gestion des visites";

    }
}

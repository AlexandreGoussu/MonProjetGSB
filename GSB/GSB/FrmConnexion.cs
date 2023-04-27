// ------------------------------------------
// Nom du fichier : FrmConnexion.cs
// Objet : Formulaire de connexion
// Auteur : M. Verghote
// Date : 24/11/2022
// ------------------------------------------

using System;
using System.Windows.Forms;

namespace GSB
{
    public partial class FrmConnexion : Form
    {
        // pour autoriser la fermeture du formulaire uniquement par le bouton quitter
        private int fermeture = 0; // 1 autoriser la fermeture,  0 : refuser la fermeture

        public FrmConnexion()
        {
            InitializeComponent();
        }

        #region procédures événementielles

        // au chargement du formulaire, il faut paramètrer ses composants
        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            parametrerComposant();
        }


        private void FrmConnexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si le visiteur a essayé de fermer la fenêtre autrement que par le bouton quitter (alt F4 par exemple) on annule la demande 
            // seul le bouton quitter place la variable fermeture à 1. 
            if (fermeture == 0)
            {
                e.Cancel = true;
            }
        }

        // Déclenchement du contrôle de la connexion
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            seConnecter(txtLogin.Text, txtMdp.Text);
        }

        // Quitter l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            fermeture = 1;
            Close();
        }


        private void txtLogin_Enter(object sender, EventArgs e)
        {
            lblErreurConnexion.Visible = false;
        }

        private void txtMdp_Enter(object sender, EventArgs e)
        {
            lblErreurConnexion.Visible = false;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMdp.Text.Length > 0)
                {
                    seConnecter(txtLogin.Text, txtMdp.Text);
                }
                else
                {
                    txtMdp.Focus();
                }
            }
        }

        private void txtMdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLogin.Text.Length > 0)
                {
                    seConnecter(txtLogin.Text, txtMdp.Text);
                }
                else
                {
                    txtLogin.Focus();
                }
            }
        }

        private void FrmConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Enter)
            {
                txtMdp.Text = "19910826";
                txtLogin.Text = "a17";
                // empêcher la propagation de l'événement vers le champ ayant le focus et gérant le même événement
                e.Handled = true;
                // seConnecter(txtLogin.Text, txtMdp.Text);
            }
        }

        #endregion

        #region méthodes

        // Paramètrage des composants de la fenêtre
        private void parametrerComposant()
        {
            Text = "Laboratoire pharmaceutique Galaxy-Swiss Bourdin - Gestion des visites";
            ControlBox = false;
            KeyPreview = true;
            txtLogin.Focus();
        }

        // contrôle que le champ txtNom est renseigné
        private bool controlerLogin(string nom)
        {
            if (nom == string.Empty)
            {
                bulleLogin.Show("Veuillez indiquer votre login ", txtLogin, 10, 30, 3000);
                return false;
            }
            else
            {
                return true;
            }
        }

        // contrôle que le mot de passe est renseigné 
        private bool controlerMdp(string mdp)
        {
            if (mdp == string.Empty)
            {
                bulleMdp.Show("Veuillez indiquer votre mot de passe", txtMdp, 10, 30, 3000);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void seConnecter(string login, string mdp)
        {
            bool nomOk = controlerLogin(login);
            bool mdpOk = controlerMdp(mdp);
            lblErreurConnexion.Visible = false;
            if (nomOk && mdpOk)
            {
                bool ok = Passerelle.seConnecter(login, mdp, out string message);
                if (ok)
                {
                    // Sécurité : on vide le champ mdp
                    txtMdp.Text = string.Empty;
                    // chargement des données
                    Passerelle.chargerDonnees();
                    // On conserve le lien vers le formulaire de connexion afin de pouvoir l'afficher losque le visiteur se déconnecte 
                    Globale.formulaireConnexion = this;
                    // on instancie un nouveau formulaire menu
                    FrmMenu unFrmMenu = new FrmMenu();
                    // On masque le formulaire de connexion (le fermer reviendrait à quitter l'application)
                    this.Hide();
                    // on affiche le formulaire Menu
                    unFrmMenu.Show();
                }
                else
                {
                    lblErreurConnexion.Text = message;
                    lblErreurConnexion.Visible = true;
                }
            }
        }

        #endregion

    }
}

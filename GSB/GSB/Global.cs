// ------------------------------------------
// Nom du fichier : global.cs
// Objet : classe statique Globale regroupant les données globales de l'application
// Auteur : M. Verghote
// Date mise à jour : 21/11/2022
// ------------------------------------------

using lesClasses;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GSB
{
    class Globale
    {


        // Données globales de l'application


        // les données communes à tous les visiteurs
        public static SortedDictionary<string, Famille> lesFamilles = new SortedDictionary<string, Famille>();
        public static List<Medicament> lesMedicaments = new List<Medicament>();
        public static List<Motif> lesMotifs = new List<Motif>();
        public static List<TypePraticien> lesTypes = new List<TypePraticien>();
        public static List<Specialite> lesSpecialites = new List<Specialite>();

        // les données spécifiques au visiteur connecté
        public static List<Ville> mesVilles = new List<Ville>();
        public static List<Visite> mesVisites = new List<Visite>();
        public static List<Praticien> mesPraticiens = new List<Praticien>();

        // FormulaireParent : Pointe le formulaire de connexion qui doit rester ouvert (caché) afin de pouvoir l'afficher quant le visiteur se déconnecte 
        public static Form formulaireConnexion = null;

        // nom à afficher dans le bas des formulaires
        public static string nomVisiteur;

    }


}


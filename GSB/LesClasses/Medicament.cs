// ------------------------------------------
// Nom du fichier : medicament.cs
// Objet : classe Medicament
// Auteur : M. Verghote
// ------------------------------------------

using System;

namespace lesClasses
{
    [Serializable]
    public class Medicament : IComparable<Medicament>
    {
        // la classe doit implémenter une méthode de comparaison car les objets Medicamement
        // seront utilisés comme clé d'accès dans un dictionnaire  (panier des médicaments distribués)

        public int CompareTo(Medicament o) => Nom.CompareTo(o.Nom);

        // Propriétés automatiques
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Composition { get; set; }
        public string Effets { get; set; }
        public string ContreIndication { get; set; }
        public Famille LaFamille { get; set; }

        // Constructeur
        public Medicament(string id, string nom, string composition, string effets, string contreIndication, Famille famille)
        {
            Id = id;
            Nom = nom;
            Composition = composition;
            Effets = effets;
            ContreIndication = contreIndication;
            LaFamille = famille;
            // mise à jour de l'association bidirectionnelle : une famille contient la collection des médicaments associés
            LaFamille.ajouterMedicament(this);

        }


        public override string ToString() => Id;

    }
}

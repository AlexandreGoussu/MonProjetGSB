// ------------------------------------------
// Nom du fichier : visite.cs
// Objet : Définition de la classe Visite
// Auteur : M. Verghote
// ------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace lesClasses
{
    [Serializable]
    public class Visite : IComparable<Visite>, IEnumerable<Medicament>
    {
        // la classe doit implémenter une méthode de comparaison car les objets Visite
        // seront utilisés dans une collection qui sera triée après chaque ajout
        // le critère de comparaison : DateEtHeure


        // attribut privé lesEchantillons : dictionnaire de médicament associé à une quantité
        private SortedDictionary<Medicament, int> lesEchantillons;

        // Propriétés automatiques Id, LePRaticien LeMotif DateetHeure Bilan PremierMedicament SecondMedicament
        public int Id { get; }

        public Praticien LePraticien { get; set; }
        public Motif LeMotif { get; set; }
        public DateTime DateEtHeure { get; private set; }
        public string Bilan { get; set; }
        public Medicament PremierMedicament { get; set; }
        public Medicament SecondMedicament { get; set; }


        // Constructeur : ne pas oublier la mise à jour de la relation bidirectionnelle
        public Visite(int id, Praticien unPraticien, Motif unMotif, DateTime uneDateEtHeure)
        {
            Id = id;
            LePraticien = unPraticien;
            LeMotif = unMotif;
            DateEtHeure = uneDateEtHeure;
            lesEchantillons = new SortedDictionary<Medicament, int>();
            // mise à jour de l'association bidirectionnelle
            LePraticien.ajouteVisite(this);
        }


        // méthode enregistrerBilan : alimente les propriétés Bilan, PremierMedicament, SecondMedicament
        public void enregistrerBilan(string bilan, Medicament premierMedicament, Medicament secondMedicament)
        {
            Bilan = bilan;
            PremierMedicament = premierMedicament;
            SecondMedicament = secondMedicament;
        }


        // méthode déplacer ; alimente la propriété DateEtHeure
        public void deplacer(DateTime uneDateEtHeure)
        {
            DateEtHeure = uneDateEtHeure;
        }

        // méthode ajouterEchantillon : ajoute un échantillon 
        // si le médicament est déjà dans le dictionnaire on cumule les quantités sinon ou ajoute
        public void ajouterEchantillon(Medicament unMedicament, int uneQuantite)
        {
            if (lesEchantillons.ContainsKey(unMedicament))
            {
                int nouvelleQuantite = lesEchantillons[unMedicament] + uneQuantite;
                lesEchantillons[unMedicament] = nouvelleQuantite;
                return;
            }

            lesEchantillons.Add(unMedicament, uneQuantite);
        }


        // méthode supprimerEchantillon
        public void supprimerEchantillon(Medicament unMedicament)
        {
            lesEchantillons.Remove(unMedicament);
        }



        // définition d'un itérateur permettant de parcourir les éléments du dictionnaire lesEchantillons

        public int CompareTo(Visite other)
        {
            return DateEtHeure.CompareTo(other.DateEtHeure);
        }

        public IEnumerator<Medicament> GetEnumerator()
        {
            return lesEchantillons.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

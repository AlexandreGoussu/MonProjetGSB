// ------------------------------------------
// Nom du fichier : famille.cs
// Objet : classe famille
// Auteur : M. Verghote
// ------------------------------------------

using System;
using System.Collections.Generic;

namespace lesClasses
{
    [Serializable]
    public class Famille
    {
        // attribut
        private List<Medicament> lesMedicaments { get; }

        // Propriétés automatiques
        public string Id { get; set; }
        public string Libelle { get; set; }


        // Constructeur
        public Famille(string id, string libelle)
            => (Id, Libelle, lesMedicaments) = (id, libelle, new List<Medicament>());

        // méthode
        public void ajouterMedicament(Medicament unMedicament)
        {
            lesMedicaments.Add(unMedicament);
        }

    }
}

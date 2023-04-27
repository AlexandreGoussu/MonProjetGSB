// ------------------------------------------
// Nom du fichier : ville.cs
// Objet : classe ville
// Auteur : M. Verghote
// ------------------------------------------

using System;

namespace lesClasses
{
    [Serializable]
    public class Ville
    {

        // Constructeur
        public Ville(string nom, string code)
        => (Code, Nom) = (code, nom);

        // Propriétés automatiques
        public string Nom { get; set; }
        public string Code { get; set; }

    }
}

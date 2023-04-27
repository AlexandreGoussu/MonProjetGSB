// ------------------------------------------
// Nom du fichier : motif.cs
// Objet : classe Motif
// Auteur : M. Verghote
// ------------------------------------------

namespace lesClasses
{
    public class Motif
    {

        // Propriétés automatiques
        public int Id { get; set; }
        public string Libelle { get; set; }

        // Constructeur
        public Motif(int id, string libelle)
         => (Id, Libelle) = (id, libelle);

    }
}

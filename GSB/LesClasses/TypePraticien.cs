// ------------------------------------------
// Nom du fichier : typePraticien.cs
// Objet : Définition de la classe TypePraticien
// Auteur : M. Verghote
// ------------------------------------------

namespace lesClasses
{
    public class TypePraticien
    {

        // Propriétés automatiques
        public string Id { get; set; }
        public string Libelle { get; set; }

        // Constructeur
        public TypePraticien(string id, string libelle)
         => (Id, Libelle) = (id, libelle);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class Utilisateur
    {
        public string prenom;
        public string nom;
        public string type;
        public int couleur;

        public Utilisateur(string prenom, string nom, string type)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.couleur = 0;
        }

        public string Prenom
        {
            get { return prenom; }
        }
        public string Nom
        {
            get { return nom; }
        }

        public string Type
        {
            get { return type; }
        }
        public int Couleur
        {
            get { return this.couleur; }
            set { this.couleur = value; }
        }

    }
}

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
        public string id_client;
        public Utilisateur(string prenom, string nom, string type, string id_client)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.couleur = 0;
            this.id_client = id_client;
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

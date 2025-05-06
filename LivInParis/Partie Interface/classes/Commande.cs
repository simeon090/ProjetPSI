using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis.Partie_Interface
{
    public class Commande
    {
        public int numero_commande;
        public int telephone_cuisinier;
        public string prenom_cuisinier;
        public string nom_cuisinier;

        public Commande(int telephone_cuisinier, int numero_commande, string prenom_cuisinier, string nom_cuisinier)
        {
            this.telephone_cuisinier = telephone_cuisinier;
            this.numero_commande = numero_commande;
            this.prenom_cuisinier = prenom_cuisinier;
            this.nom_cuisinier=nom_cuisinier;
        }

        public int Numero_commande
        {
            get { return numero_commande; }
        }

        public int Telephone_cuisinier
        {
            get { return telephone_cuisinier; }
        }

        public string Prenom_cuisinier
        {
            get { return prenom_cuisinier; }
        }

        public string Nom_cuisinier
        {
            get { return nom_cuisinier; }
        }
    }
}

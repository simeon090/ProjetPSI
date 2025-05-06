using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis.Partie_Interface.classes
{
    internal class SousCommande : Commande
    {
        public string nom_mets { get; set; }
        public string nationalité { get; set; }
        public decimal prix { get; set; }
        public string régime_alimentaire { get; set; }

        public SousCommande(int numero_commande, int telephone_cuisinier, string prenom_cuisinier, string nom_cuisinier,string nom_mets, string nationalité, decimal prix, string régime_alimentaire) : base(numero_commande, telephone_cuisinier, prenom_cuisinier, nom_cuisinier)
        {
            this.nom_mets = nom_mets;
            this.nationalité = nationalité;
            this.prix = prix;
            this.régime_alimentaire = régime_alimentaire;
        }
    }
}

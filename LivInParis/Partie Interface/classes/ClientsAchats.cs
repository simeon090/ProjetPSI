using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis.Partie_Interface.classes
{
    public class ClientAchats
    {
        public string IdentifiantClient
        { get; set; }
        public string nom_particulier
        { get; set; }

        public string prenom_particulier
        { get; set; }

        public decimal MontantTotalAchats
        { get; set; }

        public ClientAchats(string identifiantClient, string nom_particulier, string prenom_particulier, decimal montantTotalAchats)
        {
            this.IdentifiantClient = identifiantClient;
            this.nom_particulier = nom_particulier;
            this.prenom_particulier = prenom_particulier;
            this.MontantTotalAchats = montantTotalAchats;
        }
    }
}

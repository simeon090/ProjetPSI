using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class Client : Utilisateur
    {
        public string IdentifiantClient { get; set; }
        public string MotDePasse { get; set; }



        public Client(string nom, string prenom, string type, string identifiantClient, string motDePasse) : base(prenom, nom, type)
        {
            this.IdentifiantClient = identifiantClient;
            this.MotDePasse = motDePasse;
            this.type = type;
        }
    }
}

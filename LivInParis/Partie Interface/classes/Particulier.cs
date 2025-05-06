using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis.Partie_Interface.classes
{
    public class Particulier
    {
        public decimal numéro_tel_particulier { get; set; }
        public string nom_particulier { get; set; }
        public string prenom_particulier { get; set; }
        public string adresse_particulier { get; set; }
        public string Identifiant_client { get; set; }

        public string mail_client { get; set; }


        public Particulier(decimal numéro_tel_particulier, string nom_particulier, string prenom_particulier, string adresse_particulier, string Identifiant_client, string mail_client)
        {
            this.numéro_tel_particulier = numéro_tel_particulier;
            this.nom_particulier = nom_particulier;
            this.prenom_particulier = prenom_particulier;
            this.adresse_particulier = adresse_particulier;
            this.Identifiant_client = Identifiant_client;
            this.mail_client = mail_client;

        }
    }
}

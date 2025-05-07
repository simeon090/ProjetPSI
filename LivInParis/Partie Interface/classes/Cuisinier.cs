using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class Cuisinier : Utilisateur
    {
        public int telephone;
        public string adresse;
        public string mail;
        public string id_client;

        public Cuisinier(string nom, string prenom, string type, string adresse, string mail, int telephone, string id_client=null) : base(prenom, nom, type, id_client)
        {
            this.adresse = adresse;
            this.mail = mail;
            this.telephone = telephone;
            this.type = type;
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

        public int Telephone
        {
            get { return telephone; }
        }
        public string Mail
        {
            get { return mail; }
        }

        public string Adresse
        {
            get { return adresse; }
        }

    }
}

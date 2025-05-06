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

        public Cuisinier(string nom, string prenom, string type, string adresse, string mail, int telephone) : base(prenom, nom, type)
        {
            this.adresse = adresse;
            this.mail = mail;
            this.telephone = telephone;
            this.type = type;
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

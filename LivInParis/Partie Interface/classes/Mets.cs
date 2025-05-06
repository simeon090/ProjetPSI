using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class Mets
    {

        public string nom_mets { get; set; }
        public decimal prix { get; set; }
        public string id_mets { get; set; }
        public string type {  get; set; }
        public string nationalité { get; set; }
        public string régime_alimentaire { get; set; }
        public int tel_cuisinier { get; set; }
        public int quantité { get; set; }
        public string station_métro { get; set; }

        public Mets(string nom_mets, decimal prix, string station_métro)
        {
            this.nom_mets = nom_mets;
            this.prix = prix;
            this.station_métro = station_métro;
        }

        public Mets(string nom_mets, decimal prix, string id_mets, string type, string nationalité,
                string régime_alimentaire, int tel_cuisinier, int quantité, string station_métro)
        {
            this.nom_mets = nom_mets;
            this.prix = prix;
            this.id_mets = id_mets;
            this.type = type;
            this.nationalité = nationalité;
            this.régime_alimentaire = régime_alimentaire;
            this.tel_cuisinier = tel_cuisinier;
            this.quantité = quantité;
            this.station_métro = station_métro;
        }

        public override string ToString()
        {

            return nom_mets + " - "+ prix + "€ - Station: "+station_métro+ " - qty : "+quantité;
        }

    }
}

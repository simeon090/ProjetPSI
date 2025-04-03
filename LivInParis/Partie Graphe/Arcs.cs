using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class Arcs
    {
        station_metro precedent;
        station_metro suivant;
        int duree_minute;
        string ligne_de_metro;
        string sens;
        int temps_de_changement;


        public Arcs(station_metro precedent, station_metro suivant, int duree_minute, string ligne_de_metro, string sens, int temps_de_changement)
        {
            this.precedent = precedent;
            this.suivant = suivant;
            this.duree_minute = duree_minute;
            this.ligne_de_metro = ligne_de_metro;
            this.sens = sens;
            this.temps_de_changement = temps_de_changement;
        }

        public station_metro Precedent
        {
            get { return precedent; }
        }

        public station_metro Suivant
        {
            get { return suivant; }
        }

        public int Duree_minute
        {
            get { return duree_minute; }
        }

        public string Ligne_de_metro
        {
            get { return ligne_de_metro; }
        }

        public string Sens
        {
            get { return sens; }
        }

        public int Temps_de_changement
        {
            get { return temps_de_changement; }
        }
    }
}

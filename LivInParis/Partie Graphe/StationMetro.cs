using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class station_metro
    {
        int id;
        string nom;
        float latitude;
        float longitude;
        int code_insee;


        public station_metro(int id, string nom, float latitude, float longitude, int code_insee)
        {
            this.id = id;
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
            this.code_insee = code_insee;
        }

        public string Nom
        {
            get { return nom; }
        }
        public int ID
        {
            get { return id; }
        }

        public float Latitude
        {
            get { return latitude; }
        }

        public float Longitude
        {
            get { return longitude; }
        }

        public int Code_insee
        {
            get { return code_insee; }
        }

        /// <summary>
        /// Méthode de classe qui calcule la distance en km entre deux stations de métros grâce à leurs coordoonées
        /// On utilise la formule de Haversine
        /// </summary>
        public static double CalculDistance(station_metro départ, station_metro arrivé)
        {
            // On choisit de retourner le resultat en km
            int R = 6371;
            // On convertit à chaque fois les coordoonées en radians
            double delta_latitude = départ.latitude * (Math.PI / 180) - arrivé.latitude * (Math.PI / 180);
            double delta_longitude = départ.longitude * (Math.PI / 180) - arrivé.longitude * (Math.PI / 180);
            double therme1 = (Math.Sin(delta_latitude / 2));
            double therme2 = (Math.Sin(delta_longitude / 2));
            double distance = 2*R*Math.Asin(Math.Sqrt(Math.Pow(therme1,2) + Math.Cos(départ.latitude * (Math.PI / 180.0)) * Math.Cos(arrivé.latitude*(Math.PI / 180)) * Math.Pow(therme2, 2) ));
            // Arondir a deux chiffres après la virgule
            return Math.Round(distance, 2);
        }

    }
}

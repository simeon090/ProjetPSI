using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Mars 
{
    internal class station_metro
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

    }
}

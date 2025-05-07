using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis
{
    public class ArcsUtilisateurs
    {
        Cuisinier cuisinier;
        Utilisateur client;

        public ArcsUtilisateurs(Cuisinier cuisinier, Utilisateur client)
        {
            this.client = client;
            this.cuisinier = cuisinier;
        }

        public Cuisinier Cuisinier
        {
            get { return this.cuisinier; }
        }

        public Utilisateur Client
        {
            get { return this.client; }
        }
    }
}

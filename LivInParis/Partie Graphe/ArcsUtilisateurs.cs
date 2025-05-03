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
        Client client;

        public ArcsUtilisateurs(Cuisinier cuisinier, Client client)
        {
            this.client = client;
            this.cuisinier = cuisinier;
        }

        public Cuisinier Cuisinier
        {
            get { return this.cuisinier; }
        }

        public Client Client
        {
            get { return this.client; }
        }
    }
}

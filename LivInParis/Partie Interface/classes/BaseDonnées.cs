using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivInParis.Partie_Interface.classes
{
    public class Base_Données
    {
        public MySqlConnection db;

        public Base_Données(string connectionString)
        {
            db = new MySqlConnection(connectionString);
        }

        public MySqlConnection DB { get { return db; } }
    }
}

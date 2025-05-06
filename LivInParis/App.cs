using LivInParis.Partie_Graphe;
using LivInParis.Partie_Interface.admin;
using LivInParis.Partie_Interface.classes;
using MySql.Data.MySqlClient;
using System.Data;

namespace LivInParis
{
    internal static class App
    {
        public static string chemin_csv_stations = "MetroParis_Noeuds.csv";
        public static string chemin_csv_arcs = "MetroParis_Arcs.csv";
        public static string mdp_admin = "esilv";
        public static string connection_db = "server=localhost;database=projet_psi_2;uid=root;pwd=simeon;";
        static void Main()
        {
            // Initialisation DB
            Base_Données baseDonnees = new Base_Données(connection_db);
            MySqlConnection connexion = baseDonnees.DB;
            connexion.Open();

            // Initialisation Partie Graphique
            ApplicationConfiguration.Initialize();
            Application.Run(new LivInParis.ConnexionUser(mdp_admin, connexion));
        }

        public static void AffcherTab(station_metro[] list)
        {
            if (list != null && list.Length - 1 > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write(list[i].Nom + " --> ");
                }
                Console.WriteLine("\n\n");
            }
            else
            {
                Console.WriteLine("Liste null ou vide");
            }
        }

        public static void AffcherTab(string[] list)
        {
            if (list != null && list.Length - 1 > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write(list[i] + " --> ");
                }
                Console.WriteLine("\n\n");
            }
            else
            {
                Console.WriteLine("Liste null ou vide");
            }
        }

        public static void AffcherTab(int[] list)
        {
            if (list != null && list.Length - 1 > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write(list[i] + " --> ");
                }
                Console.WriteLine("\n\n");
            }
            else
            {
                Console.WriteLine("Liste null ou vide");
            }
        }
    }

}
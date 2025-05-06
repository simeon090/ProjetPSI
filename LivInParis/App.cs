using LivInParis.Partie_Graphe;
using MySql.Data.MySqlClient;
using System.Data;

namespace LivInParis
{
    internal static class App
    {
        public static string chemin_csv_stations = "MetroParis_Noeuds.csv";
        public static string chemin_csv_arcs = "MetroParis_Arcs.csv";
        static void Main()
        {
            // Initialisation Partie Graphique
            ApplicationConfiguration.Initialize();
            Application.Run(new LivInParis.ConnexionUser());

            GrapheMetro Test_Graphe = new GrapheMetro(chemin_csv_stations, chemin_csv_arcs);
            //Test_Graphe.VisualiserGraphe();
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Franklin D. Roosevelt");
            station_metro arrivee = Test_Graphe.TrouverStationAvecNom("Place de Clichy");

            //Exemple de calcule distance entre deux stations
            Console.WriteLine(station_metro.CalculDistance(depart, arrivee));

            //On lance dijkstra
            Dictionary<station_metro, (string, int)> resultat_dijkstra = Test_Graphe.Dijkstra(depart, arrivee);
            //Dictionary<station_metro, (string, int)> resultat_bellman = Test_Graphe.BellmanFord(depart, arriv�e);


            // Commande pour recuperer les stations dans l'ordre ex : Argentine-->Passy : [Argentine, Charles de Gaule, Kl�ber ..... , Passy]
            station_metro[] liste_stations = Test_Graphe.ToListStations(resultat_dijkstra);
            AffcherTab(liste_stations);

            // Commande pour recuperer les lignes emprunt�s dans l'ordre ex : Argentine-->Passy : [1, 6, 6, 6]
            string[] liste_metros = Test_Graphe.ToListMetrosUtilisés(resultat_dijkstra);
            AffcherTab(liste_metros);

            // Commande pour recuperer les poids (nb minutes de trajets) dans l'ordre ex : Argentine-->Passy : [0, 2, 5, ..., 14] 14 minutes de trajet totale
            // Le temps de trajet total correspond donc au dernier element de cette liste 
            int[] liste_minutes = Test_Graphe.ToListPoidsStations(resultat_dijkstra);
            AffcherTab(liste_minutes);
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


    public class Base_Données
    {
        private static Base_Données instance = null;
        private MySqlConnection db;
        string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=simeon;";

        public Base_Données()
        {
            db = new MySqlConnection(connectionString);
        }

        public static Base_Données Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Base_Données();
                }
                return instance;
            }
        }

        public MySqlConnection DB
        {
            get
            {
                if (db == null)
                {
                    db = new MySqlConnection(connectionString);
                }

                if (db.State == ConnectionState.Broken || db.State == ConnectionState.Closed)
                {
                    try
                    {
                        db.Open();
                    }
                    catch
                    {
                        db.Dispose();
                        db = new MySqlConnection(connectionString);
                        db.Open();
                    }
                }

                return db;
            }
        }
    }

}
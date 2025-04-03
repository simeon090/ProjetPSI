namespace LivInParis
{
    internal static class App
    {
        static void Main()
        {
            // Initialisation Partie Graphique
            ApplicationConfiguration.Initialize();
            Application.Run(new LivInParis.Administrator());

            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            //Test_Graphe.VisualiserGraphe();
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Argentine");
            station_metro arrivée = Test_Graphe.TrouverStationAvecNom("Passy");

            //Exemple de calcule distance entre deux stations
            Console.WriteLine(station_metro.CalculDistance(depart, arrivée));

            //On lance dijkstra
            Dictionary<station_metro, (string, int)> resultat_dijkstra = Test_Graphe.Dijkstra(depart, arrivée);
            //Dictionary<station_metro, (string, int)> resultat_bellman = Test_Graphe.BellmanFord(depart, arrivée);


            // Commande pour recuperer les stations dans l'ordre ex : Argentine-->Passy : [Argentine, Charles de Gaule, Kléber ..... , Passy]
            station_metro[] liste_stations = Test_Graphe.ToListStations(resultat_dijkstra);
            AffcherTab(liste_stations);

            // Commande pour recuperer les lignes empruntés dans l'ordre ex : Argentine-->Passy : [1, 6, 6, 6]
            string[] liste_métros = Test_Graphe.ToListMetrosUtilisés(resultat_dijkstra);
            AffcherTab(liste_métros);

            // Commande pour recuperer les poids (nb minutes de trajets) dans l'ordre ex : Argentine-->Passy : [0, 2, 5, ..., 14] 14 minutes de trajet totale
            // Le temps de trajet total correspond donc au dernier element de cette liste 
            int[] liste_minutes = Test_Graphe.ToListPoidsStations(resultat_dijkstra);
            AffcherTab(liste_minutes);
        }

        static void AffcherTab(station_metro[] list)
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

        static void AffcherTab(string[] list)
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

        static void AffcherTab(int[] list)
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
namespace LivInParis
{
    internal static class App
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LivInParis.Administrator());


            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Argentine");
            station_metro arriv�e = Test_Graphe.TrouverStationAvecNom("Nation");
            (List<station_metro> chemin_Dijkstra, List<string> metros_utilis�s) = Test_Graphe.Dijkstra(depart, arriv�e);
            (List<station_metro> chemin_Dijkstra2, List<string> metros_utilis�s2) = Test_Graphe.BellmanFord(depart, arriv�e);
            (List<station_metro> chemin_Dijkstra3, List<string> metros_utilis�s3) = Test_Graphe.FloydWarshall(depart, arriv�e);
            Console.WriteLine(station_metro.CalculDistance(depart, arriv�e));
            AffcherList(chemin_Dijkstra, metros_utilis�s);
            AffcherList(chemin_Dijkstra2, metros_utilis�s2);
            AffcherList(chemin_Dijkstra3, metros_utilis�s3);
        }

        static void AffcherList(List<station_metro> list, List<string> metros_utilis�s)
        {
            if (list != null && list.Count - 1 > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i].Nom);
                    if (i < list.Count - 1)
                    {
                        if (metros_utilis�s.Count > 0 && metros_utilis�s.Count > i)
                        {
                            Console.Write(" --> ligne : " + metros_utilis�s[i] + " --> ");
                        }
                        else
                        {
                            Console.Write(" --> ");
                        }
                    }
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
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
            station_metro arrivée = Test_Graphe.TrouverStationAvecNom("Nation");
            (List<station_metro> chemin_Dijkstra, List<string> metros_utilisés) = Test_Graphe.Dijkstra(depart, arrivée);
            (List<station_metro> chemin_Dijkstra2, List<string> metros_utilisés2) = Test_Graphe.BellmanFord(depart, arrivée);
            (List<station_metro> chemin_Dijkstra3, List<string> metros_utilisés3) = Test_Graphe.FloydWarshall(depart, arrivée);
            Console.WriteLine(station_metro.CalculDistance(depart, arrivée));
            AffcherList(chemin_Dijkstra, metros_utilisés);
            AffcherList(chemin_Dijkstra2, metros_utilisés2);
            AffcherList(chemin_Dijkstra3, metros_utilisés3);
        }

        static void AffcherList(List<station_metro> list, List<string> metros_utilisés)
        {
            if (list != null && list.Count - 1 > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i].Nom);
                    if (i < list.Count - 1)
                    {
                        if (metros_utilisés.Count > 0 && metros_utilisés.Count > i)
                        {
                            Console.Write(" --> ligne : " + metros_utilisés[i] + " --> ");
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
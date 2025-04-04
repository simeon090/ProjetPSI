namespace LivInParis
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestDistanceStations()
        {
            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Argentine");
            station_metro arrivee = Test_Graphe.TrouverStationAvecNom("Nation");
            Assert.AreEqual(12.22, station_metro.CalculDistance(depart, arrivee));
        }

        [TestMethod]
        public void TestDijkstra()
        {
            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Argentine");
            station_metro arrivee = Test_Graphe.TrouverStationAvecNom("Trocad�ro");
            Dictionary<station_metro, (string, int)> resultat_dijkstra = Test_Graphe.Dijkstra(depart, arrivee);
            station_metro[] liste_stations = Test_Graphe.ToListStations(resultat_dijkstra);
            Assert.AreEqual(depart, liste_stations[0]);
            Assert.AreEqual(arrivee, liste_stations[liste_stations.Length-1]);
            Assert.AreEqual(7, liste_stations.Length);
        }

        [TestMethod]
        public void TestBellmanFord()
        {
            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Argentine");
            station_metro arrivee = Test_Graphe.TrouverStationAvecNom("Europe");
            Dictionary<station_metro, (string, int)> resultat_dijkstra = Test_Graphe.BellmanFord(depart, arrivee);
            station_metro[] liste_stations = Test_Graphe.ToListStations(resultat_dijkstra);
            Assert.AreEqual(depart, liste_stations[0]);
            Assert.AreEqual(arrivee, liste_stations[liste_stations.Length - 1]);
            Assert.AreEqual(7, liste_stations.Length);
        }

        [TestMethod]
        public void TestFloydWarshall()
        {
            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro depart = Test_Graphe.TrouverStationAvecNom("Argentine");
            station_metro arrivee = Test_Graphe.TrouverStationAvecNom("Passy");
            Dictionary<station_metro, (string, int)> resultat_dijkstra = Test_Graphe.BellmanFord(depart, arrivee);
            station_metro[] liste_stations = Test_Graphe.ToListStations(resultat_dijkstra);
            Assert.AreEqual(depart, liste_stations[0]);
            Assert.AreEqual(arrivee, liste_stations[liste_stations.Length - 1]);
            Assert.AreEqual(6, liste_stations.Length);
        }

        [TestMethod]
        public void TestTrouverIndex()
        {
            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro station = Test_Graphe.TrouverStationAvecNom("Nation");
            Assert.AreEqual(16, Test_Graphe.TrouverIndexAvecStation(station));
        }

       

    }
}
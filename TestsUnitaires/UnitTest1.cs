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
            station_metro arrivée = Test_Graphe.TrouverStationAvecNom("Nation");
            Assert.AreEqual(12.23, station_metro.CalculDistance(depart, arrivée));
        }
    }
}
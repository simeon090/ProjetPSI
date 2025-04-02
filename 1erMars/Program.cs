namespace _30Mars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graphe Test_Graphe = new Graphe("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            //Test_Graphe.toString();

        }

        static void AffcherList(List<station_metro> list)
        {
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i].ID);
                    if (i < list.Count - 1)
                    {
                        Console.Write(" --> ");
                    }
                }
                Console.WriteLine("\n\n");
            } else
            {
                Console.WriteLine("Liste null ou vide");
            }
        }
    }
}

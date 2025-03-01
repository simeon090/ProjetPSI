namespace _1erMars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etude du graphe karaté");
            Console.WriteLine("======================================\n");
            Graphe Test_Graphe = new Graphe("soc-karate.mtx");
            //Décomenter cette ligne pour utiliser le constructeur matrice d'adjacence
            //Graphe Test_Graphe = new Graphe("soc-karate.txt", true);
            Console.WriteLine("Parcour en Profondeur");
            AffcherList(Test_Graphe.ParcourProfondeur());
            Console.WriteLine("Parcour en Largeur");
            AffcherList(Test_Graphe.ParcourLargeur());
            Console.WriteLine("Trouver un cycle");
            AffcherList(Test_Graphe.DetecterCycle());
            Console.WriteLine("Ce graphe est t'il connexe?");
            Console.WriteLine(Test_Graphe.est_connexe());
            Test_Graphe.VisualiserGraphe();
        }

        static void AffcherList(List<Noeud> list)
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

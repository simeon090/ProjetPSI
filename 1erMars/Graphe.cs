using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erMars
{
    internal class Graphe
    {
        List<Noeud> List_Noeuds;
        List<Lien> List_Liens;
        
        public Graphe(List<Noeud> List_Noeuds, List<Lien> List_Liens)
        {
            this.List_Noeuds = List_Noeuds;
            this.List_Liens = List_Liens;
        }

        #region Constructeurs
        /// <summary>
        /// Constructeur du graphe à partir d'une listes d'adjacence
        /// On parcour les lignes et crée les noeuds de chaque identifiants qu'on stocke dans Liste_Noeuds
        /// On mémorise les liens entre deux noeuds dans List_Liens
        /// </summary>
        /// <param name="chemin_fichier">chemin du fichier pour construire le graphe</param>
        public Graphe(String chemin_fichier)
        {
            this.List_Noeuds = new List<Noeud> { };
            this.List_Liens = new List<Lien> { };
            string[] lignes = File.ReadAllLines(chemin_fichier);
            for (int i = 0; i < lignes.Length; i++)
            {
                int id1 = Convert.ToInt32(lignes[i].Split(" ")[0]);
                int id2 = Convert.ToInt32(lignes[i].Split(" ")[1]);
                Noeud eleve1 = this.List_Noeuds[TrouverIndexID(id1)];
                Noeud eleve2 = this.List_Noeuds[TrouverIndexID(id2)];
                Lien relation = new Lien(eleve1, eleve2);
                this.List_Liens.Add(relation);
            }

        }

        /// <summary>
        /// Constructeur du graphe à partir d'une matrice d'adjacence
        /// On crée la matrice en fonction des lignes du fichier
        /// Puis on parcour la matrice en l'affichant et on créant les bons noeuds et liens nécessaires
        /// </summary>
        /// <param name="chemin_fichier">chemin du fichier pour construire le graphe</param>
        public Graphe(String chemin_fichier, bool constructeur2)
        {
            this.List_Noeuds = new List<Noeud> { };
            this.List_Liens = new List<Lien> { };
            string[] lignes = File.ReadAllLines(chemin_fichier);
            int max_id_noeud = 0;
            //Dans cette partie on parcours une première fois le fichier à la recherche de l'id maximale pour crée une matrice
            //de la bonne dimension
            for (int i = 0; i < lignes.Length; i++)
            {
                string id1 = lignes[i].Split(",")[0].Replace(" ", "").Replace("(", "");
                string id2 = lignes[i].Split(",")[1].Replace(" ", "").Replace(")", "").Replace("1.0", "");
                int id1_int = Convert.ToInt32(id1);
                int id2_int = Convert.ToInt32(id2);
                if (id1_int > max_id_noeud)
                {
                    max_id_noeud = id1_int;
                }
                if (id2_int > max_id_noeud)
                {
                    max_id_noeud = id2_int;
                }
            }
            int[,] matrice_adjacence = new int[max_id_noeud+1, max_id_noeud+1];
            //Dans cette partie on parcours une deuxième fois le fichier pour remplir cette fois-ci la matrice
            for (int i = 0; i < lignes.Length; i++)
            {
                //Extraire seulement le chiffre qui nous intéresse
                string id1 = lignes[i].Split(",")[0].Replace(" ","").Replace("(","");
                string id2 = lignes[i].Split(",")[1].Replace(" ", "").Replace(")", "").Replace("1.0","");
                int id1_int = Convert.ToInt32(id1);
                int id2_int = Convert.ToInt32(id2);
                matrice_adjacence[id1_int, id2_int] = 1;
            }
            Console.WriteLine("\n===================");
            Console.WriteLine("Matrice d'adjacence");
            Console.WriteLine("===================\n");
            Console.Write("   |");
            for (int j = 0; j < matrice_adjacence.GetLength(1); j++)
            {
                if (j < 9)
                {
                    Console.Write(j + 1 + "  ");
                } else
                {
                    Console.Write(j + 1 + " ");
                }
            }
            Console.WriteLine();
            for (int j = 0; j < matrice_adjacence.GetLength(1)+2; j++)
            {
                Console.Write("---");
            }
            Console.WriteLine();

            for (int i = 0; i < matrice_adjacence.GetLength(0); i++)
            {
                if (i < 9)
                {
                    Console.Write(i + 1 + "  |");
                }
                else
                {
                    Console.Write(i + 1 + " |");
                }
                Noeud eleve1 = this.List_Noeuds[TrouverIndexID(i + 1)];
                for (int j = 0; j < matrice_adjacence.GetLength(1); j++)
                {
                    Noeud eleve2 = this.List_Noeuds[TrouverIndexID(j + 1)];
                    //Graphe non orienté alors il peut être lu dans les deux sens
                    //Par exemple 1 --> 2 vrai mais aussi 2 --> 1
                    //Condition à modifier en "matrice_adjacence[i, j] == 1" si graphe orienté
                    if (matrice_adjacence[i, j] == 1 || matrice_adjacence[j, i] == 1)
                    {
                        Console.Write("1" + "  ");
                    } else
                    {
                        Console.Write("0" + "  ");
                    }
                    if (matrice_adjacence[i, j] == 1)
                    {
                        Lien relation = new Lien(eleve1, eleve2);
                        this.List_Liens.Add(relation);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
        #endregion

        #region Parcours
        /// <summary>
        /// Methode d'instance pour parcourir le graphe en profondeur, on utilise la structure pile (First in last out) vu en
        /// semestre 1 pour explorer une branche jusqu'au dernier element avant de passer au voisin d'un noeud.
        /// Comme le graphe n'a pas rééllement de relation parents-enfants on récupère tous les voisins d'un noeud et on s'assure
        /// qu'il n'est pas déjà dans les noeuds parcouru.
        /// </summary>
        /// <returns>La liste des noeuds parcouru en profondeur</returns>
        public List<Noeud> ParcourProfondeur()
        {
            List<Noeud> noeuds_parcouru = new List<Noeud>();
            Stack<Noeud> pile_noeuds = new Stack<Noeud>();
            pile_noeuds.Push(this.List_Noeuds[TrouverIndexID(1)]);
            while (pile_noeuds.Count > 0)
            {
                Noeud n = pile_noeuds.Pop();
                if (!noeuds_parcouru.Contains(n))
                {
                    noeuds_parcouru.Add(n);
                }
                for (int i = this.List_Liens.Count - 1; i >= 0; i--)
                {
                    if (this.List_Liens[i].LEFT.ID == n.ID)
                    {
                        if (!noeuds_parcouru.Contains(this.List_Liens[i].RIGTH))
                        {
                            pile_noeuds.Push(this.List_Liens[i].RIGTH);
                        }
                    }
                    if (this.List_Liens[i].RIGTH.ID == n.ID)
                    {
                        if (!noeuds_parcouru.Contains(this.List_Liens[i].LEFT))
                        {
                            pile_noeuds.Push(this.List_Liens[i].LEFT);
                        }
                    }
                }
            }
            return noeuds_parcouru;
        }


        /// <summary>
        /// Methode d'instance pour parcourir le graphe en largeur, on utilise la structure file (First in first out) vu en
        /// semestre 1 pour explorer d'abord tous les noeuds d'un même niveau avant de passer à leur descendants.
        /// Comme le graphe n'a pas rééllement de relation parents-enfants on récupère tous les voisins d'un noeud et on s'assure
        /// qu'il n'est pas déjà dans les noeuds parcouru.
        /// </summary>
        /// <returns>La liste des noeuds parcouru en largeur</returns>
        public List<Noeud> ParcourLargeur()
        {
            List<Noeud> noeuds_parcouru = new List<Noeud>();
            Queue<Noeud> pile_noeuds = new Queue<Noeud>();
            pile_noeuds.Enqueue(this.List_Noeuds[TrouverIndexID(1)]);
            while (pile_noeuds.Count > 0)
            {
                Noeud n = pile_noeuds.Dequeue();
                if (!noeuds_parcouru.Contains(n))
                {
                    noeuds_parcouru.Add(n);
                }
                for (int i = 0; i < this.List_Liens.Count; i++)
                {
                    if (this.List_Liens[i].LEFT.ID == n.ID)
                    {
                        if (!noeuds_parcouru.Contains(this.List_Liens[i].RIGTH))
                        {
                            pile_noeuds.Enqueue(this.List_Liens[i].RIGTH);
                        }
                    }
                    if (this.List_Liens[i].RIGTH.ID == n.ID)
                    {
                        if (!noeuds_parcouru.Contains(this.List_Liens[i].LEFT))
                        {
                            pile_noeuds.Enqueue(this.List_Liens[i].LEFT);
                        }
                    }
                }
            }
            return noeuds_parcouru;
        }
        #endregion

        #region Autres méthodes
        /// <summary>
        /// Méthode d'instance qui parcours le graphe en profondeur, mais cette fois-ci en stockant les relations parents-enfants,
        /// lorsqu'on retombe sur un noeud déjà parcouru différent du parent alors on reconstruit le cycle grâce au dictionnaire qui
        /// stocke le parents de chaque noeud.
        /// </summary>
        /// <returns>Liste contenant un cycle contenue dans le graphe</returns>
        public List<Noeud> DetecterCycle()
        {
            List<Noeud> cycle = new List<Noeud>();
            List<Noeud> noeuds_parcouru = new List<Noeud>();
            Stack<Noeud> pile_noeuds = new Stack<Noeud>();
            //Dictionnaire pour stocker le parent de chaque noeud
            Dictionary<Noeud, Noeud> parent = new Dictionary<Noeud, Noeud>();

            pile_noeuds.Push(this.List_Noeuds[TrouverIndexID(1)]);
            //On donne à la racine le parent null pour détecter qu'il s'agit ici du début de notre graphe
            parent[this.List_Noeuds[TrouverIndexID(1)]] = null;

            //On fait un parcours en profondeur mais en stockant le parent de chaque noeud
            while (pile_noeuds.Count > 0)
            {
                Noeud n = pile_noeuds.Pop();

                if (!noeuds_parcouru.Contains(n))
                {
                    noeuds_parcouru.Add(n);
                }

                for (int i=0; i<this.List_Liens.Count; i++)
                {
                    Noeud enfant = null;

                    if (this.List_Liens[i].LEFT.ID == n.ID)
                    {
                        enfant = this.List_Liens[i].RIGTH;
                    }
                    else if (this.List_Liens[i].RIGTH.ID == n.ID)
                    {
                        enfant = this.List_Liens[i].LEFT;
                    }
                    //On verifie si le noeud à un enfant  (lien gauche ou droite et différent du parent)
                    if (enfant != null && enfant != parent[n])
                    {
                        //Si on n'a pas encore parcouru l'enfant on continue le parcour en profondeur sinon on à trouver un cycle
                        if (!noeuds_parcouru.Contains(enfant))
                        {
                            pile_noeuds.Push(enfant);
                            parent[enfant] = n;
                        } else {
                            //On remonte dans les parents de chaque noeud pour reconstiuer le cycle
                            Noeud noeud_cycle = n;
                            cycle.Add(enfant);
                            while (noeud_cycle != null && noeud_cycle != enfant)
                            {
                                cycle.Add(noeud_cycle);
                                noeud_cycle = parent[noeud_cycle];
                            }
                            cycle.Add(noeud_cycle);
                            return cycle;
                        }
                    }
                }
            }
            return cycle;
        }


        /// <summary>
        /// Méthode d'instance qui test si le graphe est connexe. En effet, dans le parcour en profondeur si en partant de la racine
        /// on parcour tous les noeuds, alors tous les noeuds sont liés, le graphe est alors connexe.
        /// </summary>
        /// <returns>booléen indiquant si le graphe est connexe</returns>
        public bool est_connexe()
        {
            bool resultat = false;
            List<Noeud> noeuds = ParcourProfondeur();
            if (noeuds.Count == this.List_Noeuds.Count)
            {
                resultat = true;
            }
            return resultat;
        }


        public void toString()
        {
            for (int i = 0; i < List_Liens.Count; i++)
            {
                Console.WriteLine(List_Liens[i].LEFT.ID + "--->" + List_Liens[i].RIGTH.ID);
            }
        }


        /// <summary>
        /// Méthode qui permet de trouver à quel indice est stocké un noeud d'attribut id
        /// Si le noeud n'existe pas dans la liste alors on le rajoute et l'indice est le dernier element de la liste
        /// </summary>
        public int TrouverIndexID(int id)
        {
            int index = -1;
            for (int i = 0; i < List_Noeuds.Count; i++) {
                if (List_Noeuds[i].ID == id)
                {
                    index = i;
                }
            }
            if (index < 0)
            {
                this.List_Noeuds.Add(new Noeud(id));
                index = this.List_Noeuds.Count - 1;
            }
            return index;
        }
        #endregion

        #region Visualiser le Graphe
        /// <summary>
        /// Méthode utilisant la bibliothèque Système.Drawing et Microsoft.Forms pour visualiser le graphique
        /// </summary>
        public void VisualiserGraphe()
        {
            // On initialise une fenètre de taille 800x600
            Form form = new Form
            {
                Text = "Visualisation du Graphe karaté",
                Size = new Size(800, 600)
            };
            //fonction de l'extension windows.forms pour dessiner le graphique
            form.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                Font font = new Font("Arial", 10);

                //Dictionnaire stockant les positions de chaque noeuds : la clé est l'id de chaque noeud et Point et un type de Système.Drawing suggéré par chatGPT pour stocké les positions x et y du noeud
                Dictionary<int, Point> positions = new Dictionary<int, Point>();
                Random rand = new Random();
                int rayon = 20;
                int distanceMin = 80;

                // Cette boucle positionne chaque noeud en s'assurant que les noeuds ne se supperpose pas et soient espacé de distanceMin
                foreach (var noeud in this.List_Noeuds)
                {
                    Point newPosition = new Point(0,0);
                    bool positionValide = false;

                    // Tant que la position n'est pas valide on génère aléatoirement une nouvelle position
                    while (!positionValide)
                    {
                        newPosition = new Point(rand.Next(50, form.Width - 50), rand.Next(50, form.Height - 50));
                        positionValide = true;
                        // On utilise la formule pour calculer la distance entre deux points et on s'assure que la distance entre la position du nouveau noeuds et des autres est supérieur à la distance Minimal
                        // Cela empêche que les noeuds ce supperoposent ou soit trop proche
                        foreach (var pos in positions.Values)
                        {
                            if (Math.Sqrt(Math.Pow(newPosition.X - pos.X, 2) + Math.Pow(newPosition.Y - pos.Y, 2)) < distanceMin)
                            {
                                positionValide = false;
                                break;
                            }
                        }

                    }
                    positions[noeud.ID] = newPosition;
                }

                // Dessiner les liens
                foreach (var lien in this.List_Liens)
                {
                    Point p1 = positions[lien.LEFT.ID];
                    Point p2 = positions[lien.RIGTH.ID];
                    g.DrawLine(pen, p1, p2);
                }

                // Dessiner les noeuds
                foreach (var noeud in List_Noeuds)
                {
                    Point pos = positions[noeud.ID];
                    g.FillEllipse(Brushes.LightBlue, pos.X - rayon, pos.Y - rayon, rayon * 2, rayon * 2);
                    g.DrawEllipse(pen, pos.X - rayon, pos.Y - rayon, rayon * 2, rayon * 2);
                    g.DrawString(noeud.ID.ToString(), font, Brushes.Black, pos.X - 6, pos.Y - 6);
                }
            };

            Application.Run(form);
        }
        #endregion
    }
}

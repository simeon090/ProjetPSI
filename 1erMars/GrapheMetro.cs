using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30Mars
{
    internal class Graphe
    {
        List<station_metro> List_Noeuds;
        List<Arcs> List_Liens;
        
        public Graphe(List<station_metro> List_Noeuds, List<Arcs> List_Liens)
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
        public Graphe(String chemin_fichier_stations, String chemin_fichier_arcs)
        {
            this.List_Noeuds = new List<station_metro> { };
            this.List_Liens = new List<Arcs> { };
            string[] lignes_stations = File.ReadAllLines(chemin_fichier_stations);
            string[] lignes_arcs = File.ReadAllLines(chemin_fichier_arcs);
            for (int i = 1; i < 10; i++)
            {
                int id = Convert.ToInt32(lignes_stations[i].Split(";")[0]);
                string nom_station = lignes_stations[i].Split(";")[2];
                float longitude = float.Parse(lignes_stations[i].Split(';')[3].Replace(".",","));
                float latitude = float.Parse(lignes_stations[i].Split(';')[4].Replace(".", ","));
                int code_insee = Convert.ToInt32(lignes_stations[i].Split(';')[6]);
                station_metro station = this.List_Noeuds[TrouverIndexID(id, nom_station, longitude, latitude, code_insee)];
            }
            Console.WriteLine(List_Noeuds.Count);
            for (int i = 1; i < 5; i++)
            {
                string nom_station = lignes_arcs[i].Split(";")[1];
                string precedent = lignes_arcs[i].Split(';')[2];
                int duree = Convert.ToInt32(lignes_arcs[i].Split(';')[4]);
                string ligne_de_metro = lignes_arcs[i].Split(';')[7];
                string sens = lignes_arcs[i].Split(';')[8];
                int tps_changement = 0;
                if (lignes_arcs[i].Split(';')[5].Length > 0)
                {
                    tps_changement = Convert.ToInt32(lignes_arcs[i].Split(';')[5]);
                }
                station_metro station_precedente = null;
                station_metro station_actuelle = TrouverStationAvecNom(nom_station);
                if (precedent.Length > 0)
                {
                    station_precedente = TrouverStationAvecNom(lignes_stations[Convert.ToInt32(precedent)].Split(";")[2]);

                }
                if (station_precedente != null)
                {
                    this.List_Liens.Add(new Arcs(station_precedente, station_actuelle, duree, ligne_de_metro, sens, tps_changement));
                }
            }
            Console.WriteLine(List_Liens.Count);
        }
        #endregion

        #region Autres méthodes

        public void toString()
        {
            for (int i = 0; i < List_Liens.Count; i++)
            {
                Console.WriteLine(List_Liens[i].Precedent.Nom + "--->" + List_Liens[i].Suivant.Nom);
            }
        }


        public station_metro TrouverStationAvecNom (string nom_station)
        {
            for (int i = 0; i < List_Noeuds.Count; i++)
            {
                if (List_Noeuds[i].Nom == nom_station)
                {
                    return List_Noeuds[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Méthode qui permet de trouver à quel indice est stocké un noeud d'attribut id
        /// Si le noeud n'existe pas dans la liste alors on le rajoute et l'indice est le dernier element de la liste
        /// </summary>
        public int TrouverIndexID(int id, string nom_station, float longitude, float latitude, int code_insee)
        {
            int index = -1;
            for (int i = 0; i < List_Noeuds.Count; i++)
            {
                if (List_Noeuds[i].Nom == nom_station)
                {
                    index = i;
                }
            }
            if (index < 0)
            {
                this.List_Noeuds.Add(new station_metro(id, nom_station, longitude, latitude, code_insee));
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
                Text = "Visualisation du Graphe Metro de Paris",
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
                    Point newPosition = new Point(0, 0);
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
                    Point p1 = positions[lien.Precedent.ID];
                    Point p2 = positions[lien.Suivant.ID];
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

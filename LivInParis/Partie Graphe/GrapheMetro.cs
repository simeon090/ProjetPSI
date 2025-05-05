using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.LinkLabel;

namespace LivInParis
{
    public class GrapheMetro
    {
        List<station_metro> List_Noeuds;
        List<ArcsMetro> List_Liens;

        #region Constructeur
        /// <summary>
        /// Constructeur du graphe métro. On récupère les lignes des deux fichiers CSV préablement traités (voir read.me).
        /// On parcours les lignes des stations et on execute la fonction TrouverStation pour chacune d'entre-elles. 
        /// Ensuite on parcours les lignes des arcs et on ajoute chaque arcs à la liste en prenant soin d'enregistrer chaque information
        /// </summary>
        /// <param name="chemin_fichier_stations">chemin du fichier .csv contenant les lignes de toutes les stations de métros</param>
        /// <param name="chemin_fichier_arcs">chemin du fichier .csv contenant les lignes de tous les arcs reliant les stations</param>
        public GrapheMetro(String chemin_fichier_stations, String chemin_fichier_arcs)
        {
            // 1) Initialisation
            this.List_Noeuds = new List<station_metro>();
            this.List_Liens = new List<ArcsMetro>();

            // Solution pour résoudre le problème des accents dans un csv trouvé avec chatGPT (voir rapport)
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string[] lignes_stations = File.ReadAllLines(chemin_fichier_stations, Encoding.GetEncoding("Windows-1252"));
            string[] lignes_arcs = File.ReadAllLines(chemin_fichier_arcs, Encoding.GetEncoding("Windows-1252"));

            // 2) Parcours des stations et leur ajout dans List_Noeuds
            for (int i = 1; i < lignes_stations.Length; i++)
            {
                int id = Convert.ToInt32(lignes_stations[i].Split(";")[0]);
                string nom_station = lignes_stations[i].Split(";")[2];
                float longitude = float.Parse(lignes_stations[i].Split(';')[3].Replace(".",","));
                float latitude = float.Parse(lignes_stations[i].Split(';')[4].Replace(".", ","));
                int code_insee = Convert.ToInt32(lignes_stations[i].Split(';')[6]);
                TrouverStation(id, nom_station, longitude, latitude, code_insee);
            }

            // 3) Parcours des arcs et leur ajout dans List_Liens
            for (int i = 1; i < lignes_arcs.Length; i++)
            {
                string nom_station = lignes_arcs[i].Split(";")[1];
                string precedent = lignes_arcs[i].Split(';')[2];
                int duree = Convert.ToInt32(lignes_arcs[i].Split(';')[4]);
                string ligne_de_metro = lignes_arcs[i].Split(';')[7];
                string sens = lignes_arcs[i].Split(';')[8];
                string status = lignes_arcs[i].Split(';')[6];
                // Cette valeure est arbitraire est considéré seulement pour les stations qui ont des correspondances avec d'autres lignes
                int tps_changement = Convert.ToInt32(lignes_arcs[i].Split(';')[5]);
                station_metro station_precedente = null;
                station_metro station_actuelle = TrouverStationAvecNom(nom_station);
                if (precedent.Length > 0)
                {
                    station_precedente = TrouverStationAvecNom(lignes_stations[Convert.ToInt32(precedent)].Split(";")[2]);

                }
                if (station_precedente != null)
                {
                    this.List_Liens.Add(new ArcsMetro(station_precedente, station_actuelle, duree, ligne_de_metro, sens, tps_changement, status));
                }
            }
        }
        #endregion

        #region Autres méthodes

        /// <summary>
        /// Méthode d'instance utilisée pour le debug qui affiche chaque lien entre les noeufs
        /// </summary>
        public void toString()
        {
            for (int i = 0; i < List_Liens.Count; i++)
            {
                Console.WriteLine(List_Liens[i].Precedent.Nom + "--->" + List_Liens[i].Suivant.Nom);
            }
        }

        /// <summary>
        /// Cette méthode permet de retrouver et retourner le bon object "station_metro" à partir du nom de la station.
        /// /!\ Attention le résultat peux être nullable si la station n'existe pas
        /// </summary>
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
        /// Similaire à TrouverStation, ici on sait que la station est dans le graphe et on cherche simplement son indice dans la liste des noeuds
        /// </summary>
        public int TrouverIndexAvecStation(station_metro station)
        {
            for (int i = 0; i < List_Noeuds.Count; i++)
            {
                if (List_Noeuds[i] == station)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Cette méthode vérifie que la station entrer en paramètre n'existe pas en comparant le nom (car unique)
        /// Si elle n'existe pas la fonction crée un nouveau objet station_metro et l'ajoute à la liste des noeuds
        /// </summary>
        /// <returns>L'indice de la station dans la liste des noeuds</returns>
        public int TrouverStation(int id, string nom_station, float longitude, float latitude, int code_insee)
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

        #region Plus Court Chemin
        /// <summary>
        /// Méthode d'instance qui calcule le plus court chemin entre deux noeuds grâce à l'algorithme de Dijktra
        /// </summary>
        /// <returns>ex: le trajet Argentine -> George V retournera {Argentine : (1,0), Charle De Gaule Etoile : (1,3), George V : (1,5) </returns>
        /// Les clés du dictionnaire sont les stations parcourues et les valeurs un tuple contenant la ligne utilisé et la durée en minutes)
        public Dictionary<station_metro, (string, int)> Dijkstra(station_metro départ, station_metro arrivé)
        {
            // 1) INITIALISATION
            // Stock le poids pour aller à chaque noeud et régulièrement mis à jour si chemin plus court trouvé
            Dictionary<station_metro, int> poids = new Dictionary<station_metro, int>();
            // Stock le prédécésseur de chaque noeud c'est à dire le parent qui permet d'accéder au noeud actuel avec le coût minimale
            Dictionary<station_metro, station_metro> parent = new Dictionary<station_metro, station_metro>();
            // Stock la ligne de métro utiliser pour aller du parent au noeud actuel
            Dictionary<station_metro, string> lignePred = new Dictionary<station_metro, string>();
            // List de parcours
            List<station_metro> Stations = new List<station_metro>();

            for (int i = 0; i < this.List_Noeuds.Count; i++) {
                // Au début tous les noeuds se trouve à une distance "infini" et personne à de parents
                poids[List_Noeuds[i]] = 999999;
                parent[List_Noeuds[i]] = null;
            }
            poids[départ] = 0;
            Stations.Add(départ);

            // Tant qu'il reste des noeuds à parcourir
            while (Stations.Count > 0)
            {
                // 2) RECHERCHE DU SOMMET AVEC LA PLUS PETITE DISTANCE
                station_metro u = Stations[0];
                Stations.Remove(u);

                // On parcours tous les liens à la recherche d'un "enfant" qui peux être successeur comme prédécesseur de notre noeud actuel
                for (int i = 0; i < this.List_Liens.Count; i++)
                {
                    station_metro enfant = null;
                    if (List_Liens[i].Precedent == u)
                    {
                        enfant = List_Liens[i].Suivant;
                    }
                    else if (List_Liens[i].Suivant == u)
                    {
                        enfant = List_Liens[i].Precedent;
                    }

                    // Si un enfant est trouvé on calcule le poids necessaire pour y accéder et on regarde s'il s'agit du poids minimum trouvé ou pas pour ce noeud
                    if (enfant != null)
                    {
                        int nouvelle_distance = poids[u] + List_Liens[i].Duree_minute;
                        // Si la ligne de métro change c'est à dire que pour accéder à l'enfant on utilise une ligne différente de celle avec lequelle on est arrivé au parent alors on rajoute le temps de changement
                        if (lignePred.ContainsKey(u) && lignePred[u] != List_Liens[i].Ligne_de_metro)
                        {
                            nouvelle_distance += List_Liens[i].Temps_de_changement;
                        }
                        // Ssi la distance finale est inférieur au poids jusqu'à présent trouvé pour cette enfant alors on met à jour le poid et on explore depuis cette enfant
                        if (nouvelle_distance < poids[enfant])
                        {
                            poids[enfant] = nouvelle_distance;
                            // On stock le parent de notre enfant
                            parent[enfant] = u;
                            Stations.Add(enfant);
                            lignePred[enfant] = List_Liens[i].Ligne_de_metro;
                        }
                    }
                }
            }

            // 3) RECONSTITUTION DU PLUS COURT CHEMIN
            Dictionary<station_metro, (string, int)> resultat = new Dictionary<station_metro, (string, int)> { };
            station_metro station_actuel = arrivé;
            int poid = poids[arrivé];
            while (station_actuel != null)
            {
                if (lignePred.ContainsKey(station_actuel))
                {
                    resultat[station_actuel] = (lignePred[station_actuel], poids[station_actuel]);
                } else
                {
                    resultat[station_actuel] = (null, poids[station_actuel]);
                }
                station_actuel = parent[station_actuel];
            }
            return (resultat);
        }


        /// <summary>
        /// Méthode d'instance qui calcule le plus court chemin entre deux noeuds grâce à l'algorithme de BellmanFord
        /// </summary>
        /// <returns> ex: le trajet Argentine -> George V retournera {Argentine : (1,0), Charle De Gaule Etoile : (1,3), George V : (1,5) </returns>
        /// Les clés du dictionnaire sont les stations parcourues et les valeurs un tuple contenant la ligne utilisé et la durée en minutes)
        public Dictionary<station_metro, (string, int)> BellmanFord(station_metro départ, station_metro arrivé)
        {
            // 1) INITIALISATION
            // Stock le poids pour aller à chaque noeud et régulièrement mis à jour si chemin plus court trouvé
            Dictionary<station_metro, int> poids = new Dictionary<station_metro, int>();
            // Stock le prédécésseur de chaque noeud c'est à dire le parent qui permet d'accéder au noeud actuel avec le coût minimale
            Dictionary<station_metro, station_metro> parent = new Dictionary<station_metro, station_metro>();
            // Stock la ligne de métro utiliser pour aller du parent au noeud actuel
            Dictionary<station_metro, string> lignePred = new Dictionary<station_metro, string>();

            for (int i = 0; i < this.List_Noeuds.Count; i++)
            {
                // Au début tous les noeuds se trouve à une distance "infini" et personne à de parents
                poids[List_Noeuds[i]] = 999999;
                parent[List_Noeuds[i]] = null;
            }
            poids[départ] = 0;

            // 2) ITERATION SUR LA MATRICE POUR TROUVER LA DISTANCE MINIMALE A CHAQUE SOMMET
            // La boucle |V| - 1
            for (int i = 0; i < List_Noeuds.Count - 1; i++)
            {
                // On parcours chaque arc du graphe
                for (int j=0; j<this.List_Liens.Count; j++)
                {
                    station_metro u = List_Liens[i].Precedent;
                    station_metro enfant = List_Liens[i].Suivant;

                    int nouvelle_distance = poids[u] + List_Liens[i].Duree_minute;

                    // Si la ligne de métro change c'est à dire que pour accéder à l'enfant on utilise une ligne différente de celle avec lequelle on est arrivé au parent alors on rajoute le temps de changement
                    if (lignePred.ContainsKey(u) && lignePred[u] != List_Liens[i].Ligne_de_metro)
                    {
                        nouvelle_distance += List_Liens[i].Temps_de_changement;
                    }
                    // Ssi la distance finale est inférieur au poids jusqu'à présent trouvé pour cette enfant alors on met à jour le poid et on boucle à nouveau
                    if (nouvelle_distance < poids[enfant] && List_Liens[i].Status == "oui")
                    {
                        poids[enfant] = nouvelle_distance;
                        parent[enfant] = u;
                        lignePred[enfant] = List_Liens[i].Ligne_de_metro;
                    }
                }
            }

            // 3) RECONSTITUTION DU PLUS COURT CHEMIN
            Dictionary<station_metro, (string, int)> resultat = new Dictionary<station_metro, (string, int)> { };
            station_metro station_actuel = arrivé;
            int poid = poids[arrivé];
            while (station_actuel != null)
            {
                if (lignePred.ContainsKey(station_actuel))
                {
                    resultat[station_actuel] = (lignePred[station_actuel], poids[station_actuel]);
                }
                else
                {
                    resultat[station_actuel] = (null, poids[station_actuel]);
                }
                station_actuel = parent[station_actuel];
            }
            return (resultat);
        }


        /// <summary>
        /// Méthode d'instance qui calcule le plus court chemin entre deux noeuds grâce à l'algorithme de FloydWarshall
        /// /!\ Cette méthode n'arrive pas pour l'instant à prendre en compte les temps de changements et ne stocke pas les métros utilisés ! A revoir !
        /// </summary>
        /// /// <returns>ex: le trajet Argentine -> George V retournera {Argentine : (1,0), Charle De Gaule Etoile : (1,3), George V : (1,5) </returns>
        /// Les clés du dictionnaire sont les stations parcourues et les valeurs un tuple contenant la ligne utilisé et la durée en minutes)
        public Dictionary<station_metro, (string, int)> FloydWarshall(station_metro depart, station_metro arrivee)
        {
            // Matrice d'adjacence du graphe nécessaire pour cette algorithme
            int[,] matrice_adjacence = new int[this.List_Noeuds.Count, this.List_Noeuds.Count];
            //Stock les predecesseurs pour chaque noeud c'est à dire le parent avec la plus courte distance 
            station_metro[,] chemin_plus_cour = new station_metro[this.List_Noeuds.Count, this.List_Noeuds.Count];

            //string[,] lignePred = new string[this.List_Noeuds.Count, this.List_Noeuds.Count];

            // 1) CONSTRUCTION DE LA MATRICE D'ADJACENCE
            for (int i = 0; i < this.List_Noeuds.Count; i++)
            {
                for (int j = 0; j < this.List_Noeuds.Count; j++)
                {
                    if (i == j)
                    {
                        //On fixe la distance entre le même noeud a 0
                        matrice_adjacence[i, j] = 0;
                    }
                    else
                    {
                        //Sinon on considere la distance infini
                        matrice_adjacence[i, j] = 99999;
                    }
                }
            }

            for (int i = 0; i < List_Liens.Count; i++)
            {
                int index_parent = TrouverIndexAvecStation(List_Liens[i].Precedent);
                int index_voisin = TrouverIndexAvecStation(List_Liens[i].Suivant);

                matrice_adjacence[index_parent, index_voisin] = List_Liens[i].Duree_minute;
                // On considère le graphe comme non orienté (voir readme)
                matrice_adjacence[index_voisin, index_parent] = List_Liens[i].Duree_minute;

                chemin_plus_cour[index_parent, index_voisin] = List_Liens[i].Precedent;
                chemin_plus_cour[index_voisin, index_parent] = List_Liens[i].Suivant;

                //if (this.List_Liens[i].Ligne_de_metro != lignePred[index_parent, index_voisin])
                //{
                //    matrice_adjacence[index_parent, index_voisin] += List_Liens[i].Temps_de_changement;
                //    matrice_adjacence[index_voisin, index_parent] += List_Liens[i].Temps_de_changement;
                //}

                //lignePred[index_parent, index_voisin] = List_Liens[i].Ligne_de_metro;
                //lignePred[index_voisin, index_parent] = List_Liens[i].Ligne_de_metro;
            }

            //VisualiserMatriceAdjacence(matrice_adjacence);

            //2) ON EFFECTUE LES ITERATIONS A LA RECHERCHE D'UN CHEMIN PLUS COUR

            // Les trois boucles Floyd-Warshall vus sur Wikipédia
            for (int k = 0; k < this.List_Noeuds.Count; k++)
            {
                for (int i = 0; i < this.List_Noeuds.Count; i++)
                {
                    for (int j = 0; j < this.List_Noeuds.Count; j++)
                    {
                        // On cherche le minimum entre la distance direct (i,j) et (i;k) + (k,j)
                        if (matrice_adjacence[i, j] > matrice_adjacence[i, k] + matrice_adjacence[k, j])
                        {
                            matrice_adjacence[i, j] = matrice_adjacence[i, k] + matrice_adjacence[k, j];
                            //On met à jour le chemin le plus court ce n'est plus (i,j) mais (k,j) (on passe par un autre noeud pour avoir un chemin plus cour)
                            chemin_plus_cour[i, j] = chemin_plus_cour[k, j];
                            //lignePred[i,j] = lignePred[k,j];
                        }
                    }
                }
            }

            //3) ON RECONSTITUE LE CHEMIN
            Dictionary<station_metro, (string, int)> resultat = new Dictionary<station_metro, (string, int)> { };
            int index_depart = TrouverIndexAvecStation(depart);
            int index_arrivee = TrouverIndexAvecStation(arrivee);

            // Si on a pas trouvé de chemin entre le départ et l'arrivé on retourne null;
            if (chemin_plus_cour[index_depart, index_arrivee] == null)
            {
                return resultat;
            }

            station_metro station_actuel = arrivee;

            while (station_actuel != null)
            {
                int index_actuel = TrouverIndexAvecStation(station_actuel);
                int poids = matrice_adjacence[index_depart, index_actuel];
                if (!resultat.ContainsKey(station_actuel))
                {
                    // Le numéro de ligne est null tout le temps car on a pas réussi à trouver le moyen de sauvegarder le numéro de ligne ici
                    resultat[station_actuel] = ("null", poids);
                }

                station_actuel = chemin_plus_cour[index_depart, index_actuel];
            }
            return resultat;
        }

        #endregion

        #region Visualisation

        public void VisualiserMatriceAdjacence(int[,] matrice)
        {
            Console.WriteLine("\n===================");
            Console.WriteLine("Matrice d'adjacence");
            Console.WriteLine("===================\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j < 10; j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Méthode réalisé avec l'aide de ChatGPT utilisant la bibliothèque Système.Drawing et Microsoft.Forms pour visualiser le graphique
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
                int rayon = 5;
                int distanceMin = 5;

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

        #region Traitement résultats

        public station_metro[] ToListStations(Dictionary<station_metro, (string, int)> resultats)
        {
            station_metro[] chemin = new station_metro[resultats.Count];
            int i = resultats.Count-1;
            foreach (var station in resultats.Keys)
            {
                chemin[i] = station;
                i -= 1;
            }
            return chemin;
        }

        public string[] ToListMetrosUtilisés(Dictionary<station_metro, (string, int)> resultats)
        {
            string[] chemin = new string[resultats.Count];
            int i = resultats.Count - 1;
            foreach (var valeurs in resultats.Values)
            {
                chemin[i] = valeurs.Item1;
                i -= 1;
            }
            return chemin;
        }

        public int[] ToListPoidsStations(Dictionary<station_metro, (string, int)> resultats)
        {
            int[] chemin = new int[resultats.Count];
            int i = resultats.Count - 1;
            foreach (var valeurs in resultats.Values)
            {
                chemin[i] = valeurs.Item2;
                i -= 1;
            }
            return chemin;
        }
        #endregion
    }
}

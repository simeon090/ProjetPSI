using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LivInParis.Partie_Graphe
{
    public class GrapheUtilisateur
    {
        List<Utilisateur> List_Noeuds;
        List<ArcsUtilisateurs> List_Arcs;
        public MySqlConnection connexion;

        public GrapheUtilisateur(MySqlConnection connexion)
        {
            this.List_Noeuds = new List<Utilisateur>();
            this.List_Arcs = new List<ArcsUtilisateurs>();
            this.connexion = connexion;
            List<Cuisinier> List_Cuisiniers = new List<Cuisinier>();
            List<Client> List_Clients = new List<Client>();

            string query_client = 
                @"SELECT 
                    c.Identifiant_client, 
                    c.Mot_de_passe, 
                    p.nom_particulier, 
                    p.prenom_particulier 
                FROM Client c
                JOIN Particulier p ON c.Identifiant_client = p.Identifiant_client";

            using (MySqlDataReader reader_client = new MySqlCommand(query_client, connexion).ExecuteReader())
            {
                while (reader_client.Read())
                {
                    string nom = reader_client.GetString("nom_particulier");
                    string prenom = reader_client.GetString("prenom_particulier");
                    string identifiant = reader_client.GetString("Identifiant_client");
                    string motDePasse = reader_client.GetString("Mot_de_passe");
                    Client client = new Client(nom, prenom, "Client", identifiant, motDePasse);
                    this.List_Noeuds.Add(client);
                    List_Clients.Add(client);
                }
                reader_client.Close();
            }

            string query_cuisinier = "SELECT * FROM Cuisinier";
            MySqlDataReader reader_cuisinier = new MySqlCommand(query_cuisinier, connexion).ExecuteReader();

            while (reader_cuisinier.Read())
            {
                Cuisinier cuisinier = new Cuisinier(
                    reader_cuisinier.GetString("nom_cuisinier"),
                    reader_cuisinier.GetString("prenom_cuisinier"),
                    "Cuisinier",
                    reader_cuisinier.GetString("adresse_cuisinier"),
                    reader_cuisinier.GetString("mail_cuisinier"),
                    Convert.ToInt32(reader_cuisinier.GetDecimal("telephone_cuisinier"))
                );
                this.List_Noeuds.Add(cuisinier);
                List_Cuisiniers.Add(cuisinier);
            }
            reader_cuisinier.Close();

            for (int i = 0; i < List_Cuisiniers.Count; i++)
            {
                string query_commande = @"
                    SELECT DISTINCT c.Identifiant_client
                    FROM Client c
                    JOIN Commande com ON c.Identifiant_client = com.Identifiant_client
                    WHERE com.telephone_cuisinier = @telephone
                ";
                MySqlCommand cmd = new MySqlCommand(query_commande, connexion);
                cmd.Parameters.AddWithValue("@telephone", List_Cuisiniers[i].telephone);
                using (MySqlDataReader reader_comande = cmd.ExecuteReader())
                {
                    while (reader_comande.Read())
                    {
                        Client client = TrouverClientDeId(List_Clients, reader_comande.GetString("Identifiant_client"));
                        this.List_Arcs.Add(new ArcsUtilisateurs(List_Cuisiniers[i], client));
                    }
                }
            }
        }

        public Client TrouverClientDeId(List<Client> liste, string id)
        {
            Client client = null;
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].IdentifiantClient == id)
                {
                    client = liste[i];
                }
            }
            if (client is null)
            {
                Console.WriteLine(id);
            }
            return client;
        }

        public string ToString()
        {
            string resultat = "Liste des Utilisateurs : \n";
            for (int i = 0;i<this.List_Noeuds.Count; i++)
            {
                resultat += this.List_Noeuds[i].Nom + " " + this.List_Noeuds[i].Prenom + " | ";
            }
            resultat += "\nListe des Relations : \n";
            for (int i = 0; i < this.List_Arcs.Count; i++)
            {
                resultat += this.List_Arcs[i].Cuisinier.Nom + " " + this.List_Arcs[i].Cuisinier.Prenom + "----->" + this.List_Arcs[i].Client.Nom + " " + this.List_Arcs[i].Client.Prenom + "\n";
            }
            return resultat;
        }

        // liste qui stocke les couleurs pour la coloration
        Brush[] couleurs = new Brush[]
        {
            Brushes.LightBlue,
            Brushes.LightGreen,
            Brushes.LightCoral,
            Brushes.LightSalmon,
            Brushes.LightSeaGreen,
            Brushes.LightPink,
            Brushes.LightGoldenrodYellow,
            Brushes.LightSkyBlue,
            Brushes.LightSteelBlue,
            Brushes.LightGray
        };

        /// <summary>
        /// Méthode réalisé avec l'aide de ChatGPT utilisant la bibliothèque Système.Drawing et Microsoft.Forms pour visualiser le graphique
        /// </summary>
        public void VisualiserGraphe()
        {
            // On initialise une fenètre de taille 800x600
            Form form = new Form
            {
                Text = "Visualisation du Graphe Metro de Paris",
                Size = new Size(1000, 800)
            };
            //fonction de l'extension windows.forms pour dessiner le graphique
            form.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                Font font = new Font("Arial", 10);

                //Dictionnaire stockant les positions de chaque noeuds : la clé est l'id de chaque noeud et Point et un type de Système.Drawing suggéré par chatGPT pour stocké les positions x et y du noeud
                Dictionary<Utilisateur, Point> positions = new Dictionary<Utilisateur, Point>();
                Random rand = new Random();
                int rayon = 30;
                int distanceMin = 50;

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
                    positions[noeud] = newPosition;
                }

                // Dessiner les liens
                foreach (var lien in this.List_Arcs)
                {
                    Point p1 = positions[lien.Cuisinier];
                    Point p2 = positions[lien.Client];
                    g.DrawLine(pen, p1, p2);
                }

                // Dessiner les noeuds
                foreach (var noeud in List_Noeuds)
                {
                    Point pos = positions[noeud];
                    string nom = noeud.Nom + "\n" + noeud.Prenom;
                    if (noeud.type == "Client")
                    {
                        g.FillEllipse(couleurs[noeud.Couleur], pos.X - rayon, pos.Y - rayon, rayon * 2, rayon * 2);
                        g.DrawEllipse(pen, pos.X - rayon, pos.Y - rayon, rayon * 2, rayon * 2);
                    } else
                    {
                        g.FillRectangle(couleurs[noeud.Couleur], pos.X - rayon, pos.Y - rayon, rayon * 2, rayon * 2);
                        g.DrawRectangle(pen, pos.X - rayon, pos.Y - rayon, rayon * 2, rayon * 2);
                    }
                    g.DrawString(nom.ToString(), font, Brushes.Black, pos.X - 20, pos.Y - 10);
                }
            };

            form.Show();
        }




        public void ColorationGraphe()
        {
            //on calcul les degrés
            Dictionary<Utilisateur, int> degrés = new Dictionary<Utilisateur, int>();
            for (int i=0; i<List_Noeuds.Count; i++)
            {
                int degré = 0;
                for (int j = 0; j < List_Arcs.Count; j++)
                {
                    if (List_Arcs[j].Cuisinier == List_Noeuds[i] || List_Arcs[j].Client == List_Noeuds[i])
                    {
                        degré += 1;
                    }
                }
                degrés[List_Noeuds[i]] = degré;
            }

            //tri des noeuds par ordre croissant
            tri_noeuds(List_Noeuds, degrés);
            
            //logique de Welsh Powell
            int couleur_courante = 0;
            Dictionary<Utilisateur, int> couleurs = new Dictionary<Utilisateur, int>();

            for(int i=0; i<List_Noeuds.Count;i++)
            {
                if (!couleurs.ContainsKey(List_Noeuds[i]))
                {
                    //Incrémenter la couleur courante
                    couleur_courante++;
                    //Colorier le premier sommet de avec la couleur courante
                    couleurs[List_Noeuds[i]] = couleur_courante;
                    List_Noeuds[i].Couleur = couleur_courante;

                    //colorier tous les voisins du noeud actuelle avec la même couleur
                    for (int w = 0; w< List_Noeuds.Count; w++ )
                    {
                        bool voisin = false;
                        if (!couleurs.ContainsKey(List_Noeuds[w]))
                        {
                            for (int j = 0; j < List_Arcs.Count; j++)
                            {
                                if (List_Arcs[j].Cuisinier == List_Noeuds[w] && List_Arcs[j].Client == List_Noeuds[i])
                                {
                                    voisin = true;
                                }
                                if (List_Arcs[j].Client == List_Noeuds[w] && List_Arcs[j].Cuisinier == List_Noeuds[i])
                                {
                                    voisin = true;
                                }
                                //si on trouve un noeud voisin à un autre ayant la couleur courante alors on ne dois pas le colorier
                                if (List_Arcs[j].Client == List_Noeuds[w] && couleurs.ContainsKey(List_Arcs[j].Cuisinier) && couleurs[List_Arcs[j].Cuisinier] == couleur_courante)
                                {
                                    voisin = true;
                                }
                                if (List_Arcs[j].Cuisinier == List_Noeuds[w] && couleurs.ContainsKey(List_Arcs[j].Client) && couleurs[List_Arcs[j].Client] == couleur_courante)
                                {
                                    voisin = true;
                                }

                            }
                            if (!voisin)
                            {
                                couleurs[List_Noeuds[w]] = couleur_courante;
                                List_Noeuds[w].Couleur = couleur_courante;

                            }
                        }      
                    }
                }
            }
        }

        public void tri_noeuds(List<Utilisateur> liste, Dictionary<Utilisateur, int> degrés)
        {

            for (int i = 0; i < liste.Count - 1; i++)
            {
                int indice = i;
                for (int j = i + 1; j < liste.Count; j++)
                {
                    if (degrés[liste[j]] > degrés[liste[indice]])
                    {
                        indice = j;
                    }
                }
                Utilisateur save = liste[i];
                liste[i] = liste[indice];
                liste[indice] = save;
            };
        }

    }
}

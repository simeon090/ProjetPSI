using LivInParis.Partie_Interface;
using LivInParis.Partie_Interface.user.client;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static LivInParis.Passer_commande;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace LivInParis
{

    public partial class OrderSumary : Form
    {
        public string id_client;
        MySqlConnection connexion;

        //prend une liste de mets sélectionnés
        public OrderSumary(List<Mets> metsSelectionnes, string id_client, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;

            foreach (var mets in metsSelectionnes)
            {
                _box_resume.Items.Add(mets);
            }

            CalculerTotal();
            this.id_client = id_client;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void _box_resume_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_box_resume.SelectedItem is Mets metsSelectionne)
            {
                string stationDepart = metsSelectionne.station_métro;
                string stationArrivee = Passer_commande.StationArrivee;

                GrapheMetro graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
                station_metro depart = graphe.TrouverStationAvecNom(stationDepart);
                station_metro arrivee = graphe.TrouverStationAvecNom(stationArrivee);

                Dictionary<station_metro, (string, int)> dijkstra = graphe.Dijkstra(depart, arrivee);
                station_metro[] liste_stations = graphe.ToListStations(dijkstra);
                string[] liste_metros = graphe.ToListMetrosUtilisés(dijkstra);
                int[] liste_minutes = graphe.ToListPoidsStations(dijkstra);

                double distance_km = station_metro.CalculDistance(depart, arrivee);
                int temps_trajet = 0;

                richTextBox1.Clear();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.SelectionFont = new Font("Arial", 16, FontStyle.Bold);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.AppendText("🚇 Trajet pour " + stationDepart + " 🚇\n\n");

                for (int i = 0; i < liste_stations.Length; i++)
                {
                    if (i == 0)
                    {
                        richTextBox1.SelectionColor = Color.Green;
                    }
                    else if (i == liste_stations.Length - 1)
                    {
                        richTextBox1.SelectionColor = Color.Red;
                        temps_trajet = liste_minutes[i];
                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Black;
                    }

                    richTextBox1.SelectionFont = new Font("Arial", 12);
                    richTextBox1.AppendText(liste_stations[i].Nom);

                    if (i < liste_stations.Length - 1)
                    {
                        int index = i + 1;
                        richTextBox1.SelectionColor = Color.Gray;
                        richTextBox1.AppendText(" ==> [ligne " + liste_metros[index] + "] (" + liste_minutes[index] + " min) ==> ");
                    }
                }

                richTextBox1.AppendText("\n\n");
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.AppendText("Temps de trajet : " + temps_trajet + " minutes\n Distance : " + distance_km + " km");
            }
        }


        private void CalculerTotal()
        {
            decimal totalPrix = 0;

            foreach (Mets item in _box_resume.Items)
            {
                totalPrix += item.prix;
            }

            label_prix.Text = $"{totalPrix:0.00} €";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Passer_commande commande = new Passer_commande(id_client, connexion);
            this.Hide();
            commande.ShowDialog();
        }

        private void Panier_Load(object sender, EventArgs e)
        {
            decimal totalPrix = 0;

            foreach (Mets item in _box_resume.Items)
            {
                totalPrix += item.prix;
            }

            label5.Text = "Prix totale : " + totalPrix + "€";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Bouton executer lorsqu'on passe commande, il doit crée une livraison, et une commande en BDD pour chaque mets
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Mets item in _box_resume.Items)
            {

                long id_commande = crée_commande(item);
                Console.WriteLine("===Commande Crée===");
                long id_sous_commande = crée_ligne_commande(item, id_commande);
                Console.WriteLine("===Ligne de commande Crée===");
                crée_livraison(item, id_sous_commande);
                Console.WriteLine("===Livraison Crée===");
                mis_a_jour_quantité(item.id_mets);
                Console.WriteLine("===Quantité mise à jour===");
            }

            MessageBox.Show("Bravo votre commande a été passé!");
            HomePageClient client_page = new HomePageClient(id_client, connexion);
            this.Hide();
            client_page.ShowDialog();
        }

        public long crée_commande(Mets met)
        {
            string query_commande = "INSERT INTO commande (Identifiant_client, telephone_cuisinier) " +
                        "VALUES (@IdentifiantClient, @TelephoneCuisinier)";
            MySqlCommand cmd = new MySqlCommand(query_commande, connexion);

            cmd = new MySqlCommand(query_commande, connexion);
            cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
            cmd.Parameters.AddWithValue("@TelephoneCuisinier", met.tel_cuisinier);
            cmd.ExecuteNonQuery();
            long numero_commande = cmd.LastInsertedId;
            return numero_commande;
        }

        public long crée_ligne_commande(Mets met, long id_commande)
        {
            string query_lignes_commandes = "INSERT INTO lignes_commandes " +
            "(numéro_commande, date_livraison, adresse_livraison, régime_alimentaire, prix, type, nom_du_mets, nationalité) " +
            "VALUES (@NumeroCommande, @DateLivraison, @AdresseLivraison, @RegimeAlimentaire, @Prix, @Type, @NomDuMets, @Nationalite)";

            MySqlCommand cmd = new MySqlCommand(query_lignes_commandes, connexion);
            cmd.Parameters.AddWithValue("@NumeroCommande", id_commande);
            cmd.Parameters.AddWithValue("@DateLivraison", DateTime.Today);
            cmd.Parameters.AddWithValue("@AdresseLivraison", Passer_commande.StationArrivee);
            cmd.Parameters.AddWithValue("@RegimeAlimentaire", met.régime_alimentaire);
            cmd.Parameters.AddWithValue("@Prix", met.prix);
            cmd.Parameters.AddWithValue("@Type", met.type);
            cmd.Parameters.AddWithValue("@NomDuMets", met.nom_mets);
            cmd.Parameters.AddWithValue("@Nationalite", met.nationalité);


            cmd.ExecuteNonQuery();
            long numero_sous_commande = cmd.LastInsertedId;
            return numero_sous_commande;
        }

        public void crée_livraison(Mets met, long id_sous_commande)
        {

            string query_livraison = "INSERT INTO livraison (id_livraison, arrivée, départ) " +
                     "VALUES (@IdLivraison, @Arrivee, @Depart)";
            MySqlCommand cmd = new MySqlCommand(query_livraison, connexion);
            cmd.Parameters.AddWithValue("@IdLivraison", "10001"+id_sous_commande);
            cmd.Parameters.AddWithValue("@Arrivee", Passer_commande.StationArrivee);
            cmd.Parameters.AddWithValue("@Depart", met.station_métro);
            cmd.ExecuteNonQuery();
        }

        public void mis_a_jour_quantité(string idMets)
        {
            string selectQuery = "SELECT quantité FROM mets WHERE id_mets = @IdMets";
            MySqlCommand Cmd = new MySqlCommand(selectQuery, connexion);
            Cmd.Parameters.AddWithValue("@IdMets", idMets);

            MySqlDataReader reader = Cmd.ExecuteReader();

            if (reader.Read())
            {
                int quantite = reader.GetInt32("quantité");
                Console.WriteLine("quantité actuelle : " + quantite);
                quantite -= 1;
                reader.Close();
                if (quantite <= 0)
                {
                    //On doit supprimer le mets si la quantité est inférieur ou égale à 0
                    string delete_query = "DELETE FROM mets WHERE id_mets = @IdMets";
                    MySqlCommand cmd2 = new MySqlCommand(delete_query, connexion);
                    cmd2.Parameters.AddWithValue("@IdMets", idMets);
                    cmd2.ExecuteNonQuery();
                    Console.WriteLine("===Mets supprimé===");
                }
                else
                {
                    //Sinon on met à jour la nouvelle quantité inférieur
                    string update_query = "UPDATE mets SET quantité = @Quantite WHERE id_mets = @IdMets";
                    MySqlCommand cmd3 = new MySqlCommand(update_query, connexion);
                    cmd3.Parameters.AddWithValue("@Quantite", quantite);
                    cmd3.Parameters.AddWithValue("@IdMets", idMets);
                    cmd3.ExecuteNonQuery();
                }
            } else
            {
                reader.Close();
            }
            
        }
    }
}
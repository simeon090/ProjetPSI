using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace LivInParis
{
    public partial class Passer_commande : Form
    {

        public static string StationArrivee
        { get; set; }
        public string id_client;
        public List<Mets> selectionMets;
        public MySqlConnection connexion;
        public static List<string> StationsDepart { get; set; } = new List<string>();


        public Passer_commande(string id_client, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.connexion = connexion;
            this.selectionMets = new List<Mets>();
            ChargerStations();
            ChargerMets();
            

        }

        private void ChargerStations()
        {
            List<string> stationsMetroParis = new List<string> { };
            string[] lignes_stations = File.ReadAllLines(App.chemin_csv_stations, Encoding.GetEncoding("Windows-1252"));
            for (int i = 1; i < lignes_stations.Length; i++)
            {
                string nom_station = lignes_stations[i].Split(";")[2];
                float longitude = float.Parse(lignes_stations[i].Split(';')[3].Replace(".", ","));
                float latitude = float.Parse(lignes_stations[i].Split(';')[4].Replace(".", ","));
                stationsMetroParis.Add(nom_station);
            }


            _choix_station_commande.Items.Clear();
            _choix_station_commande.Items.AddRange(stationsMetroParis.ToArray());
        }

        private void _choix_station_commande_SelectedIndexChanged(object sender, EventArgs e)
        {

            StationArrivee = _choix_station_commande.SelectedItem.ToString();

        }


        private void ChargerMets()
        {
                try
                {
                //requête pour station + tt les champs de mets
                string query = @"
                SELECT 
                    m.nom_mets, 
                    m.prix,
                    m.id_mets,
                    m.type,
                    m.nationalité,
                    m.régime_alimentaire,
                    m.telephone_cuisinier,
                    m.quantité,
                    c.station_métro
                FROM 
                    Mets m
                JOIN 
                    Cuisinier c ON m.telephone_cuisinier = c.telephone_cuisinier";


                MySqlCommand cmd = new MySqlCommand(query, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    selectionMets.Add(
                        new Mets(
                            reader.GetString("nom_mets"),
                            reader.GetDecimal("prix"),
                            reader.GetInt32("id_mets").ToString(),
                            reader.GetString("type"),
                            reader.GetString("nationalité"),
                            reader.GetString("régime_alimentaire"),
                            reader.GetInt32("telephone_cuisinier"),
                            reader.GetInt32("quantité"),
                            reader.GetString("station_métro")
                    )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            // ListBox
            box_commande.Items.Clear();
            if (selectionMets != null)
            {
                box_commande.Items.AddRange(selectionMets.ToArray());
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void box_commande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Passer_commande_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Mets> Mets_selectionné = new List<Mets>();

            StationsDepart.Clear();

            foreach (var item in box_commande.CheckedItems)
            {
                Mets met = (Mets)item;
                Mets_selectionné.Add(met);

                if (!StationsDepart.Contains(met.station_métro))
                {
                    StationsDepart.Add(met.station_métro);
                }
            }

            if (Mets_selectionné.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un mets.");
                return;
            }
            if (StationArrivee == null)
            {
                MessageBox.Show("Veuillez sélectionner votre station de livraison");
                return;
            }
            OrderSumary panier = new OrderSumary(Mets_selectionné, id_client, connexion);


            this.Hide();
            panier.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageUser utilisateur = new HomePageUser(id_client, connexion);
            this.Hide();
            utilisateur.ShowDialog();
        }
    }
}

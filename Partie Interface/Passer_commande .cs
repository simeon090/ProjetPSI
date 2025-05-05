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
        public static List<string> StationsDepart { get; set; } = new List<string>();


        public Passer_commande(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            ChargerStations();
            ChargerMets();
            this.id_client = id_client;
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
            List<Mets> metsList = new List<Mets>();

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
                try
                {
                    // requête pour station 
                    string query = @"
                    SELECT 
                        m.nom_mets, 
                        m.prix,
                        c.station_métro
                    FROM 
                        Mets m
                    JOIN 
                        Cuisinier c ON m.telephone_cuisinier = c.telephone_cuisinier";

                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        metsList.Add(new Mets(reader.GetString("nom_mets"), reader.GetDecimal("prix"), reader.GetString("station_métro")));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            // ListBox
            box_commande.Items.Clear();
            box_commande.Items.AddRange(metsList.ToArray());

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


        public class Mets
        {

            public string nom_mets { get; set; }

            public decimal prix { get; set; }

            public string station_métro { get; set; }
            public Mets(string nom_mets, decimal prix, string station_métro)
            {
                this.nom_mets = nom_mets;
                this.prix = prix;
                this.station_métro = station_métro;
            }
            public override string ToString()
            {

                return $"{nom_mets} - {prix} € - Station: {station_métro}";
            }

        }

        private void Passer_commande_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Mets> selectionMets = new List<Mets>();

            StationsDepart.Clear();

            foreach (var item in box_commande.CheckedItems)
            {
                Mets met = (Mets)item;
                selectionMets.Add(met);

                if (!StationsDepart.Contains(met.station_métro))
                {
                    StationsDepart.Add(met.station_métro);
                }
            }

            if (selectionMets.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un mets.");
                return;
            }
            if (StationArrivee == null)
            {
                MessageBox.Show("Veuillez sélectionner votre station de livraison");
                return;
            }
            Panier panier = new Panier(selectionMets, id_client);


            this.Hide();
            panier.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChoixMode utilisateur = new ChoixMode(id_client);
            this.Hide();
            utilisateur.ShowDialog();
        }
    }
}

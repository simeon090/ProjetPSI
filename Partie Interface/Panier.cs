using LivInParis.Partie_Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static LivInParis.Passer_commande;

namespace LivInParis
{

    public partial class Panier : Form
    {
        public string id_client;

        //prend une liste de mets sélectionnés
        public Panier(List<Mets> metsSelectionnes, string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;

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
            Passer_commande commande = new Passer_commande(id_client);
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

            label7.Text = $"{totalPrix:0.00} €";
        }
    }
}
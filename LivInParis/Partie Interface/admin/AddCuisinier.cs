using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivInParis.Partie_Interface
{
    public partial class AddCuisinier : Form
    {
        public string mdp_admin;
        public MySqlConnection connexion;
        public AddCuisinier(string mdp_admin, MySqlConnection connexion)
        {
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            InitializeComponent();
            ChargerStations();
            this.mdp_admin = mdp_admin;

        }

        /// <summary>
        /// Charge les stations de métros à partir de la base de donnée
        /// </summary>
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

        private void _confirmer_button_Click(object sender, EventArgs e)
        {
            string nom = this._nom_box.Text;
            string prenom = this._prenom_box.Text;
            string telephone = this._telephone_box.Text;
            string adresse = this._adresse_box.Text;
            string station_metro = _choix_station_commande.SelectedItem.ToString();
            string e_mail = this._mail_box.Text;

            try
            {
                string query = "INSERT INTO Cuisinier (nom_cuisinier, prenom_cuisinier, telephone_cuisinier, adresse_cuisinier, station_métro, mail_cuisinier) VALUES (@nom, @prenom, @telephone, @adresse, @station_metro, @e_mail)";

                MySqlCommand cmd = new MySqlCommand(query, connexion);

                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@telephone", telephone);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@station_metro", station_metro);
                cmd.Parameters.AddWithValue("@e_mail", e_mail);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cuisinier ajouté avec succès!");
                CuisinierAdmin cuisinierPage = new CuisinierAdmin(mdp_admin, connexion);
                this.Close();
                cuisinierPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de l'ajout du cuisinier: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CuisinierAdmin cuisinierPage = new CuisinierAdmin(mdp_admin, connexion);
            this.Close();
            cuisinierPage.Show();
        }

        private void _choix_station_commande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

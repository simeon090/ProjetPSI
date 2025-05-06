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
    public partial class CreateCuisinier : Form
    {
        MySqlConnection connexion;
        string id_particulier;
        Cuisinier nouveau_cuisinier;
        public CreateCuisinier(string id_particulier, Cuisinier nouveau_cuisinier)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            connexion = Base_Données.Instance.DB;
            this.id_particulier = id_particulier;
            this.nouveau_cuisinier = nouveau_cuisinier;
            ChargerStations();

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

        private void _text_box_connexion_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void CréationCuisinier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string station_metro_cuisinier = _choix_station_commande.SelectedItem.ToString();
            string query = @"
            INSERT INTO cuisinier 
            (telephone_cuisinier, prenom_cuisinier, nom_cuisinier, adresse_cuisinier, mail_cuisinier, station_métro)
            VALUES (@telephone, @prenom, @nom, @adresse, @e_mail, @station_metro);";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.Parameters.AddWithValue("@nom", nouveau_cuisinier.Nom);
            cmd.Parameters.AddWithValue("@prenom", nouveau_cuisinier.Prenom);
            cmd.Parameters.AddWithValue("@telephone", nouveau_cuisinier.telephone);
            cmd.Parameters.AddWithValue("@adresse", nouveau_cuisinier.Adresse);
            cmd.Parameters.AddWithValue("@station_metro", station_metro_cuisinier);
            cmd.Parameters.AddWithValue("@e_mail", nouveau_cuisinier.Mail);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Félicitations vous êtes maintenant cuisinier");
            ModeCuisinier cuisinier_page = new ModeCuisinier(id_particulier, nouveau_cuisinier.telephone);
            this.Hide();
            cuisinier_page.ShowDialog();
        }

        private void _choix_station_commande_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

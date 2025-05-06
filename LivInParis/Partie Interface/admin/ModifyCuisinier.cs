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
    public partial class ModifyCuisinier : Form
    {
        public MySqlConnection connexion;
        public string mdp_admin;
        public ModifyCuisinier(string mdp_admin, MySqlConnection connexion)
        {
            this.BackColor = Color.LightBlue;
            InitializeComponent();
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;
            LoadClientFrom();


        }


        void LoadClientFrom()
        {
            List<string> cuisinier = new List<string>();

            try
            {
                string query = "SELECT nom_cuisinier from cuisinier";

                MySqlCommand cmd = new MySqlCommand(query, connexion);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cuisinier.Add(reader.GetString("nom_cuisinier"));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des identifiants des clients: " + ex.Message);
            }
            this._modif_cuis_box.Items.AddRange(cuisinier.ToArray());
        }

        private void _modif_cuis_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_cuisinier = _modif_cuis_box.SelectedItem?.ToString();

            try
            {
                string query = "SELECT adresse_cuisinier, station_métro , mail_cuisinier from cuisinier where nom_cuisinier=@nom";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@nom", nom_cuisinier);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    this._modif_adresse_box.Text = reader.GetString("adresse_cuisinier");
                    this._mail_box.Text = reader.GetString("mail_cuisinier");
                    this._station_box.Text = reader.GetString("station_métro");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des identifiants des clients: " + ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            CuisinierAdmin cp = new CuisinierAdmin(mdp_admin, connexion);
            this.Close();
            cp.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom_cuisinier = this._modif_cuis_box.Text;
            string adresse_cuisinier = this._modif_adresse_box.Text;
            string station_métro = this._station_box.Text;
            string mail_cuisinier = this._mail_box.Text;

            try
            {
                // Requête SQL pour ajouter un met
                string query = "UPDATE cuisinier SET adresse_cuisinier=@adresse, station_métro=@station, mail_cuisinier=@mail WHERE nom_cuisinier=@nom";

                MySqlCommand cmd = new MySqlCommand(query, connexion);



                cmd.Parameters.AddWithValue("@nom", nom_cuisinier);
                cmd.Parameters.AddWithValue("@adresse", adresse_cuisinier);
                cmd.Parameters.AddWithValue("@station", station_métro);
                cmd.Parameters.AddWithValue("@mail", mail_cuisinier);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cuisinier modifié avec succès!");
                CuisinierAdmin cp = new CuisinierAdmin(mdp_admin, connexion);
                this.Close();
                cp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion du met: " + ex.Message);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

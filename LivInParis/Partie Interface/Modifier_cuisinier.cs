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
    public partial class Modifier_cuisinier : Form
    {
        public Modifier_cuisinier()
        {
            this.BackColor = Color.LightBlue;
            InitializeComponent();
            LoadClientFrom();
        }


        void LoadClientFrom()
        {
            List<string> cuisinier = new List<string>();

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
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
            }
            this._modif_cuis_box.Items.AddRange(cuisinier.ToArray());
        }
        private void _modif_cuis_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_cuisinier = _modif_cuis_box.SelectedItem?.ToString();

            using (MySqlConnection  connexion = Base_Données.Instance.DB)
            {
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

        }

        private void label1_Click(object sender, EventArgs e)
        {
            CuisinierPage cp = new CuisinierPage();
            this.Close();
            cp.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

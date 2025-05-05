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
    public partial class Ajouter_cuisinier : Form
    {
        public Ajouter_cuisinier()
        {
            this.BackColor = Color.LightBlue;
            InitializeComponent();
        }

        private void _confirmer_button_Click(object sender, EventArgs e)
        {
            string nom = this._nom_box.Text;
            string prenom = this._prenom_box.Text;
            string telephone = this._telephone_box.Text;
            string adresse = this._adresse_box.Text;
            string station_metro = this._metro_box.Text;
            string e_mail = this._mail_box.Text;

            using MySqlConnection connexion = Base_Données.Instance.DB;
            {

                try
                {
                    // Requête SQL pour ajouter un cuisinier
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du cuisinier : " + ex.Message);
                }

            }
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CuisinierPage cuisinierPage = new CuisinierPage();
            this.Close();
            cuisinierPage.Show(); 
        }
    }
}

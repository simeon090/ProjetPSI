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

namespace WinFormsApp1
{
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
            LoadClientFrom();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;"; // ⚠️ Modifier selon ton setup MySQL


        void LoadClientFrom()
        {
            List<string> clientIds = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouverture de la connexion
                    conn.Open();

                    // Requête SQL pour récupérer les identifiants des clients
                    string query = "SELECT Identifiant_client FROM Client";

                    // Création de la commande MySQL
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Exécution de la commande et récupération des résultats
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Parcours des résultats et ajout des identifiants à la liste
                    while (reader.Read())
                    {
                        clientIds.Add(reader.GetString("Identifiant_client"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des identifiants des clients: " + ex.Message);
                }
            }
            this._Idenifiant_old.Items.AddRange(clientIds.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old_id_client = this._Idenifiant_old.Text; // Ancien identifiant
            string new_id_client = this._text_box_modif_id.Text; // Nouvel identifiant
            string new_pwd_client = this._text_box_mdp.Text; // Nouveau mot de passe

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouverture de la connexion
                    conn.Open();

                    // Requête SQL de mise à jour
                    string query = "UPDATE Client SET Identifiant_client = @NewIdentifiantClient," +
                        " Mot_de_passe = @NewMotDePasse WHERE Identifiant_client = @OldIdentifiantClient";

                    // Création du command pour exécuter la requête
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Ajouter les paramètres pour éviter les injections SQL
                    cmd.Parameters.AddWithValue("@OldIdentifiantClient", old_id_client);
                    cmd.Parameters.AddWithValue("@NewIdentifiantClient", new_id_client);
                    cmd.Parameters.AddWithValue("@NewMotDePasse", new_pwd_client);

                    // Exécution de la commande
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client mis à jour avec succès!");
                    }
                    else
                    {
                        MessageBox.Show("Aucun client trouvé avec cet identifiant.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du client: " + ex.Message);
                }
            }

            Close();

         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}




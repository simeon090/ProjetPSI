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
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();

            LoadClientFrom();

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


            this._ListDesClients.Items.AddRange(clientIds.ToArray());//je rempli la combox

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string identifiantClient = this._ListDesClients.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouverture de la connexion
                    conn.Open();

                    // Requête SQL pour supprimer un client par son identifiant
                    string query = "DELETE FROM Client WHERE Identifiant_client = @IdentifiantClient";

                    // Création du command pour exécuter la requête
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Ajouter le paramètre pour éviter les injections SQL
                    cmd.Parameters.AddWithValue("@IdentifiantClient", identifiantClient);

                    // Exécution de la commande
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Vérification si un client a été supprimé
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Le client avec l'identifiant {identifiantClient} a été supprimé.");
                    }
                    else
                    {
                        MessageBox.Show($"Aucun client trouvé avec l'identifiant {identifiantClient}.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du client: " + ex.Message);
                }
            }

            this.Close();
        }

        private void _ListDesClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

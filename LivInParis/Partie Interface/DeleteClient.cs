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

namespace LivInParis
{
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();

            LoadClientFrom();

        }

        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;";


        void LoadClientFrom()
        {
            List<string> clientIds = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Identifiant_client FROM Client";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

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
                    conn.Open();

                    string enlever_ctrt = "SET foreign_key_checks=0";
                    MySqlCommand enlever = new MySqlCommand (enlever_ctrt, conn);
                    enlever.ExecuteNonQuery();


                    string query = "DELETE FROM Client WHERE Identifiant_client = @IdentifiantClient";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IdentifiantClient", identifiantClient);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    string remettre_ctrt = "SET foreign_key_checks=1";

                    MySqlCommand remettre = new MySqlCommand (remettre_ctrt, conn);
                    remettre.ExecuteNonQuery ();

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

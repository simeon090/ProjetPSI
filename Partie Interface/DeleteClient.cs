using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LivInParis
{
    public partial class DeleteClient : Form
    {
        public MySqlConnection connexion;

        public DeleteClient()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;

            connexion = Base_Données.Instance.DB;

            LoadClientFrom();
        }

        void LoadClientFrom()
        {
            List<string> clientIds = new List<string>();

            try
            {
                string query = "SELECT Identifiant_client FROM Client";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
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

            _ListDesClients.Items.Clear();
            _ListDesClients.Items.AddRange(clientIds.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identifiantClient = _ListDesClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(identifiantClient))
            {
                MessageBox.Show("Veuillez sélectionner un client.");
                return;
            }

            try
            {
                string enlever_ctrt = "SET foreign_key_checks=0";
                new MySqlCommand(enlever_ctrt, connexion).ExecuteNonQuery();

                string query = "DELETE FROM Client WHERE Identifiant_client = @IdentifiantClient";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@IdentifiantClient", identifiantClient);
                cmd.ExecuteNonQuery();

                string remettre_ctrt = "SET foreign_key_checks=1";
                new MySqlCommand(remettre_ctrt, connexion).ExecuteNonQuery();

                MessageBox.Show("Client supprimé avec succès !");
                LoadClientFrom(); // Met à jour la liste
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du client: " + ex.Message);
            }
        }

        private void DeleteClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connexion != null && connexion.State == System.Data.ConnectionState.Open)
            {
                connexion.Close();
            }
        }

        private void _ListDesClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            this.Hide();
            clientPage.ShowDialog();
        }
    }
}

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
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=MOT_DE_PASSE";


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
            this._Idenifiant_old.Items.AddRange(clientIds.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old_id_client = this._Idenifiant_old.Text;
            string new_id_client = this._text_box_modif_id.Text;
            string new_pwd_client = this._text_box_mdp.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Client SET Identifiant_client = @NewIdentifiantClient," +
                        " Mot_de_passe = @NewMotDePasse WHERE Identifiant_client = @OldIdentifiantClient";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@OldIdentifiantClient", old_id_client);
                    cmd.Parameters.AddWithValue("@NewIdentifiantClient", new_id_client);
                    cmd.Parameters.AddWithValue("@NewMotDePasse", new_pwd_client);

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




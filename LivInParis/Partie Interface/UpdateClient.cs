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
            this.BackColor = Color.LightBlue;
            LoadClientFrom();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void LoadClientFrom()
        {
            List<string> clientIds = new List<string>();

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
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

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
                try
                {

                    string enlever_ctrt = "SET foreign_key_checks = 0;";
                    MySqlCommand disableFKCommand = new MySqlCommand(enlever_ctrt, connexion);
                    disableFKCommand.ExecuteNonQuery();

                    string pre_query = "Update Particulier Set Identifiant_client = @NewIdentifiantClient where Identifiant_client=@OldIdentifiantClient";
                    MySqlCommand cmd2 = new MySqlCommand(pre_query, connexion);
                    cmd2.Parameters.AddWithValue("@OldIdentifiantClient", old_id_client);
                    cmd2.Parameters.AddWithValue("@NewIdentifiantClient", new_id_client);
                    cmd2.ExecuteNonQuery();


                    string query = "UPDATE Client SET Identifiant_client = @NewIdentifiantClient," +
                                   " Mot_de_passe = @NewMotDePasse WHERE Identifiant_client = @OldIdentifiantClient";
                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    cmd.Parameters.AddWithValue("@OldIdentifiantClient", old_id_client);
                    cmd.Parameters.AddWithValue("@NewIdentifiantClient", new_id_client);
                    cmd.Parameters.AddWithValue("@NewMotDePasse", new_pwd_client);

                    int rowsAffected = cmd.ExecuteNonQuery();


                    string remettre_ctrt = "SET foreign_key_checks = 1;";

                    MySqlCommand remettre_crtCommand = new MySqlCommand(remettre_ctrt, connexion);
                    remettre_crtCommand.ExecuteNonQuery();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}




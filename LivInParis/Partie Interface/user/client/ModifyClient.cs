using LivInParis.Partie_Interface.user.client;
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
    public partial class ModifyClient : Form
    {
        MySqlConnection connexion;
        public string id_particulier;
        public bool is_admin;
        public string mdp_admin;
        public ModifyClient(string id_particulier, bool is_admin, MySqlConnection connexion, string mdp_admin = "")
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_particulier = id_particulier;
            this.connexion = connexion;
            this.is_admin = is_admin;
            this.mdp_admin = mdp_admin;
            LoadClient();
        }


        void LoadClient()
        {
            try
            {
                string query = @"SELECT c.Mot_de_passe, p.nom_particulier, p.prenom_particulier, 
                p.adresse_particulier, p.numéro_tel_particulier, p.mail_particulier 
                FROM client c 
                JOIN particulier p ON c.Identifiant_client = p.Identifiant_client 
                WHERE c.Identifiant_client = @id_client";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@id_client", id_particulier);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine("trouvé");
                    _text_box_mdp.Text = reader.GetString("Mot_de_passe");
                    textBox1.Text = reader.GetString("nom_particulier");
                    textBox2.Text = reader.GetString("prenom_particulier");
                    textBox4.Text = reader.GetString("adresse_particulier");
                    textBox3.Text = reader.GetDecimal("numéro_tel_particulier").ToString();
                    textBox5.Text = reader.GetString("mail_particulier");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (is_admin)
            {
                ClientAdmin clientPage = new ClientAdmin(mdp_admin, connexion);
                this.Hide();
                clientPage.ShowDialog();
            } else
            {
                HomePageClient client_page = new HomePageClient(id_particulier, connexion);
                this.Hide();
                client_page.ShowDialog();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string motDePasse = _text_box_mdp.Text;
            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            string adresse = textBox4.Text;
            string email = textBox5.Text;
            if (!email.Contains("@"))
            {
                MessageBox.Show("Adresse email pas valide");
                return;
            }
            int telephone;
            if (!int.TryParse(this.textBox3.Text, out telephone))
            {
                MessageBox.Show("Téléphone pas valide.");
                return;
            }
            try
            {
                //on met à jour à la fois le client et le particulier correspondant
                string query_client = "UPDATE client SET Mot_de_passe = @motDePasse WHERE Identifiant_client = @identifiant";
                string query_particulier = @"UPDATE particulier 
                SET nom_particulier = @nom, prenom_particulier = @prenom, 
                adresse_particulier = @adresse, numéro_tel_particulier = @numeroTel, 
                mail_particulier = @email 
                WHERE Identifiant_client = @identifiant";

                MySqlCommand cmd = new MySqlCommand(query_client, connexion);
                cmd.Parameters.AddWithValue("@motDePasse", motDePasse);
                cmd.Parameters.AddWithValue("@identifiant", id_particulier);
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand(query_particulier, connexion);
                cmd2.Parameters.AddWithValue("@nom", nom);
                cmd2.Parameters.AddWithValue("@prenom", prenom);
                cmd2.Parameters.AddWithValue("@adresse", adresse);
                cmd2.Parameters.AddWithValue("@numeroTel", Convert.ToDecimal(telephone));
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@identifiant", id_particulier);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Client mis à jour avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }
    }
}




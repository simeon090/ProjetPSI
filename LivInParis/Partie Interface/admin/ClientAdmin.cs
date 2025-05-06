using LivInParis.Partie_Interface;
using LivInParis.Partie_Interface.classes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LivInParis.CuisinierAdmin;

namespace LivInParis
{
    public partial class ClientAdmin : Form
    {
        public MySqlConnection connexion;
        public string mdp_admin;
        public ClientAdmin(string mdp_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;
            LoadData();
        }

        void LoadData()
        {
            List<Particulier> particuliers = new List<Particulier>();
            {
                try
                {
                    string query = "SELECT * FROM Particulier";
                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        particuliers.Add(new Particulier(
                            reader.GetDecimal("numéro_tel_particulier"),
                            reader.GetString("nom_particulier"),
                            reader.GetString("prenom_particulier"),
                            reader.GetString("adresse_particulier"),
                            reader.GetString("Identifiant_client"),
                            reader.GetString("mail_particulier")
                        ));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreur : " + ex.Message);
                }
            }
            bindingSource1.DataSource = particuliers;
            dataGridView1.DataSource = bindingSource1;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddNewClient ajouter_client = new AddNewClient(mdp_admin, connexion);
            this.Close();
            ajouter_client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                string id_client_interface = null;

                //on verifie si item est un particulier
                if (dataGridView1.CurrentRow.DataBoundItem is Particulier p)
                {
                    id_client_interface = p.Identifiant_client;
                }
                //on verifie si item est un client achats
                else if (dataGridView1.CurrentRow.DataBoundItem is ClientAchats c)
                {
                    id_client_interface = c.IdentifiantClient;
                }

                if (id_client_interface != null)
                {
                    SupprimerClient(id_client_interface);
                }
                else
                {
                    MessageBox.Show("Aucun client sélectionnée");
                }
            }
        }

        private void SupprimerClient(string id_client)
        {
            try
            {
                // on enleve la contrainte des clés étrangère pour eviter certaines erreurs
                string enlever_ctrt = "SET foreign_key_checks=0";
                new MySqlCommand(enlever_ctrt, connexion).ExecuteNonQuery();

                string query_client = "DELETE FROM Client WHERE Identifiant_client = @IdentifiantClient";
                MySqlCommand cmd = new MySqlCommand(query_client, connexion);
                cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                cmd.ExecuteNonQuery();

                string query_particulier = "DELETE FROM Particulier WHERE Identifiant_client = @IdentifiantClient";
                cmd = new MySqlCommand(query_particulier, connexion);
                cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                cmd.ExecuteNonQuery();

                // on remet la contrainte
                string remettre_ctrt = "SET foreign_key_checks=1";
                new MySqlCommand(remettre_ctrt, connexion).ExecuteNonQuery();

                MessageBox.Show("Client supprimé avec succès !");
                // on met à jour la data
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du client: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Particulier> particuliers = new List<Particulier>();

            try
            {
                string query = "SELECT * FROM Particulier ORDER BY adresse_particulier";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    particuliers.Add(new Particulier(
                        reader.GetDecimal("numéro_tel_particulier"),
                        reader.GetString("nom_particulier"),
                        reader.GetString("prenom_particulier"),
                        reader.GetString("adresse_particulier"),
                        reader.GetString("Identifiant_client"),
                        reader.GetString("mail_particulier")
                    ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }
            bindingSource1.DataSource = particuliers;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Particulier> particuliers = new List<Particulier>();

            try
            {
                string query = "SELECT * FROM Particulier ORDER BY nom_particulier";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    particuliers.Add(new Particulier(
                            reader.GetDecimal("numéro_tel_particulier"),
                            reader.GetString("nom_particulier"),
                            reader.GetString("prenom_particulier"),
                            reader.GetString("adresse_particulier"),
                            reader.GetString("Identifiant_client"),
                            reader.GetString("mail_particulier")

                        ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            bindingSource1.DataSource = particuliers;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<ClientAchats> clients_achats = new List<ClientAchats>();

            try
            {
                string query = @"
                    SELECT 
                        P.Identifiant_client, 
                        P.nom_particulier, 
                        P.prenom_particulier, 
                        SUM(LC.prix) AS montant_total_achats
                    FROM Commande CM
                    JOIN Lignes_Commandes LC ON CM.numéro_commande = LC.numéro_commande
                    JOIN Particulier P ON CM.Identifiant_client = P.Identifiant_client
                    GROUP BY P.Identifiant_client, P.nom_particulier, P.prenom_particulier
                    ORDER BY montant_total_achats DESC;
                    ";

                MySqlCommand cmd = new MySqlCommand(query, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clients_achats.Add(new ClientAchats(
                        reader.GetString("Identifiant_client"),
                        reader.GetString("nom_particulier"),
                        reader.GetString("prenom_particulier"),
                        reader.GetDecimal("montant_total_achats")
                    ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
            bindingSource1.DataSource = clients_achats;
            dataGridView1.DataSource = bindingSource1;



        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
               string id_client_interface = null;

                //on verifie si item est un particulier
                if (dataGridView1.CurrentRow.DataBoundItem is Particulier p)
                {
                    id_client_interface = p.Identifiant_client;
                }
                //on verifie si item est un client achats
                else if (dataGridView1.CurrentRow.DataBoundItem is ClientAchats c)
                {
                    id_client_interface = c.IdentifiantClient;
                }

                if (id_client_interface != null)
                {
                    UserOrders page_commandes = new UserOrders(id_client_interface, true, connexion);
                    this.Close();
                    page_commandes.Show();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Aucun client sélectionnée!");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageAdmin clientPage = new HomePageAdmin(mdp_admin, connexion);
            this.Close();
            clientPage.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id_particulier = null;

                //on verifie si item est un particulier
                if (dataGridView1.CurrentRow.DataBoundItem is Particulier p)
                {
                    id_particulier = p.Identifiant_client;
                }
                //on verifie si item est un client achats
                else if (dataGridView1.CurrentRow.DataBoundItem is ClientAchats c)
                {
                    id_particulier = c.IdentifiantClient;
                }

                if (id_particulier!=null)
                {
                    ModifyClient client = new ModifyClient(id_particulier, true, connexion, mdp_admin);
                    this.Hide();
                    client.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Aucun client sélectionnée!");
                }
            }
        }
    }
}

using LivInParis.Partie_Interface;
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
        public ClientAdmin()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = Base_Données.Instance.DB;
            LoadData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }


            bindingSource1.DataSource = particuliers;
            dataGridView1.DataSource = bindingSource1;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddNewClient form_tu = new AddNewClient();
            this.Close();
            form_tu.Show();

            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                var item = dataGridView1.CurrentRow.DataBoundItem;

                string id_client_interface = null;

                //on verifie si item est un particulier
                if (item is Particulier p)
                {
                    id_client_interface = p.Identifiant_client;
                }
                //on verifie si item est un client achats
                else if (item is ClientAchats c)
                {
                    id_client_interface = c.IdentifiantClient;
                }

                if (!string.IsNullOrEmpty(id_client_interface))
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

                string remettre_ctrt = "SET foreign_key_checks=1";
                new MySqlCommand(remettre_ctrt, connexion).ExecuteNonQuery();

                MessageBox.Show("Client supprimé avec succès !");
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
                string query = "SELECT * FROM Particulier ORDER BY adresse_particulier"; // Trie par adresse
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
            List<ClientAchats> clientsAchats = new List<ClientAchats>();

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
                    clientsAchats.Add(new ClientAchats(
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
                MessageBox.Show("Erreur : " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
            bindingSource1.DataSource = clientsAchats;
            dataGridView1.DataSource = bindingSource1;



        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var item = dataGridView1.CurrentRow.DataBoundItem;

                string id_client_interface = null;

                //on verifie si item est un particulier
                if (item is Particulier p)
                {
                    id_client_interface = p.Identifiant_client;
                }
                //on verifie si item est un client achats
                else if (item is ClientAchats c)
                {
                    id_client_interface = c.IdentifiantClient;
                }

                if (!string.IsNullOrEmpty(id_client_interface))
                {
                    UserOrders form = new UserOrders(id_client_interface, true);
                    this.Close();
                    form.Show();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Aucun client sélectionnée");
                }
            }
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageAdmin clientPage = new HomePageAdmin();
            this.Close();
            clientPage.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var item = dataGridView1.CurrentRow.DataBoundItem;

                string id_particulier = null;

                //on verifie si item est un particulier
                if (item is Particulier p)
                {
                    id_particulier = p.Identifiant_client;
                }
                //on verifie si item est un client achats
                else if (item is ClientAchats c)
                {
                    id_particulier = c.IdentifiantClient;
                }

                if (id_particulier!=null)
                {
                    ModifyClient client = new ModifyClient(id_particulier, true);
                    this.Hide();
                    client.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Aucun client sélectionnée");
                }
            }
        }
    }

    public class Particulier
    {
        public decimal numéro_tel_particulier { get; set; }
        public string nom_particulier { get; set; }
        public string prenom_particulier { get; set; }
        public string adresse_particulier { get; set; }
        public string Identifiant_client { get; set; }

        public string mail_client { get; set; }

        
        public Particulier(decimal numéro_tel_particulier, string nom_particulier, string prenom_particulier, string adresse_particulier, string Identifiant_client, string mail_client)
        {
            this.numéro_tel_particulier = numéro_tel_particulier;
            this.nom_particulier = nom_particulier;
            this.prenom_particulier = prenom_particulier;
            this.adresse_particulier = adresse_particulier;
            this.Identifiant_client = Identifiant_client;
            this.mail_client = mail_client;

        }
    }

    public class ClientAchats
    {
        public string IdentifiantClient 
        { get; set; }
        public string nom_particulier 
        { get; set; }

        public string prenom_particulier 
        { get; set; }

        public decimal MontantTotalAchats 
        { get; set; }

        public ClientAchats(string identifiantClient, string nom_particulier, string prenom_particulier, decimal montantTotalAchats)
        {
            this.IdentifiantClient = identifiantClient;
            this.nom_particulier = nom_particulier;
            this.prenom_particulier = prenom_particulier;
            this. MontantTotalAchats = montantTotalAchats;
        }
    }


}

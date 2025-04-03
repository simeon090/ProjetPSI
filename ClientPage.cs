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
using static WinFormsApp1.CuisinierPage;

namespace WinFormsApp1
{
    public partial class ClientPage : Form
    {
        public ClientPage()
        {
            InitializeComponent();

            LoadData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;"; // ⚠️ Modifier selon ton setup MySQL


        void LoadData()
        {
            List<Particulier> particuliers = new List<Particulier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Particulier";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        particuliers.Add(new Particulier(
                            reader.GetDecimal("numéro_tel_particulier"),
                            reader.GetString("nom_particulier"),
                            reader.GetString("prenom_particulier"),
                            reader.GetString("adresse_particulier"),
                            reader.GetString("Identifiant_client")
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


        private void button4_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient = new UpdateClient();
            updateClient.ShowDialog();

            LoadData();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddNewClient form_tu = new AddNewClient();

            form_tu.ShowDialog();

            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteClient deleteClient = new DeleteClient();
            deleteClient.ShowDialog();

            LoadData();
        }

        //private void button4_Click(object sender, EventArgs e)
        //{ 
        //    string id_modif = 
        //    string password_modif = 
        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            conn.Open();
        //            string query = "Update * FROM Client";
        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            MySqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                clients.Add(new Client(
        //                    reader.GetString("Identifiant_client"),
        //                    reader.GetString("Mot_de_passe")

        //                ));
        //            }

        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erreur : " + ex.Message);
        //        }
        //    }

        //    bindingSource1.DataSource = clients;
        //    dataGridView1.DataSource = bindingSource1;

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Particulier> particuliers = new List<Particulier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Particulier ORDER BY adresse_particulier"; // Trie par adresse
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        particuliers.Add(new Particulier(
                            reader.GetDecimal("numéro_tel_particulier"),
                            reader.GetString("nom_particulier"),
                            reader.GetString("prenom_particulier"),
                            reader.GetString("adresse_particulier"),
                            reader.GetString("Identifiant_client")
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

        private void button5_Click(object sender, EventArgs e)
        {
            List<Particulier> particuliers= new List<Particulier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Particulier ORDER BY nom_particulier";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        particuliers.Add(new Particulier(
                             reader.GetDecimal("numéro_tel_particulier"),
                             reader.GetString("nom_particulier"),
                             reader.GetString("prenom_particulier"),
                             reader.GetString("adresse_particulier"),
                             reader.GetString("Identifiant_client")
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

        private void button6_Click(object sender, EventArgs e)
        {
            List<ClientAchats> clientsAchats = new List<ClientAchats>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
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

                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
            }

            // Mise à jour du DataGridView
            bindingSource1.DataSource = clientsAchats;
            dataGridView1.DataSource = bindingSource1;



        }
    }
    public class Particulier
    {
        public decimal numéro_tel_particulier { get; set; }
        public string nom_particulier { get; set; }
        public string prenom_particulier { get; set; }
        public string adresse_particulier { get; set; }
        public string Identifiant_client { get; set; }

        
        public Particulier(decimal numéro_tel_particulier, string nom_particulier, string prenom_particulier, string adresse_particulier, string Identifiant_client)
        {
            this.numéro_tel_particulier = numéro_tel_particulier;
            this.nom_particulier = nom_particulier;
            this.prenom_particulier = prenom_particulier;
            this.adresse_particulier = adresse_particulier;
            this.Identifiant_client = Identifiant_client;
        }
    }


    public class Client
    {
        public string IdentifiantClient { get; set; }
        public string MotDePasse { get; set; }

       

        // Constructeur avec paramètres
        public Client(string identifiantClient, string motDePasse)
        {
            IdentifiantClient = identifiantClient;
            MotDePasse = motDePasse;
        }

        // Méthode ToString pour afficher l'objet sous une forme lisible
        public override string ToString()
        {
            return $"Identifiant: {IdentifiantClient}, Mot de passe: {MotDePasse}";
        }
    }

    public class ClientAchats
    {
        public string IdentifiantClient { get; set; }
        public string nom_particulier { get; set; }

        public string prenom_particulier { get; set; }

        public decimal MontantTotalAchats { get; set; }

        public ClientAchats(string identifiantClient, string nom_particulier, string prenom_particulier, decimal montantTotalAchats)
        {
            this.IdentifiantClient = identifiantClient;
            this.nom_particulier = nom_particulier;
            this.prenom_particulier = prenom_particulier;
            this. MontantTotalAchats = montantTotalAchats;
        }
    }


}

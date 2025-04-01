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
            List<Client> clients = new List<Client>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Client";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clients.Add(new Client(
                            reader.GetString("Identifiant_client"),
                            reader.GetString("Mot_de_passe")

                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            bindingSource1.DataSource = clients;
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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Cuisinier> client = new List<Cuisinier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Cuisinier ORDER BY Identifiant_client";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        client.Add(new Cuisinier(
                            reader.GetDecimal("telephone_cuisinier"),
                            reader.GetString("prenom_cuisinier"),
                            reader.GetString("nom_cuisinier"),
                            reader.GetString("adresse_cuisinier"),
                            reader.GetString("mail_cuisinier")
                        ));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            bindingSource1.DataSource = cuisiniers;
            dataGridView1.DataSource = bindingSource1;
        }
    }

    public class Client
    {
        public string IdentifiantClient { get; set; }
        public string MotDePasse { get; set; }

        // Constructeur par défaut
        public Client() { }

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
}

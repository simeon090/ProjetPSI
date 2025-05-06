using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LivInParis.CuisinierAdmin;

namespace LivInParis.Partie_Interface
{
    public partial class YourDishes : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        public string id_particulier;
        public int tel_cuisinier;
        public MySqlConnection connexion;
        public YourDishes(string id_particulier, int tel_cuisinier, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.tel_cuisinier = tel_cuisinier;
            this.id_particulier = id_particulier;
            this.connexion = connexion;
            LoadDishes();
            LoadClients();
        }

        void LoadDishes()
        {

            List<Mets> Mets = new List<Mets>();

            try
            {
                string query = "SELECT * from Mets WHERE telephone_cuisinier=@telephone_cuisinier";

                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@telephone_cuisinier", tel_cuisinier);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Mets.Add(new Mets(
                        reader.GetString("nom_mets"),
                        reader.GetDecimal("prix"),
                        reader.GetInt32("id_mets").ToString(),
                        reader.GetString("type"),
                        reader.GetString("nationalité"),
                        reader.GetString("régime_alimentaire"),
                        Convert.ToInt32(reader.GetDecimal("telephone_cuisinier")),
                        reader.GetInt32("quantité"),
                        ""

                    ));

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

            bindingSource1.DataSource = Mets;
            dataGridView1.DataSource = bindingSource1;
        }


        void LoadClients()
        {
            List<Client> clients = new List<Client>();

                string query = @"
                SELECT c.Identifiant_client, p.nom_particulier, p.prenom_particulier, p.adresse_particulier
                FROM commande c
                JOIN client cl ON c.Identifiant_client = cl.Identifiant_client
                JOIN particulier p ON p.Identifiant_client = cl.Identifiant_client
                WHERE c.telephone_cuisinier = @telephone_cuisinier;
                ";


                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@telephone_cuisinier", tel_cuisinier);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nom = reader.GetString("nom_particulier");
                    string prenom = reader.GetString("prenom_particulier");
                    string adresse = reader.GetString("adresse_particulier");
                    string id_client = reader.GetString("Identifiant_client");

                    clients.Add(
                        new Client(nom, prenom, "Particulier", id_client, "Confidentiel")
                    );
                }
            reader.Close();
  

            bindingSource2.DataSource = clients;
            dataGridView2.DataSource = bindingSource2;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_particulier, tel_cuisinier, connexion);
            this.Hide();
            modeCuisinier.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

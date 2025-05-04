using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LivInParis.Partie_Interface
{
    public partial class InterfaceCommande : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public string id_client;
        public InterfaceCommande(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            dataGridView1.AutoGenerateColumns = true;
            this.id_client = id_client;
            label3.Text = "Commandes de l'utilisateur : " + this.id_client;
            LoadData();
        }

        void LoadData()
        {
            List<Commande> commandes = new List<Commande>();

            MySqlConnection connexion = Base_Données.Instance.DB;

            if (connexion.State != ConnectionState.Open)
                connexion.Open();

            string query = @"
            SELECT c.numéro_commande, c.telephone_cuisinier, cu.nom_cuisinier, cu.prenom_cuisinier
            FROM Commande c
            JOIN Cuisinier cu ON c.telephone_cuisinier = cu.telephone_cuisinier
            WHERE Identifiant_client = @Identifiant_client
            ";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.Parameters.AddWithValue("@Identifiant_client", this.id_client);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    commandes.Add(new Commande(
                        Convert.ToInt32(reader.GetDecimal("telephone_cuisinier")),
                        Convert.ToInt32(reader.GetDecimal("numéro_commande")),
                        reader.GetString("nom_cuisinier"),
                        reader.GetString("prenom_cuisinier")
                    ));
                }
            }
            bindingSource1.DataSource = commandes;
            dataGridView1.DataSource = bindingSource1;
        }

        private void InterfaceCommande_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            this.Close();
            clientPage.ShowDialog();
        }
    }
}

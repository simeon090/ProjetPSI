using LivInParis.Partie_Interface.classes;
using LivInParis.Partie_Interface.user.client;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace LivInParis.Partie_Interface
{
    public partial class UserOrders : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public string id_client;
        public bool is_admin;
        public string mdp_admin;
        public MySqlConnection connexion;
        public UserOrders(string id_client, bool is_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            dataGridView1.AutoGenerateColumns = true;
            this.id_client = id_client;
            label3.Text = "Commandes de l'utilisateur : " + this.id_client;
            this.is_admin = is_admin;
            this.connexion = connexion;
            LoadData();
        }

        void LoadData()
        {
            List<SousCommande> lignes_commandes = new List<SousCommande>();

            string query = @"
            SELECT lc.nom_du_mets, lc.nationalité, lc.prix, lc.régime_alimentaire, lc.date_livraison, c.numéro_commande, c.telephone_cuisinier, cu.nom_cuisinier, cu.prenom_cuisinier
            FROM Commande c
            JOIN Cuisinier cu ON c.telephone_cuisinier = cu.telephone_cuisinier
            JOIN lignes_commandes lc ON c.numéro_commande = lc.numéro_commande
            WHERE Identifiant_client = @Identifiant_client
            ";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.Parameters.AddWithValue("@Identifiant_client", this.id_client);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lignes_commandes.Add(
                    new SousCommande(
                        reader.GetInt32("numéro_commande"),
                        reader.GetInt32("telephone_cuisinier"),
                        reader.GetString("prenom_cuisinier"),
                        reader.GetString("nom_cuisinier"),
                        reader.GetString("nom_du_mets"),
                        reader.GetString("nationalité"),
                        reader.GetDecimal("prix"),
                        reader.GetString("régime_alimentaire")
                    )
                );
            }
            reader.Close();
            bindingSource1.DataSource = lignes_commandes;
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
            if (is_admin)
            {
                ClientAdmin clientPage = new ClientAdmin(mdp_admin, connexion);
                this.Close();
                clientPage.ShowDialog();
            }
            else
            {
                HomePageClient client_page = new HomePageClient(id_client, connexion);
                this.Hide();
                client_page.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

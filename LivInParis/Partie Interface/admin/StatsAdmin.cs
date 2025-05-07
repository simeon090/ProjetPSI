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


namespace LivInParis.Partie_Interface.admin
{
    public partial class StatsAdmin : Form
    {
        private string mdp_admin;


        private MySqlConnection connexion;

        public StatsAdmin(string mdp_admin, MySqlConnection connexion)
        {
            this.BackColor = Color.LightBlue;

            InitializeComponent();
            this.mdp_admin = mdp_admin;
            this.connexion = connexion;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string requête = @"
                      SELECT c.telephone_cuisinier, cu.nom_cuisinier, cu.prenom_cuisinier, COUNT(*) AS nombre_livraisons
                      FROM commande c
                      JOIN cuisinier cu ON c.telephone_cuisinier = cu.telephone_cuisinier
                      GROUP BY c.telephone_cuisinier, cu.nom_cuisinier, cu.prenom_cuisinier
                      ORDER BY nombre_livraisons DESC;";
                MySqlCommand cmd = new MySqlCommand(requête, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable donnée_pour_data_source = new DataTable();

                donnée_pour_data_source.Load(reader);

                reader.Close();

                dataGridView1.DataSource = donnée_pour_data_source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                string requête_2 = @"SELECT AVG(total_commande) AS panier_moyen
                FROM (
                SELECT co.numéro_commande,SUM(lc.prix) AS total_commande
                FROM commande co
                JOIN lignes_commandes lc ON co.numéro_commande = lc.numéro_commande
                GROUP BY co.numéro_commande) AS commandes_totales;";


                MySqlCommand cmd = new MySqlCommand(requête_2, connexion);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable donnée_pour_data_source = new DataTable();
                donnée_pour_data_source.Load(reader);
                reader.Close();

                dataGridView1.DataSource = donnée_pour_data_source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string requête_3 = "SELECT AVG(prix) AS moyenne_des_prix FROM lignes_commandes;";
                MySqlCommand cmd = new MySqlCommand(requête_3, connexion);

                MySqlDataReader reader = cmd.ExecuteReader();


                DataTable donnée_pour_data_source = new DataTable();
                donnée_pour_data_source.Load(reader);
                reader.Close();

                dataGridView1.DataSource = donnée_pour_data_source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                string requête_3 = @"SELECT Identifiant_client, COUNT(*) AS nb_commandes
                FROM commande
                GROUP BY Identifiant_client
                HAVING COUNT(*) >= ALL (SELECT COUNT(*)
                FROM commande
                GROUP BY Identifiant_client);
                ";

                MySqlCommand cmd = new MySqlCommand(requête_3, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable donnée_pour_data_source = new DataTable();
                donnée_pour_data_source.Load(reader);
                reader.Close();

                dataGridView1.DataSource = donnée_pour_data_source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string requête_4 = @"SELECT c.Identifiant_client, SUM(lc.prix) AS total_depenses
                FROM commande c
                JOIN lignes_commandes lc ON c.numéro_commande = lc.numéro_commande
                GROUP BY c.Identifiant_client
                ORDER BY total_depenses DESC;";
                

                MySqlCommand cmd = new MySqlCommand(requête_4, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable donnée_pour_data_source = new DataTable();

                donnée_pour_data_source.Load(reader);
                reader.Close();

                dataGridView1.DataSource = donnée_pour_data_source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageAdmin clientPage = new HomePageAdmin(mdp_admin, connexion);
            this.Close();
            clientPage.Show();
        }
    }
}
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

namespace LivInParis.Partie_Interface
{
    public partial class DeleteCuisinier : Form
    {
        public string mdp_admin;
        public MySqlConnection connexion;
        public DeleteCuisinier(string mdp_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;
            LoadCuisiniers();
        }
        void LoadCuisiniers()
        {
            List<string> cuisinier = new List<string>();
            try
                {
                string query = "SELECT nom_cuisinier from cuisinier";

                MySqlCommand cmd = new MySqlCommand(query, connexion);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cuisinier.Add(reader.GetString("nom_cuisinier"));
                }

                reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des identifiants des clients: " + ex.Message);
                }
            this._delete_box_cuis.Items.AddRange(cuisinier.ToArray());
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nom_cuisinier = _delete_box_cuis.SelectedItem?.ToString();
            if (nom_cuisinier == null)
            {
                MessageBox.Show("Veuillez sélectionner un cuisinier.");
            } else
            {
                try
                {
                    string enlever_ctrt = "SET foreign_key_checks=0";
                    MySqlCommand cmd = new MySqlCommand(enlever_ctrt, connexion);
                    cmd.ExecuteNonQuery();

                    string query = "DELETE FROM cuisinier WHERE nom_cuisinier = @nom_cuisinier";
                    MySqlCommand deleteCmd = new MySqlCommand(query, connexion);
                    deleteCmd.Parameters.AddWithValue("@nom_cuisinier", nom_cuisinier);
                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Cuisinier supprimé avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreur : " + ex.Message);
                }
            }     
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CuisinierAdmin cp = new CuisinierAdmin(mdp_admin, connexion);
            this.Close();
            cp.Show();
        }
    }
}

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
    public partial class Delete_cuisinier : Form
    {
        public Delete_cuisinier()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            LoadCuisinierFrom();
        }
        void LoadCuisinierFrom()
        {
            List<string> cuisinier = new List<string>();

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
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
            }
            this._delete_box_cuis.Items.AddRange(cuisinier.ToArray());
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nom_cuisinier = _delete_box_cuis.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nom_cuisinier))
            {
                MessageBox.Show("Veuillez sélectionner un cuisinier.");
                return;
            }

            try
            {
                string enlever_ctrt = "SET foreign_key_checks=0";
                MySqlCommand cmd = new MySqlCommand(enlever_ctrt, Base_Données.Instance.DB);
                cmd.ExecuteNonQuery();

                string query = "DELETE FROM cuisinier WHERE nom_cuisinier = @nom_cuisinier";
                MySqlCommand deleteCmd = new MySqlCommand(query, Base_Données.Instance.DB);
                deleteCmd.Parameters.AddWithValue("@nom_cuisinier", nom_cuisinier);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Cuisinier supprimé avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du cuisinier: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CuisinierPage cp = new CuisinierPage();
            this.Close();
            cp.Show();
        }
    }
}

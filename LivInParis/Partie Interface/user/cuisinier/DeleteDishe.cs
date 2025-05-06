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
    public partial class DeleteDishe : Form
    {

        public string id_client;
        public int tel_cuisinier;
        public MySqlConnection connexion;
        public DeleteDishe(string id_client, int tel_cuisinier, MySqlConnection connexion)
        {
            this.BackColor = Color.LightBlue;
            InitializeComponent();
            this.id_client = id_client;
            this.tel_cuisinier = tel_cuisinier;
            this.connexion = connexion;
            LoadMetsFrom(); 
        }

        void LoadMetsFrom()
        {
            List<string> mets = new List<string>();

                try
                {
                    string query = "SELECT nom_mets from mets WHERE telephone_cuisinier=@telephone_cuisinier";

                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    
                    cmd.Parameters.AddWithValue("@telephone_cuisinier", tel_cuisinier);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        mets.Add(reader.GetString("nom_mets"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreir: " + ex.Message);
                }
            this.comboBox1.Items.AddRange(mets.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom_mets = comboBox1.SelectedItem?.ToString();

                try
                {
                    string query = "DELETE from mets where nom_mets=@nom";

                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    cmd.Parameters.AddWithValue("@nom", nom_mets);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("met supprimé avec succès !");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreir " + ex.Message);
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client, tel_cuisinier, connexion);
            this.Close();
            modeCuisinier.Show();
        }
    }
}

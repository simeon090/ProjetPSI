using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivInParis
{
    public partial class AddNewClient : Form
    {


        public AddNewClient()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_client = this._Id_Box.Text;
            string pwd_client = this._Pwd_Box.Text;


            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
                try
                {
                    // Requête SQL pour ajouter un client
                    string query = "INSERT INTO Client (Identifiant_client, Mot_de_passe) VALUES (@IdentifiantClient, @MotDePasse)";

                    // exécution de la requête 
                    MySqlCommand cmd = new MySqlCommand(query, connexion);


                    cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                    cmd.Parameters.AddWithValue("@MotDePasse", pwd_client);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client ajouté avec succès!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion du client: " + ex.Message);
                }
            }

            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            this.Hide();
            clientPage.ShowDialog();
        }
    }

}

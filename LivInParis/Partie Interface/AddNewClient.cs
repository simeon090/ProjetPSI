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
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;"; // ⚠️ Modifier selon ton setup MySQL


        public AddNewClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string id_client =  this._Id_Box.Text;
           string pwd_client = this._Pwd_Box.Text;


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouverture de la connexion
                    conn.Open();

                    // Requête SQL d'insertion
                    string query = "INSERT INTO Client (Identifiant_client, Mot_de_passe) VALUES (@IdentifiantClient, @MotDePasse)";

                    // Création du command pour exécuter la requête
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Ajouter les paramètres pour éviter les injections SQL
                    cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                    cmd.Parameters.AddWithValue("@MotDePasse", pwd_client);

                    // Exécution de la commande
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

        
    }
    
}

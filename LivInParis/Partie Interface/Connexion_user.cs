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

namespace LivInParis
{
    public partial class Connexion_user : Form
    {
        public Connexion_user()
        {
            InitializeComponent();

            this._text_box_con.KeyDown += _text_box_con_KeyDown;
        }

        private void _text_box_con_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;"; // ⚠️ Modifier selon ton setup MySQL

        private void button1_Click(object sender, EventArgs e)
        {
            string id_client = this._text_box_connexion_id.Text;
            string pwd_client = this._text_box_con.Text;


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Ouverture de la connexion
                    conn.Open();

                    // Requête SQL pour vérifier l'existence du client
                    string query = "SELECT COUNT(*) FROM Client WHERE Identifiant_client = @IdentifiantClient AND Mot_de_passe = @MotDePasse";

                    // Création du command pour exécuter la requête
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                    cmd.Parameters.AddWithValue("@MotDePasse", pwd_client);

                    // Exécution de la requête
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Vérification du résultat
                    if (count > 0)
                    {
                        //  MessageBox.Show("Connexion avec succès !");
                        Utilisateur connexion = new Utilisateur();
                        connexion.Show();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la vérification du client : " + ex.Message);
                }
            }


        }

        private void _text_box_con_TextChanged(object sender, EventArgs e)
        {


        }

        private void _button_create_account_Click(object sender, EventArgs e)
        {
            Créer_un_compte new_user = new Créer_un_compte();
            new_user.ShowDialog();
        }
    }
}

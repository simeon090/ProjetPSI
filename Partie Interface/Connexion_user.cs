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
            this.BackgroundImage = Image.FromFile("fond.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
     
            this._text_box_con.KeyDown += _text_box_con_KeyDown;
        }

        private void _text_box_con_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_client = this._text_box_connexion_id.Text;
            string pwd_client = this._text_box_con.Text;


            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
                try
                {
                    // requete SQL pour vérifier l'existence du client
                    string query = "SELECT COUNT(*) FROM Client WHERE Identifiant_client = @IdentifiantClient AND Mot_de_passe = @MotDePasse";

                    MySqlCommand cmd = new MySqlCommand(query, connexion);

                    cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                    cmd.Parameters.AddWithValue("@MotDePasse", pwd_client);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        ChoixMode connexion_utilisateur = new ChoixMode();
                        this.Hide();
                        connexion_utilisateur.ShowDialog();
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
            this.Hide();
            new_user.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModesAdmin admi = new ModesAdmin();
            this.Hide();
            admi.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

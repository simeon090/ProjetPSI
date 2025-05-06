using LivInParis.Partie_Interface;
using LivInParis.Partie_Interface.user.client;
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
using static LivInParis.CuisinierAdmin;

namespace LivInParis
{
    public partial class HomePageUser : Form
    {
        string id_particulier;
        MySqlConnection connexion;
        string mdp_admin;
        Cuisinier nouveau_cuisinier;
        public HomePageUser(string id_particulier, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.id_particulier = id_particulier;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePageClient client_page = new HomePageClient(id_particulier, connexion);
            this.Hide();
            client_page.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Ici on test si l'utilisateur est déjà un cuisinier ou pas, s'il ne les pas on demande son téléphone et il devient sinon on le redirige vers la page des cuisiniers
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        { 
            string query_telephone = "SELECT * FROM particulier WHERE Identifiant_client = @Identifiant_client;";
            MySqlCommand cmd = new MySqlCommand(query_telephone, connexion);
            cmd.Parameters.AddWithValue("@Identifiant_client", id_particulier);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("Personne trouvé");
                int tel_particulier = Convert.ToInt32(reader.GetDecimal("numéro_tel_particulier"));
                string nom = reader.GetString("nom_particulier");
                string prenom = reader.GetString("prenom_particulier");
                string adresse = reader.GetString("adresse_particulier");
                string mail = reader.GetString("mail_particulier");
                Cuisinier cuisinier = new Cuisinier(
                   nom,
                   prenom,
                   "Cuisinier",
                   adresse,
                   mail,
                   tel_particulier
               );
                reader.Close();
                string query_connexion = "SELECT COUNT(*) FROM Cuisinier WHERE telephone_cuisinier = @telephone_cuisinier";

                cmd = new MySqlCommand(query_connexion, connexion);

                cmd.Parameters.AddWithValue("@telephone_cuisinier", tel_particulier);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    Console.WriteLine("CUISINIER EXISTE : "+tel_particulier);
                    ModeCuisinier cuisinier_page = new ModeCuisinier(id_particulier, tel_particulier, connexion);
                    this.Hide();
                    cuisinier_page.ShowDialog();
                }
                else
                {
                    Console.WriteLine("CUISINIER EXISTE PAS");
                    CreateCuisinier creation_cuisinier_page = new CreateCuisinier(id_particulier, cuisinier, connexion);
                    this.Hide();
                    creation_cuisinier_page.ShowDialog();
                }
            } else
            {
                reader.Close();
                Console.WriteLine("une erreur c'est produise");
            }   
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ConnexionUser connexionUser = new ConnexionUser(mdp_admin, connexion);
            this.Hide();
            connexionUser.ShowDialog();
        }
    }
}

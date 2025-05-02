using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LivInParis
{
    public partial class CuisinierPage : Form
    {
        public CuisinierPage()
        {
            InitializeComponent();


        }
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;";




        private void button2_Click(object sender, EventArgs e)
        {
            List<ClientCuisinier> clientsCuisiniers = new List<ClientCuisinier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        C.telephone_cuisinier, 
                        C.prenom_cuisinier, 
                        C.nom_cuisinier, 
                        P.nom_particulier, 
                        P.prenom_particulier, 
                        P.Identifiant_client
                    FROM Commande CM
                    JOIN Lignes_Commandes LC ON CM.numéro_commande = LC.numéro_commande
                    JOIN Cuisinier C ON CM.telephone_cuisinier = C.telephone_cuisinier
                    JOIN Particulier P ON CM.Identifiant_client = P.Identifiant_client
                    ORDER BY C.telephone_cuisinier, P.Identifiant_client;
                    ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clientsCuisiniers.Add(new ClientCuisinier(
                            reader.GetDecimal("telephone_cuisinier"),
                            reader.GetString("prenom_cuisinier"),
                            reader.GetString("nom_cuisinier"),
                            reader.GetString("nom_particulier"),
                            reader.GetString("prenom_particulier"),
                            reader.GetString("Identifiant_client")
                        ));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }

            bindingSource1.DataSource = clientsCuisiniers;
            dataGridView1.DataSource = bindingSource1;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Cuisinier> cuisiniers = new List<Cuisinier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Cuisinier";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cuisiniers.Add(new Cuisinier(
                            reader.GetDecimal("telephone_cuisinier"),
                            reader.GetString("prenom_cuisinier"),
                            reader.GetString("nom_cuisinier"),
                            reader.GetString("adresse_cuisinier"),
                            reader.GetString("mail_cuisinier")
                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            bindingSource1.DataSource = cuisiniers;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class Cuisinier
        {
            public decimal Telephone { get; set; }
            public string Prenom { get; set; }
            public string Nom { get; set; }
            public string Adresse { get; set; }
            public string Mail { get; set; }

            public Cuisinier(decimal telephone, string prenom, string nom, string adresse, string mail)
            {
                Telephone = telephone;
                Prenom = prenom;
                Nom = nom;
                Adresse = adresse;
                Mail = mail;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            List<CuisinierPlats> cuisiniersPlats = new List<CuisinierPlats>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Cuisinier.telephone_cuisinier, 
                            Cuisinier.prenom_cuisinier, 
                            Cuisinier.nom_cuisinier, 
                            Lignes_Commandes.type AS plat_type, 
                            Lignes_Commandes.nom_du_mets
                        FROM Cuisinier
                        JOIN Commande ON Cuisinier.telephone_cuisinier = Commande.telephone_cuisinier
                        JOIN Lignes_Commandes ON Commande.numéro_commande = Lignes_Commandes.numéro_commande
                        ORDER BY Cuisinier.nom_cuisinier, Lignes_Commandes.type;
                    ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cuisiniersPlats.Add(new CuisinierPlats(
                            reader.GetDecimal("telephone_cuisinier"),
                            reader.GetString("prenom_cuisinier"),
                            reader.GetString("nom_cuisinier"),
                            reader.GetString("plat_type"),
                            reader.GetString("nom_du_mets")
                        ));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            bindingSource1.DataSource = cuisiniersPlats;
            dataGridView1.DataSource = bindingSource1;


        }

        private void CuisinierPage_Load(object sender, EventArgs e)
        {

        }

        public class ClientCuisinier
        {
            public decimal TelephoneCuisinier { get; set; }
            public string PrenomCuisinier { get; set; }
            public string NomCuisinier { get; set; }
            public string NomParticulier { get; set; }
            public string PrenomParticulier { get; set; }
            public string IdentifiantClient { get; set; }

            public ClientCuisinier(decimal telephoneCuisinier, string prenomCuisinier, string nomCuisinier,
                                   string nomParticulier, string prenomParticulier, string identifiantClient)
            {
                TelephoneCuisinier = telephoneCuisinier;
                PrenomCuisinier = prenomCuisinier;
                NomCuisinier = nomCuisinier;
                NomParticulier = nomParticulier;
                PrenomParticulier = prenomParticulier;
                IdentifiantClient = identifiantClient;
            }
        }

        public class CuisinierPlats
        {
            public decimal TelephoneCuisinier { get; set; }
            public string PrenomCuisinier { get; set; }
            public string NomCuisinier { get; set; }
            public string PlatType { get; set; }
            public string NomDuMets { get; set; }

            public CuisinierPlats(decimal telephoneCuisinier, string prenomCuisinier, string nomCuisinier, string platType, string nomDuMets)
            {
                TelephoneCuisinier = telephoneCuisinier;
                PrenomCuisinier = prenomCuisinier;
                NomCuisinier = nomCuisinier;
                PlatType = platType;
                NomDuMets = nomDuMets;
            }
        }


    }
}

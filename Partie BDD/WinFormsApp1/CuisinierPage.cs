using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CuisinierPage : Form
    {
        public CuisinierPage()
        {
            InitializeComponent();


        }
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;"; // ⚠️ Modifier selon ton setup MySQL




        private void button2_Click(object sender, EventArgs e)
        {
            List<Cuisinier> cuisiniers = new List<Cuisinier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Cuisinier ORDER BY nom_cuisinier, prenom_cuisinier";
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

            List<Cuisinier> cuisiniers = new List<Cuisinier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Cuisinier ORDER BY adresse_cuisinier ";
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

        private void CuisinierPage_Load(object sender, EventArgs e)
        {

        }
    }
}

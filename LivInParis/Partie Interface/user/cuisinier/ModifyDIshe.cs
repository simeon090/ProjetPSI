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
    public partial class Modifier_un_met : Form
    {
        public string id_client;
        public int tel_cuisinier;
        public MySqlConnection connexion;
        public string id_met;
        public Modifier_un_met(string id_client, int tel_cuisinier, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.tel_cuisinier = tel_cuisinier;
            this.connexion = connexion;
            this.id_met = "null";
            LoadDishes();
        }

        void LoadDishes()
        {
            List<string> mets = new List<string>();

            try
            {
                string query = "SELECT * from Mets WHERE telephone_cuisinier=@telephone_cuisinier";

                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@telephone_cuisinier", tel_cuisinier);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mets.Add(
                        reader.GetInt32("id_mets").ToString()
                    );
                }
                reader.Close();
                this._modif_cuis_box.Items.AddRange(mets.ToArray());
                this._modif_cuis_box.SelectedIndexChanged += _modif_cuis_box_SelectedIndexChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des identifiants des clients: " + ex.Message);
            }
        }

        private void _modif_cuis_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_met = _modif_cuis_box.SelectedItem?.ToString();
            try
            {
                string query = "SELECT * FROM Mets WHERE id_mets = @id_met";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@id_met", id_met);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine("trouvé");
                    this._modif_adresse_box.Text = reader.GetString("régime_alimentaire");
                    this._mail_box.Text = reader.GetString("nationalité");
                    this._station_box.Text = reader.GetInt32("quantité").ToString();
                    this.textBox1.Text = reader.GetDouble("prix").ToString();
                    this.textBox2.Text = reader.GetString("type");
                    this.textBox3.Text = reader.GetString("nom_mets");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des identifiants des clients: " + ex.Message);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client, tel_cuisinier, connexion);
            this.Hide();
            modeCuisinier.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void _modif_adresse_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void _station_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void _mail_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom_met = textBox3.Text;
            string regime = _modif_adresse_box.Text;
            string nationalité = _mail_box.Text;
            string quantité = _station_box.Text;
            string prix = textBox1.Text;
            string type = textBox2.Text;


            try
            {
                string query = "UPDATE Mets SET nom_mets = @nom_mets, régime_alimentaire = @regime, nationalité = @nationalite, quantité = @quantite, prix = @prix, type = @type WHERE id_mets = @id_met";

                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@regime", regime);
                cmd.Parameters.AddWithValue("@nationalite", nationalité);
                cmd.Parameters.AddWithValue("@quantite", Convert.ToInt32(quantité));
                cmd.Parameters.AddWithValue("@prix", Convert.ToDouble(prix));
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@nom_mets", nom_met);
                cmd.Parameters.AddWithValue("@id_met", id_met);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Met mis à jour avec succès !");
                }
                else
                {
                    MessageBox.Show("Aucun met trouvé à mettre à jour.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("une erreur c'est produise lors de la mise à jour du met : " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

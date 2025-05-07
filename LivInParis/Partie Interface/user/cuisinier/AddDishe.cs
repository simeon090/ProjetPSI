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
    public partial class AddDishe : Form
    {
        public MySqlConnection connexion;
        public string id_client;
        public int tel_cuisinier;
        public AddDishe(string id_client, int tel_cuisinier, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.connexion = connexion;
            this.tel_cuisinier = tel_cuisinier;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _confirmer_button_Click(object sender, EventArgs e)
        {
            string nom = this._nom_met_box.Text;
            string prix = this._prix_met_box.Text;
            string type = this._type_met_box.Text;
            string regime = this._regime_ali_box.Text;
            string nationalité = this.textBox1.Text;
            string quantité = this.textBox2.Text;

            try
            {
                string query = "INSERT INTO Mets (nom_mets, prix, type, régime_alimentaire, telephone_cuisinier, nationalité, quantité) VALUES (@nom_met, @prix_met, @type_met, @regime_ali, @tel_cuisinier, @nationalité, @quantité)";

                MySqlCommand cmd = new MySqlCommand(query, connexion);

                cmd.Parameters.AddWithValue("@nom_met", nom);
                cmd.Parameters.AddWithValue("@prix_met", prix);
                cmd.Parameters.AddWithValue("@type_met", type);
                cmd.Parameters.AddWithValue("@regime_ali", regime);
                cmd.Parameters.AddWithValue("@tel_cuisinier", Convert.ToInt32(tel_cuisinier));
                cmd.Parameters.AddWithValue("@nationalité", nationalité);
                cmd.Parameters.AddWithValue("@quantité", Convert.ToInt32(quantité));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Met ajouté avec succès!");
                ModeCuisinier modeCuisinier = new ModeCuisinier(id_client, tel_cuisinier, connexion);
                this.Hide();
                modeCuisinier.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion du met: " + ex.Message);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client, tel_cuisinier, connexion);
            this.Hide();
            modeCuisinier.ShowDialog();
        }

        private void _quantite_box_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void _quantite_box__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

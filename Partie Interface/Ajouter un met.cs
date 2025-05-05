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
    public partial class Ajouter_un_met : Form
    {
        public MySqlConnection connexion;
        public string id_client;
        public Ajouter_un_met(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.connexion = Base_Données.Instance.DB;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _confirmer_button_Click(object sender, EventArgs e)
        {
            string id_met = this._id_met.Text;
            string nom_met = this._nom_met_box.Text;
            string prix_met_box = this._prix_met_box.Text;
            string _type_met = this._type_met_box.Text;
            string _regime_ali_box = this._regime_ali_box.Text;
            string _tel_cui_box = this._tel_cui_box.Text;

            try
            {
                // Requête SQL pour ajouter un met
                string query = "INSERT INTO Mets (id_mets, nom_mets, prix, type, régime_alimentaire, telephone_cuisinier) VALUES (@id_met, @nom_met, @prix_met, @type_met, @regime_ali, @tel_cuisinier)";

                MySqlCommand cmd = new MySqlCommand(query, connexion);


                cmd.Parameters.AddWithValue("@id_met", id_met);
                cmd.Parameters.AddWithValue("@nom_met", nom_met);
                cmd.Parameters.AddWithValue("@prix_met", prix_met_box);
                cmd.Parameters.AddWithValue("@type_met", _type_met);
                cmd.Parameters.AddWithValue("@regime_ali", _regime_ali_box);
                cmd.Parameters.AddWithValue("@tel_cuisinier", _tel_cui_box);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Met ajouté avec succès!");
                label8_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion du met: " + ex.Message);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client);
            this.Close();
            modeCuisinier.ShowDialog();
        }

        private void _quantite_box_Click(object sender, EventArgs e)
        {

        }
    }
}

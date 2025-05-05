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
        private MySqlConnection connexion;

        public Modifier_un_met(string id_client, int tel_cuisinier)
        {
            this.connexion = Base_Données.Instance.DB;
            InitializeComponent();
            LoadClientFrom();

            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.tel_cuisinier = tel_cuisinier;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client, tel_cuisinier);
            this.Hide();
            modeCuisinier.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string new_nom_met = this._box_nom_met.Text;
            string new_type = this._type_box.Text;
            string new_regime = this._regime_ali_box.Text;
            string new_prix = this._prix_box.Text;
            string new_quantite = this._quantité_box.Text;

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
                try
                {
                    // Requête de mise à jour du met
                    string query = @"UPDATE mets SET nom_mets = @NomMets, `type` = @Type, `régime_alimentaire` = @Regime, prix = @Prix, quantité = @Quantite WHERE nom_mets = @OldNomMets";

                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    cmd.Parameters.AddWithValue("@NomMets", new_nom_met);
                    cmd.Parameters.AddWithValue("@Type", new_type);
                    cmd.Parameters.AddWithValue("@Regime", new_regime);
                    cmd.Parameters.AddWithValue("@Prix", new_prix);
                    cmd.Parameters.AddWithValue("@Quantite", new_quantite);
                    cmd.Parameters.AddWithValue("@OldNomMets", this._box_nom_met.SelectedItem?.ToString()); // Use old name for comparison

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Met mis à jour avec succès!");
                    }
                    else
                    {
                        MessageBox.Show("Aucun met trouvé avec cet identifiant.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du met: " + ex.Message);
                }

                Close();
            }
        }

        void LoadClientFrom()
        {
            List<string> mets = new List<string>();

            using (MySqlConnection connexion = Base_Données.Instance.DB)
            {
                try
                {
                    string query = "SELECT nom_mets from mets";

                    MySqlCommand cmd = new MySqlCommand(query, connexion);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        mets.Add(reader.GetString("nom_mets"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des noms de mets: " + ex.Message);
                }
            }
            this._box_nom_met.Items.AddRange(mets.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom_mets = _box_nom_met.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nom_mets))
            {
                using (MySqlConnection connexion = Base_Données.Instance.DB)
                {
                    try
                    {
                        string query = "SELECT prix, type, régime_alimentaire from mets where nom_mets=@nom";
                        MySqlCommand cmd = new MySqlCommand(query, connexion);
                        cmd.Parameters.AddWithValue("@nom", nom_mets);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            this._prix_box.Text = reader.GetDecimal(reader.GetOrdinal("prix")).ToString("F2");
                            this._type_box.Text = reader.GetString("type");
                            this._regime_ali_box.Text = reader.GetString("régime_alimentaire");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des informations du mets: " + ex.Message);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can implement this if needed
        }
    }
}

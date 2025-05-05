using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LivInParis.CuisinierPage;

namespace LivInParis.Partie_Interface
{
    public partial class Mets_En_Ligne : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public string id_particulier;
        public int tel_cuisinier;
        public MySqlConnection connexion;
        public Mets_En_Ligne(string id_particulier, int tel_cuisinier)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.tel_cuisinier = tel_cuisinier;
            this.id_particulier = id_particulier;
            connexion = Base_Données.Instance.DB;
            dataGridView1.AutoGenerateColumns = true;
            LoadData();
        }

        void LoadData()
        {

            List<CuisinierPlats> cuisiniersPlats = new List<CuisinierPlats>();

            try
            {
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
                WHERE Cuisinier.telephone_cuisinier = @tel_cuisinier
                ORDER BY Cuisinier.nom_cuisinier, Lignes_Commandes.type;
                ";

                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@tel_cuisinier", tel_cuisinier);
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

            bindingSource1.DataSource = cuisiniersPlats;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_particulier, tel_cuisinier);
            this.Hide();
            modeCuisinier.ShowDialog();
        }
    }
}

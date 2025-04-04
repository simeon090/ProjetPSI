﻿using MySql.Data.MySqlClient;
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
    public partial class Créer_un_compte : Form
    {
        public Créer_un_compte()
        {
            InitializeComponent();
        }
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=simeon;";

        private void _confirm_button_Click(object sender, EventArgs e)
        {
            string id = this._id_create.Text;
            string pwd = this._mdp_create.Text;
            string nom = this._nom_create.Text;
            string prenom = this._prenom_create.Text;
            string adresse = this._adresse_create.Text;
            string telephone = this._tel_create.Text;

            // Vérification de la conversion du téléphone en decimal
            if (!decimal.TryParse(telephone, out decimal telephoneDecimal))
            {
                MessageBox.Show("Erreur : Le numéro de téléphone doit être un nombre valide.");
                return; // On arrête ici si la conversion échoue
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // requête 1 
                        string queryClient = "INSERT INTO Client (Identifiant_client, Mot_de_passe) VALUES (@IdentifiantClient, @MotDePasse)";
                        MySqlCommand cmdClient = new MySqlCommand(queryClient, conn, transaction);
                        cmdClient.Parameters.AddWithValue("@IdentifiantClient", id);
                        cmdClient.Parameters.AddWithValue("@MotDePasse", pwd);
                        cmdClient.ExecuteNonQuery();

                        // requête 2 
                        string queryParticulier = "INSERT INTO Particulier (Identifiant_client, nom_particulier, prenom_particulier, adresse_particulier, numéro_tel_particulier) " +
                                                  "VALUES (@Identifiant_client, @nom_particulier, @prenom_particulier, @adresse_particulier, @numéro_particulier)";
                        MySqlCommand cmdParticulier = new MySqlCommand(queryParticulier, conn, transaction);
                        cmdParticulier.Parameters.AddWithValue("@Identifiant_client", id);
                        cmdParticulier.Parameters.AddWithValue("@nom_particulier", nom);
                        cmdParticulier.Parameters.AddWithValue("@prenom_particulier", prenom);
                        cmdParticulier.Parameters.AddWithValue("@adresse_particulier", adresse);
                        cmdParticulier.Parameters.AddWithValue("@numéro_particulier", telephoneDecimal); // Conversion en decimal
                        cmdParticulier.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Compte créé avec succès!");
                    }
                    catch (Exception ex)
                    {
                        // message erreur 
                        transaction.Rollback();
                        MessageBox.Show("Erreur lors de l'insertion: " + ex.Message);
                    }
                }
            }

            Close();
        }

    }
}

﻿using MySql.Data.MySqlClient;
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

namespace LivInParis
{
    public partial class SignUp : Form
    {
        public MySqlConnection connexion;
        public string mdp_admin;
        public SignUp(MySqlConnection connexion, string mdp_admin)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;
        }

        private void _confirm_button_Click(object sender, EventArgs e)
        {
            string id = this._id_create.Text;
            string pwd = this._mdp_create.Text;
            string nom = this._nom_create.Text;
            string prenom = this._prenom_create.Text;
            string adresse = this._adresse_create.Text;
            string mail = this.textBox1.Text;
            if (!mail.Contains("@"))
            {
                MessageBox.Show("Adresse email pas valide");
                return;
            }
            int telephone;
            if (!int.TryParse(this._tel_create.Text, out telephone))
            {
                MessageBox.Show("Téléphone pas valide.");
                return;
            }

            try
            {
                // requeete 1 
                string queryClient = "INSERT INTO Client (Identifiant_client, Mot_de_passe) VALUES (@IdentifiantClient, @MotDePasse)";
                MySqlCommand cmdClient = new MySqlCommand(queryClient, connexion);
                cmdClient.Parameters.AddWithValue("@IdentifiantClient", id);
                cmdClient.Parameters.AddWithValue("@MotDePasse", pwd);
                cmdClient.ExecuteNonQuery();

                // requete 2 
                string queryParticulier = "INSERT INTO Particulier (Identifiant_client, nom_particulier, prenom_particulier, adresse_particulier, numéro_tel_particulier, mail_particulier) " +
                                            "VALUES (@Identifiant_client, @nom_particulier, @prenom_particulier, @adresse_particulier, @numéro_particulier, @mail_particulier)";
                MySqlCommand cmdParticulier = new MySqlCommand(queryParticulier, connexion);
                cmdParticulier.Parameters.AddWithValue("@Identifiant_client", id);
                cmdParticulier.Parameters.AddWithValue("@nom_particulier", nom);
                cmdParticulier.Parameters.AddWithValue("@prenom_particulier", prenom);
                cmdParticulier.Parameters.AddWithValue("@adresse_particulier", adresse);
                cmdParticulier.Parameters.AddWithValue("@numéro_particulier", telephone);
                cmdParticulier.Parameters.AddWithValue("@mail_particulier", mail);
                cmdParticulier.ExecuteNonQuery();

                MessageBox.Show("Compte créé avec succès!");
                HomePageUser connexion_utilisateur = new HomePageUser(id, connexion);
                this.Hide();
                connexion_utilisateur.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Créer_un_compte_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _mdp_create_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ConnexionUser connexionUser = new ConnexionUser(mdp_admin, connexion);
            this.Hide();
            connexionUser.ShowDialog();
        }
    }
}

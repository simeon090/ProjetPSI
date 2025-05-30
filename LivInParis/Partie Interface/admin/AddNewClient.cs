﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivInParis
{
    public partial class AddNewClient : Form
    {
        public string mdp_admin;
        public MySqlConnection connexion;
        public AddNewClient(string mdp_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_client = this._Id_Box.Text;
            string pwd_client = this._Pwd_Box.Text;

            string nom = this.textBox1.Text;
            string prenom = this.textBox2.Text;
            string mail = this.textBox4.Text;
            string adresse = this.textBox3.Text;
            

                try
                {
                    // dans le try pour gérer les erreurs
                    int tel = Convert.ToInt32(this.textBox5.Text);
                    string query_client = "INSERT INTO Client (Identifiant_client, Mot_de_passe) VALUES (@IdentifiantClient, @MotDePasse)";

                    MySqlCommand cmd = new MySqlCommand(query_client, connexion);

                    cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                    cmd.Parameters.AddWithValue("@MotDePasse", pwd_client);

                    cmd.ExecuteNonQuery();

                    string query_particulier = "INSERT INTO particulier (numéro_tel_particulier, nom_particulier, prenom_particulier, adresse_particulier, Identifiant_client, mail_particulier) " +
                           "VALUES (@NumeroTel, @Nom, @Prenom, @Adresse, @IdentifiantClient, @Mail)";

                    cmd = new MySqlCommand(query_particulier, connexion);

                    cmd.Parameters.AddWithValue("@NumeroTel", tel);
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Prenom", prenom);
                    cmd.Parameters.AddWithValue("@Adresse", adresse);
                    cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
                    cmd.Parameters.AddWithValue("@Mail", mail);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client ajouté avec succès!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur insertion du client: " + ex.Message);
                }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ClientAdmin clientPage = new ClientAdmin(mdp_admin, connexion);
            this.Close();
            clientPage.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void _Id_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewClient_Load(object sender, EventArgs e)
        {

        }
    }

}

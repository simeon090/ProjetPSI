﻿using LivInParis.Partie_Interface.admin;
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

namespace LivInParis
{
    public partial class ConnexionUser : Form
    {
        public string mdp_admin;
        public MySqlConnection connexion; 
        public ConnexionUser(string mdp_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("fond.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.connexion = connexion;
            this._text_box_con.KeyDown += _text_box_con_KeyDown;
            this.mdp_admin = mdp_admin;
        }

        private void _text_box_con_KeyDown(object? sender, KeyEventArgs e)
        {
            //ajouter pour quand on appuie sur entrée on se connecte (gain de temps)
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_client = this._text_box_connexion_id.Text;
            string pwd_client = this._text_box_con.Text;
         
            try
            {
            // requete SQL pour vérifier l'existence du client
            string query = "SELECT COUNT(*) FROM Client WHERE Identifiant_client = @IdentifiantClient AND Mot_de_passe = @MotDePasse";

            MySqlCommand cmd = new MySqlCommand(query, connexion);

            cmd.Parameters.AddWithValue("@IdentifiantClient", id_client);
            cmd.Parameters.AddWithValue("@MotDePasse", pwd_client);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                HomePageUser connexion_utilisateur = new HomePageUser(id_client, connexion);
                this.Hide();
                connexion_utilisateur.Show();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification du client : " + ex.Message);
                }


        }

        private void _text_box_con_TextChanged(object sender, EventArgs e)
        {


        }

        private void _button_create_account_Click(object sender, EventArgs e)
        {
            SignUp new_user = new SignUp(connexion, mdp_admin);
            this.Hide();
            new_user.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnexionAdmin admi = new ConnexionAdmin(mdp_admin, connexion);
            this.Hide();
            admi.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _text_box_connexion_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

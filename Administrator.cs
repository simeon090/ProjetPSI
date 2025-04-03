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

namespace WinFormsApp1
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;";
        private void _admin_text_box_TextChanged(object sender, EventArgs e)
        {
            HomePage admin = new HomePage();
            admin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage admi = new HomePage();
            admi.ShowDialog();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            List<Client> clients = new List<Client>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Particulier";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clients.Add(new Client(
                            reader.GetString("Identifiant_client"),
                            reader.GetString("Mot_de_passe")

                        ));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            bindingSource1.DataSource = clients;
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
          Connexion_user utilisateur = new Connexion_user();
            utilisateur.ShowDialog();
        }
    }
}

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

namespace LivInParis.Partie_Interface.user.client
{
    public partial class HomePageClient : Form
    {
        public string id_particulier;
        public MySqlConnection connexion;
        public HomePageClient(string id_particulier, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.id_particulier = id_particulier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passer_commande commande = new Passer_commande(id_particulier, connexion);
            this.Hide();
            commande.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserOrders commandes = new UserOrders(id_particulier, false, connexion);
            this.Hide();
            commandes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifyClient client = new ModifyClient(id_particulier, false, connexion);
            this.Hide();
            client.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageUser utilisateur = new HomePageUser(id_particulier, connexion);
            this.Hide();
            utilisateur.ShowDialog();
        }
    }
}

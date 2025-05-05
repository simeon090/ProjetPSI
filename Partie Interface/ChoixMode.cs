using LivInParis.Partie_Interface;
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
    public partial class ChoixMode : Form
    {
        string id_client;
        public ChoixMode(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passer_commande commande = new Passer_commande(id_client);
            this.Hide();
            commande.ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeCuisinier cuisinier = new ModeCuisinier(id_client);
            this.Hide();
            cuisinier.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Connexion_user connexionUser = new Connexion_user();
            this.Hide();
            connexionUser.ShowDialog();
        }
    }
}

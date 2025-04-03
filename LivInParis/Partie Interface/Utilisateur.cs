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
    public partial class Utilisateur : Form
    {
        public Utilisateur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passer_commande commande = new Passer_commande();
            commande.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

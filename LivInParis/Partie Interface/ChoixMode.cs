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
        public ChoixMode()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passer_commande commande = new Passer_commande();
            this.Hide();
            commande.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeCuisinier cuisinier = new ModeCuisinier();
            this.Hide();
            cuisinier.ShowDialog();
            this.Close();
        }
    }
}

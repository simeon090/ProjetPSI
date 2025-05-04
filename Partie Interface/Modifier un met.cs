using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivInParis.Partie_Interface
{
    public partial class Modifier_un_met : Form
    {
        public Modifier_un_met()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier();
            this.Hide();
            modeCuisinier.ShowDialog(); 
        }
    }
}

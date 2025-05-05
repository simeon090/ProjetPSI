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
        public string id_client;
        public Modifier_un_met(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client);
            this.Hide();
            modeCuisinier.ShowDialog(); 
        }
    }
}

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
        public int tel_cuisinier;
        public Modifier_un_met(string id_client, int tel_cuisinier)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.tel_cuisinier = tel_cuisinier;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ModeCuisinier modeCuisinier = new ModeCuisinier(id_client, tel_cuisinier);
            this.Hide();
            modeCuisinier.ShowDialog(); 
        }
    }
}

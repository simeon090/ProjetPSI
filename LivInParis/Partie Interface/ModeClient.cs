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
    public partial class ModeClient : Form
    {
        public string id_client;
        public ModeClient(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passer_commande commande = new Passer_commande(id_client);
            commande.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChoixMode choixMode = new ChoixMode(id_client);
            this.Close();
            choixMode.ShowDialog(); 
        }
    }
}

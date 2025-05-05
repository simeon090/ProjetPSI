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
    public partial class ModeCuisinier : Form
    {
        public string id_client;
        public ModeCuisinier(string id_client)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_un_met ajouter_un_met = new Ajouter_un_met(id_client);
            this.Hide();
            ajouter_un_met.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChoixMode choixMode = new ChoixMode(id_client);
            this.Hide();
            choixMode.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mets_En_Ligne met_en_ligne = new Mets_En_Ligne(id_client);
            this.Hide();
            met_en_ligne.ShowDialog();
        }
    }
}

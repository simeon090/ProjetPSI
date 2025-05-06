using LivInParis.Partie_Graphe;
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
    public partial class HomePageAdmin : Form
    {
        public HomePageAdmin()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientAdmin clientPage = new ClientAdmin();
            this.Close();
            clientPage.Show();
          



        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuisinierAdmin cuis = new CuisinierAdmin();
            this.Close();
            cuis.Show();
          

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GrapheUtilisateur grapheUtilisateurs = new GrapheUtilisateur();
            Console.WriteLine(grapheUtilisateurs.ToString());
            grapheUtilisateurs.ColorationGraphe();
            grapheUtilisateurs.VisualiserGraphe();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ConnexionUser connexion = new ConnexionUser();
            this.Close();
            connexion.ShowDialog();
        }
    }
}

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
    public partial class ModesAdmin : Form
    {
        public ModesAdmin()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            this.Hide();
            clientPage.ShowDialog();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuisinierPage cuis = new CuisinierPage();
            this.Hide();
            cuis.ShowDialog();
            this.Close();

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
    }
}

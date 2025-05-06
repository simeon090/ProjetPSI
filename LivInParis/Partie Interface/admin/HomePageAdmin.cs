using LivInParis.Partie_Graphe;
using LivInParis.Partie_Interface.admin;
using MySql.Data.MySqlClient;
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
        public string mdp_admin;
        public MySqlConnection connexion;
        public HomePageAdmin(string mdp_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.mdp_admin = mdp_admin;
            this.connexion = connexion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientAdmin clientPage = new ClientAdmin(mdp_admin, connexion);
            this.Close();
            clientPage.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuisinierAdmin cuis = new CuisinierAdmin(mdp_admin, connexion);
            this.Close();
            cuis.Show();


        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GrapheUtilisateur grapheUtilisateurs = new GrapheUtilisateur(connexion);
            Console.WriteLine(grapheUtilisateurs.ToString());
            grapheUtilisateurs.ColorationGraphe();
            grapheUtilisateurs.VisualiserGraphe();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ConnexionUser connexionUser = new ConnexionUser(mdp_admin, connexion);
            this.Hide();
            connexionUser.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportData export = new ExportData(connexion, mdp_admin);
            this.Hide();
            export.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatsAdmin statistiques = new StatsAdmin(mdp_admin, connexion);
            this.Hide();
            statistiques.ShowDialog();
        }
    }
}

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

namespace LivInParis.Partie_Interface
{
    public partial class ModeCuisinier : Form
    {
        public string id_client;
        public int tel_cuisinier;
        public MySqlConnection connexion;
        public ModeCuisinier(string id_client, int tel_cuisinier, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.id_client = id_client;
            this.tel_cuisinier = tel_cuisinier;
            this.connexion = connexion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDishe ajouter_un_met = new AddDishe(id_client, tel_cuisinier, connexion);
            this.Hide();
            ajouter_un_met.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageUser choixMode = new HomePageUser(id_client, connexion);
            this.Hide();
            choixMode.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YourDishes met_en_ligne = new YourDishes(id_client, tel_cuisinier, connexion);
            this.Hide();
            met_en_ligne.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_un_met modifier_un_met = new Modifier_un_met(id_client, tel_cuisinier, connexion);
            this.Close();
            modifier_un_met.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteDishe supprimer_met = new DeleteDishe(id_client, tel_cuisinier, connexion);
            this.Close();
            supprimer_met.Show();

        }
    }
}

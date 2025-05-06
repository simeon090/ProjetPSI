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

namespace LivInParis.Partie_Interface.admin
{
    public partial class ConnexionAdmin : Form
    {
        public string mdp_admin;
        public MySqlConnection connexion;
        public ConnexionAdmin(string mdp_admin, MySqlConnection connexion)
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;
        }

        private void _text_box_con_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_text_box_con.Text == mdp_admin)
            {
                HomePageAdmin admin = new HomePageAdmin(mdp_admin, connexion);
                this.Hide();
                admin.ShowDialog();
            } else
            {
                MessageBox.Show("Mauvais mot de passe administrateur !");
            }
        }
    }
}

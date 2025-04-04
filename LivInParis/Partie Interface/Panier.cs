using LivInParis.Partie_Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static LivInParis.Passer_commande;

namespace LivInParis
{
    public partial class Panier : Form
    {
        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=MOT_DE_PASSE;";

        //prend une liste de mets sélectionnés
        public Panier(List<Mets> metsSelectionnes)
        {
            InitializeComponent();


            foreach (var mets in metsSelectionnes)
            {
                _box_resume.Items.Add(mets);
            }

            CalculerTotal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CalculerTotal()
        {
            decimal totalPrix = 0;

            foreach (Mets item in _box_resume.Items)
            {
                totalPrix += item.prix;
            }

            textBox1.Text = $"{totalPrix:0.00} €";

        }

        private void _box_resume_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trajet_Ligne_Commandes trajet = new Trajet_Ligne_Commandes();   
            trajet.Show();
        }
    }
}
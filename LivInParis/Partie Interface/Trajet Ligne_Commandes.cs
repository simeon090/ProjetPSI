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
    public partial class Trajet_Ligne_Commandes : Form
    {
        public Trajet_Ligne_Commandes()
        {
            InitializeComponent();
            arrivee_box.Text = Passer_commande.StationArrivee;
            départ_box.Text = string.Join(",", Passer_commande.StationsDepart);
            GrapheMetro Test_Graphe = new GrapheMetro("MetroParis_Noeuds.csv", "MetroParis_Arcs.csv");
            station_metro depart = Test_Graphe.TrouverStationAvecNom(départ_box.Text);
            station_metro arrivee = Test_Graphe.TrouverStationAvecNom(arrivee_box.Text);
            Dictionary<station_metro, (string, int)> resultat_dijkstra = Test_Graphe.Dijkstra(depart, arrivee);
            station_metro[] liste_stations = Test_Graphe.ToListStations(resultat_dijkstra);
            App.AffcherTab(liste_stations);


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            
        }
    }
}

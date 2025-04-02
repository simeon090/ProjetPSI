using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Passer_commande : Form
    {

        public Passer_commande()
        {
            InitializeComponent();
            ChargerStations();
            ChargerMets();

        }


        private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=psg123*;";
        private void ChargerStations()
        {
            List<string> stationsMetroParis = new List<string>
{
    "Porte Maillot",
    "Argentine",
    "Charles de Gaulle - Etoile",
    "George V",
    "Franklin D. Roosevelt",
    "Champs-Elysées - Clemenceau",
    "Concorde",
    "Tuileries",
    "Palais Royal - Musée du Louvre",
    "Louvre - Rivoli",
    "Châtelet",
    "Hôtel de Ville",
    "Saint-Paul (Le Marais)",
    "Bastille",
    "Gare de Lyon",
    "Reuilly - Diderot",
    "Nation",
    "Porte de Vincennes",
    "Château de Vincennes",
    "Porte Dauphine",
    "Victor Hugo",
    "Ternes",
    "Courcelles",
    "Monceau",
    "Villiers",
    "Rome",
    "Place de Clichy",
    "Blanche",
    "Pigalle",
    "Anvers",
    "Barbès - Rochechouart",
    "La Chapelle",
    "Stalingrad",
    "Jaurès",
    "Colonel Fabien",
    "Belleville",
    "Couronnes",
    "Ménilmontant",
    "Père Lachaise",
    "Philippe Auguste",
    "Alexandre Dumas",
    "Avron",
    "Porte de Champerret",
    "Pereire",
    "Wagram",
    "Malesherbes",
    "Europe",
    "Saint-Lazare",
    "Havre-Caumartin",
    "Opéra",
    "Quatre Septembre",
    "Bourse",
    "Sentier",
    "Réaumur - Sébastopol",
    "Arts et Métiers",
    "Temple",
    "République",
    "Parmentier",
    "Rue Saint-Maur",
    "Gambetta",
    "Porte de Bagnolet",
    "Porte des Lilas",
    "Saint-Fargeau",
    "Pelleport",
    "Porte de Clignancourt",
    "Simplon",
    "Marcadet - Poissonniers",
    "Château Rouge",
    "Gare du Nord",
    "Gare de l'Est",
    "Château d'Eau",
    "Strasbourg - Saint-Denis",
    "Etienne Marcel",
    "Les Halles",
    "Cité",
    "Saint-Michel",
    "Odéon",
    "Saint-Germain-des-Prés",
    "Saint-Sulpice",
    "Saint-Placide",
    "Montparnasse Bienvenue",
    "Vavin",
    "Raspail",
    "Denfert-Rochereau",
    "Mouton-Duvernet",
    "Alésia",
    "Porte d'Orléans",
    "Porte de Pantin",
    "Ourcq",
    "Laumière",
    "Jacques Bonsergent",
    "Oberkampf",
    "Richard-Lenoir",
    "Bréguet-Sabin",
    "Quai de la Rapée",
    "Gare d'Austerlitz",
    "Saint-Marcel",
    "Campo-Formio",
    "Place d'Italie",
    "Kléber",
    "Boissière",
    "Trocadéro",
    "Passy",
    "Bir-Hakeim",
    "Dupleix",
    "La Motte-Picquet - Grenelle",
    "Cambronne",
    "Sèvres-Lecourbe",
    "Pasteur",
    "Edgar Quinet",
    "Saint-Jacques",
    "Glacière",
    "Corvisart",
    "Nationale",
    "Chevaleret",
    "Quai de la Gare",
    "Bercy",
    "Dugommier",
    "Daumesnil",
    "Bel-Air",
    "Picpus",
    "Porte de la Villette",
    "Corentin Cariou",
    "Crimée",
    "Riquet",
    "Louis Blanc",
    "Château Landon",
    "Poissonnière",
    "Cadet",
    "Le Peletier",
    "Chaussée d'Antin - La Fayette",
    "Pyramides",
    "Pont Neuf",
    "Pont Marie (Cité des Arts)",
    "Sully - Morland",
    "Jussieu",
    "Place Monge",
    "Censier - Daubenton",
    "Les Gobelins",
    "Tolbiac",
    "Maison Blanche",
    "Porte d'Italie",
    "Porte de Choisy",
    "Porte d'Ivry",
    "Bolivar",
    "Buttes Chaumont",
    "Botzaris",
    "Place des Fêtes",
    "Pré-Saint-Gervais",
    "Danube",
    "Balard",
    "Lourmel",
    "Boucicaut",
    "Félix Faure",
    "Commerce",
    "Ecole Militaire",
    "La Tour-Maubourg",
    "Invalides",
    "Madeleine",
    "Richelieu - Drouot",
    "Grands Boulevards",
    "Bonne Nouvelle",
    "Filles du Calvaire",
    "Saint-Sébastien - Froissart",
    "Chemin Vert",
    "Ledru-Rollin",
    "Faidherbe - Chaligny",
    "Montgallet",
    "Michel Bizot",
    "Porte Dorée",
    "Porte de Charenton",
    "Porte de Saint-Cloud",
    "Exelmans",
    "Michel-Ange - Molitor",
    "Michel-Ange - Auteuil",
    "Jasmin",
    "Ranelagh",
    "La Muette",
    "Rue de la Pompe",
    "Iéna",
    "Alma - Marceau",
    "Saint-Philippe du Roule",
    "Miromesnil",
    "Saint-Augustin",
    "Saint-Ambroise",
    "Voltaire",
    "Charonne",
    "Rue des Boulets",
    "Buzenval",
    "Maraîchers",
    "Porte de Montreuil",
    "Cardinal Lemoine",
    "Maubert - Mutualité",
    "Cluny - La Sorbonne",
    "Mabillon",
    "Sèvres - Babylone",
    "Vaneau",
    "Duroc",
    "Ségur",
    "Avenue Emile Zola",
    "Charles Michels",
    "Javel - André Citroën",
    "Eglise d'Auteuil",
    "Porte d'Auteuil",
    "Chardon Lagache",
    "Mirabeau",
    "Rambuteau",
    "Goncourt",
    "Pyrénées",
    "Jourdain",
    "Télégraphe",
    "Porte de la Chapelle",
    "Marx Dormoy",
    "Jules Joffrin",
    "Lamarck - Caulaincourt",
    "Abbesses",
    "Saint-Georges",
    "Notre-Dame-de-Lorette",
    "Trinité - d'Estienne d'Orves",
    "Assemblée Nationale",
    "Solférino",
    "Rue du Bac",
    "Rennes",
    "Notre-Dame des Champs",
    "Falguière",
    "Volontaires",
    "Vaugirard",
    "Convention",
    "Porte de Versailles",
    "Porte de Vanves",
    "Plaisance",
    "Pernety",
    "Gaîté",
    "Saint-François-Xavier",
    "Varenne",
    "Liège",
    "La Fourche",
    "Guy Môquet",
    "Porte de Saint-Ouen",
    "Brochant",
    "Porte de Clichy",
    "Pont Cardinet",
    "Cour Saint-Emilion",
    "Bibliothèque François Mitterrand",
    "Olympiades"
};

            _choix_station_commande.Items.Clear(); // Nettoie la liste pour éviter les doublons
            _choix_station_commande.Items.AddRange(stationsMetroParis.ToArray());
        }

        private void _choix_station_commande_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cet événement est déclenché lorsque l'utilisateur sélectionne une station
            MessageBox.Show("Vous avez sélectionné : " + _choix_station_commande.SelectedItem);
        }


        private void ChargerMets()
        {
            List<Mets> metsList = new List<Mets>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nom_mets, prix FROM Mets";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        metsList.Add(new Mets(reader.GetString("nom_mets"), reader.GetDecimal("prix")));

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

            box_commande.Items.Clear();
            box_commande.Items.AddRange(metsList.ToArray());
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void box_commande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Mets> selectionMets = new List<Mets>();

            // Récupérer les mets sélectionnés dans box_commande
            foreach (var item in box_commande.CheckedItems)
            {
                selectionMets.Add((Mets)item); // Cast de l'élément sélectionné en Mets
            }

            if (selectionMets.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un mets.");
                return;
            }

            // Passage de la liste de Mets au formulaire Panier
            Panier panier = new Panier(selectionMets);
            panier.Show();
        }


        public class Mets
        {

            public string nom_mets { get; set; }

            public decimal prix {  get; set; }

            public Mets ( string nom_mets, decimal prix ) 
            { 
                this.nom_mets = nom_mets;   
                this.prix = prix;   
           
            }
            public override string ToString()
            {
                return $"{nom_mets} - {prix} €";
            }
        }

       

    }
}

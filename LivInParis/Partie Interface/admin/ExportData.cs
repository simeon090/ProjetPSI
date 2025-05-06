using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Newtonsoft.Json;

namespace LivInParis.Partie_Interface.admin
{
    public partial class ExportData : Form
    {
        public List<Mets> mets = new List<Mets>();
        public List<Client> clients = new List<Client>();
        public List<Cuisinier> cuisiniers = new List<Cuisinier>();
        public MySqlConnection connexion;
        public string mdp_admin;
        public ExportData(MySqlConnection connexion, string mdp_admin)
        {
            InitializeComponent();
            this.connexion = connexion;
            this.mdp_admin = mdp_admin;
            this.BackColor = Color.LightBlue;
            LoadMets();
            LoadClient();
            LoadCuisiniers();       
        }
        public void LoadCuisiniers()
        {
            try
            {
                string query = "SELECT * FROM Cuisinier";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cuisiniers.Add(new Cuisinier(
                        reader.GetString("nom_cuisinier"),
                        reader.GetString("prenom_cuisinier"),
                        "Cuisinier",
                        reader.GetString("adresse_cuisinier"),
                        reader.GetString("mail_cuisinier"),
                        Convert.ToInt32(reader.GetDecimal("telephone_cuisinier"))
                    ));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        public void LoadMets()
        {
            try
            {
                //requête pour station + tt les champs de mets
                string query = @"
                SELECT 
                    m.nom_mets, 
                    m.prix,
                    m.id_mets,
                    m.type,
                    m.nationalité,
                    m.régime_alimentaire,
                    m.telephone_cuisinier,
                    m.quantité,
                    c.station_métro
                FROM 
                    Mets m
                JOIN 
                    Cuisinier c ON m.telephone_cuisinier = c.telephone_cuisinier";


                MySqlCommand cmd = new MySqlCommand(query, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mets.Add(
                        new Mets(
                            reader.GetString("nom_mets"),
                            reader.GetDecimal("prix"),
                            reader.GetInt32("id_mets").ToString(),
                            reader.GetString("type"),
                            reader.GetString("nationalité"),
                            reader.GetString("régime_alimentaire"),
                            reader.GetInt32("telephone_cuisinier"),
                            reader.GetInt32("quantité"),
                            reader.GetString("station_métro")
                    )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        public void LoadClient()
        {
            //join pour avoir seulement les clients qui ont fais des commandes
            string query = @"
            SELECT c.Identifiant_client, p.nom_particulier, p.prenom_particulier, p.adresse_particulier
            FROM commande c
            JOIN client cl ON c.Identifiant_client = cl.Identifiant_client
            JOIN particulier p ON p.Identifiant_client = cl.Identifiant_client;
            ";

            MySqlCommand cmd = new MySqlCommand(query, connexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nom = reader.GetString("nom_particulier");
                string prenom = reader.GetString("prenom_particulier");
                string adresse = reader.GetString("adresse_particulier");
                string id_client = reader.GetString("Identifiant_client");

                clients.Add(
                    new Client(nom, prenom, "Particulier", id_client, "Confidentiel")
                );
            }
            reader.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string chemin_fichier = "cuisiniers_LivInParis.xml";
            XmlWriter writer = XmlWriter.Create(chemin_fichier, new XmlWriterSettings { Indent = true });
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Cuisiniers");

                foreach (var cuisinier in cuisiniers)
                {
                    writer.WriteStartElement("Cuisinier");
                    writer.WriteElementString("Nom", cuisinier.Nom);
                    writer.WriteElementString("Prenom", cuisinier.Prenom);
                    writer.WriteElementString("Type", cuisinier.Type);
                    writer.WriteElementString("Adresse", cuisinier.adresse);
                    writer.WriteElementString("Mail", cuisinier.mail);
                    writer.WriteElementString("Telephone", cuisinier.telephone.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            MessageBox.Show("Cuisiniers enregistrés au format XML");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chemin_fichier = "mets_LivInParis.json";
            using (StreamWriter sw = new StreamWriter(chemin_fichier))
            using (JsonTextWriter jwriter = new JsonTextWriter(sw))
            {
                jwriter.WriteStartArray();
                foreach (var mets in mets)
                {
                    jwriter.WriteStartObject();

                    jwriter.WritePropertyName("NomMets");
                    jwriter.WriteValue(mets.nom_mets);

                    jwriter.WritePropertyName("Prix");
                    jwriter.WriteValue(mets.prix);

                    jwriter.WritePropertyName("IdMets");
                    jwriter.WriteValue(mets.id_mets);

                    jwriter.WritePropertyName("Type");
                    jwriter.WriteValue(mets.type);

                    jwriter.WritePropertyName("Nationalité");
                    jwriter.WriteValue(mets.nationalité);

                    jwriter.WritePropertyName("RégimeAlimentaire");
                    jwriter.WriteValue(mets.régime_alimentaire);

                    jwriter.WritePropertyName("TelCuisinier");
                    jwriter.WriteValue(mets.tel_cuisinier);

                    jwriter.WritePropertyName("Quantité");
                    jwriter.WriteValue(mets.quantité);

                    jwriter.WritePropertyName("StationMétro");
                    jwriter.WriteValue(mets.station_métro);

                    jwriter.WriteEndObject();
                }
                jwriter.WriteEndArray();
            }
            MessageBox.Show("Mets enregistérs au format JSON");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chemin_fichier = "clients_LivInParis.json";
            using (StreamWriter sw = new StreamWriter(chemin_fichier))
            using (JsonTextWriter jwriter = new JsonTextWriter(sw))
            {
                jwriter.WriteStartArray();
                foreach (var client in clients)
                {
                    jwriter.WriteStartObject();

                    jwriter.WritePropertyName("Nom");
                    jwriter.WriteValue(client.Nom);

                    jwriter.WritePropertyName("Prenom");
                    jwriter.WriteValue(client.Prenom);

                    jwriter.WritePropertyName("Type");
                    jwriter.WriteValue(client.Type);

                    jwriter.WritePropertyName("IdentifiantClient");
                    jwriter.WriteValue(client.IdentifiantClient);

                    jwriter.WritePropertyName("MotDePasse");
                    jwriter.WriteValue(client.MotDePasse);

                    jwriter.WriteEndObject();
                }
                jwriter.WriteEndArray();
            }

            MessageBox.Show("Clients enregistrés au format JSON");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePageAdmin clientPage = new HomePageAdmin(mdp_admin, connexion);
            this.Close();
            clientPage.Show();
        }
    }
}

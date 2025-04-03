
create database projet_psi_2;
use projet_psi_2;

CREATE TABLE Client(
   Identifiant_client VARCHAR(50),
   Mot_de_passe VARCHAR(50),
   PRIMARY KEY(Identifiant_client)
);

CREATE TABLE Cuisinier(
   telephone_cuisinier DECIMAL(10,0),
   prenom_cuisinier VARCHAR(50),
   nom_cuisinier VARCHAR(50),
   adresse_cuisinier VARCHAR(50),
   mail_cuisinier VARCHAR(50),
   PRIMARY KEY(telephone_cuisinier)
);

CREATE TABLE Commande(
   numéro_commande INT,
   Identifiant_client VARCHAR(50) NOT NULL,
   telephone_cuisinier DECIMAL(10,0) NOT NULL,
   PRIMARY KEY(numéro_commande),
   FOREIGN KEY(Identifiant_client) REFERENCES Client(Identifiant_client),
   FOREIGN KEY(telephone_cuisinier) REFERENCES Cuisinier(telephone_cuisinier)
);

CREATE TABLE Particulier(
   numéro_tel_particulier DECIMAL(10,0),
   nom_particulier VARCHAR(50),
   prenom_particulier VARCHAR(50),
   adresse_particulier VARCHAR(50),
   Identifiant_client VARCHAR(50) NOT NULL,
   PRIMARY KEY(numéro_tel_particulier),
   UNIQUE(Identifiant_client),
   FOREIGN KEY(Identifiant_client) REFERENCES Client(Identifiant_client)
);

CREATE TABLE Entreprise(
   nom_entreprise VARCHAR(50),
   réferent VARCHAR(50),
   Identifiant_client VARCHAR(50) NOT NULL,
   PRIMARY KEY(nom_entreprise),
   UNIQUE(Identifiant_client),
   FOREIGN KEY(Identifiant_client) REFERENCES Client(Identifiant_client)
);

CREATE TABLE Livraison(
   id_livraison INT,
   arrivée VARCHAR(50),
   distance VARCHAR(50),
   départ VARCHAR(50),
   PRIMARY KEY(id_livraison)
);

CREATE TABLE Lignes_Commandes(
   numéro_sous_commandes INT,
   date_livraison DATE,
   adresse_livraison VARCHAR(50),
   régime_alimentaire VARCHAR(50),
   date_fabrication DATE,
   date_peremption DATE,
   nombre_personne INT,
   prix INT,
   type VARCHAR(50),
   nationalité VARCHAR(50),
   id_livraison INT,
   numéro_commande INT,
   PRIMARY KEY(numéro_sous_commandes),
   FOREIGN KEY(id_livraison) REFERENCES Livraison(id_livraison),
   FOREIGN KEY(numéro_commande) REFERENCES Commande(numéro_commande)
);

CREATE TABLE Ingrédients(
   ingredient VARCHAR(50),
   quantité VARCHAR(50),
   numéro_sous_commandes INT,
   PRIMARY KEY(numéro_sous_commandes,ingredient),
   FOREIGN KEY(numéro_sous_commandes) REFERENCES Lignes_Commandes(numéro_sous_commandes)
);

CREATE TABLE note(
   Identifiant_client VARCHAR(50),
   telephone_cuisinier DECIMAL(10,0),
   note DECIMAL(2,1),
   avis VARCHAR(50),
   PRIMARY KEY(Identifiant_client, telephone_cuisinier),
   FOREIGN KEY(Identifiant_client) REFERENCES Client(Identifiant_client),
   FOREIGN KEY(telephone_cuisinier) REFERENCES Cuisinier(telephone_cuisinier)
);




 SELECT nom_particulier,prenom_particulier
 FROM Particulier;

SELECT Identifiant_client
FROM Client ;

SELECT prix
FROM Lignes_Commandes;

SELECT * FROM Livraison ;

SELECT telephone_cuisinier
FROM Cuisinier;

SELECT date_fabrication,date_peremption
FROM Lignes_Commandes;

SELECT ingredient
FROM Ingrédients
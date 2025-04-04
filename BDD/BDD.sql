CREATE DATABASE  IF NOT EXISTS `projet_psi_2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `projet_psi_2`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: projet_psi_2
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `Identifiant_client` varchar(50) NOT NULL,
  `Mot_de_passe` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Identifiant_client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES ('client1','password1'),('client10','password10'),('client11','password11'),('client12','password12'),('client13','password13'),('client14','password14'),('client15','password15'),('client16','password16'),('client17','password17'),('client18','password18'),('client19','password19'),('client2','password2'),('client20','password20'),('client21','password21'),('client3','password3'),('client4','password4'),('client5','password5'),('client6','password6'),('client7','password7'),('client8','password8'),('client9','password9'),('yanisssou','psg ');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `commande`
--

DROP TABLE IF EXISTS `commande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commande` (
  `numéro_commande` int NOT NULL,
  `Identifiant_client` varchar(50) NOT NULL,
  `telephone_cuisinier` decimal(10,0) NOT NULL,
  PRIMARY KEY (`numéro_commande`),
  KEY `Identifiant_client` (`Identifiant_client`),
  KEY `telephone_cuisinier` (`telephone_cuisinier`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`Identifiant_client`) REFERENCES `client` (`Identifiant_client`),
  CONSTRAINT `commande_ibfk_2` FOREIGN KEY (`telephone_cuisinier`) REFERENCES `cuisinier` (`telephone_cuisinier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commande`
--

LOCK TABLES `commande` WRITE;
/*!40000 ALTER TABLE `commande` DISABLE KEYS */;
INSERT INTO `commande` VALUES (1,'client1',1),(2,'client2',2),(3,'client3',3),(4,'client4',4),(5,'client5',5),(6,'client6',6),(7,'client7',7),(8,'client8',8),(9,'client9',9),(10,'client10',10);
/*!40000 ALTER TABLE `commande` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuisinier`
--

DROP TABLE IF EXISTS `cuisinier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuisinier` (
  `telephone_cuisinier` decimal(10,0) NOT NULL,
  `prenom_cuisinier` varchar(50) DEFAULT NULL,
  `nom_cuisinier` varchar(50) DEFAULT NULL,
  `adresse_cuisinier` varchar(50) DEFAULT NULL,
  `mail_cuisinier` varchar(50) DEFAULT NULL,
  `station_métro` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`telephone_cuisinier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuisinier`
--

LOCK TABLES `cuisinier` WRITE;
/*!40000 ALTER TABLE `cuisinier` DISABLE KEYS */;
INSERT INTO `cuisinier` VALUES (1,'Marie','Dupond','30 Rue de la République 75011','Mdupond@gmail.com','Voltaire'),(2,'Jean','Martin','12 Avenue des Champs 75008','jmartin@gmail.com','Richelieu - Drouot'),(3,'Sophie','Lemoine','5 Place de la Concorde 75001','slemoine@gmail.com','Quatre Septembre'),(4,'Paul','Durand','18 Boulevard Haussmann 75009','pdurand@gmail.com','Franklin D. Roosevelt'),(5,'Lucie','Morel','45 Rue Lafayette 75010','lmorel@gmail.com','Michel Bizot'),(6,'Thomas','Bertrand','22 Rue Saint-Honoré 75001','tbertrand@gmail.com','Opéra'),(7,'Camille','Dubois','9 Avenue Montaigne 75008','cdubois@gmail.com','Bastille'),(8,'Nicolas','Fontaine','37 Rue de Rivoli 75004','nfontaine@gmail.com','Saint-Georges'),(9,'Emma','Blanc','14 Rue des Rosiers 75004','eblanc@gmail.com','Michel Bizot'),(10,'Alexandre','Renard','3 Boulevard Saint-Michel 75005','arenard@gmail.com','Chaussée d’Antin - La Fayette');
/*!40000 ALTER TABLE `cuisinier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entreprise`
--

DROP TABLE IF EXISTS `entreprise`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entreprise` (
  `nom_entreprise` varchar(50) NOT NULL,
  `réferent` varchar(50) DEFAULT NULL,
  `Identifiant_client` varchar(50) NOT NULL,
  PRIMARY KEY (`nom_entreprise`),
  UNIQUE KEY `Identifiant_client` (`Identifiant_client`),
  CONSTRAINT `entreprise_ibfk_1` FOREIGN KEY (`Identifiant_client`) REFERENCES `client` (`Identifiant_client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entreprise`
--

LOCK TABLES `entreprise` WRITE;
/*!40000 ALTER TABLE `entreprise` DISABLE KEYS */;
/*!40000 ALTER TABLE `entreprise` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ingrédients`
--

DROP TABLE IF EXISTS `ingrédients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ingrédients` (
  `ingredient` varchar(50) NOT NULL,
  `quantité` varchar(50) DEFAULT NULL,
  `numéro_sous_commandes` varchar(50) NOT NULL,
  PRIMARY KEY (`numéro_sous_commandes`,`ingredient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingrédients`
--

LOCK TABLES `ingrédients` WRITE;
/*!40000 ALTER TABLE `ingrédients` DISABLE KEYS */;
INSERT INTO `ingrédients` VALUES ('cornichon','3pièces','1'),('jambon ','200g','1'),('pommes_de_terre','200g','1'),('raclette fromage','250g','1'),('fraise','100g','2'),('kiwi','100g','2'),('sucre','10g','2');
/*!40000 ALTER TABLE `ingrédients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lignes_commandes`
--

DROP TABLE IF EXISTS `lignes_commandes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lignes_commandes` (
  `numéro_commande` int NOT NULL,
  `numéro_sous_commandes` varchar(50) NOT NULL,
  `date_livraison` date DEFAULT NULL,
  `adresse_livraison` varchar(50) DEFAULT NULL,
  `régime_alimentaire` varchar(50) DEFAULT NULL,
  `date_fabrication` date DEFAULT NULL,
  `date_peremption` date DEFAULT NULL,
  `nombre_personne` int DEFAULT NULL,
  `prix` int DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `nom_du_mets` varchar(50) DEFAULT NULL,
  `nationalité` varchar(50) DEFAULT NULL,
  `id_livraison` int DEFAULT NULL,
  PRIMARY KEY (`numéro_commande`,`numéro_sous_commandes`),
  KEY `id_livraison` (`id_livraison`),
  KEY `idx_numero_sous_commandes` (`numéro_sous_commandes`),
  CONSTRAINT `lignes_commandes_ibfk_1` FOREIGN KEY (`id_livraison`) REFERENCES `livraison` (`id_livraison`),
  CONSTRAINT `lignes_commandes_ibfk_2` FOREIGN KEY (`numéro_commande`) REFERENCES `commande` (`numéro_commande`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lignes_commandes`
--

LOCK TABLES `lignes_commandes` WRITE;
/*!40000 ALTER TABLE `lignes_commandes` DISABLE KEYS */;
INSERT INTO `lignes_commandes` VALUES (1,'1',NULL,NULL,'Végétarien','2025-01-10','2025-01-15',6,5,'Dessert','Tarte aux fraises','Indifférent',1),(2,'1',NULL,NULL,'Végétarien','2025-02-10','2025-02-15',4,15,'Plat','Bœuf bourguignon','Française',2),(2,'2',NULL,NULL,'','2025-02-10','2025-02-15',4,8,'Entrée','Soupe de lentilles','Indienne',2),(3,'1',NULL,NULL,'Non spécifié','2025-03-01','2025-03-05',2,12,'Plat','Lasagnes','Italienne',3),(3,'2',NULL,NULL,'Sans gluten','2025-03-01','2025-03-05',2,6,'Dessert','Beignets à la crème','Chinoise',3),(4,'1',NULL,NULL,'Végétarien','2025-04-05','2025-04-10',3,25,'Plat','Tacos au poulet','Mexicaine',4),(4,'2',NULL,NULL,'','2025-04-05','2025-04-10',3,10,'Dessert','Crème catalane','Espagnole',4),(5,'1',NULL,NULL,'','2025-05-10','2025-05-15',6,20,'Plat','Coq au vin','Française',5),(5,'2',NULL,NULL,'Sans lactose','2025-05-10','2025-05-15',6,12,'Entrée','Salade César','Américaine',5),(6,'1',NULL,NULL,'','2025-06-01','2025-06-05',8,18,'Plat','Risotto aux champignons','Italienne',6),(6,'2',NULL,NULL,'','2025-06-01','2025-06-05',8,5,'Dessert','Pudding au caramel','Anglaise',6),(7,'1',NULL,NULL,'Végétarien','2025-07-15','2025-07-20',5,14,'Plat','Curry de légumes','Indienne',7),(7,'2',NULL,NULL,'','2025-07-15','2025-07-20',5,7,'Entrée','Nachos au fromage','Mexicaine',7),(8,'1',NULL,NULL,'Végétarien','2025-08-10','2025-08-15',3,22,'Plat','Gratin dauphinois','Française',8),(8,'2',NULL,NULL,'','2025-08-10','2025-08-15',3,9,'Dessert','Nougat chinois','Chinoise',8),(9,'1',NULL,NULL,'','2025-09-01','2025-09-05',4,30,'Plat','Pizza Margherita','Italienne',9),(9,'2',NULL,NULL,'','2025-09-01','2025-09-05',4,15,'Entrée','Samosas','Indienne',9),(10,'1',NULL,NULL,'Végétarien','2025-10-20','2025-10-25',2,10,'Plat','Paella','Espagnole',10),(10,'2',NULL,NULL,'Sans gluten','2025-10-20','2025-10-25',2,5,'Dessert','Scones','Anglaise',10);
/*!40000 ALTER TABLE `lignes_commandes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livraison`
--

DROP TABLE IF EXISTS `livraison`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livraison` (
  `id_livraison` int NOT NULL,
  `arrivée` varchar(50) DEFAULT NULL,
  `distance` varchar(50) DEFAULT NULL,
  `départ` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_livraison`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livraison`
--

LOCK TABLES `livraison` WRITE;
/*!40000 ALTER TABLE `livraison` DISABLE KEYS */;
INSERT INTO `livraison` VALUES (1,'Rue Cardinet 15, 75017','10km','30 Rue de la République 75011'),(2,'Boulevard Haussmann 75009','8km','12 Avenue des Champs 75008'),(3,'Rue de Rivoli 75004','12km','5 Place de la Concorde 75001'),(4,'Rue Saint-Honoré 75001','6km','18 Boulevard Haussmann 75009'),(5,'Avenue Montaigne 75008','15km','45 Rue Lafayette 75010'),(6,'Rue des Rosiers 75004','9km','22 Rue Saint-Honoré 75001'),(7,'Boulevard Saint-Michel 75005','11km','9 Avenue Montaigne 75008'),(8,'Rue Cardinet 15, 75017','7km','37 Rue de Rivoli 75004'),(9,'Rue de la Paix 75002','13km','14 Rue des Rosiers 75004'),(10,'Avenue Victor Hugo 75016','10km','3 Boulevard Saint-Michel 75005');
/*!40000 ALTER TABLE `livraison` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mets`
--

DROP TABLE IF EXISTS `mets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mets` (
  `id_mets` int NOT NULL AUTO_INCREMENT,
  `nom_mets` varchar(100) NOT NULL,
  `type` varchar(50) NOT NULL,
  `nationalité` varchar(50) DEFAULT NULL,
  `régime_alimentaire` varchar(50) DEFAULT NULL,
  `prix` decimal(10,2) NOT NULL,
  `telephone_cuisinier` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`id_mets`),
  KEY `mets_ibfk_1` (`telephone_cuisinier`),
  CONSTRAINT `mets_ibfk_1` FOREIGN KEY (`telephone_cuisinier`) REFERENCES `cuisinier` (`telephone_cuisinier`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mets`
--

LOCK TABLES `mets` WRITE;
/*!40000 ALTER TABLE `mets` DISABLE KEYS */;
INSERT INTO `mets` VALUES (20,'Tarte aux fraises','Dessert','Française','Végétarien',5.00,1),(21,'Bœuf bourguignon','Plat','Française','Non spécifié',15.00,2),(22,'Soupe de lentilles','Entrée','Indienne','Non spécifié',8.00,2),(23,'Lasagnes','Plat','Italienne','Non spécifié',12.00,3),(24,'Beignets à la crème','Dessert','Chinoise','Sans gluten',6.00,3),(25,'Tacos au poulet','Plat','Mexicaine','Non spécifié',25.00,4),(26,'Crème catalane','Dessert','Espagnole','Non spécifié',10.00,4),(27,'Coq au vin','Plat','Française','Non spécifié',20.00,5),(28,'Salade César','Entrée','Américaine','Sans lactose',12.00,5),(29,'Risotto aux champignons','Plat','Italienne','Non spécifié',18.00,6),(30,'Pudding au caramel','Dessert','Anglaise','Non spécifié',5.00,6),(31,'Curry de légumes','Plat','Indienne','Végétarien',14.00,7),(32,'Nachos au fromage','Entrée','Mexicaine','Non spécifié',7.00,7),(33,'Gratin dauphinois','Plat','Française','Végétarien',22.00,8),(34,'Nougat chinois','Dessert','Chinoise','Non spécifié',9.00,8),(35,'Pizza Margherita','Plat','Italienne','Végétarien',30.00,9),(36,'Samosas','Entrée','Indienne','Non spécifié',15.00,9),(37,'Paella','Plat','Espagnole','Végétarien',10.00,10),(38,'Scones','Dessert','Anglaise','Sans gluten',5.00,10);
/*!40000 ALTER TABLE `mets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `note`
--

DROP TABLE IF EXISTS `note`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `note` (
  `Identifiant_client` varchar(50) NOT NULL,
  `telephone_cuisinier` decimal(10,0) NOT NULL,
  `note` decimal(2,1) DEFAULT NULL,
  `avis` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Identifiant_client`,`telephone_cuisinier`),
  KEY `telephone_cuisinier` (`telephone_cuisinier`),
  CONSTRAINT `note_ibfk_1` FOREIGN KEY (`Identifiant_client`) REFERENCES `client` (`Identifiant_client`),
  CONSTRAINT `note_ibfk_2` FOREIGN KEY (`telephone_cuisinier`) REFERENCES `cuisinier` (`telephone_cuisinier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `note`
--

LOCK TABLES `note` WRITE;
/*!40000 ALTER TABLE `note` DISABLE KEYS */;
/*!40000 ALTER TABLE `note` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `particulier`
--

DROP TABLE IF EXISTS `particulier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `particulier` (
  `numéro_tel_particulier` decimal(10,0) NOT NULL,
  `nom_particulier` varchar(50) DEFAULT NULL,
  `prenom_particulier` varchar(50) DEFAULT NULL,
  `adresse_particulier` varchar(50) DEFAULT NULL,
  `Identifiant_client` varchar(50) NOT NULL,
  PRIMARY KEY (`numéro_tel_particulier`),
  UNIQUE KEY `Identifiant_client` (`Identifiant_client`),
  CONSTRAINT `particulier_ibfk_1` FOREIGN KEY (`Identifiant_client`) REFERENCES `client` (`Identifiant_client`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `particulier`
--

LOCK TABLES `particulier` WRITE;
/*!40000 ALTER TABLE `particulier` DISABLE KEYS */;
INSERT INTO `particulier` VALUES (1,'Durand','Medhy','Rue Cardinet 15, 75017','client1'),(2,'Martin','Sophie','Avenue de la République 34, 75011','client2'),(3,'Bernard','Lucas','Rue de Rivoli 120, 75004','client3'),(4,'Dubois','Emma','Boulevard Haussmann 90, 75008','client4'),(5,'Thomas','Léo','Place de Clichy 7, 75018','client5'),(6,'Robert','Chloé','Rue Lafayette 55, 75009','client6'),(7,'Richard','Noah','Quai de la Gare 20, 75013','client7'),(8,'Petit','Manon','Avenue des Champs-Élysées 101, 75008','client8'),(9,'Lefevre','Nathan','Rue du Faubourg Saint-Honoré 45, 75008','client9'),(10,'Lemoine','Camille','Boulevard Voltaire 200, 75011','client10'),(11,'Moreau','Louis','Avenue Montaigne 15, 75008','client11'),(12,'Simon','Sarah','Rue Saint-Antoine 67, 75004','client12'),(13,'Laurent','Gabriel','Rue de Rennes 88, 75006','client13'),(14,'Leroy','Jade','Boulevard Saint-Michel 19, 75005','client14'),(15,'Bertrand','Adam','Rue de la Pompe 30, 75016','client15'),(16,'Roux','Inès','Avenue Victor Hugo 75, 75016','client16'),(17,'Fontaine','Hugo','Rue Mouffetard 110, 75005','client17'),(18,'David','Eva','Boulevard de la Villette 21, 75019','client18'),(19,'Girard','Tom','Place de la Bastille 10, 75004','client19'),(20,'Denis','Lina','Avenue Ledru-Rollin 56, 75011','client20'),(78236589,'rr\'r','\'rr','r\'\'r','yanisssou');
/*!40000 ALTER TABLE `particulier` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-04 15:47:36

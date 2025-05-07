CREATE DATABASE  IF NOT EXISTS `projet_psi_2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `projet_psi_2`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: projet_psi_2
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
INSERT INTO `client` VALUES ('058904023','password'),('client','password'),('client 1','password1'),('client1','password'),('client2','password'),('client3','password'),('durand','password'),('ferrari','password'),('francesco','password'),('gigi','password'),('jean','password'),('jessica','password'),('laura','password'),('lewis','password'),('marie','password'),('mattis','password'),('max','password'),('michelle','password'),('phillipe','password'),('remi','password'),('saajith','password'),('sergio','password'),('tibo','password'),('tom','password'),('yann','password');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `commande`
--

DROP TABLE IF EXISTS `commande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commande` (
  `numéro_commande` int NOT NULL AUTO_INCREMENT,
  `Identifiant_client` varchar(50) NOT NULL,
  `telephone_cuisinier` decimal(10,0) NOT NULL,
  PRIMARY KEY (`numéro_commande`),
  KEY `Identifiant_client` (`Identifiant_client`),
  KEY `telephone_cuisinier` (`telephone_cuisinier`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`Identifiant_client`) REFERENCES `client` (`Identifiant_client`),
  CONSTRAINT `commande_ibfk_2` FOREIGN KEY (`telephone_cuisinier`) REFERENCES `cuisinier` (`telephone_cuisinier`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commande`
--

LOCK TABLES `commande` WRITE;
/*!40000 ALTER TABLE `commande` DISABLE KEYS */;
INSERT INTO `commande` VALUES (49,'client2',768012546),(50,'client3',668012748),(51,'client3',768012546),(52,'tom',67801458),(53,'tom',668012748),(54,'tibo',668012748),(55,'tibo',668012748),(56,'mattis',995959),(57,'mattis',668012748),(58,'mattis',768012546),(59,'tibo',995959),(60,'jean',995959),(61,'jean',668012748),(62,'jean',766801079),(63,'durand',995959),(64,'lewis',995959),(65,'lewis',668012748),(66,'lewis',949420205),(67,'michelle',9930201),(68,'michelle',768012546),(69,'michelle',949420205),(70,'gigi',995959),(71,'gigi',995959),(72,'gigi',9930201),(73,'gigi',38885859),(74,'gigi',768012546),(75,'gigi',768012546),(76,'gigi',949420205),(77,'gigi',949420205),(78,'sergio',20283),(79,'sergio',9930201),(80,'sergio',9930201),(81,'sergio',67801458),(82,'sergio',668012748),(83,'sergio',766801079),(84,'sergio',766801079),(85,'sergio',949420205),(86,'sergio',949420205),(87,'sergio',766801079),(88,'sergio',949420205),(89,'sergio',949420205),(90,'sergio',949420205),(91,'marie',20283),(92,'marie',9930201),(93,'marie',38885859),(94,'marie',766801079),(95,'marie',949420205),(96,'marie',949420205),(97,'laura',995959),(98,'laura',38885859),(99,'francesco',995959),(100,'francesco',9930201),(101,'francesco',38885859),(102,'yann',20283),(103,'yann',9930201),(104,'yann',9930201),(105,'yann',38885859),(106,'remi',20283),(107,'remi',995959),(108,'remi',9930201),(109,'client',20283),(110,'client',38885859);
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
INSERT INTO `cuisinier` VALUES (20283,'Jessica','Clough','3 vesper clough','jessica@yopamil.fr','Monceau'),(995959,'Saajith','Sivasubramaniam','3 rue de gare du Nord','saajith@example.com','Charles de Gaulle - Etoile'),(9930201,'philipe','Leduc','63 avenue du Maillot','leduc@gmail.fr','Villiers'),(38885859,'Marie','Durand','34 avenue de j\'ai pas d\'idée','marite.durand@gmail.com','Ternes'),(67801458,'Enzo','Sierra Guisset','3 rue de Châtelet','enzo.sierra@example.com','Reuilly - Diderot'),(668012748,'Taibi','Yanis','3 rue de Puteaux','yanis.taibi@example.com','Bastille'),(766801079,'mattis','cesa','32 rue du cesa','cesa@mattis.fr','Nation'),(768012546,'Simeon','Simeonov','43 avenue du roule','sim.simeonov09@gmail.com','Porte Maillot'),(949420205,'Charles','Leclerc','34 rue de monaco','charles@ferrari.f1','Château de Vincennes');
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
  `numéro_sous_commandes` int NOT NULL AUTO_INCREMENT,
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
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lignes_commandes`
--

LOCK TABLES `lignes_commandes` WRITE;
/*!40000 ALTER TABLE `lignes_commandes` DISABLE KEYS */;
INSERT INTO `lignes_commandes` VALUES (49,23,'2025-05-07','Gare de Lyon','omnivore',NULL,NULL,NULL,11,'Plat','Pizza Regina','italien',NULL),(50,24,'2025-05-07','George V','Omnivore',NULL,NULL,NULL,15,'Plat','Tajine','Marocain',NULL),(51,25,'2025-05-07','Argentine','Carnivore',NULL,NULL,NULL,8,'Plat','Boulettes de viande','Bulgare',NULL),(52,26,'2025-05-07','Courcelles','Carnivore',NULL,NULL,NULL,19,'Plat','Coq au vin','Français',NULL),(53,27,'2025-05-07','Bastille','Omnivore',NULL,NULL,NULL,15,'Plat','Tajine','Marocain',NULL),(54,28,'2025-05-07','Victor Hugo','Omnivore',NULL,NULL,NULL,15,'Plat','Tajine','Marocain',NULL),(55,29,'2025-05-07','Victor Hugo','Végétarien',NULL,NULL,NULL,12,'Entrée','Tomate Mozzarella','Italien',NULL),(56,30,'2025-05-07','Ternes','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(57,31,'2025-05-07','Ternes','Végétarien',NULL,NULL,NULL,12,'Entrée','Tomate Mozzarella','Italien',NULL),(58,32,'2025-05-07','Ternes','Carnivore',NULL,NULL,NULL,8,'Plat','Boulettes de viande','Bulgare',NULL),(59,33,'2025-05-07','Alexandre Dumas','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(60,34,'2025-05-07','Château de Vincennes','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(61,35,'2025-05-07','Château de Vincennes','Omnivore',NULL,NULL,NULL,15,'Plat','Tajine','Marocain',NULL),(62,36,'2025-05-07','Château de Vincennes','Végétalien',NULL,NULL,NULL,10,'Entrée','Carrotes Houmous','Français',NULL),(63,37,'2025-05-07','Hôtel de Ville','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(64,38,'2025-05-07','Louvre - Rivoli','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(65,39,'2025-05-07','Louvre - Rivoli','Végétarien',NULL,NULL,NULL,12,'Entrée','Tomate Mozzarella','Italien',NULL),(66,40,'2025-05-07','Louvre - Rivoli','Végé',NULL,NULL,NULL,6,'dessert','Flan','Français',NULL),(67,41,'2025-05-07','Saint-Paul (Le Marais)','Carnivore',NULL,NULL,NULL,12,'Plat','Pizza Reine','Italien',NULL),(68,42,'2025-05-07','Saint-Paul (Le Marais)','Carnivore',NULL,NULL,NULL,8,'Plat','Boulettes de viande','Bulgare',NULL),(69,43,'2025-05-07','Saint-Paul (Le Marais)','Végé',NULL,NULL,NULL,6,'dessert','Flan','Français',NULL),(70,44,'2025-05-07','Saint-Paul (Le Marais)','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(71,45,'2025-05-07','Saint-Paul (Le Marais)','Végétarien',NULL,NULL,NULL,10,'Entrée','Soupe aux legumes','Français',NULL),(72,46,'2025-05-07','Saint-Paul (Le Marais)','Omnivore',NULL,NULL,NULL,12,'Dessert','Tiramisu','Italien',NULL),(73,47,'2025-05-07','Saint-Paul (Le Marais)','végétalien',NULL,NULL,NULL,6,'Entrée','Frites','Belge',NULL),(74,48,'2025-05-07','Saint-Paul (Le Marais)','omnivore',NULL,NULL,NULL,11,'Plat','Pizza Regina','italien',NULL),(75,49,'2025-05-07','Saint-Paul (Le Marais)','Carnivore',NULL,NULL,NULL,8,'Plat','Boulettes de viande','Bulgare',NULL),(76,50,'2025-05-07','Saint-Paul (Le Marais)','Végétalien',NULL,NULL,NULL,12,'Plat','Couscous','Marocaine',NULL),(77,51,'2025-05-07','Saint-Paul (Le Marais)','Végé',NULL,NULL,NULL,6,'dessert','Flan','Français',NULL),(78,52,'2025-05-07','Saint-Paul (Le Marais)','Omnivore',NULL,NULL,NULL,12,'Plat','Fich and Chips','Anglais',NULL),(79,53,'2025-05-07','Saint-Paul (Le Marais)','Carnivore',NULL,NULL,NULL,12,'Plat','Pizza Reine','Italien',NULL),(80,54,'2025-05-07','Saint-Paul (Le Marais)','Omnivore',NULL,NULL,NULL,12,'Dessert','Tiramisu','Italien',NULL),(81,55,'2025-05-07','Saint-Paul (Le Marais)','Carnivore',NULL,NULL,NULL,19,'Plat','Coq au vin','Français',NULL),(82,56,'2025-05-07','Saint-Paul (Le Marais)','Végétarien',NULL,NULL,NULL,12,'Entrée','Tomate Mozzarella','Italien',NULL),(83,57,'2025-05-07','Saint-Paul (Le Marais)','Omnivore',NULL,NULL,NULL,11,'Plat','Spagethi','Italien',NULL),(84,58,'2025-05-07','Saint-Paul (Le Marais)','Végétalien',NULL,NULL,NULL,10,'Entrée','Carrotes Houmous','Français',NULL),(85,59,'2025-05-07','Saint-Paul (Le Marais)','Végétalien',NULL,NULL,NULL,11,'Plat','Quiche Loraine','Française',NULL),(86,60,'2025-05-07','Saint-Paul (Le Marais)','Végé',NULL,NULL,NULL,6,'dessert','Flan','Français',NULL),(87,61,'2025-05-07','Reuilly - Diderot','Omnivore',NULL,NULL,NULL,11,'Plat','Spagethi','Italien',NULL),(88,62,'2025-05-07','Reuilly - Diderot','Carnivore',NULL,NULL,NULL,11,'Plat','Pates Carbonara','italien',NULL),(89,63,'2025-05-07','Reuilly - Diderot','Végétalien',NULL,NULL,NULL,12,'Plat','Couscous','Marocaine',NULL),(90,64,'2025-05-07','Reuilly - Diderot','Végé',NULL,NULL,NULL,6,'dessert','Flan','Français',NULL),(91,65,'2025-05-07','Gare de Lyon','Omnivore',NULL,NULL,NULL,12,'Plat','Fich and Chips','Anglais',NULL),(92,66,'2025-05-07','Gare de Lyon','Omnivore',NULL,NULL,NULL,12,'Dessert','Tiramisu','Italien',NULL),(93,67,'2025-05-07','Gare de Lyon','végétalien',NULL,NULL,NULL,6,'Entrée','Frites','Belge',NULL),(94,68,'2025-05-07','Gare de Lyon','Végétalien',NULL,NULL,NULL,10,'Entrée','Carrotes Houmous','Français',NULL),(95,69,'2025-05-07','Gare de Lyon','Carnivore',NULL,NULL,NULL,11,'Plat','Pates Carbonara','italien',NULL),(96,70,'2025-05-07','Gare de Lyon','Végé',NULL,NULL,NULL,6,'dessert','Flan','Français',NULL),(97,71,'2025-05-07','Bastille','Carnivore',NULL,NULL,NULL,11,'Plat','Fajitas','Mexicaine',NULL),(98,72,'2025-05-07','Bastille','végétalien',NULL,NULL,NULL,6,'Entrée','Frites','Belge',NULL),(99,73,'2025-05-07','Gare de Lyon','Végétarien',NULL,NULL,NULL,10,'Entrée','Soupe aux legumes','Français',NULL),(100,74,'2025-05-07','Gare de Lyon','Carnivore',NULL,NULL,NULL,12,'Plat','Pizza Reine','Italien',NULL),(101,75,'2025-05-07','Gare de Lyon','végétalien',NULL,NULL,NULL,6,'Entrée','Frites','Belge',NULL),(102,76,'2025-05-07','Hôtel de Ville','Omnivore',NULL,NULL,NULL,12,'Plat','Fich and Chips','Anglais',NULL),(103,77,'2025-05-07','Hôtel de Ville','Carnivore',NULL,NULL,NULL,12,'Plat','Pizza Reine','Italien',NULL),(104,78,'2025-05-07','Hôtel de Ville','Omnivore',NULL,NULL,NULL,12,'Dessert','Tiramisu','Italien',NULL),(105,79,'2025-05-07','Hôtel de Ville','végétalien',NULL,NULL,NULL,6,'Entrée','Frites','Belge',NULL),(106,80,'2025-05-07','Louvre - Rivoli','Omnivore',NULL,NULL,NULL,12,'Plat','Fich and Chips','Anglais',NULL),(107,81,'2025-05-07','Louvre - Rivoli','Végétarien',NULL,NULL,NULL,10,'Entrée','Soupe aux legumes','Français',NULL),(108,82,'2025-05-07','Louvre - Rivoli','Carnivore',NULL,NULL,NULL,12,'Plat','Pizza Reine','Italien',NULL),(109,83,'2025-05-07','Châtelet','Omnivore',NULL,NULL,NULL,12,'Plat','Fich and Chips','Anglais',NULL),(110,84,'2025-05-07','Châtelet','végétalien',NULL,NULL,NULL,6,'Entrée','Frites','Belge',NULL);
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
INSERT INTO `livraison` VALUES (1000123,'Gare de Lyon',NULL,'Porte Maillot'),(1000124,'George V',NULL,'Bastille'),(1000125,'Argentine',NULL,'Porte Maillot'),(1000126,'Courcelles',NULL,'Reuilly - Diderot'),(1000127,'Bastille',NULL,'Bastille'),(1000128,'Victor Hugo',NULL,'Bastille'),(1000129,'Victor Hugo',NULL,'Bastille'),(1000130,'Ternes',NULL,'Charles de Gaulle - Etoile'),(1000131,'Ternes',NULL,'Bastille'),(1000132,'Ternes',NULL,'Porte Maillot'),(1000133,'Alexandre Dumas',NULL,'Charles de Gaulle - Etoile'),(1000134,'Château de Vincennes',NULL,'Charles de Gaulle - Etoile'),(1000135,'Château de Vincennes',NULL,'Bastille'),(1000136,'Château de Vincennes',NULL,'Nation'),(1000137,'Hôtel de Ville',NULL,'Charles de Gaulle - Etoile'),(1000138,'Louvre - Rivoli',NULL,'Charles de Gaulle - Etoile'),(1000139,'Louvre - Rivoli',NULL,'Bastille'),(1000140,'Louvre - Rivoli',NULL,'Château de Vincennes'),(1000141,'Saint-Paul (Le Marais)',NULL,'Villiers'),(1000142,'Saint-Paul (Le Marais)',NULL,'Porte Maillot'),(1000143,'Saint-Paul (Le Marais)',NULL,'Château de Vincennes'),(1000144,'Saint-Paul (Le Marais)',NULL,'Charles de Gaulle - Etoile'),(1000145,'Saint-Paul (Le Marais)',NULL,'Charles de Gaulle - Etoile'),(1000146,'Saint-Paul (Le Marais)',NULL,'Villiers'),(1000147,'Saint-Paul (Le Marais)',NULL,'Ternes'),(1000148,'Saint-Paul (Le Marais)',NULL,'Porte Maillot'),(1000149,'Saint-Paul (Le Marais)',NULL,'Porte Maillot'),(1000150,'Saint-Paul (Le Marais)',NULL,'Château de Vincennes'),(1000151,'Saint-Paul (Le Marais)',NULL,'Château de Vincennes'),(1000152,'Saint-Paul (Le Marais)',NULL,'Monceau'),(1000153,'Saint-Paul (Le Marais)',NULL,'Villiers'),(1000154,'Saint-Paul (Le Marais)',NULL,'Villiers'),(1000155,'Saint-Paul (Le Marais)',NULL,'Reuilly - Diderot'),(1000156,'Saint-Paul (Le Marais)',NULL,'Bastille'),(1000157,'Saint-Paul (Le Marais)',NULL,'Nation'),(1000158,'Saint-Paul (Le Marais)',NULL,'Nation'),(1000159,'Saint-Paul (Le Marais)',NULL,'Château de Vincennes'),(1000160,'Saint-Paul (Le Marais)',NULL,'Château de Vincennes'),(1000161,'Reuilly - Diderot',NULL,'Nation'),(1000162,'Reuilly - Diderot',NULL,'Château de Vincennes'),(1000163,'Reuilly - Diderot',NULL,'Château de Vincennes'),(1000164,'Reuilly - Diderot',NULL,'Château de Vincennes'),(1000165,'Gare de Lyon',NULL,'Monceau'),(1000166,'Gare de Lyon',NULL,'Villiers'),(1000167,'Gare de Lyon',NULL,'Ternes'),(1000168,'Gare de Lyon',NULL,'Nation'),(1000169,'Gare de Lyon',NULL,'Château de Vincennes'),(1000170,'Gare de Lyon',NULL,'Château de Vincennes'),(1000171,'Bastille',NULL,'Charles de Gaulle - Etoile'),(1000172,'Bastille',NULL,'Ternes'),(1000173,'Gare de Lyon',NULL,'Charles de Gaulle - Etoile'),(1000174,'Gare de Lyon',NULL,'Villiers'),(1000175,'Gare de Lyon',NULL,'Ternes'),(1000176,'Hôtel de Ville',NULL,'Monceau'),(1000177,'Hôtel de Ville',NULL,'Villiers'),(1000178,'Hôtel de Ville',NULL,'Villiers'),(1000179,'Hôtel de Ville',NULL,'Ternes'),(1000180,'Louvre - Rivoli',NULL,'Monceau'),(1000181,'Louvre - Rivoli',NULL,'Charles de Gaulle - Etoile'),(1000182,'Louvre - Rivoli',NULL,'Villiers'),(1000183,'Châtelet',NULL,'Monceau'),(1000184,'Châtelet',NULL,'Ternes');
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
  `quantité` int DEFAULT '1',
  PRIMARY KEY (`id_mets`),
  KEY `mets_ibfk_1` (`telephone_cuisinier`),
  CONSTRAINT `mets_ibfk_1` FOREIGN KEY (`telephone_cuisinier`) REFERENCES `cuisinier` (`telephone_cuisinier`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mets`
--

LOCK TABLES `mets` WRITE;
/*!40000 ALTER TABLE `mets` DISABLE KEYS */;
INSERT INTO `mets` VALUES (49,'Pizza Regina','Plat','italien','omnivore',11.00,768012546,1),(50,'Boulettes de viande','Plat','Bulgare','Carnivore',8.00,768012546,1),(51,'Tajine','Plat','Marocain','Omnivore',15.00,668012748,1),(52,'Tomate Mozzarella','Entrée','Italien','Végétarien',12.00,668012748,6),(53,'Coq au vin','Plat','Français','Carnivore',19.00,67801458,2),(54,'Fajitas','Plat','Mexicaine','Carnivore',11.00,995959,3),(55,'Soupe aux legumes','Entrée','Français','Végétarien',10.00,995959,7),(56,'Burger','Plat','American','Carnivore',20.00,766801079,10),(57,'Spagethi','Plat','Italien','Omnivore',11.00,766801079,12),(58,'Sandwitch Végan','Plat','Français','Végan',8.00,766801079,20),(59,'Carrotes Houmous','Entrée','Français','Végétalien',10.00,766801079,9),(60,'Frites','Entrée','Belge','végétalien',6.00,38885859,94),(61,'Pates Carbonara','Plat','italien','Carnivore',11.00,949420205,10),(62,'Quiche Loraine','Plat','Française','Végétalien',11.00,949420205,11),(63,'Couscous','Plat','Marocaine','Végétalien',12.00,949420205,9),(64,'Flan','dessert','Français','Végé',6.00,949420205,6),(65,'Pizza Reine','Plat','Italien','Carnivore',12.00,9930201,7),(66,'Lasagne','Plat','Italien','Carnivore',12.00,9930201,11),(67,'Tiramisu','Dessert','Italien','Omnivore',12.00,9930201,8),(68,'Fich and Chips','Plat','Anglais','Omnivore',12.00,20283,7);
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
  `mail_particulier` varchar(50) DEFAULT 'defaut@;email.com',
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
INSERT INTO `particulier` VALUES (20283,'Clough','Jessica','3 vesper clough','jessica','jessica@yopamil.fr'),(303383,'De forêt','Giselle','32 avenue de la souris','gigi','gigi@gmail.com'),(505935,'Case','Yann','32 rue de la prepa','yann','yann.case@gmail.fr'),(995959,'Sivasubramaniam','Saajith','3 rue de gare du Nord','saajith','saajith@example.com'),(7560127,'Ringot','Tom','1 avenue de Boulogne','tom','tom.ringo@gmail.com'),(9930201,'Leduc','philipe','63 avenue du Maillot','phillipe','leduc@gmail.fr'),(29291383,'Hamilton','Lewis','32 boulevard de ferrari','lewis','hamilton@ferrari.fr'),(38885859,'Durand','Marie','34 avenue de j\'ai pas d\'idée','durand','marite.durand@gmail.com'),(58340482,'Speranza','francesco','32 rue de l\'italien','francesco','francesco@gmail.fr'),(59592424,'Bucheron','Michelle','32 rue du michelle','michelle','michelle@test.Fr'),(60583244,'Perez','Sergio','12 rue de la défaite','sergio','sergio@perez.fr'),(67801458,'Sierra Guisset','Enzo','3 rue de Châtelet','client3','enzo.sierra@example.com'),(75830203,'Henderson','Laura','0509224492','laura','laura@henderson.fr'),(83833933,'Duchene','remi','90 boulevard de Cimiez','remi','remi.duchennes@gmail.com'),(85580020,'Durand','Tibeau','35 rue de durand','tibo','tibo.durand@gmail.com'),(86940221,'Furret','Eleonore','32 rue de Nice','058904023','eleonore@gmail.fr'),(595900494,'Jeanne','Marine','32 rue de la marine','marie','marie@paris.fr'),(668012748,'Yanis','Taibi','3 rue de Puteaux','client2','yanis.taibi@example.com'),(696920819,'Gauché','Arthur','3 rue de gauché','client1','arthur.gauché@gmail.com'),(766801079,'cesa','mattis','32 rue du cesa','mattis','cesa@mattis.fr'),(768012546,'Simeonov','Simeon','43 avenue du roule','client 1','sim.simeonov09@gmail.com'),(768021840,'Jean','Sion','35 rue de esilv','jean','jean.sion@gmail.fr'),(850295811,'Verstappen','Max','36 rue des pays bas','max','max@verstappen'),(858502058,'Test','User','23 rue du test','client','testmail@gmail.com'),(949420205,'Leclerc','Charles','34 rue de monaco','ferrari','charles@ferrari.f1');
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

-- Dump completed on 2025-05-07 15:35:50

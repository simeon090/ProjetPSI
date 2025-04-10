# 📍 Projet Metro Paris – README

## 🛠️ 1. Installation

Ce projet nécessite **.NET 8.0**.

Après avoir cloné le dépôt via `git clone`, le projet peut être directement exécuté afin de tester la partie graphe dans la console.
Pour lancer la db et tester pleinement l'interface, executer le fichier BDD.sql dans le dossier ProjetPSI/BDD en localhost.
Puis dans le code modifier le mot de passe du root avec le votre : 

private string connectionString = "server=localhost;database=projet_psi_2;uid=root;pwd=MOT_DE_PASSE_A_MODIFIER;";

Nous sommes désolé mais il faut refaire cette procédure pour tous les fichiers suivants (Ceci sera modifié dans la prochaine version, pour le prochain rendu nous allons trouver une solution plus optimale)

AddNewClient.cs
ClientPage.cs
Connexion_user.cs
Créeruncompte.cs
CuisinierPage.cs
DeleteClient.cs
Panier.cs
Passer_commande.cs
UpdateClient.cs
**

## 📦 2. Dépendances

Ce projet utilise deux fichiers CSV indispensables au bon fonctionnement de l'application et des tests unitaires :

- `MetroParis_Arcs.csv`
- `MetroParis_Noeuds.csv`

> Ces fichiers doivent être placés dans le répertoire `bin/Debug` du projet.

### 🧩 Étapes pour générer le fichier `MetroParis_Arcs.csv` :

1. Lier chaque station avec les champs **"Précédent"** et **"Suivant"**.
2. Attribuer une valeur entière à la colonne **"Temps entre les stations"** pour chaque arc.
3. Attribuer une valeur entière à la colonne **"Temps de changement"** pour chaque arc.  
   ⚠️ Pour les stations sans correspondance, cette valeur ne sera **pas prise en compte**.
4. Définir un **"Statut"** pour chaque arc, indiquant s’il est actif ou non.
5. Préciser la **"Ligne_de_metro"** à laquelle chaque arc appartient.
6. Indiquer le **"Sens"** pour les cas à sens unique (notamment sur les lignes 10 et 7bis).
7. Exporter la page Arc du fichier Excel en CSV avec "Enregistrer Sous" Choisir l'option CSV séparateur ;
   
<img width="589" alt="image" src="https://github.com/user-attachments/assets/6d9bfa17-4550-4f9b-a158-ecd101a6630a" />

### 🧩 Étapes pour générer le fichier `MetroParis_Noeuds.csv` :

1. Exporter la page Noeud du fichier Excel en CSV avec "Enregistrer Sous" Choisir l'option CSV séparateur ;

---

## 📌 3. Particularités

Les choix techniques et les particularités du projet sont détaillés dans le document `rapport.pdf`.

---

## 👥 4. Informations utiles

**Identifiants clients pour l'interface :**

Identifiant: client1 
Mot de passe : password1

**Membres du groupe** :
- Yanis Taibi  
- Simeon Simeonov  
- Enzo Sierrat-Guisset  

**Groupe** : A2 – Groupe O

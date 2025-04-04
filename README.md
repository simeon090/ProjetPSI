# 📍 Projet Metro Paris – README

## 🛠️ 1. Installation

Ce projet nécessite **.NET 8.0**.

Après avoir cloné le dépôt via `git clone`, le projet peut être directement exécuté sans configuration supplémentaire.

---

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

---

## 📌 3. Particularités

Les choix techniques et les particularités du projet sont détaillés dans le document `rapport.pdf`.

---

## 👥 4. Informations utiles

**Membres du groupe** :
- Yanis Taibi  
- Simeon Simeonov  
- Enzo Sierrat-Guisset  

**Groupe** : A2 – Groupe O

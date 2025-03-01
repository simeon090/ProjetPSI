INSERT INTO Client (Identifiant_client, Mot_de_passe) VALUES ('client1', 'password1');

INSERT INTO Particulier (numéro_tel_particulier, nom_particulier, prenom_particulier, adresse_particulier, Identifiant_client)
VALUES (1, 'Durand', 'Medhy', 'Rue Cardinet 15, 75017', 'client1');

INSERT INTO Cuisinier (telephone_cuisinier,prenom_cuisinier,nom_cuisinier,adresse_cuisinier,mail_cuisinier)
VALUES (1,'Marie','Dupond','30 Rue de la République 75011','Mdupond@gmail.com');

INSERT INTO Livraison (id_livraison, départ, distance, arrivée)
VALUES (1, '30 Rue de la République 75011', '10km', 'Rue Cardinet 15, 75017');

INSERT INTO Commande (numéro_commande, Identifiant_client, telephone_cuisinier)
VALUES (1, 'client1', 1);


INSERT INTO Lignes_Commandes(numéro_commande, numéro_sous_commandes, prix, type, nombre_personne, nationalité, régime_alimentaire, date_fabrication, date_peremption,id_livraison)
VALUES
(1, 01, 10, 'Plat', 6, 'Francaise', '', '2025-01-10', '2025-01-15',1),
(1, 02, 5, 'Dessert', 6, 'Indifférent', 'Végétarien', '2025-01-10', '2025-01-15',1);





INSERT INTO Ingrédients (numéro_sous_commandes, ingredient, quantité)
VALUES (01, 'raclette fromage', '250g'),
       (01, 'pommes_de_terre', '200g'),
       (01, 'jambon ','200g'),
       (01,'cornichon','3pièces'),
       (02,'fraise','100g'),
       (02,'kiwi','100g'),
       (02,'sucre','10g');
       
       

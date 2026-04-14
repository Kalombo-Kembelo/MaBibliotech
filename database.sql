CREATE DATABASE smartlibrary;
USE smartlibrary;

CREATE TABLE Livre (
    id_livre INT AUTO_INCREMENT PRIMARY KEY,
    titre VARCHAR(100),
    auteur VARCHAR(100),
    disponible BOOLEAN
);

CREATE TABLE Abonne (
    id_abonne INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(100),
    prenom VARCHAR(100)
);

CREATE TABLE Emprunt (
    id_emprunt INT AUTO_INCREMENT PRIMARY KEY,
    date_emprunt DATETIME,
    id_abonne INT,
    id_livre INT,
    FOREIGN KEY (id_abonne) REFERENCES Abonne(id_abonne),
    FOREIGN KEY (id_livre) REFERENCES Livre(id_livre)
);

CREATE TABLE Retour (
    id_retour INT AUTO_INCREMENT PRIMARY KEY,
    date_retour DATETIME,
    id_emprunt INT,
    FOREIGN KEY (id_emprunt) REFERENCES Emprunt(id_emprunt)
);

CREATE TABLE Penalite (
    id_penalite INT AUTO_INCREMENT PRIMARY KEY,
    montant DOUBLE,
    id_retour INT,
    FOREIGN KEY (id_retour) REFERENCES Retour(id_retour)
);

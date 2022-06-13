create database cegep
use cegep

create table etudiant(
id_etudiant int primary key identity,
prenom varchar (50),
nom varchar (50),
moyenne int,
programme varchar (50)
);

insert into etudiant (prenom,nom,moyenne,programme) values ('Alexandre', 'Tremblay', 72, 'Informatique')
insert into etudiant (prenom,nom,moyenne,programme) values ('Marc', 'Dufour', 57, 'Informatique')
insert into etudiant (prenom,nom,moyenne,programme) values ('Marie', 'Cordonier', 97, 'Informatique')
insert into etudiant (prenom,nom,moyenne,programme) values ('Justin', 'Dumont', 87, 'Informatique')
insert into etudiant (prenom,nom,moyenne,programme) values ('Sophie', 'Plouffe', 89, 'Enseignement')
insert into etudiant (prenom,nom,moyenne,programme) values ('Mathieu', 'Rodriguez', 81, 'Enseignement')
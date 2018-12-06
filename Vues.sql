--TP final
--
--Vincent Falardeau
--Emile Menard
--
--Vues

--1
create view vue_prix_circuit as
select idcircuit, sum(m.prix) as prix from circuitsmonuments cm 
inner join monuments m on m.idmonument = cm.idmonument
group by cm.idcircuit;

create view vue_circuit_2 as
select c.nomcircuit as nom, 
v.nomville as depart, 
v2.nomville as arrivee, 
cm.prix from vue_prix_circuit cm 
inner join circuits c on c.idcircuit = cm.idcircuit
inner join villes v on c.codevilledépart = v.codeville
inner join villes v2 on c.codevillearrivée = v2.codeville;

--2
create view vue_prix_circuit_2 as
select idcircuit, sum(m.prix) as prix from circuitsmonuments cm 
inner join monuments m on m.idmonument = cm.idmonument
group by cm.idcircuit;

create view vue_circuit_3 as
select m2.nom as nom_monument,
c.nomcircuit as nom, 
v.nomville as depart, 
v2.nomville as arrivee, 
cm.prix as prix from vue_prix_circuit_2 cm 
inner join circuits c on c.idcircuit = cm.idcircuit
inner join villes v on c.codevilledépart = v.codeville
inner join villes v2 on c.codevillearrivée = v2.codeville
inner join circuitsmonuments cm2 on cm.idcircuit = cm2.idcircuit
inner join monuments m2 on m2.idmonument = cm2.idmonument;



create view vue_circuit_5 as
select c.nomcircuit as nom, 
v.nomville as depart, 
v2.nomville as arrivee, 
c.prix as prix from circuits c
inner join villes v on c.codevilledépart = v.codeville
inner join villes v2 on c.codevillearrivée = v2.codeville;

create view vue_circuit_6 as
select m2.nom as nom_monument,
c.nomcircuit as nom, 
v.nomville as depart, 
v2.nomville as arrivee, 
c.prix as prix from circuitsmonuments cm 
inner join circuits c on c.idcircuit = cm.idcircuit
inner join villes v on c.codevilledépart = v.codeville
inner join villes v2 on c.codevillearrivée = v2.codeville
inner join monuments m2 on m2.idmonument = cm.idmonument;

create view vue_monument_1 as
select m.nom as nom
from monuments m;





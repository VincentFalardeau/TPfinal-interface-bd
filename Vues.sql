--TP final
--
--Vincent Falardeau
--Emile Menard
--
--Vues
select prix from circuits where nomcircuit = '';
describe circuits;
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

create view vue_circuit_monument_1 as
select m.nom as nom, c.nomcircuit as nomcircuit from monuments m
inner join circuitsmonuments cm on m.idmonument = cm.idmonument
inner join circuits c on c.idcircuit = cm.idcircuit;




create view vue_etoiles_circuit as
select idcircuit, avg(m.etoiles) as etoiles from circuitsmonuments cm 
inner join monuments m on m.idmonument = cm.idmonument
group by cm.idcircuit;

create view officiel_vue_circuit as
select m2.nom as nom_monument,
c.nomcircuit as nom, 
v.nomville as depart, 
v2.nomville as arrivee, 
cm.prix as prix,
ec.etoiles as etoiles from vue_prix_circuit_2 cm
inner join  vue_etoiles_circuit ec on ec.idcircuit = cm.idcircuit
inner join circuits c on c.idcircuit = cm.idcircuit
inner join villes v on c.codevilledépart = v.codeville
inner join villes v2 on c.codevillearrivée = v2.codeville
inner join circuitsmonuments cm2 on cm.idcircuit = cm2.idcircuit
inner join monuments m2 on m2.idmonument = cm2.idmonument;


create view vue_etoiles_prix_circuit as
select idcircuit, avg(m.etoiles) as etoiles, sum(m.prix) as prix  from circuitsmonuments cm 
inner join monuments m on m.idmonument = cm.idmonument
group by cm.idcircuit;




create view vue_circuit_monument as
select ovc.nom as nom, 
ovc.depart as depart, 
ovc.arrivee as arrivee, 
ovc.prix as prix,
ovc.etoiles as etoiles,
m.nom as nom_circuit
from officiel_vue_circuit_7 ovc
inner join circuitsmonuments cm on ovc.idcircuit = cm.idcircuit
inner join monuments m on m.idmonument = cm.idmonument;

create view officiel_vue_circuit_7 as
select distinct c.idcircuit as idcircuit,
c.nomcircuit as nom, 
v.nomville as depart, 
v2.nomville as arrivee, 
c.prix as prix,
ec.etoiles as etoiles
from vue_etoiles_circuit_2 ec 
inner join circuits c on c.idcircuit = ec.idcircuit
inner join villes v on c.codevilledépart = v.codeville
inner join villes v2 on c.codevillearrivée = v2.codeville;

create view vue_etoiles_circuit_2 as
select idcircuit, avg(m.etoiles) as etoiles from circuitsmonuments cm 
inner join monuments m on m.idmonument = cm.idmonument
group by cm.idcircuit;


CREATE VIEW ODREDANSCIRCUIT AS
SELECT CM.IDMONUMENT, NOMCIRCUIT, CM.ORDRESURCIRCUIT FROM Circuits C INNER JOIN CircuitsMonuments CM ON C.IDCIRCUIT = CM.IDCIRCUIT;



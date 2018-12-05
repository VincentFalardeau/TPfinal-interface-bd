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
inner join villes v on c.codevilled�part = v.codeville
inner join villes v2 on c.codevillearriv�e = v2.codeville;



create view vue_monument_1 as
select m.nom as nom
from monuments m;
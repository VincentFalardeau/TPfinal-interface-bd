--TP final
--
--Vincent Falardeau
--Emile Menard
--
--Insertions
select * from circuits;
select * from monuments;
select * from villes;

--Monuments
select sysdate from dual;
alter session set nls_date_format = 'DD-MM-YYYY';
--1
insert into monuments values (
sqMonuments.nextval, 'Statue de la liberté', 
'01-09-1875', 'donné par la France aux USA', 'lien', 100, 3);
--2
insert into monuments values (
sqMonuments.nextval, 'St-Basil', 
'12-07-1561', 'Symbole de la Russie', 'lien', 200,4);
--3
insert into monuments values (
sqMonuments.nextval, 'Sphinx', 
'01-01-0001', 'Figure mythologique', 'lien', 300,5);
--4
insert into monuments values (
sqMonuments.nextval, 'Pyramide Giza', 
'01-01-0001', 'On ne sait pas comment elle a ete construite', 'lien', 350,5);
--5
insert into monuments values (
sqMonuments.nextval, 'Statue de sirene', 
'01-01-1913', 'A inspire Walt Disney', 'lien', 50,2);
--6
insert into monuments values (
sqMonuments.nextval, 'Palais de Versailles', 
'01-01-1682', 'Residence de Louix XIV', 'lien', 110,3);
--7
insert into monuments values (
sqMonuments.nextval, 'Kinderdijk', 
'01-01-1997', 'Village hollandais pittoresque', 'lien', 500,4);
--8
insert into monuments values (
sqMonuments.nextval, 'Big Ben', 
'31-05-1859', 'Horloge geante', 'lien', 100,4);
--9
insert into monuments values (
sqMonuments.nextval, 'Stonehenge', 
'01-01-0001', 'Le monument prehistorique le plus populaire', 'lien', 300,5);
--10
insert into monuments values (
sqMonuments.nextval, 'College Lionel-Groulx', 
'01-01-1970', 'Nest pas a la station de metro', 'lien', 50, 2);
--11
insert into monuments values (
sqMonuments.nextval, 'Vieux-port', 
'01-01-1642', 'On y tourne des films qui sont supposes se passer en Europe', 'lien', 100,3);
--12
insert into monuments values (
sqMonuments.nextval, 'Stationnement de Lionel-Groulx', 
'01-01-1980', 'Il faut une vignette', 'lien', 400,1);
--13
insert into monuments values (
sqMonuments.nextval, 'Centropolis', 
'01-01-2012', 'Endroit tendance a Laval', 'lien', 200,2);
--14
insert into monuments values (
sqMonuments.nextval, 'Parc du Mont-Tremblant', 
'01-01-1975', 'Endroit de plein air au Quebec', 'lien', 100,3);
--15
insert into monuments values (
sqMonuments.nextval, 'Tour Eiffel', 
'01-01-1889', 'Se trouve a Paris', 'lien', 200,3);

--Villes
--1
insert into villes values(sqVilles.nextval, 'New-York', 10000000, 'aucune');
--2
insert into villes values(sqVilles.nextval, 'Moscou', 3000000, 'aucune');
--3
insert into villes values(sqVilles.nextval, 'Le Caire', 5000000, 'aucune');
--4
insert into villes values(sqVilles.nextval, 'Paris', 1000000, 'aucune');
--5
insert into villes values(sqVilles.nextval, 'Londres', 2000000, 'aucune');
--6
insert into villes values(sqVilles.nextval, 'Ste-therese', 10000, 'aucune');
--7
insert into villes values(sqVilles.nextval, 'Montreal', 1000000, 'aucune');
--8
insert into villes values(sqVilles.nextval, 'Laval', 500000, 'aucune');
--9
insert into villes values(sqVilles.nextval, 'Sotckholm', 300000, 'aucune');


--1
insert into circuits values (sqCircuits.nextval, 2, 3, 'New-York Moscou', 1000, 20, 500);
--2
insert into circuits values (sqCircuits.nextval, 3, 4, 'Moscou Le caire', 2000, 14, 1000);
--3
insert into circuits values (sqCircuits.nextval, 5, 6, 'Paris Londres', 3000, 7, 50);
--4
insert into circuits values (sqCircuits.nextval, 7, 8, 'Ste-therese Montreal', 50, 2, 10);
--5
insert into circuits values (sqCircuits.nextval, 9, 10, 'Laval Sotckholm', 7500, 25, 500);

--1
insert into circuitsmonuments values(1,2,1);
--2
insert into circuitsmonuments values(2,2,2);
--3
insert into circuitsmonuments values(3,2,3);
--4
insert into circuitsmonuments values(4,2,4);
--5
insert into circuitsmonuments values(5,2,5);

--6
insert into circuitsmonuments values(3,3,1);
--7
insert into circuitsmonuments values(4,2,2);
--8
insert into circuitsmonuments values(5,2,3);
--9
insert into circuitsmonuments values(6,2,4);
--10
insert into circuitsmonuments values(7,2,5);
--11
--12
--13
--14
--15
--16
--17
--18
--19
--20
--21
--22
--23
--24
--25



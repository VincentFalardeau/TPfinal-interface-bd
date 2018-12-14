--TP final
--
--Vincent Falardeau
--Emile Menard
--
--Tables
describe circuits;

CREATE TABLE circuits (
    idcircuit          NUMBER(4) NOT NULL,
    codevilledépart    CHAR(3) NOT NULL,
    codevillearrivée   CHAR(3) NOT NULL,
    nomcircuit         VARCHAR2(20) NOT NULL,
    prix               NUMBER(8,2) NOT NULL,
    durée              NUMBER(3) NOT NULL,
    nbclientsmax       NUMBER(4)
);

ALTER TABLE circuits ADD CONSTRAINT circuits_pk PRIMARY KEY ( idcircuit );
ALTER TABLE circuits ADD CONSTRAINT circuits__un UNIQUE ( nomcircuit );
ALTER TABLE circuits ADD CONSTRAINT circuits_prix_ck CHECK ( prix > 49);

CREATE TABLE circuitsmonuments (
    idmonument        NUMBER(3) NOT NULL,
    idcircuit         NUMBER(4) NOT NULL,
    ordresurcircuit   NUMBER(2)
);

ALTER TABLE circuitsmonuments ADD CONSTRAINT circuitmonument_pk PRIMARY KEY ( idmonument,
                                                                              idcircuit );

CREATE TABLE clients (
    idclient       NUMBER(4) NOT NULL,
    nomclient      VARCHAR2(30),
    prenomclient   VARCHAR2(30),
    adresse        VARCHAR2(40)
);

ALTER TABLE clients ADD CONSTRAINT clients_pk PRIMARY KEY ( idclient );

CREATE TABLE monuments (
    idmonument         NUMBER(3) NOT NULL,
    nom                VARCHAR2(30),
    dateconstruction   DATE,
    histoire           VARCHAR2(100),
    image              VARCHAR2(300),
    prix               NUMBER(6,2),
    etoiles            NUMBER(1)
);

ALTER TABLE monuments ADD CONSTRAINT monuments_pk PRIMARY KEY ( idmonument );
ALTER TABLE monuments ADD CONSTRAINT monuments__un UNIQUE ( nom );
ALTER TABLE monuments ADD CONSTRAINT circuits_etoiles_ck CHECK ( 1 <= etoiles and etoiles <= 5);

CREATE TABLE reservations (
    idreservation     NUMBER(4) NOT NULL,
    datereservation   DATE,
    datelimite        DATE,
    idclient          NUMBER(4) NOT NULL,
    idcircuit         NUMBER(4) NOT NULL
);

ALTER TABLE reservations ADD CONSTRAINT reservations_pk PRIMARY KEY ( idreservation );
ALTER TABLE reservations ADD CONSTRAINT idreservation_un UNIQUE ( idreservation );

CREATE TABLE villes (
    codeville     CHAR(3) NOT NULL,
    nomville      VARCHAR2(30),
    nbhabitants   NUMBER(6),
    histoire      VARCHAR2(100)
);

ALTER TABLE villes ADD CONSTRAINT villes_pk PRIMARY KEY ( codeville );

ALTER TABLE circuitsmonuments
    ADD CONSTRAINT circuitmonument_circuits_fk FOREIGN KEY ( idcircuit )
        REFERENCES circuits ( idcircuit ) ON DELETE CASCADE;

ALTER TABLE circuitsmonuments
    ADD CONSTRAINT circuitmonument_monuments_fk FOREIGN KEY ( idmonument )
        REFERENCES monuments ( idmonument ) ON DELETE CASCADE;

ALTER TABLE circuits
    ADD CONSTRAINT circuits_villes_fk FOREIGN KEY ( codevilledépart )
        REFERENCES villes ( codeville );

ALTER TABLE circuits
    ADD CONSTRAINT circuits_villes_fkv2 FOREIGN KEY ( codevillearrivée )
        REFERENCES villes ( codeville );

ALTER TABLE reservations
    ADD CONSTRAINT reservations_circuits_fk FOREIGN KEY ( idcircuit )
        REFERENCES circuits ( idcircuit );

ALTER TABLE reservations
    ADD CONSTRAINT reservations_clients_fk FOREIGN KEY ( idclient )
        REFERENCES clients ( idclient );

--6.Zadatak - U samostanu se nalaze svećenici. Svaki svećenik zadužen je za više poslova.
--Jedan posao u isto vrijeme može obavljati više svećenika. Scaki svećenik ima samo jednog nadređenog svećenika.

use master;
go
drop database if exists samostan;
go
create database samostan collate Croatian_CI_AS;
go
use samostan;

create table svecenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
titula varchar (50),
poslovi int
);

create table poslovi(
sifra int not null primary key identity(1,1),
tip_posla varchar (50) not null,
sakrament varchar(50) not null,
radni_odnos bit,
svecenici int,
);

create table nadredeni_svecenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
svecenici int,
);

alter table svecenici add foreign key (poslovi) references poslovi(sifra);
alter table poslovi add foreign key (svecenici) references svecenici(sifra);
alter table nadredeni_svecenici add foreign key (svecenici) references svecenici(sifra);

insert into svecenici(ime,prezime)
values
('Antun', 'Marošević'),
('Marko', 'Nekić');

insert into poslovi(tip_posla,sakrament,radni_odnos)
values
('Sveta misa', 'Krštenje', 1),
('Ispovijed', 'ispovijed',1);

insert into nadredeni_svecenici (ime, prezime)
values
('Martin','Veliki'),
('Stuart', 'Mali') ;
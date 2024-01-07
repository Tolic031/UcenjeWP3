--7. Zadatak. Taxi služba ima više vozila. jedno vozilo vozi svaki vozač. U jednoj vožnji vozač može prevesti više putnika.
--Jedan putnik može preko vremena imati više vožnji.

use master;
go
drop database if exists taxi_sluzba;
go
create database taxi_sluzba collate Croatian_CI_AS;
go
use taxi_sluzba;

create table vozila(
sifra int not null primary key identity(1,1),
marka varchar(50) not null,
godiste char(4) not null,
kilometraza varchar(50) not null,
vozno_stanje bit
);

create table vozaci(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
);

create table putnici(
sifra int not null primary key identity(1,1),
broj_putnika varchar(50) not null,
nacin_placanja varchar(50) not null,
vozac int,
);

create table voznje(
sifra int not null primary key identity(1,1),
pocetak_voznje datetime not null,
kraj_voznje datetime not null,
cijena decimal (18,2),
putnik int,
);

alter table putnici add foreign key (vozac) references vozaci (sifra);
alter table voznje add foreign key (putnik) references putnici (sifra);


insert into vozila (marka, godiste, kilometraza, vozno_stanje)
values 
('Volkswagen', '2005', '129233', 1),
('Škoda', '2007', '119443', 1),
('Renault' , '2009', '98632', 2);

insert into vozaci (ime, prezime)
values 
('Kimmi', 'Raikonen'),
('Michael', 'Schummaher'),
('Ivan' , 'Tolić');

insert into voznje (pocetak_voznje, kraj_voznje)
values 
('2023-11-09 19:00:01', '2023-11-09 19:30:01'),
('2023-11-09 19:40:01', '2023-11-09 19:50:01');
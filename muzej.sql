--5. Zadatak --- 
--U muzeju postoji više izložaba. Jedna izložba ima više djela. Svaki kustos je zadužen za jednu izložbu. Svaka izložba ima jednog sponzora.


use master;
go
drop database if exists muzej;
go
create database muzej collate Croatian_CI_AS;
go
use muzej;

create table izlozbe (
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
datum_pocetka datetime not null,
mjesto varchar (50) not null,
);

create table djela (
sifra int not null primary key identity(1,1),
tehnika varchar (50) not null,
izlozbe int,
autor varchar (100) not null,
);

create table kustosi(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
);

create table sponzori(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
);

alter table djela add foreign key (izlozbe) references izlozbe (sifra);

insert into izlozbe (naziv, datum_pocetka, mjesto)
values 
('Renesansa', '2024-01-15 20:00:00', 'Osijek'),
('Gotika', '2024-02-05 20:00:00', 'Vinkovci'),
('Modernizam', '2024-02-25 20:00:00', 'Vukovar');

insert into djela (tehnika, autor)
values
('Ulje na platnu', 'Da Vinci'),
('Akvarel', 'Michelangelo');

insert into kustosi (ime, prezime)
values
('Josip', 'Leovac'),
('Ivana' , 'Harangozo');

insert into sponzori (ime, prezime)
values
('Zdravko', 'Mamić'),
('Milan' , 'Bandić');
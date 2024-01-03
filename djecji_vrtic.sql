-- Dječji vrtić vježba --
-- U dječjem vrtiću postoji više odgojnih skupina. Svaka odgojna skupina ima više djece i vodi ih jedna odgajateljica.
-- Odgajateljica ima jednu strućnu spremu.

use master;
go
drop database if exists djecji_vrtic;
go
create database djecji_vrtic collate Croatian_CI_AS;
go
use djecji_vrtic;

create table odgojne_skupine(
sifra int not null primary key identity(1,1),
naziv varchar (50) not null,
boja varchar(50),
broj_polaznika char(10),
);

create table djeca(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar (50) not null,
odgojne_skupine int 
);

create table odgajateljice(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar (50) not null,
oib char(11)
);

create table strucne_spreme(
sifra int not null primary key identity(1,1),
naziv varchar (50) null
);

alter table djeca add foreign key (odgojne_skupine) references odgojne_skupine(sifra);

insert into odgojne_skupine (naziv)
values ('jaslice');

insert into djeca (ime, prezime)
values
('Novak', 'Đoković'),
('Goran', 'Ivanišević'),
('Marin', 'Ančić');

insert into odgajateljice (ime, prezime)
values
('Biserka' , 'Salamon');
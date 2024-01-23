use master;
go
drop database if exists teniska_liga;
go
create database teniska_liga collate Croatian_CI_AS;
go
use teniska_liga;

create table sezone(
id int not null primary key identity(1,1),
pocetak_sezone datetime not null,
kraj_sezone datetime not null,
cijena decimal (18,2)not null,
);

create table mecevi(
id int not null primary key identity(1,1),
izazivac  varchar(50) not null,
izazvani varchar(50) not null,
pobjednik  varchar(50),
datum datetime not null,
red  char(10) not null,
napomena text,
sezona int,
natjecatelj int
);

create table natjecatelji(
id int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar (50) not null,
broj_telefona varchar(50),
email varchar(50),
clan bit not null,
);

alter table mecevi add foreign key (sezona) references sezone(id);
alter table mecevi add foreign key (natjecatelj) references natjecatelji(id);

insert into sezone (pocetak_sezone,kraj_sezone,cijena)
values ('2024-04-01 08:00:00', '2024-11-15 23:59:59', 100)

insert into mecevi (izazivac, izazvani, datum, red)
values 
('Valent Brkić', 'Tomislav Kušević', '2024-04-01 15:00:00', '5'),
('Ljudevit Sukić', 'Ivan Salamon', '2024-04-01 16:30:00', '4'),
('Antun Marošević', 'Ivan Tolić', '2024-04-01 18:00:00', '3'),
('Dajana Tolić', 'Sara Matijević', '2024-04-01 19:30:00', '2'),
('Tomislav Wilhelm', 'Jadranko Grubišić', '2024-04-01 21:00:00', '1');

insert into natjecatelji (ime, prezime, clan)
values
('Valent','Brkić', 1),
('Tomislav','Kušević', 2),
('Ljudevit','Sukić', 2),
('Ivan','Salamon', 1),
('Antun','Marošević', 2),
('Ivan','Tolić', 1),
('Dajana','Tolić', 1),
('Sara','Matijević', 2),
('Tomislav','Wilhelm', 1),
('Jadranko','Grubišić', 1);
Create table Klub (
		 KlubId int not null,
         KlubName varchar (50),
		 KlubCityName varchar (50),
        KlubCountryName varchar(30)
		primary key (KlubId));

Create table Player (PlayerId int not null,
	PlayerFirstName varchar (20),
	PlayerLastName varchar (20),
	KlubName varchar (50),
	PlayerPosition varchar(15)
	primary key (PlayerId));

insert into Klub ( KlubId, KlubName, KlubCityName, KlubCountryName)
values ( 1,'Osijek', 'Osijek', 'Hrv.');
insert into Klub ( KlubId, KlubName, KlubCityName, KlubCountryName)
values ( 2,'Psv', 'Amsterdam', 'Niz.');
insert into Klub ( KlubId, KlubName, KlubCityName, KlubCountryName)
values ( 3,'Real', 'Madrid', 'Spa.');
insert into Klub ( KlubId, KlubName, KlubCityName, KlubCountryName)
values ( 4,'Bayern', 'Munchen', 'Nje'); 

insert into Player (PlayerId, PlayerFirstName, PlayerLastName, KlubName, PlayerPosition )
values ( 1, 'Pero', 'Peric', 'Osijek', 'Goalkeeper');
insert into Player (PlayerId, PlayerFirstName, PlayerLastName, KlubName, PlayerPosition )
values ( 2, 'Ivo', 'Ivic', 'Psv', 'defender');
insert into Player (PlayerId, PlayerFirstName, PlayerLastName, KlubName, PlayerPosition )
values ( 3, 'Miro', 'Miric', 'Real', 'attacker');
insert into Player (PlayerId, PlayerFirstName, PlayerLastName, KlubName, PlayerPosition )
values ( 4, 'Hans', 'Jurgen', 'Bayern', 'middlefilder');
insert into Player (PlayerId, PlayerFirstName, PlayerLastName, KlubName, PlayerPosition )
values ( 5, 'Ivica', 'Peric', 'Osijek', 'defender');
insert into Player (PlayerId, PlayerFirstName, PlayerLastName, KlubName, PlayerPosition )
values ( 6, 'Blagoje', 'van burek', 'Psv', 'attacker');

select * from Klub
select * from Player



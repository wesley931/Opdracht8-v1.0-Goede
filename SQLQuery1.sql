CREATE table users(
Voornaam varchar(20) not null,
Tussenvoegsel varchar(7),
Achternaam varchar(30),
Username nvarchar(10) not null PRIMARY KEY,
Password nvarchar(8) not null
);

insert into users (Voornaam, Achternaam, Username, Password) values(
'Wesley', 'Barink', 'Wesley931', 'test'),
('Demi', 'Barink', 'Demi831', 'test'),
('Bjorn', 'Barink', 'Bjorn', 'test')
;

select * from users;
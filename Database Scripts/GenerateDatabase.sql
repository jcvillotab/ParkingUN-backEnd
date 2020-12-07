Create database ParkingUN;

use ParkingUN;

CREATE TABLE Users(
	id int identity(1,1) PRIMARY KEY, 
	username varchar(40)  not null,
	name varchar(100) not null,
	surname varchar(100) not null,
	email varchar(100) not null,
	identification bigint not null,
	passwordF varchar(40) not null
);

select * from Users;
insert into Users values('jcvillotab', 'Juan Camilo', 'Villota Ballesteros', 'jcvillotab@unal.edu.co' , 1032506479, '@CamiloVillota4');
insert into Users values('default', 'default', 'default', 'default@default.com', 123456789, 'default');


CREATE TABLE Parking(
	id int identity(1,1) PRIMARY KEY,
	nameP varchar (200) not null,
	latitude Decimal(9,6) not null,
	longitude Decimal(8,6) not null,
	capacity int not null,
	actual int not null,
	state varchar(20),
	nearbyPlaces varchar(max)
);


CREATE TABLE Parking_User(
	id int not null identity(1,1),
	idUser int not null,
	idParking int not null,
	dateStart datetime not null,
	dateEnd datetime,
	PRIMARY KEY (id),
	FOREIGN KEY (idUser) REFERENCES Users(id),
	FOREIGN KEY (idParking) REFERENCES Parking(id)
);

CREATE TABLE Parking_log(
	id int not null identity(1,1),
	idUser int not null,
	idParking int not null,
	dateStart datetime not null,
	dateEnd datetime not null,
	PRIMARY KEY (id),
	FOREIGN KEY (idUser) REFERENCES Users(id),
	FOREIGN KEY (idParking) REFERENCES Parking(id)
);

insert into Parking values ('Parqueadero Derecho', 4.635766195897006, -74.08453887647495, 15, 0,'Open', 'Ubicado detras del edificio de derecho, entre el edificio de medicina y humanas');
insert into Parking values ('Parqueadero BiciRun Calle 26', 4.632982481909863, -74.08366955910104, 10, 0,'Open', 'Ubicado cerca a la entrada de la calle 26, al lado del anillo vial');
insert into Parking values ('Parqueadero Edificio Ciencia y Tecnolog�a', 4.63829174981494, -74.08485208507527, 10, 0,'Open', 'Ubicado detras del edificio de Ciencia y Tecnolog�a');
insert into Parking values ('Parqueadero Aulas de Ingenier�a', 4.63839363932783, -74.0835192493212, 12, 0,'Open', 'Ubicado en frente de la salida principal del edificio de aulas de Ingenier�a');
insert into Parking values ('Parqueadero Agronom�a', 4.635789171239537, -74.08684303367633, 15, 0,'Open', 'Ubicado en frente de la salida principal del edificio de agronom�a, al lado del anillo vial');
insert into Parking values ('Parqueadero Biolog�a', 4.640295147890939, -74.08212657496358, 10, 0,'Open', 'Ubicado en la salida principal del edificio de Biolog�a');
insert into Parking values ('Parqueadero El Viejo', 4.640295147890939, -74.08212657496358, 10, 0,'Open', 'Ubicado al lado de la salida del eficio "El Viejo", al frente del edificio de matem�ticas');
insert into Parking values ('Parqueadero Odontolog�a', 4.634599074739043, -74.08562879289693, 8, 0,'Open', 'Ubicado en la salida trasera del edificio de odontolog�a, colindando con Aulas de Ciencias Humanas');
insert into Parking values ('Parqueadero Ciencias Econ�micas', 4.636980299486396, -74.08054093689522, 15, 0,'Open', 'Ubicado en la salida trasera del edificio de ciencias economicas, al lado del anillo vial');
insert into Parking values ('Parqueadero Bicirun Calle 45', 4.635133863292353, -74.08044831036703, 15, 0,'Open', 'Ubicado despues de la entrada de la calle 45, al lado del camino que lleva al edificio SINDU');





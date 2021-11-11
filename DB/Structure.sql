Create database SMG
go
use SMG;
go
Create table users(
id int not null primary key IDENTITY(1,1),
name varChar(50) not null,
lastName varChar (50) not null,
email varChar (60) not null unique,
password varchar(100),
cell varchar(20) null,
image varchar(100),
IsAdmin bit default (0),
Fecha_nacimiento date,
Estado bit default(1),
)
go
create table categories(
id int not null primary key IDENTITY(1,1),
name varChar(50) not null,
Estado bit default(1),
)
go
create table developers(
id int not null primary key IDENTITY(1,1),
name varChar(50) not null,
information varChar(50) not null,
Estado bit default(1),
)
go
Create table videoGames(
id int not null primary key IDENTITY(1,1),
name varChar(50) not null,
Description varchar (200) not null,
Requerimientos varchar (200) not null,
Id_category int Foreign key references categories(id),
Id_developer int Foreign key references developers(id),
Price decimal,
Descuento decimal,
Destacado bit,
Clasificacion_PIG int,
Launch_Date date,
Estado bit default(1),
)
go
Create table images(
id int not null primary key IDENTITY(1,1),
url_image varchar (200),
id_product int Foreign key references videoGames(id),
Estado bit default(1),
)
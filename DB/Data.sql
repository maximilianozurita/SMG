use SMG;
INSERT INTO categories (name) VALUES ('Horror'),('FPS'),('Aventure'),('MOBA'),('RPG'),('MMORPG'),('RTS'),('Survival'),('Indie');
go
INSERT INTO developers (name, information) VALUES ('IndieProduction','Loremasdfdsdf'),('hash','sadfasdfa'),('bcry','12345a'),('Spunch','67808a')
go
INSERT INTO users (name,lastName,email,password,cell,image,Fecha_nacimiento) VALUES ('Maxi','Zurita','max@gmailc','1234','+5411838273','user1','11/11/11');
go
INSERT INTO videoGames (name,Description,Requerimientos,Id_category,Id_developer,Price,Descuento,Destacado,Clasificacion_PIG,Launch_Date) VALUES 
('Doom eternal','DESCRIPCION JUEGO 1','Requerimientos juego 1', 2,1,999,3,1,18,'06/06/06'),
('Escape From tarkov','DESCRIPCION JUEGO 2','Requerimientos juego 2', 2,2,999,1,1,15,'11/11/11'),
('God of war','DESCRIPCION JUEGO 3','Requerimientos juego 3', 3,3,999,0.1,1,15,'12/12/12'),
('The last of us 2','DESCRIPCION JUEGO 4','Requerimientos juego 4', 3,4,999,10,0,15,'12/12/12');
go
INSERT INTO images (url_image,id_product) VALUES ('DoomEternal.jpg',1),('EFT.png',2),('GOW.jpeg',3),('TLU2',4);
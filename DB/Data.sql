use SMG;
INSERT INTO categories (name) VALUES ('Horror'),('FPS'),('Aventure'),('MOBA'),('RPG'),('MMORPG'),('RTS'),('Survival'),('Indie');
go
INSERT INTO developers (name, information) VALUES ('IndieProduction','Loremasadfasdfaasdfdfdsdf'),('hash','sadfasdfasdfasdfasdfa'),('bcry','12345adfasdfasdfa'),('Spunch','67808aasdfasdfasdfasdf')
go
INSERT INTO users (name,lastName,email,password,cell,image,isAdmin ,Fecha_nacimiento) 
VALUES ('Maxi','Zurita','maxi@gmail.com','1234','+5411838273','user1', 1 ,'11/11/11'),
('Santiago','Maldonado','Santiago@gmail.com','1234','+5411838273','user1', 1 ,'11/11/11'),
('Gabriel','Cordoba','Gabi@gmail.com','1234','+5411838273','user1', 1 ,'11/11/11'),
('NoAdmin','NoAdmin','NoAdmin@gmail.com','1234','+5411838273','user1',0,'11/11/11');
go
INSERT INTO videoGames (name,Description,Requerimientos,Id_category,Id_developer,Price,Descuento,Destacado,Clasificacion_PIG,Launch_Date,LinkVideo) VALUES 
('Doom eternal','DESCRIPCION JUEGO 1','Requerimientos juego 1', 2,1,999,3,1,18,'2021-06-02','https://www.youtube.com/watch?v=xIf0X9MAtI0'),
('Escape From tarkov','DESCRIPCION JUEGO 2','Requerimientos juego 2', 2,2,999,1,1,15,'2021-11-18','https://www.youtube.com/watch?v=MyUQsh0UCZI&t=38s'),
('God of war','DESCRIPCION JUEGO 3','Requerimientos juego 3', 3,3,999,0.1,1,15,'2021-11-18','https://www.youtube.com/watch?v=mbwvbFZOlcY'),
('The last of us 2','DESCRIPCION JUEGO 4','Requerimientos juego 4', 3,4,999,10,0,15,'2021-11-18','https://www.youtube.com/watch?v=JdE9U9WW_HM'),
('SubNautica','DESCRIPCION JUEGO 5','Requerimientos juego 5', 8,4,999,10,1,15,'2021-11-18','https://www.youtube.com/watch?v=Rz2SNm8VguE'),
('AgeOfEmpires2','DESCRIPCION JUEGO 6','Requerimientos juego 6', 7,4,999,10,0,15,'2021-11-18','https://www.youtube.com/watch?v=ZOgBVR21pWg'),
('Outlast','DESCRIPCION JUEGO 7','Requerimientos juego 7', 1,4,999,10,0,15,'2021-11-18','https://www.youtube.com/watch?v=uKA-IA4locM');
go
INSERT INTO images (url_image,id_product) VALUES 
('DoomEternal1.jpg',1),('DoomEternal2.jpg',1),('DoomEternal3.jpg',1),('DoomEternal4.jpg',1),('DoomEternal5.png',1),
('EFT1.png',2),('EFT2.jpeg',2),('EFT3.jpg',2),('EFT4.jpg',2),('EFT5.jpg',2),
('GOW1.jpeg',3),('GOW2.jpg',3),('GOW3.jpg',3),('GOW4.jpg',3),('GOW5.jpg',3),
('TLU21.jpeg',4),('TLU22.jpEg',4),('TLU23.jpg',4),('TLU24.jpg',4),('TLU25.jpg',4),
('SubNautica1.jpg',5),('SubNautica2.jpg',5),('SubNautica3.jpg',5),('SubNautica4.jpg',5),('SubNautica5.jpg',5),
('AgeOfEmpires21.jpg',6),('AgeOfEmpires22.jpg',6),('AgeOfEmpires23.jpg',6),('AgeOfEmpires24.jpg',6),('AgeOfEmpires25.jpg',6),
('Outlast1.jpg',7),('Outlast2.jpg',7),('Outlast3.jpg',7),('Outlast4.jpg',7),('Outlast5.jpg',7);

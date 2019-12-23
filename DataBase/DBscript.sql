use FOPROLYD_recep;


--****Script de Pruebas de la Base de datos****-----


create table llamadas (
ID_llama int NOT NULL IDENTITY PRIMARY KEY,
Rubro_llamada varchar(12) NOT NULL,
Fecha_llamada date NOT NULL,
Identificador int NOT NULL,
Categoria varchar(15)
);




alter table llamadas add Categoria varchar(15) NOT NULL; 
alter table llamadas alter column Fecha_llamada datetime NOT NULL;

select ID_llama, Rubro_llamada, Fecha_llamada, Categoria,Notas from llamadas;

truncate table llamadas;


select * from llamadas;


insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','09/10/2019 2:51:25',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');

insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-11',5,'Proveedores');


select FORMAT( GETDATE(), 'd');
select GETDATE();

select Rubro_llamada, COUNT(Rubro_llamada) AS Cantidad FROM llamadas
GROUP BY Rubro_llamada;


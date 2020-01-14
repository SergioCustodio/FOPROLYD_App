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


select Rubro_llamada, COUNT(Rubro_llamada) AS Cantidad FROM llamadas
GROUP BY Rubro_llamada;

Select Categoria, COUNT(Categoria) As Cantidad from llamadas
group by Categoria;


Create table correspondencias(
ID_correspondencia int not null IDENTITY PRIMARY KEY,
Rubro_correspondencia varchar(25) not null,
Fecha_correspondencia datetime not null,
Identificador_c int not null
);

select ID_correspondencia as ID, Rubro_correspondencia as Rubro, Fecha_correspondencia as Fecha, observaciones as Observaciones from correspondencias;

alter table correspondencias add observaciones varchar(350);

create table audiencias(
ID_a int not null IDENTITY PRIMARY KEY,
Rubro_a varchar(25) not null,
Fecha_a datetime not null,
Hora_a varchar(10) not null,
nombre_a varchar(50) not null,
telefono_a varchar(10),
audiencia_main varchar(50),
observaciones_a varchar(350)
);

create table atencion(
ID_atencion int not null IDENTITY PRIMARY KEY,
Rubro_atencion varchar(25) not null,
Tipo_atencion varchar(15)not null,
Observacion_atencion varchar(350),
);

--alter table audiencias add Identificador int not null;


select ID_a as ID, Rubro_a as Rubro, Fecha_a as Fecha, Hora_a as Hora, nombre_a as 'Nombre Beneficiario', telefono_a as 'Teléfono', 
	audiencia_main as 'Audiencia con', observaciones_a as Observaciones from audiencias

select * from audiencias

select * from correspondencias

sELECT * FROM llamadas

select * from atencion

select ID_atencion as 'ID', Rubro_atencion as 'Rubro', Fecha_atencion as 'Fecha', Tipo_atencion as 'Tipo', Observacion_atencion as 'Observación' from atencion

insert into atencion (Rubro_atencion , Tipo_atencion,Observacion_atencion,Fecha_atencion) values ('Retiro de Medicamentos','Beneficiario','El Beneficiario fulano vino por sus medicamentos','09/10/2019 2:51:25');
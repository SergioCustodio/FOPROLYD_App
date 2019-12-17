use FOPROLYD_recep;

create table llamadas (
ID_llama int NOT NULL IDENTITY PRIMARY KEY,
Rubro_llamada varchar(12) NOT NULL,
Fecha_llamada date NOT NULL,
Identificador int NOT NULL,
Categoria varchar(15)
);




alter table llamadas add Categoria varchar(15) NOT NULL; 
alter table llamadas add Notas varchar (170);

select * from llamadas;

insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');
insert into llamadas (Rubro_llamada,Fecha_llamada,Identificador,Categoria) values('DPYBE','2019-10-09',7,'Beneficiarios');


select Rubro_llamada, COUNT(Rubro_llamada) AS Cantidad FROM llamadas
GROUP BY Rubro_llamada;


if object_id('productos') is not null
drop table productos;

create table productos(
id int  not null,
nombre varchar(255),
descripcion text,
precio varchar (255),
imagen varchar (255)
CONSTRAINT pk_productos PRIMARY KEY(id)
);

SELECT *FROM productos;
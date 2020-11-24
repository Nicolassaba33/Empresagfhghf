create table legajos(
legajo int,
dni int,
nombre varchar (50),
caja int,
[fecha de carga] smalldatetime

);


select *from legajos;

insert into legajos 
values (21,242412,'nicolas',07,'20201122')

insert into legajos (legajo,dni,nombre,caja,[fecha de carga])
values (25,25769,'tomas',27,'20201123')

insert into legajos (legajo,dni,nombre,caja,[fecha de carga])
values (23,543432,'juan',28,'20201110'),(24,3323,'perez',28,'20201110')

update legajos set caja=28
where legajo=25

select * from legajos 
select * from legajos where legajo in (23,24)

update legajos set caja = caja + 1, [fecha de carga] = '20201111' where legajo in (23,24)

select *from legajos where legajo=25
delete legajos 
where legajo=25



create table cajas( 
caja int,
nombre varchar (50)
)

insert into cajas 
values  (7,'siente'),(29,'veinte y nueve');

--servidor.base.esquema.tabla
--

/*
kjhjkkh
*/

select * from [desktop-kljutm1\mssqlserver01].practica.dbo.cajas 

select * from cajas 

select * 
from legajos l
	inner join cajas c on l.caja = c.caja

select legajo, l.nombre as nombrelegajo, c.nombre as nombrecaja,DAY([fecha de carga]) as dia
from legajos l
	left outer join cajas c on l.caja = c.caja
where [fecha de carga] is not null
order by nombrelegajo





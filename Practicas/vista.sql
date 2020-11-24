create view legajoscajas
as
select legajo, l.nombre as nombrelegajo, c.nombre as nombrecaja,DAY([fecha de carga]) as dia, month([fecha de carga]) as mes
from legajos l
	left outer join cajas c on l.caja = c.caja
where [fecha de carga] is not null


select * from legajoscajas
where dia = 11
order by nombrelegajo


drop view legajoscajas

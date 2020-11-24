alter procedure legajoinsert
	@legajo int,
	@dni int,
	@nombre varchar (50),
	@caja int,
	@fecha smalldatetime
as

if @legajo = 25
begin
	print('no se puede insertar el 25')
	
end
else
begin
insert into legajos (legajo,dni,nombre,caja,[fecha de carga])
values (@legajo,
@dni,
@nombre,
@caja,
@fecha
)
end

exec legajoinsert 25, 555, 'napoleon', 29, null
exec legajoinsert @legajo = 26, @dni = 556, @nombre = 'bonaparte', @caja = 28, @fecha = null


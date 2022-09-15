create proc sp_reporte_registros2(
@FechaInicio varchar(10),
@FechaFin varchar(10)
)

as
begin

select Documento, Nombre, Apellidos, CONVERT(char(10), FechaNac, 103)[FechaNac], Direccion, Celular, Genero, Deporte, Trabaja, Sueldo, Estado, CONVERT(char(10), FechaRegistro, 103)[FechaRegistro] from Registros
where FechaRegistro between @FechaInicio and @FechaFin

end
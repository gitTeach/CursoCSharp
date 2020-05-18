use Autolote
go

--Especificando todas las columnas de la tablas sin columnas incrementales
insert into t_Base
(Nombre,Departamento,Ciudad,Direccion,NumeroTelefono)
values
(	'Sucursal City Mall', 
	'Cortes', 
	'San Pedro Sula', 
	'Contiguo City Mall',
	'9999-9999')

--No especificando el campo direccion	
insert into t_Base
(Nombre,Departamento,Ciudad,NumeroTelefono)
values
(	'Sucursal City Salida TGU', 
	'Cortes', 
	'San Pedro Sula', 
	'9999-9998')
	
--Moviendo de orden una columna para verificar que no afecta el orden de
--como fueron definidas
insert into t_Base
(Nombre,Departamento,NumeroTelefono, Ciudad)
values
(	'Sucursal City Salida La Lima', 
	'Cortes', 
	'9999-9998',
	'San Pedro Sula'
)

--Insercion sin especificacion de columnas
--Se toma el orden de como fueron definidos
--No se consideran columnas autoincrementales
--Debe de insertarse todas las columnas que no acepten valores nullos
insert into t_Base
values
(	'Sucursal Salida Cortes', 
	'Cortes', 
	'San Pedro Sula',
	'Cerca del Peaje salida a la lopez.', 
	'9999-9997')

--Insercion para multiples valores en la misma clausula
insert into t_Base
values
(	'Sucursal Ave. Junior', 
	'Cortes', 
	'San Pedro Sula',
	'Cerca de Supermercado Junior', 
	'9999-9996'
),
(	'Sucursal Maheco', 
	'Cortes', 
	'San Pedro Sula',
	'1 Calle 2 Avenida', 
	'9999-9995'
)
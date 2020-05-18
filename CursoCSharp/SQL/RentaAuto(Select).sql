use RentaCar
go

select *
from t_Cliente as tc

select *
from t_Cliente as tc
--where tc.Nombre like '%Josue%'
where tc.Nombre = 'Josue' -- Coincidencia exacta.

select *
from t_Cliente as tc
where tc.Apellido like '%Zuniga%'
order by tc.Direccion asc

select top 1 *
from t_Cliente as tc
where tc.Apellido like '%Zuniga%'
order by tc.Direccion asc

select count (tc.Nombre) as TotalRegistros
from t_Cliente as tc
where tc.Apellido like '%Zuniga%'


select *
from t_Cliente as tc
where tc.Apellido like '%Zuniga%' and tc.Direccion = 'La Ceiba'
order by tc.Direccion asc


select tc.idCliente, tc.Nombre, tc.Apellido, tc.Direccion, O.*
from t_Cliente as tc
inner join t_Orden as O
on tc.idCliente = O.idCliente
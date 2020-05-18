use Autolote
go

select * from t_Orden o

select 
	*
from		t_Orden o
inner join	t_Cliente c
on			o.idCliente = c.IdCliente

select 
	c.Nombre, 
	a.Marca, 
	a.Modelo, 
	o.RentaFechaInicio, 
	o.RentaFechaFin
from		t_Orden o
inner join	t_Cliente c
on			o.idCliente = c.IdCliente
inner join	t_Auto a
on			o.idAuto = a.IdAuto
where 
 

 
 

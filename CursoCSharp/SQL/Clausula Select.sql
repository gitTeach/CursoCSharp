--Forma base
select * from t_Base

--Forma seleccion columna
select idBase, Nombre from t_Base

--Forma seleccion columna con nombre de origen como alias
select t_Base.idBase, t_Base.Direccion from t_Base

--Forma seleccion columna con nombre de alias
select b.idBase, b.Direccion from t_Base b

--Forma seleccion columna renombrandolas con alias
select b.idBase Id, b.Direccion Dir from t_Base b

--Forma seleccion columna renombrandolas con alias usando argumento as
select b.idBase as Id, b.Direccion as Dir from t_Base as b
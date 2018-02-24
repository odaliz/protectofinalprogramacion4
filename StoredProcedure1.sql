--select serieequipo from movimientosequipos 
--SELECT inv.idequipo AS Número, inv.serieequipo AS Série, est.descripcionestado AS Estado, equip.descripcionequipo AS Equipo FROM inventario inv INNER JOIN equipos equip ON equip.idequipo = inv.idequipo INNER JOIN estados est ON est.idestado = inv.idestado
select * from inventario
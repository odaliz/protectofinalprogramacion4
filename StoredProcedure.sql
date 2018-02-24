USE [UCSystem_SQLServer]
GO
/****** Object:  StoredProcedure [dbo].[insertar_movimientos]    Script Date: 2/23/2018 10:20:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[insertar_movimientos]
    @matricula varchar(7),
	@serieequipo varchar(30),
	@idestado int,   
    @fechaestado varchar (10)   
AS
BEGIN   
    SET NOCOUNT ON;  
    INSERT INTO movimientosequipos (matricula, serieequipo, idestado, fechaestado)
	VALUES (@matricula, @serieequipo, @idestado,@fechaestado);
	UPDATE inventario SET idestado = @idestado WHERE serieequipo = @serieequipo
	END
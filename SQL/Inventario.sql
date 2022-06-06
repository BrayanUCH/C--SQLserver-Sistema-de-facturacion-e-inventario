/*==================================================================================================*/
/*===================INSERTAR Inventario ==========================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE InventarioInsertar @Inventario_ArticuloID INT,
									@Inventario_Cantidad FLOAT,
									@Inventario_Tipo VARCHAR(1),
									@Inventario_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TInventario(Inventario_ArticuloID,
									Inventario_Cantidad,
									Inventario_Tipo,
									Inventario_Estado) 

	SELECT  @Inventario_ArticuloID,
			@Inventario_Cantidad,
			@Inventario_Tipo,
			@Inventario_Estado
			
END
GO
--InventarioInsertar 1,1,'B','A' 
/*==================================================================================================*/
/*===================MODIFICAR Inventario ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioModificar @Inventario_id INT,
		                					@Inventario_ArticuloID INT,
		                					@Inventario_Cantidad FLOAT,
		                					@Inventario_Tipo VARCHAR(1),
		                					@Inventario_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TInventario
		SET	Inventario_ArticuloID = @Inventario_ArticuloID,
			Inventario_Cantidad = @Inventario_Cantidad,
			Inventario_Tipo = @Inventario_Tipo,
			Inventario_Estado = @Inventario_Estado

		WHERE Inventario_id = @Inventario_id
	END
GO
--InventarioModificar 1,1,1,22222,'A' 
/*==================================================================================================*/
/*===================INACTIVAR Inventario ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioInactivar @Inventario_id INT
AS
	BEGIN
		UPDATE TInventario
		SET Inventario_Estado = 'I'
		WHERE Inventario_id = @Inventario_id
END
GO
--InventarioInactivar 2
/*==================================================================================================*/
/*==================ACTIVAR Inventario ===========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioActivar @Inventario_id INT
AS
	BEGIN
		UPDATE TInventario
		SET Inventario_Estado = 'A'
		WHERE Inventario_id = @Inventario_id
END
GO
--InventarioActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Inventario =========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioEliminar @Inventario_id INT 								
AS
BEGIN 
	DELETE FROM TInventario
	WHERE Inventario_id = @Inventario_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
--InventarioEliminar 1
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Inventario =============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioConsultar @Inventario_id INT
AS
BEGIN
	 SELECT *
	 FROM TInventario
	 WHERE Inventario_id = @Inventario_id
END
GO
/*==================================================================================================*/
/*===================CONSULTAR Existencia L=============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioConsultarExistenciaL @Inventario_ArticuloID INT
AS
BEGIN
	 SELECT *
	 FROM TInventario
	 WHERE Inventario_ArticuloID = @Inventario_ArticuloID AND Inventario_Tipo = 'L'
END
GO
/*==================================================================================================*/
/*===================CONSULTAR Existencia B=============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioConsultarExistenciaB @Inventario_ArticuloID INT
AS
BEGIN
	 SELECT *
	 FROM TInventario
	 WHERE Inventario_ArticuloID = @Inventario_ArticuloID AND Inventario_Tipo = 'B'
END
GO
--InventarioConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Inventario =============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioListarAL
AS
BEGIN
	SELECT *
	FROM TInventario
	WHERE Inventario_Estado = 'A' and Inventario_Tipo = 'L'
END
GO 
--InventarioListarAL
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Inventario =============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioListarIL
AS
BEGIN
	SELECT *
	FROM TInventario
	WHERE Inventario_estado = 'I' and Inventario_Tipo = 'L'
END
GO
--InventarioListarIL
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Inventario =============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioListarAB
AS
BEGIN
	SELECT *
	FROM TInventario
	WHERE Inventario_Estado = 'A' and Inventario_Tipo = 'B'
END
GO
--InventarioListarAB
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Inventario =============================*/
/*==================================================================================================*/
CREATE PROCEDURE InventarioListarIB
AS
BEGIN
	SELECT *
	FROM TInventario
	WHERE Inventario_estado = 'I' and Inventario_Tipo = 'B'
END
GO
--InventarioListarIB

/*==================================================================================================*/
/*===================CONSULTAR existencia en el Inventario =============================*/
/*==================================================================================================*/
--CREATE PROCEDURE InventarioConsultarExistenciaL @Articulo_ID INT
--AS
--BEGIN
--	 SELECT *
--	 FROM TInventario i
--	 WHERE i.Inventario_ArticuloID = @Articulo_ID and i.Inventario_Tipo = 'L'
--END
--GO
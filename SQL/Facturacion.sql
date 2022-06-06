/*==================================================================================================*/
/*===================INSERTAR Facturacion ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionInsertar @Facturacion_Observaciones VARCHAR(150),
									@Facturacion_ClienteID INT,
									@Facturacion_Descuento FLOAT,
									@Facturacion_Impuesto FLOAT,
									@Facturacion_NumeroArticulos INT,
									@Facturacion_SubTotal FLOAT,
									@Facturacion_Total FLOAT,
									@Facturacion_Fecha VARCHAR(10),
									@Facturacion_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TFacturacion(Facturacion_Observaciones,
							Facturacion_ClienteID,
							Facturacion_Descuento,
							Facturacion_Impuesto,
							Facturacion_NumeroArticulos,
							Facturacion_SubTotal,
							Facturacion_Total,
							Facturacion_Fecha,
							Facturacion_estado) 

	SELECT @Facturacion_Observaciones,
			@Facturacion_ClienteID,
			@Facturacion_Descuento,
			@Facturacion_Impuesto,
			@Facturacion_NumeroArticulos,
			@Facturacion_SubTotal,
			@Facturacion_Total,
			@Facturacion_Fecha,
			@Facturacion_Estado
			
END
GO
-- FacturacionInsertar 'tipo', 0.13, 12, 10000, 11300, '2021-05-05', 'A'
/*==================================================================================================*/
/*===================MODIFICAR Facturacion ==============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionModificar @Facturacion_id INT,
									@Facturacion_Observaciones VARCHAR(150),
									@Facturacion_ClienteID INT,
									@Facturacion_Descuento FLOAT,
									@Facturacion_Impuesto FLOAT,
									@Facturacion_NumeroArticulos INT,
									@Facturacion_SubTotal FLOAT,
									@Facturacion_Total FLOAT,
									@Facturacion_Fecha VARCHAR(10),
									@Facturacion_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TFacturacion
		SET	Facturacion_Observaciones = @Facturacion_Observaciones,
			Facturacion_ClienteID = @Facturacion_ClienteID,
			Facturacion_Descuento = @Facturacion_Descuento,
			Facturacion_Impuesto = @Facturacion_Impuesto,
			Facturacion_NumeroArticulos = @Facturacion_NumeroArticulos,
			Facturacion_SubTotal = @Facturacion_SubTotal,
			Facturacion_Total = @Facturacion_Total,
			Facturacion_Fecha =@Facturacion_Fecha,
			Facturacion_Estado =@Facturacion_Estado
	
		WHERE Facturacion_id = @Facturacion_id
	END
GO
-- FacturacionModificar 1, 'tipos', 0.13, 12, 10000, 11300, '2021-05-05', 'A'
/*==================================================================================================*/
/*===================INACTIVAR Facturacion ==============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionInactivar @Facturacion_id INT
AS
	BEGIN
		UPDATE TFacturacion
		SET Facturacion_estado = 'I'
		WHERE Facturacion_id = @Facturacion_id
END
GO
-- FacturacionInactivar 1
/*==================================================================================================*/
/*===================ACTIVAR Facturacion ================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionActivar @Facturacion_id INT
AS
	BEGIN
		UPDATE TFacturacion
		SET Facturacion_estado = 'A'
		WHERE Facturacion_id = @Facturacion_id
END
GO
-- FacturacionActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Facturacion ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionEliminar @Facturacion_id INT 								
AS
BEGIN 
	DELETE FROM TFacturacion
	WHERE Facturacion_id = @Facturacion_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- FacturacionEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Facturacion ===================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionConsultar @Facturacion_id INT
AS
BEGIN
	 SELECT *
	 FROM TFacturacion
	 WHERE Facturacion_id = @Facturacion_id
END
GO
-- FacturacionConsultar 1
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Facturacion ===================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionListarA
AS
BEGIN
	SELECT *
	FROM TFacturacion
	WHERE Facturacion_estado = 'A'
END
GO
-- FacturacionListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Facturacion ===================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionListarI
AS
BEGIN
	SELECT *
	FROM TFacturacion
	WHERE Facturacion_estado = 'I'
END
GO
-- FacturacionListarI
/*==================================================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionListarFiltradoId @ID int
AS
BEGIN
	SELECT *
	FROM TFacturacion f
	WHERE f.Facturacion_id = @ID and f.Facturacion_Estado = 'A'
END
GO
/*==================================================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionListarFiltradoFecha @Fecha Varchar (10)
AS
BEGIN
	SELECT *
	FROM TFacturacion f
	WHERE f.Facturacion_Fecha like '%'+@Fecha+'%' and f.Facturacion_Estado = 'A'
END
GO
/*==================================================================================================*/
/*======================================ULTIMO REGISTRO ============================================*/
/*==================================================================================================*/
CREATE PROCEDURE FacturacionConsultarUltimoResgistro
AS
BEGIN
	SELECT top(1) * 
	FROM TFacturacion 
	WHERE Facturacion_estado = 'A'
	ORDER by Facturacion_id desc
END
GO

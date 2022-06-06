/*==================================================================================================*/
/*===================INSERTAR DetalleFactura ================================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE DetalleFacturaInsertar @DetalleFactura_ArticulosID INT,
									@DetalleFactura_FacturacionID INT,
									@DetalleFactura_Cantidad FLOAT,
									@DetalleFactura_Descuento FLOAT,
									@DetalleFactura_Impuesto FLOAT,
									@DetalleFactura_Precio FLOAT,
									@DetalleFactura_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TDetalleFactura(DetalleFactura_ArticulosID,
							DetalleFactura_FacturacionID,
							DetalleFactura_Cantidad,
							DetalleFactura_Descuento,
							DetalleFactura_Impuesto,
							DetalleFactura_Precio,
							DetalleFactura_Estado) 

	SELECT  @DetalleFactura_ArticulosID,
			@DetalleFactura_FacturacionID,
			@DetalleFactura_Cantidad,
			@DetalleFactura_Descuento, 
			@DetalleFactura_Impuesto,
			@DetalleFactura_Precio,
			@DetalleFactura_Estado

END
GO
-- DetalleFacturaInsertar 1,1,3,3,1000,'A'
/*==================================================================================================*/
/*===================MODIFICAR DetalleFactura ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaModificar  @DetalleFactura_id INT,
									@DetalleFactura_ArticulosID INT,
									@DetalleFactura_FacturacionID INT,
									@DetalleFactura_Cantidad FLOAT,
									@DetalleFactura_Descuento FLOAT,
									@DetalleFactura_Impuesto FLOAT,
									@DetalleFactura_Precio FLOAT,
									@DetalleFactura_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TDetalleFactura
		SET	DetalleFactura_ArticulosID = @DetalleFactura_ArticulosID,
			DetalleFactura_FacturacionID = @DetalleFactura_FacturacionID,
			DetalleFactura_Cantidad = @DetalleFactura_Cantidad,
			DetalleFactura_Descuento = @DetalleFactura_Descuento,
			DetalleFactura_Impuesto = @DetalleFactura_Impuesto,
			DetalleFactura_Precio = @DetalleFactura_Precio,
			DetalleFactura_Estado = @DetalleFactura_Estado
	
		WHERE DetalleFactura_id = @DetalleFactura_id
	END
GO
-- DetalleFacturaModificar 1,1,1,3,3,22222,'A'
/*==================================================================================================*/
/*===================INACTIVAR DetalleFactura ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaInactivar @DetalleFactura_id INT
AS
	BEGIN
		UPDATE TDetalleFactura
		SET DetalleFactura_Estado = 'I'
		WHERE DetalleFactura_id = @DetalleFactura_id
END
GO
--DetalleFacturaInactivar 2
/*==================================================================================================*/
/*==================ACTIVAR DetalleFactura ==================================================================*/
/*==================================================================================================*/

CREATE PROCEDURE DetalleFacturaActivar @DetalleFactura_id INT
AS
	BEGIN
		UPDATE TDetalleFactura
		SET DetalleFactura_Estado = 'A'
		WHERE DetalleFactura_id = @DetalleFactura_id
END
GO
--DetalleFacturaActivar 1
/*==================================================================================================*/
/*===================ELIMINAR DetalleFactura ================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaEliminar @DetalleFactura_id INT 								
AS
BEGIN 
	DELETE FROM TDetalleFactura
	WHERE DetalleFactura_id = @DetalleFactura_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
--DetalleFacturaEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN DetalleFactura =====================================*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaConsultar @DetalleFactura_id INT
AS
BEGIN
	 SELECT *
	 FROM TDetalleFactura
	 WHERE DetalleFactura_id = @DetalleFactura_id
END
GO
--DetalleFacturaConsultar 1
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN DetalleFactura ============================*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaListarA
AS
BEGIN
	SELECT *
	FROM TDetalleFactura
	WHERE DetalleFactura_estado = 'A'
END
GO
--DetalleFacturaListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN DetalleFactura =====================================*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaListarI
AS
BEGIN
	SELECT *
	FROM TDetalleFactura
	WHERE DetalleFactura_estado = 'I'
END
GO
--DetalleFacturaListarI
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN DetalleFactura de una factura =============*/
/*==================================================================================================*/
CREATE PROCEDURE DetalleFacturaListarIDfactura @idFactura int 
AS
BEGIN
	SELECT *
	FROM TDetalleFactura
	WHERE DetalleFactura_FacturacionID = @idFactura
END
GO
--DetalleFacturaListarI

/*==================================================================================================*/
/*==================================================================================================*/
CREATE TRIGGER TR_ACTUALIZAR_IVENTARIO ON TDetalleFactura AFTER INSERT 
AS
	BEGIN 
		UPDATE TInventario 
		SET Inventario_Cantidad = Inventario_Cantidad - (SELECT DetalleFactura_Cantidad FROM Inserted)
		WHERE Inventario_ArticuloID = (SELECT DetalleFactura_ArticulosID FROM Inserted) and Inventario_Tipo = 'L'
END
GO

/*==================================================================================================*/
/*===================INSERTAR Unidades de medida =============================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE UnidadesMedidaInsertar @UnidadesMedida_Descripcion VARCHAR(50),
									@UnidadesMedida_Abreviatura VARCHAR(3),
									@UnidadesMedida_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TUnidadesMedida(UnidadesMedida_Descripcion,
							UnidadesMedida_Abreviatura,
							UnidadesMedida_Estado) 

	SELECT  @UnidadesMedida_Descripcion,
			 @UnidadesMedida_Abreviatura,
			 @UnidadesMedida_Estado
			
END
GO
-- UnidadesMedidaInsertar 'descricion', 'abr', 'A'
/*==================================================================================================*/
/*===================MODIFICAR Unidades de medida ============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaModificar @UnidadesMedida_id INT,
									@UnidadesMedida_Descripcion VARCHAR(50),
									@UnidadesMedida_Abreviatura VARCHAR(3),
									@UnidadesMedida_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TUnidadesMedida
		SET	UnidadesMedida_Descripcion = @UnidadesMedida_Descripcion,
			UnidadesMedida_Abreviatura = @UnidadesMedida_Abreviatura,
			UnidadesMedida_Estado = @UnidadesMedida_Estado
	
		WHERE UnidadesMedida_id = @UnidadesMedida_id
	END
GO
-- UnidadesMedidaModificar 1, 'des', 'abr', 'A'
/*==================================================================================================*/
/*===================INACTIVAR Unidades de medida ============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaInactivar @UnidadesMedida_id INT
AS
	BEGIN
		UPDATE TUnidadesMedida
		SET UnidadesMedida_Estado = 'I'
		WHERE UnidadesMedida_id = @UnidadesMedida_id
END
GO
-- UnidadesMedidaInactivar 1
/*==================================================================================================*/
/*==================ACTIVAR Unidades de medida ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaActivar @UnidadesMedida_id INT
AS
	BEGIN
		UPDATE TUnidadesMedida
		SET UnidadesMedida_Estado = 'A'
		WHERE UnidadesMedida_id = @UnidadesMedida_id
END
GO
-- UnidadesMedidaActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Unidades de medida =============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaEliminar @UnidadesMedida_id INT 								
AS
BEGIN 
	DELETE FROM TUnidadesMedida
	WHERE UnidadesMedida_id = @UnidadesMedida_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- UnidadesMedidaEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Unidades de medida =================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaConsultar @UnidadesMedida_id INT
AS
BEGIN
	 SELECT *
	 FROM TUnidadesMedida
	 WHERE UnidadesMedida_id = @UnidadesMedida_id
END
GO
-- UnidadesMedidaConsultar 1
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Unidades de medida =================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaListarA
AS
BEGIN
	SELECT *
	FROM TUnidadesMedida
	WHERE UnidadesMedida_Estado = 'A'
END
GO
-- UnidadesMedidaListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Unidades de medida =================================*/
/*==================================================================================================*/
CREATE PROCEDURE UnidadesMedidaListarI
AS
BEGIN
	SELECT *
	FROM TUnidadesMedida
	WHERE UnidadesMedida_Estado = 'I'
END
GO
-- UnidadesMedidaListarI
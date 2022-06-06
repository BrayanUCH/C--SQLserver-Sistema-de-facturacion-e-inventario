/*==================================================================================================*/
/*===================INSERTAR Familia =============================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE FamiliaInsertar @Familia_Codigo VARCHAR(10),
									@Familia_tipo VARCHAR(50),
									@Familia_descripcion VARCHAR(100),
									@Familia_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TFamilia(Familia_Codigo,
							Familia_tipo,
							Familia_descripcion,
							Familia_estado) 

	SELECT  @Familia_Codigo,
			 @Familia_tipo,
			 @Familia_descripcion,
			 @Familia_estado
			
END
GO
-- FamiliaInsertar 'codigo', 'tipo', 'descripcion', 'A'
/*==================================================================================================*/
/*===================MODIFICAR Familia ============================================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaModificar @Familia_id INT,
									@Familia_Codigo VARCHAR(10),
									@Familia_tipo VARCHAR(50),
									@Familia_descripcion VARCHAR(100),
									@Familia_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TFamilia
		SET	Familia_Codigo = @Familia_Codigo,
			Familia_tipo = @Familia_tipo,
			Familia_descripcion = @Familia_descripcion,
			Familia_estado = @Familia_estado
	
		WHERE Familia_id = @Familia_id
	END
GO
-- FamiliaModificar 1, 'codigos', 'tipos', 'descripciones', 'A'
/*==================================================================================================*/
/*===================INACTIVAR Familia ============================================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaInactivar @Familia_id INT
AS
	BEGIN
		UPDATE TFamilia
		SET Familia_estado = 'I'
		WHERE Familia_id = @Familia_id
END
GO
-- FamiliaInactivar 1
/*==================================================================================================*/
/*==================ACTIVAR Familia ===============================================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaActivar @Familia_id INT
AS
	BEGIN
		UPDATE TFamilia
		SET Familia_estado = 'A'
		WHERE Familia_id = @Familia_id
END
GO
-- FamiliaActivar 1
/*==================================================================================================*/
/*===================ELIMINAR EMPLEADO =============================================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaEliminar @Familia_id INT 								
AS
BEGIN 
	DELETE FROM TFamilia
	WHERE Familia_id = @Familia_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- FamiliaEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Familia =================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaConsultar @Familia_id INT
AS
BEGIN
	 SELECT *
	 FROM TFamilia
	 WHERE Familia_id = @Familia_id
END
GO
-- FamiliaConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Familia =================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaListarA
AS
BEGIN
	SELECT *
	FROM TFamilia
	WHERE Familia_estado = 'A'
END
GO
-- FamiliaListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Familia =================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaListarI
AS
BEGIN
	SELECT *
	FROM TFamilia
	WHERE Familia_estado = 'I'
END
GO
-- FamiliaListarI
/*==================================================================================================*/
/*==================================================================================================*/

CREATE PROCEDURE FamiliaConsultarCodigo @Familia_codigo VARCHAR(10)
AS
BEGIN
	 SELECT *
	 FROM TFamilia
	 WHERE Familia_Codigo = @Familia_codigo
END
GO
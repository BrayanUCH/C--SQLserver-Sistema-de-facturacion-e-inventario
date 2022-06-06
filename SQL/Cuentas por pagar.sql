/*==================================================================================================*/
/*===================INSERTAR Cuentas por pagar ==========================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE CuentasXPagarInsertar @CuentasXPagar_ProveedorID INT,
									@CuentasXPagar_Descripcion VARCHAR(100),
									@CuentasXPagar_FechaPago VARCHAR(50),
									@CuentasXPagar_Monto FLOAT,
									@CuentasXPagar_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TCuentasXPagar(CuentasXPagar_ProveedorID,
							CuentasXPagar_Descripcion,
							CuentasXPagar_FechaPago,
							CuentasXPagar_Monto,
							CuentasXPagar_Estado)

	SELECT  @CuentasXPagar_ProveedorID,
			@CuentasXPagar_Descripcion,
			@CuentasXPagar_FechaPago,
			@CuentasXPagar_Monto,
			@CuentasXPagar_Estado
END
GO
-- CuentasXPagarInsertar 1,1,'des','fecha',1333,'A'
/*==================================================================================================*/
/*===================MODIFICAR Cuentas por pagar ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarModificar @CuentasXPagar_id INT,
									@CuentasXPagar_ProveedorID INT,
									@CuentasXPagar_Descripcion VARCHAR(100),
									@CuentasXPagar_FechaPago VARCHAR(50),
									@CuentasXPagar_Monto FLOAT,
									@CuentasXPagar_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TCuentasXPagar
		SET	CuentasXPagar_ProveedorID = @CuentasXPagar_ProveedorID,
			CuentasXPagar_Descripcion = @CuentasXPagar_Descripcion,
			CuentasXPagar_FechaPago = @CuentasXPagar_FechaPago,
			CuentasXPagar_Monto = @CuentasXPagar_Monto,
			CuentasXPagar_Estado = @CuentasXPagar_Estado
				
		WHERE CuentasXPagar_id = @CuentasXPagar_id
	END
GO
-- CuentasXPagarModificar 1,1,1,'desc','fechas',22222,'A'
/*==================================================================================================*/
/*===================INACTIVAR Cuentas por pagar ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarInactivar @CuentasXPagar_id INT
AS
	BEGIN
		UPDATE TCuentasXPagar
		SET CuentasXPagar_Estado = 'I'
		WHERE CuentasXPagar_id = @CuentasXPagar_id
END
GO
--CuentasXPagarInactivar 2
/*==================================================================================================*/
/*==================ACTIVAR Cuentas por pagar ===========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarActivar @CuentasXPagar_id INT
AS
	BEGIN
		UPDATE TCuentasXPagar
		SET CuentasXPagar_Estado = 'A'
		WHERE CuentasXPagar_id = @CuentasXPagar_id
END
GO
-- CuentasXPagarActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Cuentas por pagar =========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarEliminar @CuentasXPagar_id INT 								
AS
BEGIN 
	DELETE FROM TCuentasXPagar
	WHERE CuentasXPagar_id = @CuentasXPagar_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- CuentasXPagarEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cuentas por pagar =============================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarConsultar @CuentasXPagar_id INT
AS
BEGIN
	 SELECT *
	 FROM TCuentasXPagar
	 WHERE CuentasXPagar_id = @CuentasXPagar_id
END
GO
-- CuentasXPagarConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cuentas por pagar =============================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarListarA
AS
BEGIN
	SELECT *
	FROM TCuentasXPagar
	WHERE CuentasXPagar_Estado = 'A'
END
GO
-- CuentasXPagarListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cuentas por pagar =============================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarListarI
AS
BEGIN
	SELECT *
	FROM TCuentasXPagar
	WHERE CuentasXPagar_Estado = 'I'
END
GO
-- CuentasXPagarListarI
/*==================================================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE CuentasXPagarConsultarIdProveedor @CuentasXPagar_ProveedorID int
AS
BEGIN
	 SELECT *
	 FROM TCuentasXPagar
	 WHERE CuentasXPagar_ProveedorID = @CuentasXPagar_ProveedorID
END
GO
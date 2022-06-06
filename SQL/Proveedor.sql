/*==================================================================================================*/
/*===================INSERTAR Proveedor ==========================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE ProveedorInsertar @Proveedor_Cedula VARCHAR(20),
									@Proveedor_Codigo VARCHAR(10),
									@Proveedor_NombreORazonSocial VARCHAR(100),
									@Proveedor_FechaIngreso VARCHAR(10),
									@Proveedor_Saldo FLOAT,
									@Proveedor_CuentaDelBanco VARCHAR(50),
									@Proveedor_Banco VARCHAR(50),
									@Proveedor_DiasDePago VARCHAR(50),
									@Proveedor_Telefono VARCHAR(20),
									@Proveedor_CorreoElectronico VARCHAR(100),
									@Proveedor_Estado VARCHAR(3)
AS
BEGIN
	INSERT INTO TProveedor(Proveedor_Cedula,
							Proveedor_Codigo,
							Proveedor_NombreORazonSocial,
							Proveedor_FechaIngreso,
							Proveedor_Saldo,
							Proveedor_CuentaDelBanco,
							Proveedor_Banco,
							Proveedor_DiasDePago,
							Proveedor_Telefono,
							Proveedor_CorreoElectronico,
							Proveedor_Estado)

	SELECT  @Proveedor_Cedula,
			@Proveedor_Codigo,
			@Proveedor_NombreORazonSocial,
			@Proveedor_FechaIngreso,
			@Proveedor_Saldo,
			@Proveedor_CuentaDelBanco,
			@Proveedor_Banco,
			@Proveedor_DiasDePago,
			@Proveedor_Telefono,
			@Proveedor_CorreoElectronico,
			@Proveedor_Estado
END
GO
-- ProveedorInsertar '601110111','Nombre', '2021-01-01', 2.2, 'cuenta', 'BCR', 'los 15', '8888 8888', 'correo', 'A'
/*==================================================================================================*/
/*===================MODIFICAR Proveedor ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ProveedorModificar @Proveedor_id int,
									@Proveedor_Cedula VARCHAR(20),
									@Proveedor_Codigo VARCHAR(10),
									@Proveedor_NombreORazonSocial VARCHAR(100),
									@Proveedor_FechaIngreso VARCHAR(10),
									@Proveedor_Saldo FLOAT,
									@Proveedor_CuentaDelBanco VARCHAR(50),
									@Proveedor_Banco VARCHAR(50),
									@Proveedor_DiasDePago VARCHAR(50),
									@Proveedor_Telefono VARCHAR(20),
									@Proveedor_CorreoElectronico VARCHAR(100),
									@Proveedor_Estado VARCHAR(3)
AS
	BEGIN
		UPDATE TProveedor
		SET	Proveedor_Cedula = @Proveedor_Cedula,
			Proveedor_Codigo = @Proveedor_Codigo,
			Proveedor_NombreORazonSocial = @Proveedor_NombreORazonSocial,
			Proveedor_FechaIngreso = @Proveedor_FechaIngreso,
			Proveedor_Saldo = @Proveedor_Saldo,
			Proveedor_CuentaDelBanco = @Proveedor_CuentaDelBanco,
			Proveedor_Banco = @Proveedor_Banco,
			Proveedor_DiasDePago = @Proveedor_DiasDePago,
			Proveedor_Telefono = @Proveedor_Telefono,
			Proveedor_CorreoElectronico = @Proveedor_CorreoElectronico,
			Proveedor_Estado = @Proveedor_Estado

		WHERE Proveedor_id = @Proveedor_id
	END
GO
-- ProveedorModificar 2,'0','0', '2021-01-01', 2.2, '0', '0', '0', '0', '0', 'A'
/*==================================================================================================*/
/*===================INACTIVAR Proveedor ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ProveedorInactivar @Proveedor_id INT
AS
	BEGIN
		UPDATE TProveedor
		SET Proveedor_Estado = 'I'
		WHERE Proveedor_id = @Proveedor_id
END
GO
-- ProveedorInactivar 1
/*==================================================================================================*/
/*==================ACTIVAR Proveedor ===========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ProveedorActivar @Proveedor_id INT
AS
	BEGIN
		UPDATE TProveedor
		SET Proveedor_Estado = 'A'
		WHERE Proveedor_id = @Proveedor_id
END
GO
-- ProveedorActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Proveedor =========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ProveedorEliminar @Proveedor_id INT 								
AS
BEGIN 
	DELETE FROM TProveedor
	WHERE Proveedor_id = @Proveedor_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- ProveedorEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Proveedor =============================*/
/*==================================================================================================*/

CREATE PROCEDURE ProveedorConsultar @Proveedor_id INT
AS
BEGIN
	 SELECT *
	 FROM TProveedor
	 WHERE Proveedor_id = @Proveedor_id
END
GO
-- ProveedorConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Proveedor =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ProveedorListarA
AS
BEGIN
	SELECT *
	FROM TProveedor
	WHERE Proveedor_Estado = 'A'
END
GO
-- ProveedorListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Proveedor =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ProveedorListarI
AS
BEGIN
	SELECT *
	FROM TProveedor
	WHERE Proveedor_Estado = 'I'
END
GO
-- ProveedorListarI
/*==================================================================================================*/
/*==================================================================================================*/

CREATE PROCEDURE ProveedorConsultarCodigo @Proveedor_Codigo VARCHAR(10)
AS
BEGIN
	 SELECT *
	 FROM TProveedor
	 WHERE Proveedor_Codigo = @Proveedor_Codigo 
END
GO
/*==================================================================================================*/
/*==================================================================================================*/

CREATE PROCEDURE ProveedorConsultarCedula @Proveedor_Cedula VARCHAR(20)
AS
BEGIN
	 SELECT *
	 FROM TProveedor
	 WHERE Proveedor_Cedula = @Proveedor_Cedula
END
GO
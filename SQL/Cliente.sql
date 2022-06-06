/*==================================================================================================*/
/*===================INSERTAR Cliente ==========================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE ClienteInsertar @Cliente_nombre VARCHAR(50),
									@Cliente_Cedula VARCHAR(20),
									@Cliente_CorreoElectronico VARCHAR(100),
									@Cliente_Telefono VARCHAR(20),
									@Cliente_FechaNacimiento VARCHAR(10),
									@Cliente_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TCliente(Cliente_nombre,
							Cliente_Cedula,
							Cliente_CorreoElectronico,
							Cliente_Telefono,
							Cliente_FechaNacimiento,
							Cliente_Estado)

	SELECT  @Cliente_nombre,
			@Cliente_Cedula,
			@Cliente_CorreoElectronico,
			@Cliente_Telefono,
			@Cliente_FechaNacimiento,
			@Cliente_Estado			
END
GO
-- ClienteInsertar 'nombre','cedula','correo','8888 8888','2000-02-02','A'
/*==================================================================================================*/
/*===================MODIFICAR Cliente ========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE ClienteModificar @Cliente_id int,
									@Cliente_nombre VARCHAR(50),
									@Cliente_Cedula VARCHAR(20),
									@Cliente_CorreoElectronico VARCHAR(100),
									@Cliente_Telefono VARCHAR(20),
									@Cliente_FechaNacimiento VARCHAR(10),
									@Cliente_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TCliente
		SET	Cliente_nombre = @Cliente_nombre,
			Cliente_Cedula = @Cliente_Cedula,
			Cliente_CorreoElectronico = @Cliente_CorreoElectronico,
			Cliente_Telefono = @Cliente_Telefono,
			Cliente_FechaNacimiento = @Cliente_FechaNacimiento,
			Cliente_Estado = @Cliente_Estado
				
		WHERE Cliente_id = @Cliente_id
	END
GO
-- ClienteModificar 1, 'nombres','cedulaa','correoa','8888-8888','2000-02-02','A'
/*==================================================================================================*/
/*===================INACTIVAR Cliente ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteInactivar @Cliente_id INT
AS
	BEGIN
		UPDATE TCliente
		SET Cliente_Estado = 'I'
		WHERE Cliente_id = @Cliente_id
END
GO
-- ClienteInactivar 2
/*==================================================================================================*/
/*==================ACTIVAR Inventario ===========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteActivar @Cliente_id INT
AS
	BEGIN
		UPDATE TCliente
		SET Cliente_Estado = 'A'
		WHERE Cliente_id = @Cliente_id
END
GO
-- ClienteActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Cliente =========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteEliminar @Cliente_id INT 								
AS
BEGIN 
	DELETE FROM TCliente
	WHERE Cliente_id = @Cliente_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- ClienteEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cliente =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteConsultar @Cliente_id INT
AS
BEGIN
	 SELECT *
	 FROM TCliente
	 WHERE Cliente_id = @Cliente_id
END
GO
-- ClienteConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cliente =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteListarA
AS
BEGIN
	SELECT *
	FROM TCliente
	WHERE Cliente_Estado = 'A'
END
GO
-- ClienteListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cliente =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteListarI
AS
BEGIN
	SELECT *
	FROM TCliente
	WHERE Cliente_Estado = 'I'
END
GO
-- ClienteListarI

/*==================================================================================================*/
/*========================== CONSULTAR Articulos filtrando =========================================*/
/*==================================================================================================*/
CREATE PROCEDURE ClientesListarFiltrado @Filtro Varchar(20)
AS
BEGIN
	SELECT *
	FROM TCliente c 
	WHERE c.Cliente_Cedula like '%'+@Filtro +'%' and c.Cliente_Estado = 'A'
END
GO
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Cliente mediante la cedula ===============*/
/*==================================================================================================*/
CREATE PROCEDURE ClienteConsultarCedula @Cliente_Cedula VARCHAR(20)
AS
BEGIN
	 SELECT *
	 FROM TCliente
	 WHERE Cliente_Cedula = @Cliente_Cedula
END
GO
/*==================================================================================================*/
/*===================INSERTAR LOGIN ================================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE LoginInsertar @Login_Usuario VARCHAR(10),
									@Login_Nombre VARCHAR(50),
									@Login_contraseña VARCHAR(8),
									@Login_correoElectronico VARCHAR(100),
									@Login_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TLogin(Login_Usuario,
							Login_Nombre,
							Login_contraseña,
							Login_correoElectronico,
							Login_estado) 

	SELECT  @Login_Usuario,
			@Login_Nombre,
			@Login_contraseña,
			@Login_correoElectronico,
			@Login_estado
			
END
GO
-- LoginInsertar 'Usuario', 'nombre', 'contra', 'correo', 'A'
/*==================================================================================================*/
/*===================MODIFICAR LOGIN ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginModificar @Login_id INT,
							@Login_Usuario VARCHAR(10),
							@Login_Nombre VARCHAR(50),
							@Login_contraseña VARCHAR(8),
							@Login_correoElectronico VARCHAR(100),
							@Login_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TLogin
		SET	Login_Usuario = @Login_Usuario,
			Login_Nombre = @Login_Nombre,
			Login_contraseña = @Login_contraseña,
			Login_correoElectronico = @Login_correoElectronico,
			Login_estado = @Login_estado
	
		WHERE Login_id = @Login_id
	END
GO
/*==================================================================================================*/
/*===================MODIFICAR CONTRASEÑA ==========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginModificarContraseña @Login_id INT,
							@Login_contraseña VARCHAR(8)
AS
	BEGIN
		UPDATE TLogin
		SET	
			Login_contraseña = @Login_contraseña

		WHERE Login_id = @Login_id
	END
GO
/*==================================================================================================*/
/*===================INACTIVAR LOGIN ===============================================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginInactivar @Login_id INT
AS
	BEGIN
		UPDATE TLogin
		SET Login_estado = 'I'
		WHERE Login_id = @Login_id
END
GO
-- LoginInactivar 1
/*==================================================================================================*/
/*==================ACTIVAR LOGIN ==================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginActivar @Login_id INT
AS
	BEGIN
		UPDATE TLogin
		SET Login_estado = 'A'
		WHERE Login_id = @Login_id
END
GO
-- LoginActivar 2
/*==================================================================================================*/
/*===================ELIMINAR LOGIN ================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginEliminar @Login_id INT 								
AS
BEGIN 
	DELETE FROM TLogin
	WHERE Login_id = @Login_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- LoginEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACION DE UN LOGIN =====================================*/
/*==================================================================================================*/

CREATE PROCEDURE LoginConsultar @Login_id INT
AS
BEGIN
	 SELECT *
	 FROM TLogin
	 WHERE Login_id = @Login_id
END
GO
-- LoginConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN LOGIN =====================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginListarA
AS
BEGIN
	SELECT *
	FROM TLogin
	WHERE Login_estado = 'A'
END
GO
-- LoginListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN LOGIN =====================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginListarI
AS
BEGIN
	SELECT *
	FROM TLogin
	WHERE Login_estado = 'I'
END
GO
-- LoginListarI
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN LOGIN =====================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginConsultarUsuario @Login_Usuario Varchar(10)
AS
BEGIN
	 SELECT *
	 FROM TLogin
	 WHERE Login_Usuario = @Login_Usuario AND Login_estado != 'I'
END
GO
-- LoginConsultarUsuario 'Usuarios'
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UN LOGIN =====================================*/
/*==================================================================================================*/
CREATE PROCEDURE LoginConsultarCorreo @Login_correoElectronico Varchar(50)
AS
BEGIN
	 SELECT *
	 FROM TLogin
	 WHERE Login_correoElectronico = @Login_correoElectronico AND Login_estado != 'I'
END
GO
-- LoginConsultarCorreo 'correo'
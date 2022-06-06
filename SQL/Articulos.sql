/*==================================================================================================*/
/*===================INSERTAR Articulos ==========================================================*/
/*==================================================================================================*/
--ALTER CREATE 
CREATE PROCEDURE ArticulosInsertar @Articulos_Codigo VARCHAR(10),
									@Articulos_Descripcion VARCHAR(100),
									@Articulos_Nombre VARCHAR(50),
									@Articulos_FamiliaID VARCHAR(10),/*ID*/
									@Articulos_UnidadesMedidaID VARCHAR(3),/*ID*/
									@Articulos_CantidadUnidadesMedida FLOAT,
									@Articulos_Precio FLOAT,
									@Articulos_Descuento FLOAT,
									@Articulos_Impuesto FLOAT,
									@Articulos_Estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TArticulos(Articulos_Codigo,
							Articulos_Descripcion,
							Articulos_Nombre,
							Articulos_FamiliaID,
							Articulos_UnidadesMedidaID,
							Articulos_CantidadUnidadesMedida,
							Articulos_Precio,
							Articulos_Descuento,
							Articulos_Impuesto,
							Articulos_Estado) 

	SELECT  @Articulos_Codigo,
			@Articulos_Descripcion,
			@Articulos_Nombre,
			@Articulos_FamiliaID,
			@Articulos_UnidadesMedidaID,
			@Articulos_CantidadUnidadesMedida,
			@Articulos_Precio,
			@Articulos_Descuento,
			@Articulos_Impuesto,
			@Articulos_Estado
			
END
GO
-- ArticulosInsertar 'abc','descripcion','nombre',1,1,1,1000,0,13,'A'
/*==================================================================================================*/
/*===================MODIFICAR Articulos ========================================================*/
/*==================================================================================================*/

CREATE PROCEDURE ArticulosModificar @Articulos_id INT,
									@Articulos_Codigo VARCHAR(10),
									@Articulos_Descripcion VARCHAR(100),
									@Articulos_Nombre VARCHAR(50),
									@Articulos_FamiliaID VARCHAR(10),/*ID*/
									@Articulos_UnidadesMedidaID VARCHAR(3),/*ID*/
									@Articulos_CantidadUnidadesMedida FLOAT,
									@Articulos_Precio FLOAT,
									@Articulos_Descuento FLOAT,
									@Articulos_Impuesto FLOAT,
									@Articulos_Estado VARCHAR(1)
AS
	BEGIN
		UPDATE TArticulos
		SET	Articulos_Codigo = @Articulos_Codigo,
			Articulos_Descripcion = @Articulos_Descripcion,
			Articulos_Nombre = @Articulos_Nombre,
			Articulos_FamiliaID = @Articulos_FamiliaID,
			Articulos_UnidadesMedidaID = @Articulos_UnidadesMedidaID,
			Articulos_CantidadUnidadesMedida = @Articulos_CantidadUnidadesMedida,
			Articulos_Precio = @Articulos_Precio,
			Articulos_Descuento = @Articulos_Descuento,
			Articulos_Impuesto = @Articulos_Impuesto,
			Articulos_Estado = @Articulos_Estado
				
		WHERE Articulos_id = @Articulos_id
	END
GO
-- ArticulosModificar 1 ,'abcv','descripciones','nombres',12,12,2,2000,2,12,'A'
/*==================================================================================================*/
/*===================INACTIVAR Articulos ========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosInactivar @Articulos_id INT
AS
	BEGIN
		UPDATE TArticulos
		SET Articulos_Estado = 'I'
		WHERE Articulos_id = @Articulos_id
END
GO
-- ArticulosInactivar 1
/*==================================================================================================*/
/*==================ACTIVAR Articulos ===========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosActivar @Articulos_id INT
AS
	BEGIN
		UPDATE TArticulos
		SET Articulos_Estado = 'A'
		WHERE Articulos_id = @Articulos_id
END
GO
-- ArticulosActivar 1
/*==================================================================================================*/
/*===================ELIMINAR Articulos =========================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosEliminar @Articulos_id INT 								
AS
BEGIN 
	DELETE FROM TArticulos
	WHERE Articulos_id = @Articulos_id
	SELECT 'SE HA ELIMINADO CON EXITO' 		
	
END
GO
-- ArticulosEliminar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Articulos =============================*/
/*==================================================================================================*/ 
CREATE PROCEDURE ArticulosConsultar @Articulos_id INT
AS
BEGIN
	 SELECT *
	 FROM TArticulos
	 WHERE Articulos_id = @Articulos_id
END
GO
-- ArticulosConsultar 2
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Articulos =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosListarA
AS
BEGIN
	SELECT *
	FROM TArticulos
	WHERE Articulos_Estado = 'A'
END
GO
-- ArticulosListarA
/*==================================================================================================*/
/*===================CONSULTAR TODA LA INFORMACI�N DE UNA Articulos =============================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosListarI
AS
BEGIN
	SELECT *
	FROM TArticulos
	WHERE Articulos_Estado = 'I'
END
GO
-- ArticulosListarI

/*==================================================================================================*/
/*=============== CONSULTAR TODA LA INFORMACI�N DE UNA Articulos filtrando =========================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosListarFiltradoPF @Producto Varchar(50), @Familia Varchar(10)
AS
BEGIN
	SELECT *
	FROM TArticulos a
	WHERE exists (select * from TInventario i  where i.Inventario_ArticuloID = a.Articulos_id and i.Inventario_Tipo = 'L') and 
	a.Articulos_FamiliaID like '%'+@Familia+'%'  and  a.Articulos_Nombre like '%'+@Producto+'%' and a.Articulos_Estado = 'A'
END
GO

/*==================================================================================================*/
/*========================== CONSULTAR Articulos filtrando producto ================================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosListarFiltradoF @Familia Varchar(10)
AS
BEGIN
	SELECT *
	FROM TArticulos a
	WHERE exists (select * from TInventario i  where i.Inventario_ArticuloID = a.Articulos_id and i.Inventario_Tipo = 'L') and 
	a.Articulos_FamiliaID like '%'+@Familia+'%' and a.Articulos_Estado = 'A'
END
GO

/*==================================================================================================*/
/*========================== CONSULTAR Articulos filtrando familia =================================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosListarFiltradoP @Producto Varchar(50)
AS
BEGIN
	SELECT *
	FROM TArticulos a
	WHERE exists (select * from TInventario i  where i.Inventario_ArticuloID = a.Articulos_id and i.Inventario_Tipo = 'L') and 
	a.Articulos_Nombre like '%'+@Producto+'%' and a.Articulos_Estado = 'A'
END
GO
/*==================================================================================================*/
/*==================================================================================================*/
CREATE PROCEDURE ArticulosListarFiltradoProducto @Producto Varchar(50)
AS
BEGIN
	SELECT *
	FROM TArticulos a
	WHERE a.Articulos_Nombre like '%'+@Producto+'%' and a.Articulos_Estado = 'A'
END
GO
CREATE DATABASE SisQuerubin
go
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TFamilia (Familia_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							Familia_Codigo VARCHAR(10),
							Familia_tipo VARCHAR(50),
							Familia_descripcion VARCHAR(100),
							Familia_estado VARCHAR(1)
							)
ALTER TABLE TFamilia ADD CONSTRAINT TFamilia_PK PRIMARY KEY (Familia_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TLogin (Login_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							Login_Usuario VARCHAR(10),
							Login_Nombre VARCHAR(50),
							Login_contraseña VARCHAR(8),
							Login_correoElectronico VARCHAR(100),
							Login_estado VARCHAR(1)
							)
ALTER TABLE TLogin ADD CONSTRAINT TLogin_PK PRIMARY KEY (Login_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TCliente (Cliente_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							Cliente_nombre VARCHAR(50),
							Cliente_Cedula VARCHAR(20),
							Cliente_CorreoElectronico VARCHAR(100),
							Cliente_Telefono VARCHAR(20),
							Cliente_FechaNacimiento VARCHAR(10),
							Cliente_Estado VARCHAR(1)
							)
ALTER TABLE TCliente ADD CONSTRAINT TCliente_PK PRIMARY KEY (Cliente_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TUnidadesMedida (UnidadesMedida_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							UnidadesMedida_Descripcion VARCHAR(50),
							UnidadesMedida_Abreviatura VARCHAR(3),
							UnidadesMedida_Estado VARCHAR(1)
							)
ALTER TABLE TUnidadesMedida ADD CONSTRAINT UnidadesMedida_PK PRIMARY KEY (UnidadesMedida_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TProveedor (Proveedor_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							  Proveedor_Cedula VARCHAR(20),
							  Proveedor_Codigo VARCHAR(10),
							  Proveedor_NombreORazonSocial VARCHAR(100),
							  Proveedor_FechaIngreso VARCHAR(10),
							  Proveedor_Saldo FLOAT,
							  Proveedor_CuentaDelBanco VARCHAR(50),
							  Proveedor_Banco VARCHAR(50),
							  Proveedor_DiasDePago VARCHAR(50),
							  Proveedor_Telefono VARCHAR(20),
							  Proveedor_CorreoElectronico VARCHAR(100),
							  Proveedor_Estado VARCHAR(3)
							)	   
ALTER TABLE TProveedor ADD CONSTRAINT TProveeedor_PK PRIMARY KEY (Proveedor_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TCuentasXPagar (CuentasXPagar_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							  CuentasXPagar_ProveedorID INT, /*ID*/
							  CuentasXPagar_Descripcion VARCHAR(100),
							  CuentasXPagar_FechaPago VARCHAR(50),
							  CuentasXPagar_Monto FLOAT,
							  CuentasXPagar_Estado VARCHAR(3)
							)
ALTER TABLE TCuentasXPagar ADD CONSTRAINT TCuentasXPagar_PK PRIMARY KEY (CuentasXPagar_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TArticulos (Articulos_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							Articulos_Codigo VARCHAR(10),
							Articulos_Descripcion VARCHAR(100),
							Articulos_Nombre VARCHAR(50),
							Articulos_FamiliaID VARCHAR(10),/*ID*/
							Articulos_UnidadesMedidaID VARCHAR(3),/*ID*/
							Articulos_CantidadUnidadesMedida FLOAT,
							Articulos_Precio FLOAT,
							Articulos_Descuento FLOAT,
							Articulos_Impuesto FLOAT,
							Articulos_Estado VARCHAR(1)
							)
ALTER TABLE TArticulos ADD CONSTRAINT TArticulos_PK PRIMARY KEY (Articulos_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TFacturacion  (Facturacion_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							Facturacion_Observaciones VARCHAR(150),/*Factura o cuanta por pagar*/
							Facturacion_ClienteID INT,
							Facturacion_Descuento FLOAT,
							Facturacion_Impuesto FLOAT,
							Facturacion_NumeroArticulos int,
							Facturacion_SubTotal FLOAT,
							Facturacion_Total FLOAT,
							Facturacion_Fecha VARCHAR(10),
							Facturacion_Estado VARCHAR(1)
							)
ALTER TABLE TFacturacion ADD CONSTRAINT TFacturacion_PK PRIMARY KEY (Facturacion_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TDetalleFactura (DetalleFactura_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							DetalleFactura_ArticulosID INT, /*ID*/
							DetalleFactura_FacturacionID INT, /*ID*/
							DetalleFactura_Cantidad FLOAT,
							DetalleFactura_Descuento FLOAT,
							DetalleFactura_Impuesto FLOAT,
							DetalleFactura_Precio FLOAT,
							DetalleFactura_Estado VARCHAR(1)
							)
ALTER TABLE TDetalleFactura ADD CONSTRAINT TDetalleFactura_PK PRIMARY KEY (DetalleFactura_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/
CREATE TABLE TInventario (Inventario_id INT IDENTITY(1,1),/*LLAVE PRIMARIA*/
							Inventario_ArticuloID INT,/*ID*/
							Inventario_Cantidad FLOAT,
							Inventario_Tipo VARCHAR(1),
							Inventario_Estado VARCHAR(1)
							)
ALTER TABLE TInventario ADD CONSTRAINT TTInventario_PK PRIMARY KEY (Inventario_id)/*Llave primaria*/
/*...................................................................................................
.....................................................................................................*/

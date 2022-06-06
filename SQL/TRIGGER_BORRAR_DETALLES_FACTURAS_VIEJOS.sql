CREATE TRIGGER BORRAR_DETALLES ON TFacturacion FOR DELETE
AS 

Delete from TDetalleFactura 
where DetalleFactura_FacturacionID IN (SELECT deleted.Facturacion_id FROM deleted) 

go




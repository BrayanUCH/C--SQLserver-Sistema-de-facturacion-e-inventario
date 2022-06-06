using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVerduleria.CapaLogica.LogicaNegocio;
using SistemaVerduleria.CapaLogica.Servicios;
using System.Data;
using SistemaVerduleria.CapaConexion;

namespace SistemaVerduleria.CapaIntegracion
{
    public class GestorDetalleFactura : servicio, IDisposable
    {
        public GestorDetalleFactura()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(int detalleFactura_ArticulosID, int detalleFactura_FacturacionID, double detalleFactura_Cantidad, double detalleFactura_Descuento, double detallefactura_impuesto, double detalleFactura_Precio, string detalleFactura_Estado)
        {
            DetalleFactura insertarOBJ = new DetalleFactura(detalleFactura_ArticulosID, detalleFactura_FacturacionID, detalleFactura_Cantidad, detalleFactura_Descuento, detallefactura_impuesto, detalleFactura_Precio, detalleFactura_Estado);

            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int detalleFactura_id, int detalleFactura_ArticulosID, int detalleFactura_FacturacionID, int detalleFactura_Cantidad, double detalleFactura_Descuento, double detallefactura_impuesto, double detalleFactura_Precio, string detalleFactura_Estado)
        {
            DetalleFactura modificarOBJ = new DetalleFactura(detalleFactura_id, detalleFactura_ArticulosID, detalleFactura_FacturacionID, detalleFactura_Cantidad, detalleFactura_Descuento, detallefactura_impuesto, detalleFactura_Precio, detalleFactura_Estado);

            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
                return objServico.Modificar(modificarOBJ);
        }
        public object ListarA()
        {
            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
                return objServico.ListarI();
        } 
        public DataTable ListarIdFactura(int IdFactura)
        {
            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
                return objServico.ListarIdFactura(IdFactura);
        }
        public DataSet Consultar(int id)
        {
            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
            {
                return objServico.Consultar(id);
            }
        }

        public string Activar(int id)
        {
            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioDetalleFactura objServico = new ServicioDetalleFactura())
            {
                return objServico.Inactivar(id);
            }
        }
    }
}
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
    public class GestorFacturacion : servicio, IDisposable
    {
        public GestorFacturacion()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string facturacion_Observaciones, int facturacion_ClienteID, double facturacion_Descuento, double facturacion_Impuesto, int facturacion_NumeroArticulos, double facturacion_SubTotal, double facturacion_Total, string facturacion_Fecha, string facturacion_Estado)
        {
            Facturaccion insertarOBJ = new Facturaccion(facturacion_Observaciones, facturacion_ClienteID, facturacion_Descuento, facturacion_Impuesto, facturacion_NumeroArticulos, facturacion_SubTotal, facturacion_Total, facturacion_Fecha, facturacion_Estado);

            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.Insertar(insertarOBJ);
        }
        public string Modificar(int facturacion_id, string facturacion_Observaciones, int facturacion_ClienteID, double facturacion_Descuento, double facturacion_Impuesto, int facturacion_NumeroArticulos, double facturacion_SubTotal, double facturacion_Total, string facturacion_Fecha, string facturacion_Estado)
        {
            Facturaccion modificarOBJ = new Facturaccion(facturacion_id, facturacion_Observaciones, facturacion_ClienteID, facturacion_Descuento, facturacion_Impuesto, facturacion_NumeroArticulos, facturacion_SubTotal, facturacion_Total, facturacion_Fecha, facturacion_Estado);

            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.Modificar(modificarOBJ);
        }
        public DataTable ListarA()
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.ListarA();
        }

        public DataTable ListarI()
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.ListarI();
        }
        public DataTable ListarFiltradoId(int id)
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.ListarFiltradoId(id);
        }
        public DataTable ListarFiltradoFecha(string Fecha)
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.ListarFiltradoFecha(Fecha);
        }
        public DataSet UltimoRegistro()
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
                return objServico.UltimoRegistro();
        }

        public DataSet Consultar(int id)
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
            {
                return objServico.Consultar(id);
            }
        }

        public string Activar(int id)
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioFacturacion objServico = new ServicioFacturacion())
            {
                return objServico.Inactivar(id);
            }
        }
    }
}
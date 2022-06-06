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
    public class GestorCuentasPorPagar : servicio, IDisposable
    {
        public GestorCuentasPorPagar()
        {

        }
         
        public void Dispose()
        {

        }

        public string Insertar(int cuentasXPagar_ProveedorID, string cuentasXPagar_Descripcion, string cuentasXPagar_FechaPago, double cuentasXPagar_Monto, string cuentasXPagar_Estado)
        {
            CuentasPorPagar insertarOBJ = new CuentasPorPagar(cuentasXPagar_ProveedorID, cuentasXPagar_Descripcion, cuentasXPagar_FechaPago, cuentasXPagar_Monto, cuentasXPagar_Estado);

            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int cuentasXPagar_id, int cuentasXPagar_ProveedorID, string cuentasXPagar_Descripcion, string cuentasXPagar_FechaPago, double cuentasXPagar_Monto, string cuentasXPagar_Estado)
        {
            CuentasPorPagar modificarOBJ = new CuentasPorPagar(cuentasXPagar_id, cuentasXPagar_ProveedorID, cuentasXPagar_Descripcion, cuentasXPagar_FechaPago, cuentasXPagar_Monto, cuentasXPagar_Estado);

            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
                return objServico.Modificar(modificarOBJ);
        }
        public DataTable ListarA()
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
                return objServico.ListarI();
        }
        public DataSet Consultar(int id)
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
            {
                return objServico.Consultar(id);
            }
        }
        public DataTable ConsultarIdProveedor(int id)
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
            {
                return objServico.ConsultarIdProveedor(id);
            }
        }

        public string Activar(int id)
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioCuentasPorPagar objServico = new ServicioCuentasPorPagar())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}
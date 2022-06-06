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
    public class GestorInventario : servicio, IDisposable
    {
        public GestorInventario()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(int Inventario_ArticuloID, double Inventario_Cantidad,string Inventario_tipo, string Inventario_Estado)
        {
            Inventario insertarOBJ = new Inventario( Inventario_ArticuloID, Inventario_Cantidad, Inventario_tipo, Inventario_Estado);

            using (ServicioInventario objServico = new ServicioInventario())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int Inventario_id, int Inventario_ArticuloID, double Inventario_Cantidad, string Inventario_tipo, string Inventario_Estado)
        {
            Inventario modificarOBJ = new Inventario(Inventario_id, Inventario_ArticuloID, Inventario_Cantidad, Inventario_tipo, Inventario_Estado);

            using (ServicioInventario objServico = new ServicioInventario())
                return objServico.Modificar(modificarOBJ);
        }
        public DataTable ListarAB()
        {
            using (ServicioInventario objServico = new ServicioInventario())
                return objServico.ListarAB();
        }

        public DataTable ListarIB()
        {
            using (ServicioInventario objServico = new ServicioInventario())
                return objServico.ListarIB();
        }

        public DataTable ListarAL()
        {
            using (ServicioInventario objServico = new ServicioInventario())
                return objServico.ListarAL();
        }

        public DataTable ListarIL()
        {
            using (ServicioInventario objServico = new ServicioInventario())
                return objServico.ListarIL();
        }

        public DataSet Consultar(int id)
        {
            using (ServicioInventario objServico = new ServicioInventario())
            {
                return objServico.Consultar(id);
            }
        }

        public DataSet ConsultarExistenciaL(int id)
        {
            using (ServicioInventario objServico = new ServicioInventario())
            {
                return objServico.ConsultarExistenciaL(id);
            }
        }
        public DataSet ConsultarExistenciaB(int id)
        {
            using (ServicioInventario objServico = new ServicioInventario())
            {
                return objServico.ConsultarExistenciaB(id);
            }
        }

        public string Activar(int id)
        {
            using (ServicioInventario objServico = new ServicioInventario())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioInventario objServico = new ServicioInventario())
            {
                return objServico.Inactivar(id);
            }
        }
        
        public string Eliminar(int id)
        {
            using (ServicioInventario objServico = new ServicioInventario())
            {
                return objServico.Eliminar(id);
            }
        }

    }
}
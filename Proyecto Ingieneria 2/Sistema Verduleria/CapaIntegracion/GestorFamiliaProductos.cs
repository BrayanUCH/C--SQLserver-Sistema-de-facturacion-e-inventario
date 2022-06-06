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
    public class GestorFamiliaProductos : servicio, IDisposable
    {
        public GestorFamiliaProductos()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string familia_Codigo, string familia_tipo, string familia_descripcion, string familia_estado)
        {
            FamiliaProductos insertarOBJ = new FamiliaProductos(familia_Codigo, familia_tipo, familia_descripcion, familia_estado);
            
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int familia_id, string familia_Codigo, string familia_tipo, string familia_descripcion, string familia_estado)
        {
            FamiliaProductos modificarOBJ = new FamiliaProductos(familia_id, familia_Codigo, familia_tipo, familia_descripcion, familia_estado);

            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
                return objServico.Modificar(modificarOBJ);
        }
        public object ListarA()
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
                return objServico.ListarI();
        }
        public DataSet Consultar(int id)
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
            {
                return objServico.Consultar(id);
            }
        }
        public DataSet ConsultarCodigo(string codigo)
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
            {
                return objServico.ConsultarCodigo(codigo);
            }
        }

        public string Activar(int id)
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioFamiliaProductos objServico = new ServicioFamiliaProductos())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}
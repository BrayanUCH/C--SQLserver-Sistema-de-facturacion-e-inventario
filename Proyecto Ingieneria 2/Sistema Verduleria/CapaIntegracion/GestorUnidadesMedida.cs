using SistemaVerduleria.CapaConexion;
using SistemaVerduleria.CapaLogica.LogicaNegocio;
using SistemaVerduleria.CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaIntegracion
{
    public class GestorUnidadesMedida : servicio, IDisposable
    {
        public GestorUnidadesMedida()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string unidadesMedida_Descripcion, string unidadesMedida_Abreviatura, string unidadesMedida_Estado)
        {
            UnidadesMedida insertarOBJ = new UnidadesMedida(unidadesMedida_Descripcion, unidadesMedida_Abreviatura, unidadesMedida_Estado);

            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int unidadesMedida_id, string unidadesMedida_Descripcion, string unidadesMedida_Abreviatura, string unidadesMedida_Estado)
        {
            UnidadesMedida modificarOBJ = new UnidadesMedida(unidadesMedida_id, unidadesMedida_Descripcion, unidadesMedida_Abreviatura, unidadesMedida_Estado);

            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
                return objServico.Modificar(modificarOBJ);
        }
        public object ListarA()
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
                return objServico.ListarI();
        }
        public DataSet Consultar(int id)
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
            {
                return objServico.Consultar(id);
            }
        }
        public DataSet ConsultarAbreviatura(int abreviatura)
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
            {
                return objServico.ConsultarAbreviatura(abreviatura);
            }
        }

        public string Activar(int id)
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioUnidadesMedida objServico = new ServicioUnidadesMedida())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}

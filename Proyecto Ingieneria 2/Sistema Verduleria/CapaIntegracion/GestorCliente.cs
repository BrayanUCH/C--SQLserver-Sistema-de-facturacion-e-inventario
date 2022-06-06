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
    public class GestorCliente : servicio, IDisposable
    {
        public GestorCliente()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string cliente_nombre, string cliente_Cedula, string cliente_CorreoElectronico, string cliente_Telefono, string cliente_FechaNacimiento, string cliente_Estado)
        {
            Cliente insertarOBJ = new Cliente(cliente_nombre, cliente_Cedula, cliente_CorreoElectronico, cliente_Telefono, cliente_FechaNacimiento, cliente_Estado);

            using (ServicioCliente objServico = new ServicioCliente())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int cliente_id, string cliente_nombre, string cliente_Cedula, string cliente_CorreoElectronico, string cliente_Telefono, string cliente_FechaNacimiento, string cliente_Estado)
        {
            Cliente modificarOBJ = new Cliente(cliente_id, cliente_nombre, cliente_Cedula, cliente_CorreoElectronico, cliente_Telefono, cliente_FechaNacimiento, cliente_Estado);

            using (ServicioCliente objServico = new ServicioCliente())
                return objServico.Modificar(modificarOBJ);
        }
        public DataTable ListarA()
        {
            using (ServicioCliente objServico = new ServicioCliente())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioCliente objServico = new ServicioCliente())
                return objServico.ListarI();
        }
        public object ListarFiltrado(string filtro)
        {
            using (ServicioCliente objServico = new ServicioCliente())
                return objServico.ListarFiltrado(filtro);
        }
        public DataSet Consultar(int id)
        {
            using (ServicioCliente objServico = new ServicioCliente())
            {
                return objServico.Consultar(id);
            }
        }
        public DataSet ConsultarCedula(string cedula)
        {
            using (ServicioCliente objServico = new ServicioCliente())
            {
                return objServico.ConsultarCedula(cedula);
            }
        }
        public string Activar(int id)
        {
            using (ServicioCliente objServico = new ServicioCliente())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioCliente objServico = new ServicioCliente())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioCliente objServico = new ServicioCliente())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}


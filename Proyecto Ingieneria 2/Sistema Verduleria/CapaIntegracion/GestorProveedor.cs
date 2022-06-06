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
    public class GestorProveedor : servicio, IDisposable
    {
        public GestorProveedor()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string proveedor_Codigo, string proveedor_Cedula, string proveedor_NombreORazonSocial, DateTime proveedor_FechaIngreso, double proveedor_Saldo, string proveedor_CuentaDelBanco, string proveedor_Banco, string proveedor_DiasDePago, string proveedor_Telefono, string proveedor_CorreoElectronico, string proveedor_Estado)
        {
            Proveedor insertarOBJ = new Proveedor(proveedor_Codigo, proveedor_Cedula, proveedor_NombreORazonSocial, proveedor_FechaIngreso, proveedor_Saldo, proveedor_CuentaDelBanco, proveedor_Banco, proveedor_DiasDePago, proveedor_Telefono, proveedor_CorreoElectronico, proveedor_Estado);

            using (ServicioProveedor objServico = new ServicioProveedor())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int proveedor_id, string proveedor_Codigo, string proveedor_Cedula, string proveedor_NombreORazonSocial, DateTime proveedor_FechaIngreso, double proveedor_Saldo, string proveedor_CuentaDelBanco, string proveedor_Banco, string proveedor_DiasDePago, string proveedor_Telefono, string proveedor_CorreoElectronico, string proveedor_Estado)
        {
            Proveedor modificarOBJ = new Proveedor(proveedor_id, proveedor_Codigo, proveedor_Cedula, proveedor_NombreORazonSocial, proveedor_FechaIngreso, proveedor_Saldo, proveedor_CuentaDelBanco, proveedor_Banco, proveedor_DiasDePago, proveedor_Telefono, proveedor_CorreoElectronico, proveedor_Estado);

            using (ServicioProveedor objServico = new ServicioProveedor())
                return objServico.Modificar(modificarOBJ);
        }
        public DataTable ListarA()
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
                return objServico.ListarI();
        }
        public DataSet Consultar(int id)
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
            {
                return objServico.Consultar(id);
            }
        }
        public DataSet ConsultarCedula(string cedula)
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
            {
                return objServico.ConsultarCedula(cedula);
            }
        }
        public DataSet ConsultarCodigo(string codigo)
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
            {
                return objServico.ConsultarCodigo(codigo);
            }
        }

        public string Activar(int id)
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioProveedor objServico = new ServicioProveedor())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}

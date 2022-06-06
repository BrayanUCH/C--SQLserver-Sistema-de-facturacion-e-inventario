using SistemaVerduleria.CapaConexion;
using SistemaVerduleria.CapaLogica.LogicaNegocio;
using SistemaVerduleria.CapaLogica.Servicios;
using System;
using System.Data;

namespace SistemaVerduleria.CapaIntegracion
{
    public class GestorLogin : servicio, IDisposable
    {
        public GestorLogin()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string login_Usuario, string login_Nombre, string login_contraseña, string login_correoElectronico, string login_estado)
        {
            Login insertarOBJ = new Login(login_Usuario, login_Nombre, login_contraseña, login_correoElectronico, login_estado);

            using (ServicioLogin objServico = new ServicioLogin())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int login_id, string login_Usuario, string login_Nombre, string login_contraseña, string login_correoElectronico, string login_estado)
        {
            Login modificarOBJ = new Login(login_id, login_Usuario, login_Nombre, login_contraseña, login_correoElectronico, login_estado);
            
            using (ServicioLogin objServico = new ServicioLogin())
                return objServico.Modificar(modificarOBJ);
        }
        public string ModificarContraseña(int login_id, string login_contraseña)
        {
            Login modificarOBJ = new Login(login_id, login_contraseña);

            using (ServicioLogin objServico = new ServicioLogin())
                return objServico.ModificarContraseña(modificarOBJ);
        }
        public object ListarA()
        {
            using (ServicioLogin objServico = new ServicioLogin())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioLogin objServico = new ServicioLogin())
                return objServico.ListarI();
        }
        public DataSet Consultar(int id)
        {
            using (ServicioLogin objServico = new ServicioLogin())
            {
                return objServico.Consultar(id);
            }
        }
        public DataSet ConsultarUsuario(string usuario)
        {
            using (ServicioLogin objServico = new ServicioLogin())
            {
                return objServico.ConsultarUsuario(usuario);
            }
        }
        public DataSet ConsultarCorreo(string correo)
        {
            using (ServicioLogin objServico = new ServicioLogin())
            {
                return objServico.ConsultarCorreo(correo);
            }
        }
        public string Activar(int id)
        {
            using (ServicioLogin objServico = new ServicioLogin())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioLogin objServico = new ServicioLogin())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioLogin objServico = new ServicioLogin())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}

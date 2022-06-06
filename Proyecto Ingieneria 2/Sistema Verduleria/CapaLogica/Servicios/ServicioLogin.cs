using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaVerduleria.CapaConexion;
using SistemaVerduleria.CapaLogica.LogicaNegocio;

namespace SistemaVerduleria.CapaLogica.Servicios
{
    public class ServicioLogin : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioLogin()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(Login obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "LoginInsertar";

            miComando.Parameters.Add("Login_Usuario", SqlDbType.VarChar);
            miComando.Parameters["Login_Usuario"].Value = obj.Login_Usuario;

            miComando.Parameters.Add("Login_Nombre", SqlDbType.VarChar);
            miComando.Parameters["Login_Nombre"].Value = obj.Login_Nombre;

            miComando.Parameters.Add("Login_contraseña", SqlDbType.VarChar);
            miComando.Parameters["Login_contraseña"].Value = obj.Login_contraseña;

            miComando.Parameters.Add("Login_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Login_correoElectronico"].Value = obj.Login_correoElectronico;

            miComando.Parameters.Add("Login_estado", SqlDbType.VarChar);
            miComando.Parameters["Login_estado"].Value = obj.Login_estado;


            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(Login obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginModificar";

            miComando.Parameters.Add("Login_id", SqlDbType.Int);
            miComando.Parameters["Login_id"].Value = obj.Login_id;

            miComando.Parameters.Add("Login_Usuario", SqlDbType.VarChar);
            miComando.Parameters["Login_Usuario"].Value = obj.Login_Usuario;

            miComando.Parameters.Add("Login_Nombre", SqlDbType.VarChar);
            miComando.Parameters["Login_Nombre"].Value = obj.Login_Nombre;

            miComando.Parameters.Add("Login_contraseña", SqlDbType.VarChar);
            miComando.Parameters["Login_contraseña"].Value = obj.Login_contraseña;

            miComando.Parameters.Add("Login_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Login_correoElectronico"].Value = obj.Login_correoElectronico;

            miComando.Parameters.Add("Login_estado", SqlDbType.VarChar);
            miComando.Parameters["Login_estado"].Value = obj.Login_estado;

            //Aqui da el error en caso de que se necesite 
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                return "1";// es uno si todo salio bien 
            }

            return "0";// es cero si al un error
        }

        public string Eliminar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginEliminar";

            miComando.Parameters.AddWithValue("@Login_id", SqlDbType.Int);
            miComando.Parameters["@Login_id"].Value = id;

            //Aqui da el error en caso de que se necesite 
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                return "1";// es uno si todo salio bien 
            }
            return "0";// es cero si al un error
        }

        public string ModificarContraseña(Login obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginModificarContraseña";

            miComando.Parameters.Add("Login_id", SqlDbType.Int);
            miComando.Parameters["Login_id"].Value = obj.Login_id;

            miComando.Parameters.Add("Login_contraseña", SqlDbType.VarChar);
            miComando.Parameters["Login_contraseña"].Value = obj.Login_contraseña;

            //Aqui da el error en caso de que se necesite 
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                return "1";// es uno si todo salio bien 
            }

            return "0";// es cero si al un error
        }
        public DataSet Consultar(int id)
        {
            miComando.CommandText = "LoginConsultar";
            miComando.Parameters.AddWithValue("@Login_id", SqlDbType.Int);
            miComando.Parameters["@Login_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarUsuario(string usuario)
        {
            miComando.CommandText = "LoginConsultarUsuario";
            miComando.Parameters.AddWithValue("@Login_Usuario", SqlDbType.VarChar);
            miComando.Parameters["@Login_Usuario"].Value = usuario;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarCorreo(string correo)
        {
            miComando.CommandText = "LoginConsultarCorreo";
            miComando.Parameters.AddWithValue("@Login_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["@Login_correoElectronico"].Value = correo;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginInactivar";

            miComando.Parameters.AddWithValue("@Login_id", SqlDbType.Int);
            miComando.Parameters["@Login_id"].Value = id;

            //Aqui da el error en caso de que se necesite 
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                return "1";// es uno si todo salio bien 
            }

            return "0";// es cero si al un error
        }

        public string Activar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "LoginActivar";

            miComando.Parameters.AddWithValue("@Login_id", SqlDbType.Int);
            miComando.Parameters["@Login_id"].Value = id;

            //Aqui da el error en caso de que se necesite 
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                return "1";// es uno si todo salio bien 
            }
            return "0";// es cero si al un error
        }

    }
}

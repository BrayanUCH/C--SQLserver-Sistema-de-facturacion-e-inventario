using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Bibliotecas
using SistemaVerduleria.CapaConexion;
using SistemaVerduleria.CapaLogica.LogicaNegocio;

namespace SistemaVerduleria.CapaLogica.Servicios
{
    public class ServicioCliente : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioCliente()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(Cliente obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "ClienteInsertar";

            miComando.Parameters.Add("cliente_nombre", SqlDbType.VarChar);
            miComando.Parameters["cliente_nombre"].Value = obj.Cliente_nombre;

            miComando.Parameters.Add("cliente_Cedula", SqlDbType.VarChar);
            miComando.Parameters["cliente_Cedula"].Value = obj.Cliente_Cedula;

            miComando.Parameters.Add("cliente_CorreoElectronico", SqlDbType.VarChar);
            miComando.Parameters["cliente_CorreoElectronico"].Value = obj.Cliente_CorreoElectronico;

            miComando.Parameters.Add("cliente_Telefono", SqlDbType.VarChar);
            miComando.Parameters["cliente_Telefono"].Value = obj.Cliente_Telefono;

            miComando.Parameters.Add("cliente_FechaNacimiento", SqlDbType.VarChar);
            miComando.Parameters["cliente_FechaNacimiento"].Value = obj.Cliente_FechaNacimiento;

            miComando.Parameters.Add("cliente_Estado", SqlDbType.VarChar);
            miComando.Parameters["cliente_Estado"].Value = obj.Cliente_Estado;


            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(Cliente obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ClienteModificar";

            miComando.Parameters.Add("Cliente_id", SqlDbType.Int);
            miComando.Parameters["Cliente_id"].Value = obj.Cliente_id;

            miComando.Parameters.Add("cliente_nombre", SqlDbType.VarChar);
            miComando.Parameters["cliente_nombre"].Value = obj.Cliente_nombre;

            miComando.Parameters.Add("cliente_Cedula", SqlDbType.VarChar);
            miComando.Parameters["cliente_Cedula"].Value = obj.Cliente_Cedula;

            miComando.Parameters.Add("cliente_CorreoElectronico", SqlDbType.VarChar);
            miComando.Parameters["cliente_CorreoElectronico"].Value = obj.Cliente_CorreoElectronico;

            miComando.Parameters.Add("cliente_Telefono", SqlDbType.VarChar);
            miComando.Parameters["cliente_Telefono"].Value = obj.Cliente_Telefono;

            miComando.Parameters.Add("cliente_FechaNacimiento", SqlDbType.VarChar);
            miComando.Parameters["cliente_FechaNacimiento"].Value = obj.Cliente_FechaNacimiento;

            miComando.Parameters.Add("cliente_Estado", SqlDbType.VarChar);
            miComando.Parameters["cliente_Estado"].Value = obj.Cliente_Estado;

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

            miComando.CommandText = "ClienteEliminar";

            miComando.Parameters.AddWithValue("@Cliente_id", SqlDbType.Int);
            miComando.Parameters["@Cliente_id"].Value = id;

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
            miComando.CommandText = "ClienteConsultar";
            miComando.Parameters.AddWithValue("@Cliente_id", SqlDbType.Int);
            miComando.Parameters["@Cliente_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarCedula(string cedula)
        {
            miComando.CommandText = "ClienteConsultarCedula";
            miComando.Parameters.AddWithValue("@Cliente_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Cliente_Cedula"].Value = cedula;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ClienteListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ClienteListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarFiltrado(string filtro)
        {
            miComando = new SqlCommand();
            miComando.CommandText = "ClientesListarFiltrado";
            miComando.Parameters.AddWithValue("@Filtro", SqlDbType.VarChar);
            miComando.Parameters["@Filtro"].Value = filtro;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ClienteInactivar";

            miComando.Parameters.AddWithValue("@Cliente_id", SqlDbType.Int);
            miComando.Parameters["@Cliente_id"].Value = id;

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

            miComando.CommandText = "ClienteActivar";

            miComando.Parameters.AddWithValue("@Cliente_id", SqlDbType.Int);
            miComando.Parameters["@Cliente_id"].Value = id;

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

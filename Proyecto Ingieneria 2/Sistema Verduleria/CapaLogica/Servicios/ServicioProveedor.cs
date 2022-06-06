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
    public class ServicioProveedor : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioProveedor()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(Proveedor obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "ProveedorInsertar";

            miComando.Parameters.Add("Proveedor_Codigo", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Codigo"].Value = obj.Proveedor_Codigo;
            
            miComando.Parameters.Add("Proveedor_Cedula", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Cedula"].Value = obj.Proveedor_Cedula;

            miComando.Parameters.Add("Proveedor_NombreORazonSocial", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_NombreORazonSocial"].Value = obj.Proveedor_NombreORazonSocial;

            miComando.Parameters.Add("Proveedor_FechaIngreso", SqlDbType.Date);
            miComando.Parameters["Proveedor_FechaIngreso"].Value = obj.Proveedor_FechaIngreso;

            miComando.Parameters.Add("Proveedor_Saldo", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Saldo"].Value = obj.Proveedor_Saldo;

            miComando.Parameters.Add("Proveedor_CuentaDelBanco", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_CuentaDelBanco"].Value = obj.Proveedor_CuentaDelBanco;

            miComando.Parameters.Add("Proveedor_Banco", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Banco"].Value = obj.Proveedor_Banco;

            miComando.Parameters.Add("Proveedor_DiasDePago", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_DiasDePago"].Value = obj.Proveedor_DiasDePago;

            miComando.Parameters.Add("Proveedor_Telefono", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Telefono"].Value = obj.Proveedor_Telefono;

            miComando.Parameters.Add("Proveedor_CorreoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_CorreoElectronico"].Value = obj.Proveedor_CorreoElectronico;

            miComando.Parameters.Add("Proveedor_Estado", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Estado"].Value = obj.Proveedor_Estado;

            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(Proveedor obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ProveedorModificar";

            miComando.Parameters.Add("Proveedor_id", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_id"].Value = obj.Proveedor_id;

            miComando.Parameters.Add("Proveedor_Codigo", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Codigo"].Value = obj.Proveedor_Codigo;

            miComando.Parameters.Add("Proveedor_Cedula", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Cedula"].Value = obj.Proveedor_Cedula;

            miComando.Parameters.Add("Proveedor_NombreORazonSocial", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_NombreORazonSocial"].Value = obj.Proveedor_NombreORazonSocial;

            miComando.Parameters.Add("Proveedor_FechaIngreso", SqlDbType.Date);
            miComando.Parameters["Proveedor_FechaIngreso"].Value = obj.Proveedor_FechaIngreso;

            miComando.Parameters.Add("Proveedor_Saldo", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Saldo"].Value = obj.Proveedor_Saldo;

            miComando.Parameters.Add("Proveedor_CuentaDelBanco", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_CuentaDelBanco"].Value = obj.Proveedor_CuentaDelBanco;

            miComando.Parameters.Add("Proveedor_Banco", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Banco"].Value = obj.Proveedor_Banco;

            miComando.Parameters.Add("Proveedor_DiasDePago", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_DiasDePago"].Value = obj.Proveedor_DiasDePago;

            miComando.Parameters.Add("Proveedor_Telefono", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Telefono"].Value = obj.Proveedor_Telefono;

            miComando.Parameters.Add("Proveedor_CorreoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_CorreoElectronico"].Value = obj.Proveedor_CorreoElectronico;

            miComando.Parameters.Add("Proveedor_Estado", SqlDbType.VarChar);
            miComando.Parameters["Proveedor_Estado"].Value = obj.Proveedor_Estado;

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

            miComando.CommandText = "ProveedorEliminar";

            miComando.Parameters.AddWithValue("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = id;

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
            miComando.CommandText = "ProveedorConsultar";
            miComando.Parameters.AddWithValue("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarCedula(string cedula)
        {
            miComando.CommandText = "ProveedorConsultarCedula";
            miComando.Parameters.AddWithValue("@Proveedor_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_Cedula"].Value = cedula;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataSet ConsultarCodigo(string codigo)
        {
            miComando.CommandText = "ProveedorConsultarCodigo";
            miComando.Parameters.AddWithValue("@Proveedor_Codigo", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_Codigo"].Value = codigo;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ProveedorListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ProveedorListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ProveedorInactivar";

            miComando.Parameters.AddWithValue("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = id;

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

            miComando.CommandText = "ProveedorActivar";

            miComando.Parameters.AddWithValue("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = id;

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

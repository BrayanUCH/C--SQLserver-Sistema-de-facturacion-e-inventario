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
    public class ServicioCuentasPorPagar : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioCuentasPorPagar()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(CuentasPorPagar obj)
        {
            miComando = new SqlCommand();
             
            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "CuentasXPagarInsertar";

            miComando.Parameters.Add("CuentasXPagar_ProveedorID", SqlDbType.Int);
            miComando.Parameters["CuentasXPagar_ProveedorID"].Value = obj.CuentasXPagar_ProveedorID;

            miComando.Parameters.Add("CuentasXPagar_Descripcion", SqlDbType.VarChar);
            miComando.Parameters["CuentasXPagar_Descripcion"].Value = obj.CuentasXPagar_Descripcion;

            miComando.Parameters.Add("CuentasXPagar_FechaPago", SqlDbType.VarChar);
            miComando.Parameters["CuentasXPagar_FechaPago"].Value = obj.CuentasXPagar_FechaPago;

            miComando.Parameters.Add("CuentasXPagar_Monto", SqlDbType.Float);
            miComando.Parameters["CuentasXPagar_Monto"].Value = obj.CuentasXPagar_Monto;

            miComando.Parameters.Add("CuentasXPagar_Estado", SqlDbType.VarChar);
            miComando.Parameters["CuentasXPagar_Estado"].Value = obj.CuentasXPagar_Estado;

            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(CuentasPorPagar obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "CuentasXPagarModificar";

            miComando.Parameters.Add("CuentasXPagar_id", SqlDbType.Int);
            miComando.Parameters["CuentasXPagar_id"].Value = obj.CuentasXPagar_id;

            miComando.Parameters.Add("CuentasXPagar_ProveedorID", SqlDbType.Int);
            miComando.Parameters["CuentasXPagar_ProveedorID"].Value = obj.CuentasXPagar_ProveedorID;

            miComando.Parameters.Add("CuentasXPagar_Descripcion", SqlDbType.VarChar);
            miComando.Parameters["CuentasXPagar_Descripcion"].Value = obj.CuentasXPagar_Descripcion;

            miComando.Parameters.Add("CuentasXPagar_FechaPago", SqlDbType.VarChar);
            miComando.Parameters["CuentasXPagar_FechaPago"].Value = obj.CuentasXPagar_FechaPago;

            miComando.Parameters.Add("CuentasXPagar_Monto", SqlDbType.Float);
            miComando.Parameters["CuentasXPagar_Monto"].Value = obj.CuentasXPagar_Monto;

            miComando.Parameters.Add("CuentasXPagar_Estado", SqlDbType.VarChar);
            miComando.Parameters["CuentasXPagar_Estado"].Value = obj.CuentasXPagar_Estado;

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

            miComando.CommandText = "CuentasXPagarEliminar";

            miComando.Parameters.AddWithValue("@CuentasXPagar_id", SqlDbType.Int);
            miComando.Parameters["@CuentasXPagar_id"].Value = id;

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
            miComando.CommandText = "CuentasXPagarConsultar";
            miComando.Parameters.AddWithValue("@CuentasXPagar_id", SqlDbType.Int);
            miComando.Parameters["@CuentasXPagar_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataTable ConsultarIdProveedor(int id)
        {
            miComando.CommandText = "CuentasXPagarConsultarIdProveedor";
            miComando.Parameters.AddWithValue("@CuentasXPagar_ProveedorID", SqlDbType.Int);
            miComando.Parameters["@CuentasXPagar_ProveedorID"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "CuentasXPagarListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "CuentasXPagarListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "CuentasXPagarInactivar";

            miComando.Parameters.AddWithValue("@CuentasXPagar_id", SqlDbType.Int);
            miComando.Parameters["@CuentasXPagar_id"].Value = id;

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

            miComando.CommandText = "CuentasXPagarActivar";

            miComando.Parameters.AddWithValue("@CuentasXPagar_id", SqlDbType.Int);
            miComando.Parameters["@CuentasXPagar_id"].Value = id;

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

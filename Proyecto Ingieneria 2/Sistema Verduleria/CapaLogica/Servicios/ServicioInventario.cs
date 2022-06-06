using SistemaVerduleria.CapaConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaVerduleria.CapaLogica.LogicaNegocio;
using System.Data.SqlClient;
using System.Data;

namespace SistemaVerduleria.CapaLogica.Servicios
{
    public class ServicioInventario : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioInventario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(Inventario obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "InventarioInsertar";

            miComando.Parameters.Add("Inventario_ArticuloID", SqlDbType.Int);
            miComando.Parameters["Inventario_ArticuloID"].Value = obj.Inventario_ArticuloID;

            miComando.Parameters.Add("Inventario_Cantidad", SqlDbType.Float);
            miComando.Parameters["Inventario_Cantidad"].Value = obj.Inventario_Cantidad;

            miComando.Parameters.Add("Inventario_Tipo", SqlDbType.VarChar);
            miComando.Parameters["Inventario_Tipo"].Value = obj.Inventario_Tipo;

            miComando.Parameters.Add("Inventario_Estado", SqlDbType.VarChar);
            miComando.Parameters["Inventario_Estado"].Value = obj.Inventario_Estado;

            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(Inventario obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "InventarioModificar";

            miComando.Parameters.Add("Inventario_id", SqlDbType.Int);
            miComando.Parameters["Inventario_id"].Value = obj.Inventario_id;

            miComando.Parameters.Add("Inventario_ArticuloID", SqlDbType.Int);
            miComando.Parameters["Inventario_ArticuloID"].Value = obj.Inventario_ArticuloID;

            miComando.Parameters.Add("Inventario_Cantidad", SqlDbType.Float);
            miComando.Parameters["Inventario_Cantidad"].Value = obj.Inventario_Cantidad;

            miComando.Parameters.Add("Inventario_Tipo", SqlDbType.VarChar);
            miComando.Parameters["Inventario_Tipo"].Value = obj.Inventario_Tipo;

            miComando.Parameters.Add("Inventario_Estado", SqlDbType.VarChar);
            miComando.Parameters["Inventario_Estado"].Value = obj.Inventario_Estado;

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
            miComando.CommandText = "InventarioConsultar";
            miComando.Parameters.AddWithValue("@Inventario_id", SqlDbType.Int);
            miComando.Parameters["@Inventario_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarExistenciaL(int id)
        {
            miComando.CommandText = "InventarioConsultarExistenciaL";
            miComando.Parameters.AddWithValue("@Inventario_ArticuloID", SqlDbType.Int);
            miComando.Parameters["@Inventario_ArticuloID"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarExistenciaB(int id)
        {
            miComando.CommandText = "InventarioConsultarExistenciaB";
            miComando.Parameters.AddWithValue("@Inventario_ArticuloID", SqlDbType.Int);
            miComando.Parameters["@Inventario_ArticuloID"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarAL()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "InventarioListarAL";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarIL()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "InventarioListarIL";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarAB()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "InventarioListarAB";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarIB()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "InventarioListarIB";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "InventarioInactivar";

            miComando.Parameters.AddWithValue("@Inventario_id", SqlDbType.Int);
            miComando.Parameters["@Inventario_id"].Value = id;

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

            miComando.CommandText = "InventarioActivar";

            miComando.Parameters.AddWithValue("@Inventario_id", SqlDbType.Int);
            miComando.Parameters["@Inventario_id"].Value = id;

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

            miComando.CommandText = "InventarioEliminar";

            miComando.Parameters.AddWithValue("@Inventario_id", SqlDbType.Int);
            miComando.Parameters["@Inventario_id"].Value = id;

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

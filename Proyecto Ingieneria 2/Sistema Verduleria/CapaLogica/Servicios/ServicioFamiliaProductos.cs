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
    public class ServicioFamiliaProductos : servicio, IDisposable
    {

        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioFamiliaProductos()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(FamiliaProductos obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "FamiliaInsertar";

            miComando.Parameters.Add("Familia_Codigo", SqlDbType.VarChar);
            miComando.Parameters["Familia_Codigo"].Value = obj.Familia_Codigo;

            miComando.Parameters.Add("Familia_tipo", SqlDbType.VarChar);
            miComando.Parameters["Familia_tipo"].Value = obj.Familia_tipo;

            miComando.Parameters.Add("Familia_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Familia_descripcion"].Value = obj.Familia_descripcion;

            miComando.Parameters.Add("Familia_estado", SqlDbType.VarChar);
            miComando.Parameters["Familia_estado"].Value = obj.Familia_estado;

            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(FamiliaProductos obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FamiliaModificar";

            miComando.Parameters.Add("Familia_id", SqlDbType.VarChar);
            miComando.Parameters["Familia_id"].Value = obj.Familia_id;

            miComando.Parameters.Add("Familia_Codigo", SqlDbType.VarChar);
            miComando.Parameters["Familia_Codigo"].Value = obj.Familia_Codigo;

            miComando.Parameters.Add("Familia_tipo", SqlDbType.VarChar);
            miComando.Parameters["Familia_tipo"].Value = obj.Familia_tipo;

            miComando.Parameters.Add("Familia_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Familia_descripcion"].Value = obj.Familia_descripcion;

            miComando.Parameters.Add("Familia_estado", SqlDbType.VarChar);
            miComando.Parameters["Familia_estado"].Value = obj.Familia_estado;

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

            miComando.CommandText = "FacturacionEliminar";

            miComando.Parameters.AddWithValue("@Familia_id", SqlDbType.Int);
            miComando.Parameters["@Familia_id"].Value = id;

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
            miComando.CommandText = "FamiliaConsultar";
            miComando.Parameters.AddWithValue("@Familia_id", SqlDbType.Int);
            miComando.Parameters["@Familia_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }
        public DataSet ConsultarCodigo(string codigo)
        {
            miComando.CommandText = "FamiliaConsultarCodigo";
            miComando.Parameters.AddWithValue("@Familia_codigo", SqlDbType.VarChar);
            miComando.Parameters["@Familia_codigo"].Value = codigo;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FamiliaListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FamiliaListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FamiliaInactivar";

            miComando.Parameters.AddWithValue("@Familia_id", SqlDbType.Int);
            miComando.Parameters["@Familia_id"].Value = id;

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

            miComando.CommandText = "FamiliaActivar";

            miComando.Parameters.AddWithValue("@Familia_id", SqlDbType.Int);
            miComando.Parameters["@Familia_id"].Value = id;

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

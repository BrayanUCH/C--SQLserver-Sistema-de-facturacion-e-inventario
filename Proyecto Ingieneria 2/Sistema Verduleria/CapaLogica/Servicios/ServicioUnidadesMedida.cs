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
    public class ServicioUnidadesMedida : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioUnidadesMedida()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(UnidadesMedida obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "UnidadesMedidaInsertar";

            miComando.Parameters.Add("UnidadesMedida_Descripcion", SqlDbType.VarChar);
            miComando.Parameters["UnidadesMedida_Descripcion"].Value = obj.UnidadesMedida_Descripcion;

            miComando.Parameters.Add("UnidadesMedida_Abreviatura", SqlDbType.VarChar);
            miComando.Parameters["UnidadesMedida_Abreviatura"].Value = obj.UnidadesMedida_Abreviatura;

            miComando.Parameters.Add("UnidadesMedida_Estado", SqlDbType.VarChar);
            miComando.Parameters["UnidadesMedida_Estado"].Value = obj.UnidadesMedida_Estado;

            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(UnidadesMedida obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "UnidadesMedidaModificar";

            miComando.Parameters.Add("UnidadesMedida_id", SqlDbType.Int);
            miComando.Parameters["UnidadesMedida_id"].Value = obj.UnidadesMedida_id;

            miComando.Parameters.Add("UnidadesMedida_Descripcion", SqlDbType.VarChar);
            miComando.Parameters["UnidadesMedida_Descripcion"].Value = obj.UnidadesMedida_Descripcion;

            miComando.Parameters.Add("UnidadesMedida_Abreviatura", SqlDbType.VarChar);
            miComando.Parameters["UnidadesMedida_Abreviatura"].Value = obj.UnidadesMedida_Abreviatura;

            miComando.Parameters.Add("UnidadesMedida_Estado", SqlDbType.VarChar);
            miComando.Parameters["UnidadesMedida_Estado"].Value = obj.UnidadesMedida_Estado;

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
            miComando.CommandText = "UnidadesMedidaConsultar";
            miComando.Parameters.AddWithValue("@UnidadesMedida_id", SqlDbType.Int);
            miComando.Parameters["@UnidadesMedida_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();
            
            dataSetOBJ = this.selecionarInformacion(miComando);
            
            return dataSetOBJ;
        }

        public string Eliminar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "UnidadesMedidaEliminar";

            miComando.Parameters.AddWithValue("@UnidadesMedida_id", SqlDbType.Int);
            miComando.Parameters["@UnidadesMedida_id"].Value = id;

            //Aqui da el error en caso de que se necesite 
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
            {
                return "1";// es uno si todo salio bien 
            }
            return "0";// es cero si al un error
        }

        public DataSet ConsultarAbreviatura(int abreviatura)
        {
            miComando.CommandText = "UnidadesMedidaConsultarAbreviatura";
            miComando.Parameters.AddWithValue("@UnidadesMedidaConsultarAbreviatura", SqlDbType.VarChar);
            miComando.Parameters["@UnidadesMedidaConsultarAbreviatura"].Value = abreviatura;

            DataSet dataSetOBJ = new DataSet();
            
            dataSetOBJ = this.selecionarInformacion(miComando);
            
            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "UnidadesMedidaListarA";

            DataSet dataSetOBJ = new DataSet();
            
            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "UnidadesMedidaListarI";

            DataSet dataSetOBJ = new DataSet();
            
            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "UnidadesMedidaInactivar";

            miComando.Parameters.AddWithValue("@UnidadesMedida_id", SqlDbType.Int);
            miComando.Parameters["@UnidadesMedida_id"].Value = id;

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

            miComando.CommandText = "UnidadesMedidaActivar";

            miComando.Parameters.AddWithValue("@UnidadesMedida_id", SqlDbType.Int);
            miComando.Parameters["@UnidadesMedida_id"].Value = id;

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

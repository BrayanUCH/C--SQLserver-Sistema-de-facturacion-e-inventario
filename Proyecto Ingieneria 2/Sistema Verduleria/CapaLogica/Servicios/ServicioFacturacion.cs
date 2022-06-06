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
    public class ServicioFacturacion : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioFacturacion()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(Facturaccion obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "FacturacionInsertar";

            miComando.Parameters.Add("Facturacion_Observaciones", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_Observaciones"].Value = obj.Facturacion_Observaciones;

            miComando.Parameters.Add("Facturacion_ClienteID", SqlDbType.Int);
            miComando.Parameters["Facturacion_ClienteID"].Value = obj.Facturacion_ClienteID;

            miComando.Parameters.Add("Facturacion_Descuento", SqlDbType.Float);
            miComando.Parameters["Facturacion_Descuento"].Value = obj.Facturacion_Descuento;

            miComando.Parameters.Add("Facturacion_Impuesto", SqlDbType.Float);
            miComando.Parameters["Facturacion_Impuesto"].Value = obj.Facturacion_Impuesto;

            miComando.Parameters.Add("Facturacion_NumeroArticulos", SqlDbType.Int);
            miComando.Parameters["Facturacion_NumeroArticulos"].Value = obj.Facturacion_NumeroArticulos;

            miComando.Parameters.Add("Facturacion_SubTotal", SqlDbType.Float);
            miComando.Parameters["Facturacion_SubTotal"].Value = obj.Facturacion_SubTotal;

            miComando.Parameters.Add("Facturacion_Total", SqlDbType.Float);
            miComando.Parameters["Facturacion_Total"].Value = obj.Facturacion_Total;

            miComando.Parameters.Add("Facturacion_Fecha", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_Fecha"].Value = obj.Facturacion_Fecha;

            miComando.Parameters.Add("Facturacion_estado", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_estado"].Value = obj.Facturacion_Estado;


            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(Facturaccion obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionModificar";

            miComando.Parameters.Add("Facturacion_id", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_id"].Value = obj.Facturacion_id;

            miComando.Parameters.Add("Facturacion_Observaciones", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_Observaciones"].Value = obj.Facturacion_Observaciones;

            miComando.Parameters.Add("Facturacion_ClienteID", SqlDbType.Int);
            miComando.Parameters["Facturacion_ClienteID"].Value = obj.Facturacion_ClienteID;

            miComando.Parameters.Add("Facturacion_Descuento", SqlDbType.Float);
            miComando.Parameters["Facturacion_Descuento"].Value = obj.Facturacion_Descuento;

            miComando.Parameters.Add("Facturacion_Impuesto", SqlDbType.Float);
            miComando.Parameters["Facturacion_Impuesto"].Value = obj.Facturacion_Impuesto;

            miComando.Parameters.Add("Facturacion_NumeroArticulos", SqlDbType.Int);
            miComando.Parameters["Facturacion_NumeroArticulos"].Value = obj.Facturacion_NumeroArticulos;

            miComando.Parameters.Add("Facturacion_SubTotal", SqlDbType.Float);
            miComando.Parameters["Facturacion_SubTotal"].Value = obj.Facturacion_SubTotal;

            miComando.Parameters.Add("Facturacion_Total", SqlDbType.Float);
            miComando.Parameters["Facturacion_Total"].Value = obj.Facturacion_Total;

            miComando.Parameters.Add("Facturacion_Fecha", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_Fecha"].Value = obj.Facturacion_Fecha;

            miComando.Parameters.Add("Facturacion_estado", SqlDbType.VarChar);
            miComando.Parameters["Facturacion_estado"].Value = obj.Facturacion_Estado;

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
            miComando.CommandText = "FacturacionConsultar";
            miComando.Parameters.AddWithValue("@Facturacion_id", SqlDbType.Int);
            miComando.Parameters["@Facturacion_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarFiltradoId(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionListarFiltradoId"; 
            miComando.Parameters.AddWithValue("@ID", SqlDbType.Int);
            miComando.Parameters["@ID"].Value = id;

            DataSet dataSetOBJ = new DataSet();
            this.abrirConexion();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarFiltradoFecha(string Fecha)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionListarFiltradoFecha";
            miComando.Parameters.AddWithValue("@Fecha", SqlDbType.VarChar);
            miComando.Parameters["@Fecha"].Value = Fecha;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataSet UltimoRegistro()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionConsultarUltimoResgistro";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "FacturacionInactivar";

            miComando.Parameters.AddWithValue("@Facturacion_id", SqlDbType.Int);
            miComando.Parameters["@Facturacion_id"].Value = id;

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

            miComando.CommandText = "FacturacionActivar";

            miComando.Parameters.AddWithValue("@Facturacion_id", SqlDbType.Int);
            miComando.Parameters["@Facturacion_id"].Value = id;

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

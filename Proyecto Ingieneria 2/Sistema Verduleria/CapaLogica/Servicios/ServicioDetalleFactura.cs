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
    public class ServicioDetalleFactura : servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioDetalleFactura()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string Insertar(DetalleFactura obj)
        {
            miComando = new SqlCommand();

            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "DetalleFacturaInsertar";

            miComando.Parameters.Add("DetalleFactura_ArticulosID", SqlDbType.Int);
            miComando.Parameters["DetalleFactura_ArticulosID"].Value = obj.DetalleFactura_ArticulosID;

            miComando.Parameters.Add("DetalleFactura_FacturacionID", SqlDbType.Int);
            miComando.Parameters["DetalleFactura_FacturacionID"].Value = obj.DetalleFactura_FacturacionID;

            miComando.Parameters.Add("DetalleFactura_Cantidad", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Cantidad"].Value = obj.DetalleFactura_Cantidad;

            miComando.Parameters.Add("DetalleFactura_Descuento", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Descuento"].Value = obj.DetalleFactura_Descuento;

            miComando.Parameters.Add("DetalleFactura_Impuesto", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Impuesto"].Value = obj.DetalleFactura_Impuesto;

            miComando.Parameters.Add("DetalleFactura_Precio", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Precio"].Value = obj.DetalleFactura_Precio;

            miComando.Parameters.Add("DetalleFactura_Estado", SqlDbType.VarChar);
            miComando.Parameters["DetalleFactura_Estado"].Value = obj.DetalleFactura_Estado;


            respuesta = this.ejecutaSentencia(miComando);

            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(DetalleFactura obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "DetalleFacturaModificar";

            miComando.Parameters.Add("DetalleFactura_id", SqlDbType.Int);
            miComando.Parameters["DetalleFactura_id"].Value = obj.DetalleFactura_id;

            miComando.Parameters.Add("DetalleFactura_ArticulosID", SqlDbType.Int);
            miComando.Parameters["DetalleFactura_ArticulosID"].Value = obj.DetalleFactura_ArticulosID;

            miComando.Parameters.Add("DetalleFactura_FacturacionID", SqlDbType.Int);
            miComando.Parameters["DetalleFactura_FacturacionID"].Value = obj.DetalleFactura_FacturacionID;

            miComando.Parameters.Add("DetalleFactura_Cantidad", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Cantidad"].Value = obj.DetalleFactura_Cantidad;

            miComando.Parameters.Add("DetalleFactura_Descuento", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Descuento"].Value = obj.DetalleFactura_Descuento;

            miComando.Parameters.Add("DetalleFactura_Impuesto", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Impuesto"].Value = obj.DetalleFactura_Impuesto;

            miComando.Parameters.Add("DetalleFactura_Precio", SqlDbType.Float);
            miComando.Parameters["DetalleFactura_Precio"].Value = obj.DetalleFactura_Precio;

            miComando.Parameters.Add("DetalleFactura_Estado", SqlDbType.VarChar);
            miComando.Parameters["DetalleFactura_Estado"].Value = obj.DetalleFactura_Estado;

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
            miComando.CommandText = "DetalleFacturaConsultar";
            miComando.Parameters.AddWithValue("@DetalleFactura_id", SqlDbType.Int);
            miComando.Parameters["@DetalleFactura_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "DetalleFacturaListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "DetalleFacturaListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarIdFactura(int IdFactura)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "DetalleFacturaListarIDfactura";
            miComando.Parameters.AddWithValue("@idFactura", SqlDbType.Int);
            miComando.Parameters["@idFactura"].Value = IdFactura;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "DetalleFacturaInactivar";

            miComando.Parameters.AddWithValue("@DetalleFactura_id", SqlDbType.Int);
            miComando.Parameters["@DetalleFactura_id"].Value = id;

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

            miComando.CommandText = "DetalleFacturaActivar";

            miComando.Parameters.AddWithValue("@DetalleFactura_id", SqlDbType.Int);
            miComando.Parameters["@DetalleFactura_id"].Value = id;

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

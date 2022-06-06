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
    public class ServicioArticulo:servicio, IDisposable
    {
        private SqlCommand miComando;
        private String respuesta;

        public void Dispose()
        {

        }

        public ServicioArticulo()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }
        public string Insertar(Articulos obj)
        {
            miComando = new SqlCommand();
            //igual a la base de datos en Programmability/Stored Procedures
            miComando.CommandText = "ArticulosInsertar";

            miComando.Parameters.Add("Articulos_Codigo", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Codigo"].Value = obj.Articulos_Codigo;

            miComando.Parameters.Add("Articulos_Descripcion", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Descripcion"].Value = obj.Articulos_Descripcion;

            miComando.Parameters.Add("Articulos_Nombre", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Nombre"].Value = obj.Articulos_Nombre;

            miComando.Parameters.Add("Articulos_FamiliaID", SqlDbType.VarChar);
            miComando.Parameters["Articulos_FamiliaID"].Value = obj.Articulos_FamiliaID;

            miComando.Parameters.Add("Articulos_UnidadesMedidaID", SqlDbType.VarChar);
            miComando.Parameters["Articulos_UnidadesMedidaID"].Value = obj.Articulos_UnidadesMedidaID;

            miComando.Parameters.Add("Articulos_CantidadUnidadesMedida", SqlDbType.Float);
            miComando.Parameters["Articulos_CantidadUnidadesMedida"].Value = obj.Articulos_CantidadUnidadesMedida;

            miComando.Parameters.Add("Articulos_Precio", SqlDbType.Float);
            miComando.Parameters["Articulos_Precio"].Value = obj.Articulos_Precio;

            miComando.Parameters.Add("Articulos_Descuento", SqlDbType.Float);
            miComando.Parameters["Articulos_Descuento"].Value = obj.Articulos_Descuento;

            miComando.Parameters.Add("Articulos_Impuesto", SqlDbType.Float);
            miComando.Parameters["Articulos_Impuesto"].Value = obj.Articulos_Impuesto;

            miComando.Parameters.Add("Articulos_Estado", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Estado"].Value = obj.Articulos_Estado;

            respuesta = this.ejecutaSentencia(miComando);
            
            //Console.WriteLine("Fin");
            if (respuesta == "")
            {
                return "1";
            }

            return "0";
        }

        public string Modificar(Articulos obj)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ArticulosModificar";

            miComando.Parameters.Add("Articulos_id", SqlDbType.Int);
            miComando.Parameters["Articulos_id"].Value = obj.Articulo_id;

            miComando.Parameters.Add("Articulos_Codigo", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Codigo"].Value = obj.Articulos_Codigo;

            miComando.Parameters.Add("Articulos_Descripcion", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Descripcion"].Value = obj.Articulos_Descripcion;

            miComando.Parameters.Add("Articulos_Nombre", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Nombre"].Value = obj.Articulos_Nombre;

            miComando.Parameters.Add("Articulos_FamiliaID", SqlDbType.VarChar);
            miComando.Parameters["Articulos_FamiliaID"].Value = obj.Articulos_FamiliaID;

            miComando.Parameters.Add("Articulos_UnidadesMedidaID", SqlDbType.VarChar);
            miComando.Parameters["Articulos_UnidadesMedidaID"].Value = obj.Articulos_UnidadesMedidaID;

            miComando.Parameters.Add("Articulos_CantidadUnidadesMedida", SqlDbType.Float);
            miComando.Parameters["Articulos_CantidadUnidadesMedida"].Value = obj.Articulos_CantidadUnidadesMedida;

            miComando.Parameters.Add("Articulos_Precio", SqlDbType.Float);
            miComando.Parameters["Articulos_Precio"].Value = obj.Articulos_Precio;

            miComando.Parameters.Add("Articulos_Descuento", SqlDbType.Float);
            miComando.Parameters["Articulos_Descuento"].Value = obj.Articulos_Descuento;

            miComando.Parameters.Add("Articulos_Impuesto", SqlDbType.Float);
            miComando.Parameters["Articulos_Impuesto"].Value = obj.Articulos_Impuesto;

            miComando.Parameters.Add("Articulos_Estado", SqlDbType.VarChar);
            miComando.Parameters["Articulos_Estado"].Value = obj.Articulos_Estado;

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

            miComando.CommandText = "ArticulosEliminar";

            miComando.Parameters.AddWithValue("@Articulos_id", SqlDbType.Int);
            miComando.Parameters["@Articulos_id"].Value = id;

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
            miComando.CommandText = "ArticulosConsultar";
            miComando.Parameters.AddWithValue("@Articulos_id", SqlDbType.Int);
            miComando.Parameters["@Articulos_id"].Value = id;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            return dataSetOBJ;
        }

        public DataTable ListarA()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ArticulosListarA";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public DataTable ListarI()
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ArticulosListarI";

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);
            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarPF(string Familia, string Producto)
        {
            miComando = new SqlCommand();
            miComando.CommandText = "ArticulosListarFiltradoPF";
            miComando.Parameters.AddWithValue("@Producto", SqlDbType.VarChar);
            miComando.Parameters.AddWithValue("@Familia", SqlDbType.VarChar);
            miComando.Parameters["@Producto"].Value = Producto;
            miComando.Parameters["@Familia"].Value = Familia;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarP(string Producto)
        {
            miComando = new SqlCommand();
            miComando.CommandText = "ArticulosListarFiltradoP";
            miComando.Parameters.AddWithValue("@Producto", SqlDbType.VarChar);
            miComando.Parameters["@Producto"].Value = Producto;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarFiltradoP(string Producto)
        {
            miComando = new SqlCommand();
            miComando.CommandText = "ArticulosListarFiltradoProducto";
            miComando.Parameters.AddWithValue("@Producto", SqlDbType.VarChar);
            miComando.Parameters["@Producto"].Value = Producto;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }
        public DataTable ListarF(string Familia)
        {
            miComando = new SqlCommand();
            miComando.CommandText = "ArticulosListarFiltradoF";
            miComando.Parameters.AddWithValue("@Familia", SqlDbType.VarChar);
            miComando.Parameters["@Familia"].Value = Familia;

            DataSet dataSetOBJ = new DataSet();

            dataSetOBJ = this.selecionarInformacion(miComando);

            DataTable miTabla = dataSetOBJ.Tables[0];

            return miTabla;
        }

        public string Inactivar(int id)
        {
            miComando = new SqlCommand();

            miComando.CommandText = "ArticulosInactivar";

            miComando.Parameters.AddWithValue("@Articulos_id", SqlDbType.Int);
            miComando.Parameters["@Articulos_id"].Value = id;

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

            miComando.CommandText = "ArticulosActivar";

            miComando.Parameters.AddWithValue("@Articulos_id", SqlDbType.Int);
            miComando.Parameters["@Articulos_id"].Value = id;

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
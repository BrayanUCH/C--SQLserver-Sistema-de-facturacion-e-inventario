using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaConexion
{
    public class servicio
    {
        private SqlConnection conexion;

        public servicio()
        {
            //conexion = new SqlConnection(@"user=LAPTOP-155E316T\Brandon; password=validpassword; server=LAPTOP-155E316T;
            //                                Trusted_Connection=yes; database=SisQuerubin; connection timeout=30");
            conexion = new SqlConnection (@"Server=(local); DataBase=SisQuerubin; integrated security = true");

        }

        protected void abrirConexion()
        {
            conexion.Open();
        }

        protected void cerrarConexion()
        {
            conexion.Close();
        }

        protected string ejecutarsentencia(string sentencia)
        {
            SqlCommand comando = new SqlCommand(sentencia, conexion);

            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }

            this.cerrarConexion();
            return "";
        }

        protected string ejecutaSentencia(SqlCommand micomando)
        {
            micomando.Connection = conexion;
            micomando.CommandType = CommandType.StoredProcedure;
            micomando.CommandTimeout = 6000;

            try
            {
                this.abrirConexion();
                micomando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }

            this.cerrarConexion();

            return "";
        }

        protected DataSet selecionarInformacion(string sentencias)
        {
            this.abrirConexion();
            DataSet miDataSet = new DataSet();
            SqlCommand miSqlCommand = conexion.CreateCommand();

            miSqlCommand.CommandText = sentencias;
            SqlDataAdapter miSqlDataAdapter = new SqlDataAdapter();

            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);
            this.cerrarConexion();
            return miDataSet;
        }

        protected DataSet selecionarInformacion(SqlCommand miComando)
        {
            this.abrirConexion();
            DataSet miDataSet = new DataSet();
            SqlDataAdapter miSqlAdapter = new SqlDataAdapter();

            miComando.CommandTimeout = 2000;
            miComando.Connection = conexion;

            miComando.CommandType = CommandType.StoredProcedure;
            miSqlAdapter.SelectCommand = miComando;
            miSqlAdapter.Fill(miDataSet);

            this.cerrarConexion();
            return miDataSet;
        }
    }
}
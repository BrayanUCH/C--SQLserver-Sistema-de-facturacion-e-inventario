using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class Inventario
    {
        #region ATRIBUTOS
        private int inventario_id;
        private int inventario_ArticuloID;
        private double inventario_Cantidad;
        private string inventario_Tipo;
        private string inventario_Estado;
        #endregion

        #region CONSTRUTORES
        public Inventario()
        {
          
        }

        public Inventario(int inventario_ArticuloID, double inventario_Cantidad, string inventario_Tipo, string inventario_Estado)
        {
            this.Inventario_ArticuloID = inventario_ArticuloID;
            this.Inventario_Cantidad = inventario_Cantidad;
            this.Inventario_Tipo = inventario_Tipo;
            this.Inventario_Estado = inventario_Estado;
        }

        public Inventario(int inventario_id, int inventario_ArticuloID, double inventario_Cantidad, string inventario_Tipo, string inventario_Estado)
        {
            this.Inventario_id = inventario_id;
            this.Inventario_ArticuloID = inventario_ArticuloID;
            this.Inventario_Cantidad = inventario_Cantidad;
            this.Inventario_Tipo = inventario_Tipo;
            this.Inventario_Estado = inventario_Estado;
        }

        #endregion

        #region GETS_SETS
        public int Inventario_id { get => inventario_id; set => inventario_id = value; }
        public int Inventario_ArticuloID { get => inventario_ArticuloID; set => inventario_ArticuloID = value; }
        public double Inventario_Cantidad { get => inventario_Cantidad; set => inventario_Cantidad = value; }
        public string Inventario_Tipo { get => inventario_Tipo; set => inventario_Tipo = value; }
        public string Inventario_Estado { get => inventario_Estado; set => inventario_Estado = value; }
        #endregion
    }
}

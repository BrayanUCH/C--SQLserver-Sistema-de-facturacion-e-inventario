using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class Facturaccion
    {
        #region ATRIBUTOS
        private int facturacion_id;
        private string facturacion_Observaciones;
        private int facturacion_ClienteID;
        private double facturacion_Descuento;
        private double facturacion_Impuesto;
        private int facturacion_NumeroArticulos;
        private double facturacion_SubTotal;
        private double facturacion_Total;
        private string facturacion_Fecha;
        private string facturacion_Estado;





        #endregion

        #region CONSTRUTORES
        public Facturaccion()
        {
           
        }

        public Facturaccion(string facturacion_Observaciones, int facturacion_ClienteID, double facturacion_Descuento, double facturacion_Impuesto, int facturacion_NumeroArticulos, double facturacion_SubTotal, double facturacion_Total, string facturacion_Fecha, string facturacion_Estado)
        {
            this.facturacion_id = 0;
            this.facturacion_Observaciones = facturacion_Observaciones;
            this.facturacion_ClienteID = facturacion_ClienteID;
            this.facturacion_Descuento = facturacion_Descuento;
            this.facturacion_Impuesto = facturacion_Impuesto;
            this.facturacion_NumeroArticulos = facturacion_NumeroArticulos;
            this.facturacion_SubTotal = facturacion_SubTotal;
            this.facturacion_Total = facturacion_Total;
            this.facturacion_Fecha = facturacion_Fecha;
            this.facturacion_Estado = facturacion_Estado;
        }
        public Facturaccion(int facturacion_id, string facturacion_Observaciones, int facturacion_ClienteID, double facturacion_Descuento, double facturacion_Impuesto, int facturacion_NumeroArticulos, double facturacion_SubTotal, double facturacion_Total, string facturacion_Fecha, string facturacion_Estado)
        {
            this.facturacion_id = facturacion_id;
            this.facturacion_Observaciones = facturacion_Observaciones;
            this.facturacion_ClienteID = facturacion_ClienteID;
            this.facturacion_Descuento = facturacion_Descuento;
            this.facturacion_Impuesto = facturacion_Impuesto;
            this.facturacion_NumeroArticulos = facturacion_NumeroArticulos;
            this.facturacion_SubTotal = facturacion_SubTotal;
            this.facturacion_Total = facturacion_Total;
            this.facturacion_Fecha = facturacion_Fecha;
            this.facturacion_Estado = facturacion_Estado;
        }

        #endregion

        #region GETS_SETS
        public int Facturacion_id { get => facturacion_id; set => facturacion_id = value; }
       public string Facturacion_Observaciones { get => facturacion_Observaciones; set => facturacion_Observaciones = value; }
       public int Facturacion_ClienteID { get => facturacion_ClienteID; set => facturacion_ClienteID = value; }
       public double Facturacion_Descuento { get => facturacion_Descuento; set => facturacion_Descuento = value; }
       public double Facturacion_Impuesto { get => facturacion_Impuesto; set => facturacion_Impuesto = value; }
       public int Facturacion_NumeroArticulos { get => facturacion_NumeroArticulos; set => facturacion_NumeroArticulos = value; }
       public double Facturacion_SubTotal { get => facturacion_SubTotal; set => facturacion_SubTotal = value; }
       public double Facturacion_Total { get => facturacion_Total; set => facturacion_Total = value; }
       public string Facturacion_Fecha { get => facturacion_Fecha; set => facturacion_Fecha = value; }
       public string Facturacion_Estado { get => facturacion_Estado; set => facturacion_Estado = value; }
        #endregion
    }
}

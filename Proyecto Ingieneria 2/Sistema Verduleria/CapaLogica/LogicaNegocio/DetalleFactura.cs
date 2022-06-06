using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class DetalleFactura
    {

        #region ATRIBUTOS
        private int detalleFactura_id;
        private int detalleFactura_ArticulosID;
        private int detalleFactura_FacturacionID;
        private double detalleFactura_Cantidad;
        private double detalleFactura_Descuento;
        private double detalleFactura_Impuesto;
        private double detalleFactura_Precio;
        private string detalleFactura_Estado;
        #endregion

        #region CONSTRUTORES
        public DetalleFactura()
        {
            
        }

        public DetalleFactura(int detalleFactura_ArticulosID, int detalleFactura_FacturacionID, double detalleFactura_Cantidad, double detalleFactura_Descuento, double detalleFactura_Impuesto, double detalleFactura_Precio, string detalleFactura_Estado)
        {
            this.detalleFactura_id = 0;
            this.detalleFactura_ArticulosID = detalleFactura_ArticulosID;
            this.detalleFactura_FacturacionID = detalleFactura_FacturacionID;
            this.detalleFactura_Cantidad = detalleFactura_Cantidad;
            this.detalleFactura_Descuento = detalleFactura_Descuento;
            this.detalleFactura_Precio = detalleFactura_Precio;
            this.detalleFactura_Impuesto = detalleFactura_Impuesto;
            this.detalleFactura_Estado = detalleFactura_Estado;
        }
        public DetalleFactura(int detalleFactura_id, int detalleFactura_ArticulosID, int detalleFactura_FacturacionID, double detalleFactura_Cantidad, double detalleFactura_Descuento, double detalleFactura_Impuesto, double detalleFactura_Precio, string detalleFactura_Estado)
        {
            this.detalleFactura_id = detalleFactura_id;
            this.detalleFactura_ArticulosID = detalleFactura_ArticulosID;
            this.detalleFactura_FacturacionID = detalleFactura_FacturacionID;
            this.detalleFactura_Cantidad = detalleFactura_Cantidad;
            this.detalleFactura_Descuento = detalleFactura_Descuento;
            this.detalleFactura_Precio = detalleFactura_Precio;
            this.detalleFactura_Impuesto = detalleFactura_Impuesto;
            this.detalleFactura_Estado = detalleFactura_Estado;
        }
        #endregion

        #region GETS_SETS
        public int DetalleFactura_id { get => detalleFactura_id; set => detalleFactura_id = value; }
        public int DetalleFactura_ArticulosID { get => detalleFactura_ArticulosID; set => detalleFactura_ArticulosID = value; }
        public int DetalleFactura_FacturacionID { get => detalleFactura_FacturacionID; set => detalleFactura_FacturacionID = value; }
        public double DetalleFactura_Cantidad { get => detalleFactura_Cantidad; set => detalleFactura_Cantidad = value; }
        public double DetalleFactura_Descuento { get => detalleFactura_Descuento; set => detalleFactura_Descuento = value; }
        public double DetalleFactura_Impuesto { get => detalleFactura_Impuesto; set => detalleFactura_Impuesto = value; }
        public double DetalleFactura_Precio { get => detalleFactura_Precio; set => detalleFactura_Precio = value; }
        public string DetalleFactura_Estado { get => detalleFactura_Estado; set => detalleFactura_Estado = value; }
        #endregion




    }
}

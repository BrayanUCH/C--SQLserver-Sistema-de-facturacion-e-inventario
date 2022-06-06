using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class Articulos
    {

        #region ATRIBUTOS
        private int articulo_id;
        private string articulos_Codigo;
        private string articulos_Descripcion;
        private string articulos_Nombre;
        private string articulos_FamiliaID;
        private string articulos_UnidadesMedidaID;
        private double articulos_CantidadUnidadesMedida;
        private double articulos_Precio;
        private double articulos_Descuento;
        private double articulos_DescuentoApartirDe;
        private double articulos_Impuesto;
        private string articulos_Estado;




        #endregion

        #region CONSTRUTORES

        public Articulos()
        {

        }

        public Articulos(string articulos_Codigo, string articulos_Descripcion, string articulos_Nombre, string articulos_FamiliaID, string articulos_UnidadesMedidaID, double articulos_CantidadUnidadesMedida, double articulos_Precio, double articulos_Descuento, double articulos_Impuesto, string articulos_Estado)
        {
            this.articulos_Codigo = articulos_Codigo;
            this.articulos_Descripcion = articulos_Descripcion;
            this.articulos_Nombre = articulos_Nombre;
            this.articulos_FamiliaID = articulos_FamiliaID;
            this.articulos_UnidadesMedidaID = articulos_UnidadesMedidaID;
            this.articulos_CantidadUnidadesMedida = articulos_CantidadUnidadesMedida;
            this.articulos_Precio = articulos_Precio;
            this.articulos_Descuento = articulos_Descuento;
            this.articulos_Impuesto = articulos_Impuesto;
            this.articulos_Estado = articulos_Estado;
        }

        public Articulos(int articulo_id, string articulos_Codigo, string articulos_Descripcion, string articulos_Nombre, string articulos_FamiliaID, string articulos_UnidadesMedidaID, double articulos_CantidadUnidadesMedida, double articulos_Precio, double articulos_Descuento, double articulos_Impuesto, string articulos_Estado)
        {
            this.articulo_id = articulo_id;
            this.articulos_Codigo = articulos_Codigo;
            this.articulos_Descripcion = articulos_Descripcion;
            this.articulos_Nombre = articulos_Nombre;
            this.articulos_FamiliaID = articulos_FamiliaID;
            this.articulos_UnidadesMedidaID = articulos_UnidadesMedidaID;
            this.articulos_CantidadUnidadesMedida = articulos_CantidadUnidadesMedida;
            this.articulos_Precio = articulos_Precio;
            this.articulos_Descuento = articulos_Descuento;
            this.articulos_Impuesto = articulos_Impuesto;
            this.articulos_Estado = articulos_Estado;
        }
        #endregion

        #region GETS_SETS
        public int Articulo_id { get => articulo_id; set => articulo_id = value; }
        public string Articulos_Codigo { get => articulos_Codigo; set => articulos_Codigo = value; }
        public string Articulos_Descripcion { get => articulos_Descripcion; set => articulos_Descripcion = value; }
        public string Articulos_Nombre { get => articulos_Nombre; set => articulos_Nombre = value; }
        public string Articulos_FamiliaID { get => articulos_FamiliaID; set => articulos_FamiliaID = value; }
        public string Articulos_UnidadesMedidaID { get => articulos_UnidadesMedidaID; set => articulos_UnidadesMedidaID = value; }
        public double Articulos_CantidadUnidadesMedida { get => articulos_CantidadUnidadesMedida; set => articulos_CantidadUnidadesMedida = value; }
        public double Articulos_Precio { get => articulos_Precio; set => articulos_Precio = value; }
        public double Articulos_Descuento { get => articulos_Descuento; set => articulos_Descuento = value; }
        public double Articulos_DescuentoApartirDe { get => articulos_DescuentoApartirDe; set => articulos_DescuentoApartirDe = value; }
        public double Articulos_Impuesto { get => articulos_Impuesto; set => articulos_Impuesto = value; }
        public string Articulos_Estado { get => articulos_Estado; set => articulos_Estado = value; }
        #endregion

    }
}

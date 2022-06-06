using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class FamiliaProductos
    {
        #region ATRIBUTOS
        private int familia_id;
        private string familia_Codigo;
        private string familia_tipo;
        private string familia_descripcion;
        private string familia_estado;       
        #endregion

        #region CONSTRUTORES
        public FamiliaProductos()
        {

        }
        public FamiliaProductos(string familia_Codigo, string familia_tipo, string familia_descripcion, string familia_estado)
        {
            this.familia_id = 0;
            this.familia_Codigo = familia_Codigo;
            this.familia_tipo = familia_tipo;
            this.familia_descripcion = familia_descripcion;
            this.familia_estado = familia_estado;
        }
        public FamiliaProductos(int familia_id, string familia_Codigo, string familia_tipo, string familia_descripcion, string familia_estado)
        {
            this.familia_id = familia_id;
            this.familia_Codigo = familia_Codigo;
            this.familia_tipo = familia_tipo;
            this.familia_descripcion = familia_descripcion;
            this.familia_estado = familia_estado;
        }
        #endregion

        #region GETS_SETS
        public int Familia_id { get => familia_id; set => familia_id = value; }
        public string Familia_Codigo { get => familia_Codigo; set => familia_Codigo = value; }
        public string Familia_tipo { get => familia_tipo; set => familia_tipo = value; }
        public string Familia_descripcion { get => familia_descripcion; set => familia_descripcion = value; }
        public string Familia_estado { get => familia_estado; set => familia_estado = value; }
        #endregion
    }
}

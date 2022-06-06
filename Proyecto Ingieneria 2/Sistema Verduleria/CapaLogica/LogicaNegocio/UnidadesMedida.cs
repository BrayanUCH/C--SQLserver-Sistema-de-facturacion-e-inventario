using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class UnidadesMedida
    {
        #region ATRIBUTOS
        private int unidadesMedida_id;
        private string unidadesMedida_Descripcion;
        private string unidadesMedida_Abreviatura;
        private string unidadesMedida_Estado;
        #endregion

        #region CONSTRUTORES
        public UnidadesMedida()
        {
            
        }
        public UnidadesMedida(string unidadesMedida_Descripcion, string unidadesMedida_Abreviatura, string unidadesMedida_Estado)
        {
            this.unidadesMedida_id = 0;
            this.unidadesMedida_Descripcion = unidadesMedida_Descripcion;
            this.unidadesMedida_Abreviatura = unidadesMedida_Abreviatura;
            this.unidadesMedida_Estado = unidadesMedida_Estado;
        }
        public UnidadesMedida(int unidadesMedida_id, string unidadesMedida_Descripcion, string unidadesMedida_Abreviatura, string unidadesMedida_Estado)
        {
            this.unidadesMedida_id = unidadesMedida_id;
            this.unidadesMedida_Descripcion = unidadesMedida_Descripcion;
            this.unidadesMedida_Abreviatura = unidadesMedida_Abreviatura;
            this.unidadesMedida_Estado = unidadesMedida_Estado;
        }
        #endregion

        #region GETS_SETS
        public int UnidadesMedida_id { get => unidadesMedida_id; set => unidadesMedida_id = value; }
        public string UnidadesMedida_Descripcion { get => unidadesMedida_Descripcion; set => unidadesMedida_Descripcion = value; }
        public string UnidadesMedida_Abreviatura { get => unidadesMedida_Abreviatura; set => unidadesMedida_Abreviatura = value; }
        public string UnidadesMedida_Estado { get => unidadesMedida_Estado; set => unidadesMedida_Estado = value; }
        #endregion


    }
}

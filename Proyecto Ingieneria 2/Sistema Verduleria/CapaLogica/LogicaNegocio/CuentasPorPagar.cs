using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class CuentasPorPagar
    {
        #region ATRIBUTOS
        private int cuentasXPagar_id;
        private int cuentasXPagar_ProveedorID;
        private string cuentasXPagar_Descripcion;
        private string cuentasXPagar_FechaPago;
        private double cuentasXPagar_Monto;
        private string cuentasXPagar_Estado;




        #endregion

        #region CONSTRUTORES
        public CuentasPorPagar()
        {
            
        }
        public CuentasPorPagar(int cuentasXPagar_ProveedorID, string cuentasXPagar_Descripcion, string cuentasXPagar_FechaPago, double cuentasXPagar_Monto, string cuentasXPagar_Estado)
        {
            this.cuentasXPagar_ProveedorID = cuentasXPagar_ProveedorID;
            this.cuentasXPagar_Descripcion = cuentasXPagar_Descripcion;
            this.cuentasXPagar_FechaPago = cuentasXPagar_FechaPago;
            this.cuentasXPagar_Monto = cuentasXPagar_Monto;
            this.cuentasXPagar_Estado = cuentasXPagar_Estado;
        }
        public CuentasPorPagar(int cuentasXPagar_id, int cuentasXPagar_ProveedorID, string cuentasXPagar_Descripcion, string cuentasXPagar_FechaPago, double cuentasXPagar_Monto, string cuentasXPagar_Estado)
        {
            this.cuentasXPagar_id = cuentasXPagar_id;
            this.cuentasXPagar_ProveedorID = cuentasXPagar_ProveedorID;
            this.cuentasXPagar_Descripcion = cuentasXPagar_Descripcion;
            this.cuentasXPagar_FechaPago = cuentasXPagar_FechaPago;
            this.cuentasXPagar_Monto = cuentasXPagar_Monto;
            this.cuentasXPagar_Estado = cuentasXPagar_Estado;
        }
        #endregion

        #region GETS_SETS
        public int CuentasXPagar_id { get => cuentasXPagar_id; set => cuentasXPagar_id = value; }
        public int CuentasXPagar_ProveedorID { get => cuentasXPagar_ProveedorID; set => cuentasXPagar_ProveedorID = value; }
        public string CuentasXPagar_Descripcion { get => cuentasXPagar_Descripcion; set => cuentasXPagar_Descripcion = value; }
        public string CuentasXPagar_FechaPago { get => cuentasXPagar_FechaPago; set => cuentasXPagar_FechaPago = value; }
        public double CuentasXPagar_Monto { get => cuentasXPagar_Monto; set => cuentasXPagar_Monto = value; }
        public string CuentasXPagar_Estado { get => cuentasXPagar_Estado; set => cuentasXPagar_Estado = value; }
        #endregion
         



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class Cliente
    {
        #region ATRIBUTOS
        protected int cliente_id;
        protected string cliente_nombre;
        protected string cliente_Cedula;
        protected string cliente_CorreoElectronico;
        protected string cliente_Telefono;
        protected string cliente_FechaNacimiento;
        protected string cliente_Estado;
        #endregion

        #region CONSTRUTORES
        public Cliente()
        {

        }

        public Cliente(string pcliente_nombre, string pcliente_Cedula, string pcliente_CorreoElectronico, string pcliente_Telefono, string pcliente_FechaNacimiento, string pcliente_Estado)
        {
            this.cliente_id = 0;
            this.cliente_nombre = pcliente_nombre;
            this.cliente_Cedula = pcliente_Cedula;
            this.cliente_CorreoElectronico = pcliente_CorreoElectronico;
            this.cliente_Telefono = pcliente_Telefono;
            this.cliente_FechaNacimiento = pcliente_FechaNacimiento;
            this.cliente_Estado = pcliente_Estado;
        }
        public Cliente(int pcliente_id,string pcliente_nombre, string pcliente_Cedula, string pcliente_CorreoElectronico, string pcliente_Telefono, string pcliente_FechaNacimiento, string pcliente_Estado)
        {
            this.cliente_id = pcliente_id;
            this.cliente_nombre = pcliente_nombre;
            this.cliente_Cedula = pcliente_Cedula;
            this.cliente_CorreoElectronico = pcliente_CorreoElectronico;
            this.cliente_Telefono = pcliente_Telefono;
            this.cliente_FechaNacimiento = pcliente_FechaNacimiento;
            this.cliente_Estado = pcliente_Estado;
        }

        #endregion

        #region GETS_SETS
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Cliente_nombre { get => cliente_nombre; set => cliente_nombre = value; }
        public string Cliente_Cedula { get => cliente_Cedula; set => cliente_Cedula = value; }
        public string Cliente_CorreoElectronico { get => cliente_CorreoElectronico; set => cliente_CorreoElectronico = value; }
        public string Cliente_Telefono { get => cliente_Telefono; set => cliente_Telefono = value; }
        public string Cliente_FechaNacimiento { get => cliente_FechaNacimiento; set => cliente_FechaNacimiento = value; }
        public string Cliente_Estado { get => cliente_Estado; set => cliente_Estado = value; }
        #endregion

    }
}



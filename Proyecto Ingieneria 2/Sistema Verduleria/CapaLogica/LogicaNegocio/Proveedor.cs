using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class Proveedor
    {
        #region ATRIBUTOS
        private int proveedor_id;
        private string proveedor_Codigo;
        private string proveedor_Cedula;
        private string proveedor_NombreORazonSocial;
        private DateTime proveedor_FechaIngreso;
        private double proveedor_Saldo;
        private string proveedor_CuentaDelBanco;
        private string proveedor_Banco;
        private string proveedor_DiasDePago;
        private string proveedor_Telefono;
        private string proveedor_CorreoElectronico;
        private string proveedor_Estado;
        
        #endregion

        #region CONSTRUTORES
        public Proveedor()
        {
            
        }
        public Proveedor(string proveedor_Codigo, string proveedor_Cedula, string proveedor_NombreORazonSocial, DateTime proveedor_FechaIngreso, double proveedor_Saldo, string proveedor_CuentaDelBanco, string proveedor_Banco, string proveedor_DiasDePago, string proveedor_Telefono, string proveedor_CorreoElectronico, string proveedor_Estado)
        {
            this.proveedor_id = 0;
            this.proveedor_Codigo = proveedor_Codigo;
            this.proveedor_Cedula = proveedor_Cedula;
            this.proveedor_NombreORazonSocial = proveedor_NombreORazonSocial;
            this.proveedor_FechaIngreso = proveedor_FechaIngreso;
            this.proveedor_Saldo = proveedor_Saldo;
            this.proveedor_CuentaDelBanco = proveedor_CuentaDelBanco;
            this.proveedor_Banco = proveedor_Banco;
            this.proveedor_DiasDePago = proveedor_DiasDePago;
            this.proveedor_Telefono = proveedor_Telefono;
            this.proveedor_CorreoElectronico = proveedor_CorreoElectronico;
            this.proveedor_Estado = proveedor_Estado;
        }
        public Proveedor(int proveedor_id, string proveedor_Codigo, string proveedor_Cedula, string proveedor_NombreORazonSocial, DateTime proveedor_FechaIngreso, double proveedor_Saldo, string proveedor_CuentaDelBanco, string proveedor_Banco, string proveedor_DiasDePago, string proveedor_Telefono, string proveedor_CorreoElectronico, string proveedor_Estado)
        {
            this.proveedor_id = proveedor_id;
            this.proveedor_Codigo = proveedor_Codigo;
            this.proveedor_Cedula = proveedor_Cedula;
            this.proveedor_NombreORazonSocial = proveedor_NombreORazonSocial;
            this.proveedor_FechaIngreso = proveedor_FechaIngreso;
            this.proveedor_Saldo = proveedor_Saldo;
            this.proveedor_CuentaDelBanco = proveedor_CuentaDelBanco;
            this.proveedor_Banco = proveedor_Banco;
            this.proveedor_DiasDePago = proveedor_DiasDePago;
            this.proveedor_Telefono = proveedor_Telefono;
            this.proveedor_CorreoElectronico = proveedor_CorreoElectronico;
            this.proveedor_Estado = proveedor_Estado;
        }
        #endregion

        #region GETS_SETS
        public int Proveedor_id { get => proveedor_id; set => proveedor_id = value; }
        public string Proveedor_Codigo { get => proveedor_Codigo; set => proveedor_Codigo = value; }
        public string Proveedor_Cedula { get => proveedor_Cedula; set => proveedor_Cedula = value; }
        public string Proveedor_NombreORazonSocial { get => proveedor_NombreORazonSocial; set => proveedor_NombreORazonSocial = value; }
        public DateTime Proveedor_FechaIngreso { get => proveedor_FechaIngreso; set => proveedor_FechaIngreso = value; }
        public double Proveedor_Saldo { get => proveedor_Saldo; set => proveedor_Saldo = value; }
        public string Proveedor_CuentaDelBanco { get => proveedor_CuentaDelBanco; set => proveedor_CuentaDelBanco = value; }
        public string Proveedor_Banco { get => proveedor_Banco; set => proveedor_Banco = value; }
        public string Proveedor_DiasDePago { get => proveedor_DiasDePago; set => proveedor_DiasDePago = value; }
        public string Proveedor_Telefono { get => proveedor_Telefono; set => proveedor_Telefono = value; }
        public string Proveedor_CorreoElectronico { get => proveedor_CorreoElectronico; set => proveedor_CorreoElectronico = value; }
        public string Proveedor_Estado { get => proveedor_Estado; set => proveedor_Estado = value; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVerduleria.CapaLogica.LogicaNegocio
{
    public class Login
    {
        #region ATRIBUTOS
        private int login_id;
        private string login_Usuario;
        private string login_Nombre;
        private string login_contraseña;
        private string login_correoElectronico;
        private string login_estado;
        #endregion

        #region CONSTRUTORES
        public Login()
        {
            
        }

        public Login(int login_id, string login_contraseña)
        {
            this.login_id = login_id;
            this.login_contraseña = login_contraseña;
        }

        public Login(string login_Usuario, string login_Nombre, string login_contraseña, string login_correoElectronico, string login_estado)
        {
            this.login_id = 0;
            this.login_Usuario = login_Usuario;
            this.login_Nombre = login_Nombre;
            this.login_contraseña = login_contraseña;
            this.login_correoElectronico = login_correoElectronico;
            this.login_estado = login_estado;
        }
        public Login(int login_id, string login_Usuario, string login_Nombre, string login_contraseña, string login_correoElectronico, string login_estado)
        {
            this.login_id = login_id;
            this.login_Usuario = login_Usuario;
            this.login_Nombre = login_Nombre;
            this.login_contraseña = login_contraseña;
            this.login_correoElectronico = login_correoElectronico;
            this.login_estado = login_estado;
        }
        #endregion

        #region GETS_SETS
        public int Login_id { get => login_id; set => login_id = value; }
        public string Login_Usuario { get => login_Usuario; set => login_Usuario = value; }
        public string Login_Nombre { get => login_Nombre; set => login_Nombre = value; }
        public string Login_contraseña { get => login_contraseña; set => login_contraseña = value; }
        public string Login_correoElectronico { get => login_correoElectronico; set => login_correoElectronico = value; }
        public string Login_estado { get => login_estado; set => login_estado = value; }
        #endregion
    }
}

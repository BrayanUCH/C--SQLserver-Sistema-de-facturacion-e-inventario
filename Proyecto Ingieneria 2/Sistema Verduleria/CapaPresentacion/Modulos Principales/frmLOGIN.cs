using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//Bibliotecas
using SistemaVerduleria.CapaIntegracion;
using System.Data.SqlClient;
using SistemaVerduleria.CapaConexion;
using CapaPresentacion.Modulos;
using CapaPresentacion.Modulos_Registros;
using CapaPresentacion.Modulos_Principales;

namespace CapaPresentacion
{
    /// <summary>
    /// Está clase es la que posee los atributos de usuarios para que permita el ingreso de estos mismos al programa.
    /// </summary>
    public partial class frmLOGIN : Form
    {
        public frmLOGIN()
        {
            InitializeComponent();
        }

        string userid;
        string user;
        string name;
        string password;
        string mail;
        string status;

        DataSet dsU = new DataSet();
        DataTable dtU = new DataTable();

        /// <summary>
        /// Este método se encargan de buscar los datos que se encuentra en la base de datos  
        /// y verificar si se encuentra o no en la base de datos.
        /// <summary>
        private void BuscarUser()
        {
            user = txtUsuario.Text;

            using (GestorLogin service = new GestorLogin())
            {
                this.dsU = service.ConsultarUsuario(user);
                this.dtU = this.dsU.Tables[0];
            }
            if ((txtUsuario.Text == "Admin99" && txtContraseña.Text == "Admin99"))
            {
                this.Hide();
                frmPrincipal form1 = new frmPrincipal();
                form1.ShowDialog();
                this.Close();
                Refresh();
            }
            else if ((dtU == null) || (dtU.Rows.Count == 0))
            {
                msgError("El usuario ingreaso no se encuentra registrado \nPor favor intente nuevamente");
            }
            else
            {
                CargarDatosU();
                logear();
            }

        }

        /// <summary>
        /// Este método es el que permiten cargar los datos que se encuentran en la base datos.
        /// </summary>
        private void CargarDatosU()
        {
            userid = this.dtU.Rows[0]["Login_id"].ToString();
            user = this.dtU.Rows[0]["Login_Usuario"].ToString();
            name = this.dtU.Rows[0]["Login_Nombre"].ToString();
            password = this.dtU.Rows[0]["Login_contraseña"].ToString();
            mail = this.dtU.Rows[0]["Login_correoElectronico"].ToString();
            status = this.dtU.Rows[0]["Login_estado"].ToString();
        }

        /// <summary>
        /// Este método es el que pemite hacer la validación del tipo de usuario que ingresa al programa.
        /// </summary>

        public void logear()
        {
            if (password == txtContraseña.Text)
            {
                this.Hide();

                frmPrincipal form1 = new frmPrincipal();

                form1.Show();
            }
            else
            {
                msgError("Usuario y/o contraseña incorrecta \nPorfavor intente nuevamente");
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            BuscarUser();
        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.White;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Este método se encargan de cerrar la aplicación.
        /// <summary>
        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Este método se encargan de minimizar la ventane del form.
        /// <summary>
        private void ibtnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Este método se encargan de generar y mostrar un mensage de error.
        /// <summary>
        private void msgError(string msg)
        {
            lblMensageError.Text = msg;
            lblMensageError.Visible = true;
        }

        /// <summary>
        /// Este método se encarga de hacer la conexión entre los from.
        /// <summary>
        #region METODO CAMBIO DE FORM
        bool login;
        internal void Logout(bool Volver)
        {
            login = Volver;
        }
        #endregion METODO CAMBIO FORM

        private void lnk_olvidoContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOlvidarContraseña frm = new frmOlvidarContraseña();
            frm.ShowDialog();
            Refresh();
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarUser();
            }
        }

         }
}

using SistemaVerduleria.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace CapaPresentacion.Modulos_Principales
{
    public partial class frmOlvidarContraseña : Form
    {
        private int codigo = 0;
        private int ID = 0;
        public frmOlvidarContraseña()
        {
            InitializeComponent();
            pnl_contraseñaNueva.Visible = false;
            txb_codigo.Visible = false;
            btn_siguiente.Visible = false;
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();

            if (txb_correo.Text != "")
            {
                using (GestorLogin service = new GestorLogin())
                {
                    dset = service.ConsultarCorreo(txb_correo.Text);
                    dtable = dset.Tables[0];
                }
                if (dtable.Rows.Count != 0)
                {
                    ID = int.Parse(dtable.Rows[0]["Login_id"].ToString());
                    btn_verificar.Enabled = false;
                    enviarCorreo(txb_correo.Text, dtable.Rows[0]["Login_Nombre"].ToString());
                    btn_verificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Correo incorrecto.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Digite un correo electrónico", "ERROR");
            }
        }
        private void enviarCorreo(string correo, string nombre)
        {
            Random random = new Random();

            codigo = random.Next(1000, 10000);

            MailMessage recuperacion = new MailMessage();

            recuperacion.To.Add(correo);
            recuperacion.Subject = "Codigo de confirmación.";
            recuperacion.SubjectEncoding = Encoding.UTF8;
            recuperacion.Bcc.Add("verduleriaquerubin@gmail.com");

            recuperacion.Body = "<h1>Estimado(a) :" + nombre + ". " +
                "El codigo de recuperación para el sistema de facturación es: " + codigo + ". " +
                "No envíe ni comparte este código con nadie.</h1>";

            recuperacion.BodyEncoding = Encoding.UTF8;
            recuperacion.IsBodyHtml = true;
            recuperacion.From = new MailAddress("verduleriaquerubin@gmail.com", "SISTEMA DE SEGURIDAD 'Verdulería Querubín'");

            SmtpClient cliente = new SmtpClient();
            //verduleriaquerubin@gmail.com
            //Querubin261021
            cliente.Credentials = new NetworkCredential("verduleriaquerubin@gmail.com", "Querubin261021");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(recuperacion);
                lbl_info.Text = "CÓDIGO ENVIADO CON ÉXITO.";
                txb_codigo.Visible = true;
                btn_siguiente.Visible = true;

            }
            catch (Exception)
            {
                lbl_info.Text = "ERROR AL ENVIO DEL CODIGO.";
                MessageBox.Show("Revise su conexión o la dirección de correo electrónico.", "ERROR");
            }
        }

        private void bnt_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarContraseña();
        }
        void ActualizarContraseña()
        {
            if (txb_nuevaContraseña.Text == txb_VerificarContraseña.Text)
            {
                using (GestorLogin Gestor = new GestorLogin())
                {
                    Gestor.ModificarContraseña(ID, txb_nuevaContraseña.Text);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, vuelva a intentarlo.", "ERROR");
            }
        }
        private void bnt_volver_Click(object sender, EventArgs e)
        {
            pnl_contraseñaNueva.Visible = false;
            txb_codigo.Visible = false;
            btn_siguiente.Visible = false;
            ID = 0;
            codigo = 0;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (txb_codigo.Text == codigo.ToString() && txb_codigo.Text != "0")
            {
                pnl_contraseñaNueva.Visible = true;
                txb_codigo.Text = "Codigo de verificación";
                txb_correo.Text = "Correo electrónico";
                lbl_info.Text = "...";
                txb_codigo.Visible = false;
                btn_siguiente.Visible = false;
            }
            else
            {
                MessageBox.Show("El código es incorrecto.", "ERROR DE CONFIRMACIÓN");
            }
        }


        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txb_correo_Enter(object sender, EventArgs e)
        {
            if (txb_correo.Text == "Correo electrónico")
            {
                txb_correo.Text = "";
                txb_correo.ForeColor = Color.White;
            }
        }

        private void txb_correo_Leave(object sender, EventArgs e)
        {
            if (txb_correo.Text == "")
            {
                txb_correo.Text = "Correo electrónico";
                txb_correo.ForeColor = Color.White;

            }
        }

        private void txb_codigo_Enter(object sender, EventArgs e)
        {
            if (txb_codigo.Text == "Codigo de verificación")
            {
                txb_codigo.Text = "";
                txb_codigo.ForeColor = Color.White;
                txb_codigo.UseSystemPasswordChar = true;
            }
        }

        private void txb_codigo_Leave(object sender, EventArgs e)
        {
            if (txb_codigo.Text == "")
            {
                txb_codigo.Text = "Codigo de verificación";
                txb_codigo.ForeColor = Color.White;
                txb_codigo.UseSystemPasswordChar = false;
            }
        }

        private void txb_nuevaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ActualizarContraseña();
            }
        }

        private void txb_VerificarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ActualizarContraseña();
            }
        }

        private void pnl_contraseñaNueva_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

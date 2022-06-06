using SistemaVerduleria.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modulos_Registros
{
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }
        private int CampoVacio()
        {
            if (txb_Nombre.Text == "")
            {
                errorProvider1.SetError(txb_Nombre, "Ingresar nombre");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Cedula.Text == "")
            {
                errorProvider1.SetError(txb_Cedula, "Ingresar cédula");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_CorreoElectronico.Text == "")
            {
                errorProvider1.SetError(txb_CorreoElectronico, "Ingresar correo electrónico");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Telefono.Text == "")
            {
                errorProvider1.SetError(txb_Telefono, "Ingresar teléfono");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (dp_FechaNacimiento.Text == "")
            {
                errorProvider1.SetError(dp_FechaNacimiento, "Ingresar fecha de nacimiento");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                MailMessage mail = new MailMessage();

                mail.To.Add(txb_CorreoElectronico.Text);
                mail.Subject = "SISTEMA Verduleria Querubín.";
                mail.SubjectEncoding = Encoding.UTF8;
                //recuperacion.Bcc.Add("verduleriaquerubin@gmail.com");

                mail.Body = "<h1>Bienvenido(a) " + txb_Nombre.Text + " al sistema de facturacion de la Verduleria " +
                    "el Querubín, ahora todas sus transaciones seran mas faciles y rapidas. Si no desea estar en el sistema " +
                    "responda a este correo con la palabra 'NO'.</h1>";

                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("verduleriaquerubin@gmail.com", "SISTEMA DE FACTURACIÓN 'Verdulería Querubín'");

                SmtpClient cliente = new SmtpClient();
                //verduleriaquerubin@gmail.com
                //Querubin261021
                cliente.Credentials = new NetworkCredential("verduleriaquerubin@gmail.com", "Querubin261021");

                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";


                cliente.Send(mail);
            }
            catch (Exception)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txb_CorreoElectronico, "Verifique el correo que se dígito.");
                return 1;
            }
            errorProvider1.Clear();
            return 0;
        }
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0)
            {
                using (GestorCliente Gestor = new GestorCliente())
                {
                    Gestor.Insertar(txb_Nombre.Text, txb_Cedula.Text, txb_CorreoElectronico.Text, txb_Telefono.Text, dp_FechaNacimiento.Value.ToString(), "A");
                }
                this.Close();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txb_Nombre.Text = "";
            txb_Cedula.Text = "";
            txb_CorreoElectronico.Text = "";
            txb_Telefono.Text = "";
            dp_FechaNacimiento.Value = DateTime.Now;
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (CampoVacio() == 0)
                {
                    using (GestorCliente Gestor = new GestorCliente())
                    {
                        Gestor.Insertar(txb_Nombre.Text, txb_Cedula.Text, txb_CorreoElectronico.Text, txb_Telefono.Text, dp_FechaNacimiento.Value.ToString(), "A");
                    }
                    this.Close();
                }
            }
        }
    }
}

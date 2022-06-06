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
    public partial class frmRegistroUsuarios : Form
    {
        int id = 0;
        public frmRegistroUsuarios()
        {
            InitializeComponent();

            CargarGridUsuarios();
            ckb_Activar.Visible = false;
        }

        #region Métodos Cargar DataGrid
        private void CargarGridUsuarios()
        {
            using (GestorLogin servicio = new GestorLogin())
            {
                if (ckb_ListarInactivos.Checked == true)
                {
                    dgv_Usuarios.DataSource = servicio.ListarI();
                    btn_Insertar.Visible = false;
                }
                else
                {
                    dgv_Usuarios.DataSource = servicio.ListarA();
                    btn_Insertar.Visible = true;
                }

                dgv_Usuarios.Columns["Login_id"].HeaderText = "ID";
                dgv_Usuarios.Columns["Login_Usuario"].HeaderText = "Usuario";
                dgv_Usuarios.Columns["Login_Nombre"].HeaderText = "Nombre";
                dgv_Usuarios.Columns["Login_contraseña"].HeaderText = "Contraseña";
                dgv_Usuarios.Columns["Login_correoElectronico"].HeaderText = "Correo electrónico";
                dgv_Usuarios.Columns["Login_estado"].Visible = false;
            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar
        private void Limpiar()
        {
            txb_Usuario.Text = "";
            txb_Nombre.Text = "";
            txb_Contraseña.Text = "";
            txb_CorreoElectronico.Text = "";

            id = 0;
            ckb_Activar.Visible = false;

            errorProvider1.Clear();

            CargarGridUsuarios();
        }

        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio(string M)
        {
            if (txb_Usuario.Text == "")
            {
                errorProvider1.SetError(txb_Usuario, "Ingresar un usuario");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Nombre.Text == "")
            {
                errorProvider1.SetError(txb_Nombre, "Ingresar un nombre");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Contraseña.Text == "")
            {
                errorProvider1.SetError(txb_Contraseña, "Ingresar una contraseña");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_CorreoElectronico.Text == "")
            {
                errorProvider1.SetError(txb_CorreoElectronico, "Ingresar el correo electrónico");
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
                if (M == "M")
                {
                    mail.Body = "<h1>Estimado(a) " + txb_Nombre.Text + " su infomración ha sido modificada en el sistema de facturacion de la Verduleria" +
                        " el Querubín. Si no desea estar en el sistema responda a este correo con la palabra 'NO'.</h1>";
                }
                else
                {
                    mail.Body = "<h1>Bienvenido(a) " + txb_Nombre.Text + " al sistema de facturacion de la Verduleria " +
                        "el Querubín, ahora todas sus transaciones seran mas faciles y rapidas. Si no desea estar en el sistema " +
                        "responda a este correo con la palabra 'NO'.</h1>";
                }
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
            return 0;
        }
        #endregion Métodos Campos Vacios

        #region Eventos Botones
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio("I") == 0)
            {
                using (GestorLogin Gestor = new GestorLogin())
                {
                    Gestor.Insertar(txb_Usuario.Text, txb_Nombre.Text, txb_Contraseña.Text, txb_CorreoElectronico.Text, "A");
                }
                Limpiar();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio("M") == 0 && id != 0)
            {
                using (GestorLogin Gestor = new GestorLogin())
                {
                    if (ckb_Activar.Checked == true)
                    {
                        Gestor.Modificar(id, txb_Usuario.Text, txb_Nombre.Text, txb_Contraseña.Text, txb_CorreoElectronico.Text, "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, txb_Usuario.Text, txb_Nombre.Text, txb_Contraseña.Text, txb_CorreoElectronico.Text, "I");
                    }
                }
                Limpiar();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorLogin Gestor = new GestorLogin())
                {
                    Gestor.Eliminar(id);
                }
                Limpiar();
            }
        }
        #endregion Eventos Botones

        #region Eventos CheckBox
        private void ckb_ListarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion Eventos CheckBox

        #region Eventos DataGrid
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgv_Usuarios.CurrentCell.RowIndex;
                id = int.Parse(this.dgv_Usuarios[0, numFila].Value.ToString());

                using (GestorLogin Gestor = new GestorLogin())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                txb_Usuario.Text = dtable.Rows[0]["Login_Usuario"].ToString();
                txb_Nombre.Text = dtable.Rows[0]["Login_Nombre"].ToString();
                txb_Contraseña.Text = dtable.Rows[0]["Login_contraseña"].ToString();
                txb_CorreoElectronico.Text = dtable.Rows[0]["Login_correoElectronico"].ToString();

                if (dtable.Rows[0]["Login_estado"].ToString() == "A")
                {
                    ckb_Activar.Visible = true;
                    ckb_Activar.Checked = true;
                }
                else
                {
                    ckb_Activar.Visible = true;
                    ckb_Activar.Checked = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion Eventos DataGrid


    }
}

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
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();

            CargarGridCliente();
            ckb_Activar.Visible = false;
        }

        int id = 0;

        #region Método Cargar Grid
        private void CargarGridCliente()
        {
            using (GestorCliente servicio = new GestorCliente())
            {
                if (ckb_ListarInactivos.Checked == true)
                {
                    dgv.DataSource = servicio.ListarI();
                    btn_Insertar.Visible = false;
                }
                else
                {
                    dgv.DataSource = servicio.ListarA();
                    btn_Insertar.Visible = true;
                }


                dgv.Columns["Cliente_id"].HeaderText = "ID";
                dgv.Columns["Cliente_nombre"].HeaderText = "Nombre";
                dgv.Columns["Cliente_Cedula"].HeaderText = "Cedula";
                dgv.Columns["Cliente_CorreoElectronico"].HeaderText = "Correo Electronico";
                dgv.Columns["Cliente_Telefono"].HeaderText = "Telefono";
                dgv.Columns["Cliente_FechaNacimiento"].HeaderText = "Fecha Nacimiento";
                dgv.Columns["Cliente_Estado"].Visible = false;
            }
        }
        #endregion Método Cargar Grid

        #region Método Limpiar
        private void Limpiar()
        {
            txb_Nombre.Text = "";
            txb_Cedula.Text = "";
            txb_CorreoElectronico.Text = "";
            txb_Telefono.Text = "";
            dp_FechaNacimiento.Value = DateTime.Now;

            id = 0;
            ckb_Activar.Visible = false;

            errorProvider1.Clear();

            CargarGridCliente();
        }
        #endregion Método Limpiar

        #region Método Campos Vacios
        private int CampoVacio(string M)
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
            errorProvider1.Clear();
            return 0;
        }
        #endregion Método Campos Vacios

        #region Eventos Botones
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio("I") == 0)
            {
                using (GestorCliente Gestor = new GestorCliente())
                {
                    Gestor.Insertar(txb_Nombre.Text, txb_Cedula.Text, txb_CorreoElectronico.Text, txb_Telefono.Text, dp_FechaNacimiento.Value.ToString(), "A");
                }
                Limpiar();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio("M") == 0 && id != 0)
            {
                using (GestorCliente Gestor = new GestorCliente())
                {
                    if (ckb_Activar.Checked == true)
                    {
                        Gestor.Modificar(id, txb_Nombre.Text, txb_Cedula.Text, txb_CorreoElectronico.Text, txb_Telefono.Text, dp_FechaNacimiento.Value.ToString(), "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, txb_Nombre.Text, txb_Cedula.Text, txb_CorreoElectronico.Text, txb_Telefono.Text, dp_FechaNacimiento.Value.ToString(), "I");
                    }
                }
                Limpiar();
            }
        }

        private void BtnCliente_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorCliente Gestor = new GestorCliente())
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

        #region Eventos Data Grid 
        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgv.CurrentCell.RowIndex;
                id = int.Parse(this.dgv[0, numFila].Value.ToString());

                using (GestorCliente Gestor = new GestorCliente())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                txb_Nombre.Text = dtable.Rows[0]["Cliente_nombre"].ToString();
                txb_Cedula.Text = dtable.Rows[0]["Cliente_Cedula"].ToString();
                txb_CorreoElectronico.Text = dtable.Rows[0]["Cliente_CorreoElectronico"].ToString();
                txb_Telefono.Text = dtable.Rows[0]["Cliente_Telefono"].ToString();
                dp_FechaNacimiento.Value = DateTime.Parse(dtable.Rows[0]["Cliente_FechaNacimiento"].ToString());

                if (dtable.Rows[0]["Cliente_Estado"].ToString() == "A")
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
        #endregion Eventos Data Grid


    }
}

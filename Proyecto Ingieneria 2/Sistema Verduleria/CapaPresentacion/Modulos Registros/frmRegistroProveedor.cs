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
    public partial class frmRegistroProveedor : Form
    {
        int id = 0;
        public frmRegistroProveedor()
        {
            InitializeComponent();

            CargarGridProveedor();
            ckb_Activar.Visible = false;
        }

        #region Métodos Cargar DataGrid
        private void CargarGridProveedor()
        {
            using (GestorProveedor servicio = new GestorProveedor())
            {
                if (ckb_ListarInactivos.Checked == true)
                {
                    dgv_Proveedor.DataSource = servicio.ListarI();
                    btn_Insertar.Visible = false;
                }
                else
                {
                    dgv_Proveedor.DataSource = servicio.ListarA();
                    btn_Insertar.Visible = true;
                }

                dgv_Proveedor.Columns["Proveedor_id"].HeaderText = "ID";
                dgv_Proveedor.Columns["Proveedor_Codigo"].HeaderText = "Codigo del proveedor";
                dgv_Proveedor.Columns["Proveedor_Cedula"].HeaderText = "Cédula";
                dgv_Proveedor.Columns["Proveedor_NombreORazonSocial"].HeaderText = "Razón social";
                dgv_Proveedor.Columns["Proveedor_FechaIngreso"].HeaderText = "Fecha de ingreso";
                dgv_Proveedor.Columns["Proveedor_Saldo"].HeaderText = "Saldo";
                dgv_Proveedor.Columns["Proveedor_CuentaDelBanco"].HeaderText = "Cuenta de banco";
                dgv_Proveedor.Columns["Proveedor_Banco"].HeaderText = "Banco";
                dgv_Proveedor.Columns["Proveedor_DiasDePago"].HeaderText = "Días de pago";
                dgv_Proveedor.Columns["Proveedor_Telefono"].HeaderText = "Teléfono";
                dgv_Proveedor.Columns["Proveedor_CorreoElectronico"].HeaderText = "Correo electrónico";
                dgv_Proveedor.Columns["Proveedor_Estado"].Visible = false;

            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar
        private void Limpiar()
        {
            txb_Cedula.Text = "";
            txb_Nombre.Text = "";
            txb_Codigo.Text = "";
            dtp_FechaIngreso.Text = "";
            txb_Saldo.Text = null;
            txb_CuentaBanco.Text = null;
            txb_Banco.Text = "";
            txb_DiasDePago.Text = "";
            txb_Telefono.Text = "";
            txb_CorreoElectronico.Text = "";

            id = 0;
            ckb_Activar.Visible = false;

            errorProvider1.Clear();

            CargarGridProveedor();
        }
        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio(string M)
        {
            if (txb_Cedula.Text == "")
            {
                errorProvider1.SetError(txb_Cedula, "Ingresar la cédula");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Codigo.Text == "")
            {
                errorProvider1.SetError(txb_Codigo, "Ingresar el código");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Nombre.Text == "")
            {
                errorProvider1.SetError(txb_Nombre, "Ingresar el nobre o la razón social");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (dtp_FechaIngreso.Value == null)
            {
                errorProvider1.SetError(dtp_FechaIngreso, "Ingresar la fecha de ingreso");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Saldo.Text == "")
            {
                errorProvider1.SetError(txb_Saldo, "Ingresar el saldo");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_CuentaBanco.Text == "")
            {
                errorProvider1.SetError(txb_CuentaBanco, "Ingresar la cuenta de banco");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Banco.Text == "")
            {
                errorProvider1.SetError(txb_Banco, "Ingresar el nombre del banco");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_DiasDePago.Text == "")
            {
                errorProvider1.SetError(txb_DiasDePago, "Ingresar los días de pago");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Telefono.Text == "")
            {
                errorProvider1.SetError(txb_Telefono, "Ingresar el teléfono");
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
            if (CampoVacio("M") == 0)
            {
                using (GestorProveedor Gestor = new GestorProveedor())
                {
                    Gestor.Insertar(txb_Codigo.Text, txb_Cedula.Text, txb_Nombre.Text, DateTime.Parse(dtp_FechaIngreso.Text), double.Parse(txb_Saldo.Text), txb_CuentaBanco.Text, txb_Banco.Text, txb_DiasDePago.Text, txb_Telefono.Text, txb_CorreoElectronico.Text, "A");
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
                using (GestorProveedor Gestor = new GestorProveedor())
                {
                    if (ckb_Activar.Checked == true)
                    {
                        Gestor.Modificar(id, txb_Codigo.Text, txb_Cedula.Text, txb_Nombre.Text, DateTime.Parse(dtp_FechaIngreso.Text), double.Parse(txb_Saldo.Text), txb_CuentaBanco.Text, txb_Banco.Text, txb_DiasDePago.Text, txb_Telefono.Text, txb_CorreoElectronico.Text, "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, txb_Codigo.Text, txb_Cedula.Text, txb_Nombre.Text, DateTime.Parse(dtp_FechaIngreso.Text), double.Parse(txb_Saldo.Text), txb_CuentaBanco.Text, txb_Banco.Text, txb_DiasDePago.Text, txb_Telefono.Text, txb_CorreoElectronico.Text, "I");
                    }
                }
                Limpiar();
            }
        }
        
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorProveedor Gestor = new GestorProveedor())
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
        private void dgv_Proveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgv_Proveedor.CurrentCell.RowIndex;
                id = int.Parse(this.dgv_Proveedor[0, numFila].Value.ToString());

                using (GestorProveedor Gestor = new GestorProveedor())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                txb_Cedula.Text = dtable.Rows[0]["Proveedor_Cedula"].ToString();
                txb_Codigo.Text = dtable.Rows[0]["Proveedor_Codigo"].ToString();
                txb_Nombre.Text = dtable.Rows[0]["Proveedor_NombreORazonSocial"].ToString();
                dtp_FechaIngreso.Text = dtable.Rows[0]["Proveedor_FechaIngreso"].ToString();
                txb_Saldo.Text = dtable.Rows[0]["Proveedor_Saldo"].ToString();
                txb_CuentaBanco.Text = dtable.Rows[0]["Proveedor_CuentaDelBanco"].ToString();
                txb_Banco.Text = dtable.Rows[0]["Proveedor_Banco"].ToString();
                txb_DiasDePago.Text = dtable.Rows[0]["Proveedor_DiasDePago"].ToString();
                txb_Telefono.Text = dtable.Rows[0]["Proveedor_Telefono"].ToString();
                txb_CorreoElectronico.Text = dtable.Rows[0]["Proveedor_CorreoElectronico"].ToString();

                if (dtable.Rows[0]["Proveedor_Estado"].ToString() == "A")
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

        #region Eventos TextBox
        private void txb_Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion Eventos TextBox

        
    }
}


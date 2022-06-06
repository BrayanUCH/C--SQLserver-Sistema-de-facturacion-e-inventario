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

namespace CapaPresentacion.Modulos_Registros
{
    public partial class frmRegistroCustasXPagar : Form
    {
        int id = 0;
        public frmRegistroCustasXPagar()
        {
            InitializeComponent();

            CargarComboProveedor();
            CargarGridCuentasXPagar();
            ckb_Activar.Visible = false;
        }

        #region Métodos Cargar ComboBox
        private void CargarComboProveedor()
        {
            using (GestorProveedor servicio = new GestorProveedor())
            {
                cbx_ProveedorID.DataSource = servicio.ListarA();

                cbx_ProveedorID.ValueMember = "Proveedor_id";
                cbx_ProveedorID.DisplayMember = "Proveedor_NombreORazonSocial";
                cbx_ProveedorID.SelectedItem = null;
            }
        }
        #endregion Métodos Cargar ComboBox

        #region Métodos Cargar DataGrid
        private void CargarGridCuentasXPagar()
        {
            using (GestorCuentasPorPagar servicio = new GestorCuentasPorPagar())
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


                dgv.Columns["CuentasXPagar_id"].HeaderText = "ID";
                dgv.Columns["CuentasXPagar_ProveedorID"].HeaderText = "ProveedorID";
                dgv.Columns["CuentasXPagar_Descripcion"].HeaderText = "Descripcion";
                dgv.Columns["CuentasXPagar_FechaPago"].HeaderText = "Fecha De Pago";
                dgv.Columns["CuentasXPagar_Monto"].HeaderText = "Monto";
                dgv.Columns["CuentasXPagar_Estado"].Visible = false;
            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar
        private void Limpiar()
        {
            cbx_ProveedorID.SelectedItem = null;
            txb_Descripcion.Text = "";
            txb_FechaPago.Text = "";
            txb_Monto.Text = "";

            id = 0;
            ckb_Activar.Visible = false;

            errorProvider1.Clear();

            CargarComboProveedor();
            CargarGridCuentasXPagar();
        }
        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio()
        {
            if (cbx_ProveedorID.SelectedValue == null)
            {
                errorProvider1.SetError(cbx_ProveedorID, "Ingresar el proveedor");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Descripcion.Text == "")
            {
                errorProvider1.SetError(txb_Descripcion, "Ingresar una descripción");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_FechaPago.Text == "")
            {
                errorProvider1.SetError(txb_FechaPago, "Ingresar la fecha de pago");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Monto.Text == "")
            {
                errorProvider1.SetError(txb_Monto, "Ingresar el monto");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
                return 0;
            }
        }
        #endregion Métodos Campos Vacios

        #region Eventos Botones
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0 && id != 0)
            {
                using (GestorCuentasPorPagar Gestor = new GestorCuentasPorPagar())
                {
                    if (ckb_Activar.Checked == true)
                    {
                        Gestor.Modificar(id, Convert.ToInt32(cbx_ProveedorID.SelectedValue), txb_Descripcion.Text, txb_FechaPago.Text, double.Parse(txb_Monto.Text), "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, Convert.ToInt32(cbx_ProveedorID.SelectedValue), txb_Descripcion.Text, txb_FechaPago.Text, double.Parse(txb_Monto.Text), "I");
                    }
                }
                Limpiar();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0)
            {
                using (GestorCuentasPorPagar Gestor = new GestorCuentasPorPagar())
                {
                    Gestor.Insertar(Convert.ToInt32(cbx_ProveedorID.SelectedValue), txb_Descripcion.Text, txb_FechaPago.Text, double.Parse(txb_Monto.Text), "A");
                }
                Limpiar();
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorCuentasPorPagar Gestor = new GestorCuentasPorPagar())
                {
                    Gestor.Eliminar(id);
                }
                Limpiar();
            }
        }
        #endregion Eventos Eventos Botones

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
                int numFila = dgv.CurrentCell.RowIndex;
                id = int.Parse(this.dgv[0, numFila].Value.ToString());

                using (GestorCuentasPorPagar Gestor = new GestorCuentasPorPagar())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }
                cbx_ProveedorID.SelectedValue = dtable.Rows[0]["CuentasXPagar_ProveedorID"].ToString();
                txb_Descripcion.Text = dtable.Rows[0]["CuentasXPagar_Descripcion"].ToString();
                txb_FechaPago.Text = dtable.Rows[0]["CuentasXPagar_FechaPago"].ToString();
                txb_Monto.Text = dtable.Rows[0]["CuentasXPagar_Monto"].ToString();

                if (dtable.Rows[0]["CuentasXPagar_Estado"].ToString() == "A")
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

        private void txb_Monto_KeyPress(object sender, KeyPressEventArgs e)
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

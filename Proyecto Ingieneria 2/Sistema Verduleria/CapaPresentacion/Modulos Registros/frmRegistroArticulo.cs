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
    public partial class frmRegistroArticulo : Form
    {
        int id = 0;
        public frmRegistroArticulo()
        {
            InitializeComponent();

            CargarComboFamilia();
            CargarComboUnidadesMedida();
            CargarGridArticulos();
            chbActivo.Visible = false;
        }

        #region Métodos Cargar ComboBox
        private void CargarComboFamilia()
        {
            using (GestorFamiliaProductos servicio = new GestorFamiliaProductos())
            {
                cbxArticulo_FamiliaID.DataSource = servicio.ListarA();

                cbxArticulo_FamiliaID.ValueMember = "Familia_id";
                cbxArticulo_FamiliaID.DisplayMember = "Familia_tipo";
                cbxArticulo_FamiliaID.SelectedItem = null;
            }
        }

        private void CargarComboUnidadesMedida()
        {
            using (GestorUnidadesMedida servicio = new GestorUnidadesMedida())
            {
                cbxArticulo_UnidadesMedidaID.DataSource = servicio.ListarA();

                cbxArticulo_UnidadesMedidaID.ValueMember = "UnidadesMedida_Abreviatura";
                cbxArticulo_UnidadesMedidaID.DisplayMember = "UnidadesMedida_Abreviatura";
                cbxArticulo_UnidadesMedidaID.SelectedItem = null;
            }
        }
        #endregion Métodos Cargar ComboBox

        #region Métodos Cargar DataGrid
        private void CargarGridArticulos()
        {
            using (GestorArticulo servicio = new GestorArticulo())
            {
                if (chbListarI.Checked == true)
                {
                    dgvArticulos.DataSource = servicio.ListarI();
                    btnArticulo_Insertar.Visible = false;
                }
                else
                {
                    dgvArticulos.DataSource = servicio.ListarA();
                    btnArticulo_Insertar.Visible = true;
                }

                dgvArticulos.Columns["Articulos_id"].HeaderText = "ID";
                dgvArticulos.Columns["Articulos_FamiliaID"].HeaderText = "Familia de productos";
                dgvArticulos.Columns["Articulos_UnidadesMedidaID"].HeaderText = "Unidad de medida";
                dgvArticulos.Columns["Articulos_Nombre"].HeaderText = "Producto";
                dgvArticulos.Columns["Articulos_Codigo"].HeaderText = "Codigo";
                dgvArticulos.Columns["Articulos_Descripcion"].HeaderText = "Descripción";
                dgvArticulos.Columns["Articulos_Precio"].HeaderText = "Precio";
                dgvArticulos.Columns["Articulos_CantidadUnidadesMedida"].HeaderText = "Peso";
                dgvArticulos.Columns["Articulos_Descuento"].HeaderText = "Descuento";
                dgvArticulos.Columns["Articulos_Impuesto"].HeaderText = "Impuesto";
                dgvArticulos.Columns["Articulos_Estado"].Visible = false;
            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar 
        private void Limpiar()
        {
            txbArticulo_Codigo.Text = "";
            txbArticulo_Descripcion.Text = "";
            txbArticulo_Producto.Text = "";
            cbxArticulo_FamiliaID.SelectedItem = null;
            cbxArticulo_UnidadesMedidaID.SelectedItem = null;
            txbArticulo_Peso.Text = "";
            txbArticulo_Precio.Text = "";
            txbArticulo_Descuentos.Text = "";
            txbArticulo_Impuesto.Text = "";

            id = 0;
            chbActivo.Visible = false;

            errorProvider1.Clear();

            CargarComboFamilia();
            CargarComboUnidadesMedida();
            CargarGridArticulos();
        }
        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio()
        {
            if (cbxArticulo_FamiliaID.SelectedValue == null)
            {
                errorProvider1.SetError(cbxArticulo_FamiliaID, "Ingresar una familia");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cbxArticulo_UnidadesMedidaID.SelectedValue == null)
            {
                errorProvider1.SetError(cbxArticulo_UnidadesMedidaID, "Ingresar una unidad de medida");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Producto.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Producto, "Ingresar nombre del producto");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Codigo.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Codigo, "Ingresar el código");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Descripcion.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Descripcion, "Ingresar una descripción");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Precio.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Precio, "Ingresar el precio");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Peso.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Peso, "Ingresar el peso");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Descuentos.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Descuentos, "Ingresar el descuento");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txbArticulo_Impuesto.Text == "")
            {
                errorProvider1.SetError(txbArticulo_Impuesto, "Ingresar el impuesto");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }






            return 0;
        }
        #endregion Métodos Campos Vacios

        #region Eventos Botones
        private void btnArticulo_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0)
            {
                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    Gestor.Insertar(txbArticulo_Codigo.Text, txbArticulo_Descripcion.Text, txbArticulo_Producto.Text, cbxArticulo_FamiliaID.SelectedValue.ToString(), cbxArticulo_UnidadesMedidaID.SelectedValue.ToString(), double.Parse(txbArticulo_Peso.Text), double.Parse(txbArticulo_Precio.Text), double.Parse(txbArticulo_Descuentos.Text), double.Parse(txbArticulo_Impuesto.Text), "A");
                }
                Limpiar();
            }
        }
        private void btnArticulo_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgvArticulos.CurrentCell.RowIndex;
                id = int.Parse(this.dgvArticulos[0, numFila].Value.ToString());

                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                txbArticulo_Codigo.Text = dtable.Rows[0]["Articulos_Codigo"].ToString();
                txbArticulo_Descripcion.Text = dtable.Rows[0]["Articulos_Descripcion"].ToString();
                txbArticulo_Producto.Text = dtable.Rows[0]["Articulos_Nombre"].ToString();
                cbxArticulo_FamiliaID.SelectedValue = dtable.Rows[0]["Articulos_FamiliaID"].ToString();
                cbxArticulo_UnidadesMedidaID.SelectedValue = dtable.Rows[0]["Articulos_UnidadesMedidaID"].ToString();
                txbArticulo_Peso.Text = dtable.Rows[0]["Articulos_CantidadUnidadesMedida"].ToString();
                txbArticulo_Precio.Text = dtable.Rows[0]["Articulos_Precio"].ToString();
                txbArticulo_Descuentos.Text = dtable.Rows[0]["Articulos_Descuento"].ToString();
                txbArticulo_Impuesto.Text = dtable.Rows[0]["Articulos_Impuesto"].ToString();

                if (dtable.Rows[0]["Articulos_Estado"].ToString() == "A")
                {
                    chbActivo.Visible = true;
                    chbActivo.Checked = true;
                }
                else
                {
                    chbActivo.Visible = true;
                    chbActivo.Checked = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnArticulo_Modificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0 && id != 0)
            {
                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    if (chbActivo.Checked == true)
                    {
                        Gestor.Modificar(id, txbArticulo_Codigo.Text, txbArticulo_Descripcion.Text, txbArticulo_Producto.Text, cbxArticulo_FamiliaID.SelectedValue.ToString(), cbxArticulo_UnidadesMedidaID.SelectedValue.ToString(), double.Parse(txbArticulo_Peso.Text), double.Parse(txbArticulo_Precio.Text), double.Parse(txbArticulo_Descuentos.Text), double.Parse(txbArticulo_Impuesto.Text), "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, txbArticulo_Codigo.Text, txbArticulo_Descripcion.Text, txbArticulo_Producto.Text, cbxArticulo_FamiliaID.SelectedValue.ToString(), cbxArticulo_UnidadesMedidaID.SelectedValue.ToString(), double.Parse(txbArticulo_Peso.Text), double.Parse(txbArticulo_Precio.Text), double.Parse(txbArticulo_Descuentos.Text), double.Parse(txbArticulo_Impuesto.Text), "I");
                    }
                }
                Limpiar();
            }
        }
        private void BtnArticulo_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    Gestor.Eliminar(id);
                }
                Limpiar();
            }
        }
        #endregion Eventos Botones

        #region Eventos CheckBox
        private void chbListarI_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion Eventos CheckBox

        #region Eventos TextBoxs

        private void txbArticulo_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }

        private void txbArticulo_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }

        private void txbArticulo_Descuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }

        private void txbArticulo_Impuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }


        #endregion Eventos TextBoxs


    }
}

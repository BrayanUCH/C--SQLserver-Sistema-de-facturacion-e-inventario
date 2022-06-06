using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVerduleria.CapaIntegracion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Modulos_Registros
{
    public partial class frmRegistroInventarioLocal : Form
    {
        public frmRegistroInventarioLocal()
        {
            InitializeComponent();
            CargarComboArticulo();
            CargarGridInventario();
            CargarGridProductos();
            chbActivo.Visible = false;
        }

        int id = 0;

        #region Métodos Cargar ComboBox
        private void CargarComboArticulo()
        {
            using (GestorArticulo servicio = new GestorArticulo())

                cbxInventario_ArticuloID.DataSource = servicio.ListarFiltradoP("");

            cbxInventario_ArticuloID.ValueMember = "Articulos_id";
            cbxInventario_ArticuloID.DisplayMember = "Articulos_Nombre";
            cbxInventario_ArticuloID.SelectedItem = null;
        }
        #endregion Métodos Cargar ComboBox

        #region Métodos Cargar DataGrid
        private void CargarGridInventario()
        {
            using (GestorInventario servicio = new GestorInventario())
            {
                DataTable dtable = new DataTable();
                DataTable tablenew = new DataTable();

                if (chbListarI.Checked == true)
                {
                    dtable = servicio.ListarIL();
                    btnInventario_Insertar.Visible = false;
                }
                else
                {
                    dtable = servicio.ListarAL();
                    btnInventario_Insertar.Visible = true;
                }

                tablenew.Columns.Add("ID Inventario");
                tablenew.Columns.Add("ID");
                tablenew.Columns.Add("Producto");
                tablenew.Columns.Add("Codigo");
                tablenew.Columns.Add("Cantidad");
                tablenew.Columns.Add("Descripción");

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    #region articulo
                    DataSet set = new DataSet();
                    DataTable table = new DataTable();
                    int ID = int.Parse(dtable.Rows[i]["Inventario_ArticuloID"].ToString());

                    using (GestorArticulo Gestor = new GestorArticulo())
                    {
                        set = Gestor.Consultar(ID);
                        table = set.Tables[0];
                    }
                    #endregion
                    object[] o = {
                         dtable.Rows[i]["Inventario_id"].ToString(),
                        dtable.Rows[i]["Inventario_ArticuloID"].ToString(),
                        table.Rows[0]["Articulos_Nombre"].ToString(),
                        table.Rows[0]["Articulos_Codigo"].ToString(),
                        dtable.Rows[i]["Inventario_Cantidad"].ToString(),
                        table.Rows[0]["Articulos_Descripcion"].ToString()
                    };

                    tablenew.Rows.Add(o);
                }
                dgvInventarioLocal.DataSource = tablenew;
                dgvInventarioLocal.Columns["ID"].Width = 35;
                //dgvInventarioLocal.Columns["ID Inventario"].Visible = false;
            }
        }

        private void CargarGridProductos()
        {
            using (GestorArticulo servicio = new GestorArticulo())
            {
                dgv_Productos.DataSource = null;
                if (txb_filtradoProducto.Text != "")
                {
                    dgv_Productos.DataSource = servicio.ListarFiltradoP(txb_filtradoProducto.Text);
                }
                else
                {
                    dgv_Productos.DataSource = servicio.ListarFiltradoP("");
                }

                dgv_Productos.Columns["Articulos_id"].HeaderText = "ID";
                dgv_Productos.Columns["Articulos_FamiliaID"].Visible = false;
                dgv_Productos.Columns["Articulos_UnidadesMedidaID"].Visible = false;
                dgv_Productos.Columns["Articulos_Nombre"].HeaderText = "Producto";
                dgv_Productos.Columns["Articulos_Codigo"].HeaderText = "Codigo";
                dgv_Productos.Columns["Articulos_Descripcion"].Visible = false;
                dgv_Productos.Columns["Articulos_Precio"].Visible = false;
                dgv_Productos.Columns["Articulos_CantidadUnidadesMedida"].Visible = false;
                dgv_Productos.Columns["Articulos_Descuento"].Visible = false;
                dgv_Productos.Columns["Articulos_Impuesto"].Visible = false;
                dgv_Productos.Columns["Articulos_Estado"].Visible = false;
                dgv_Productos.Columns[0].Width = 35;
                dgv_Productos.Columns[1].Width = 50;
            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar
        private void Limpiar()
        {
            cbxInventario_ArticuloID.Enabled = true;

            cbxInventario_ArticuloID.SelectedItem = null;
            txbInventario_Cantidad.Text = "";

            txb_filtradoProducto.Text = "";
            id = 0;
            chbActivo.Visible = false;
            errorProvider1.Clear();

            CargarComboArticulo();
            CargarGridInventario();
            CargarGridProductos();
        }
        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio()
        {
            if (txbInventario_Cantidad.Text == "")
            {
                errorProvider1.SetError(txbInventario_Cantidad, "Ingresar la cantidad");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cbxInventario_ArticuloID.SelectedValue == null)
            {
                errorProvider1.SetError(cbxInventario_ArticuloID, "Ingresar el artículo");
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
        private void btnInventario_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0)
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();

                using (GestorInventario Gestor = new GestorInventario())
                {
                    dset = Gestor.ConsultarExistenciaL(Convert.ToInt32(cbxInventario_ArticuloID.SelectedValue));
                    dtable = dset.Tables[0];

                }
                if (dtable.Rows.Count == 0)
                {
                    using (GestorInventario Gestor = new GestorInventario())
                    {
                        Gestor.Insertar(Convert.ToInt32(cbxInventario_ArticuloID.SelectedValue), double.Parse(txbInventario_Cantidad.Text), "L", "A");
                    }
                }
                else
                {
                    using (GestorInventario Gestor = new GestorInventario())
                    {
                        Gestor.Modificar(int.Parse(dtable.Rows[0]["Inventario_id"].ToString()), Convert.ToInt32(cbxInventario_ArticuloID.SelectedValue), (double.Parse(dtable.Rows[0]["Inventario_Cantidad"].ToString()) + double.Parse(txbInventario_Cantidad.Text)), "L", "A");
                    }
                }
                Limpiar();
            }
        }

        private void btnInventario_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnInventario_Modificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0 && id != 0)
            {
                using (GestorInventario Gestor = new GestorInventario())
                {
                    if (chbActivo.Checked == true)
                    {
                        Gestor.Modificar(id, Convert.ToInt32(cbxInventario_ArticuloID.SelectedValue), double.Parse(txbInventario_Cantidad.Text), "L", "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, Convert.ToInt32(cbxInventario_ArticuloID.SelectedValue), double.Parse(txbInventario_Cantidad.Text), "L", "I");
                    }
                }
                Limpiar();
            }
        }
        
        private void btnInventario_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorInventario Gestor = new GestorInventario())
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

        #region Eventos DataGrid
        private void dgvInventarioLocal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgvInventarioLocal.CurrentCell.RowIndex;
                id = int.Parse(this.dgvInventarioLocal[0, numFila].Value.ToString());

                using (GestorInventario Gestor = new GestorInventario())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                cbxInventario_ArticuloID.SelectedValue = int.Parse(dtable.Rows[0]["Inventario_ArticuloID"].ToString());
                txbInventario_Cantidad.Text = dtable.Rows[0]["Inventario_Cantidad"].ToString();

                if (dtable.Rows[0]["Inventario_Estado"].ToString() == "A")
                {
                    chbActivo.Visible = true;
                    chbActivo.Checked = true;
                }
                else
                {
                    chbActivo.Visible = true;
                    chbActivo.Checked = false;
                }
                cbxInventario_ArticuloID.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgv_Productos.CurrentCell.RowIndex;
                id = int.Parse(this.dgv_Productos[0, numFila].Value.ToString());

                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                //txbArticulo_Codigo.Text = dtable.Rows[0]["Articulos_Codigo"].ToString();
                cbxInventario_ArticuloID.SelectedValue = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion Eventos DataGrid

        #region Eventos TextBox
        private void txbInventario_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }
        private void txb_filtradoProducto_TextChanged(object sender, EventArgs e)
        {
            CargarGridProductos();
        }





        #endregion Eventos TextBox


    }
}

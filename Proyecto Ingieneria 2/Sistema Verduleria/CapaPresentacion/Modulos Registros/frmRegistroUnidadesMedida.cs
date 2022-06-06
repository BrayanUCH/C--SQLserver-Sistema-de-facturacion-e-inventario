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
    public partial class frmRegistroUnidadesMedida : Form
    {
        int id = 0;
        public frmRegistroUnidadesMedida()
        {
            InitializeComponent();

            CargarGridUnidadesMedida();
            ckb_Activar.Visible = false;
        }

        #region Métodos Cargar DataGrid
        private void CargarGridUnidadesMedida()
        {
            using (GestorUnidadesMedida servicio = new GestorUnidadesMedida())
            {
                if (ckb_ListarInactivos.Checked == true)
                {
                    dgv_UnidadesMedida.DataSource = servicio.ListarI();
                    btnUnidadesMedida_Insertar.Visible = false;
                }
                else
                {
                    dgv_UnidadesMedida.DataSource = servicio.ListarA();
                    btnUnidadesMedida_Insertar.Visible = true;
                }

                dgv_UnidadesMedida.Columns["UnidadesMedida_id"].HeaderText = "ID";
                dgv_UnidadesMedida.Columns["UnidadesMedida_Descripcion"].HeaderText = "Descripción";
                dgv_UnidadesMedida.Columns["UnidadesMedida_Abreviatura"].HeaderText = "Unidad de medida";
                dgv_UnidadesMedida.Columns["UnidadesMedida_Estado"].Visible = false;
            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar
        private void Limpiar()
        {
            txb_Descripcion.Text = "";
            txb_Abreviatura.Text = "";

            id = 0;
            ckb_Activar.Visible = false;

            errorProvider1.Clear();

            CargarGridUnidadesMedida();
        }
        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio()
        {
            if (txb_Descripcion.Text == "")
            {
                errorProvider1.SetError(txb_Descripcion, "Ingresar una descripción");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Abreviatura.Text == "")
            {
                errorProvider1.SetError(txb_Abreviatura, "Ingresar la abreviatura");
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
        private void btnUnidadesMedida_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0)
            {
                using (GestorUnidadesMedida Gestor = new GestorUnidadesMedida())
                {
                    Gestor.Insertar(txb_Descripcion.Text, txb_Abreviatura.Text, "A");
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
            if (CampoVacio() == 0 && id != 0)
            {
                using (GestorUnidadesMedida Gestor = new GestorUnidadesMedida())
                {
                    if (ckb_Activar.Checked == true)
                    {
                        Gestor.Modificar(id, txb_Descripcion.Text, txb_Abreviatura.Text, "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, txb_Descripcion.Text, txb_Abreviatura.Text, "I");
                    }
                }
                Limpiar();
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorUnidadesMedida Gestor = new GestorUnidadesMedida())
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
                int numFila = dgv_UnidadesMedida.CurrentCell.RowIndex;
                id = int.Parse(this.dgv_UnidadesMedida[0, numFila].Value.ToString());

                using (GestorUnidadesMedida Gestor = new GestorUnidadesMedida())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }

                txb_Descripcion.Text = dtable.Rows[0]["UnidadesMedida_Descripcion"].ToString();
                txb_Abreviatura.Text = dtable.Rows[0]["UnidadesMedida_Abreviatura"].ToString();

                if (dtable.Rows[0]["UnidadesMedida_Estado"].ToString() == "A")
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

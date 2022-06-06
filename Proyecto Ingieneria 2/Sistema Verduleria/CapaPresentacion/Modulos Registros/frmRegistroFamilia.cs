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
    public partial class frmRegistroFamilia : Form
    {
        public frmRegistroFamilia()
        {
            InitializeComponent();
            CargarGridFamilia();
            ckb_Activar.Visible = false;
        }
        int id = 0;

        #region Métodos Cargar DataGrid
        private void CargarGridFamilia()
        {
            using (GestorFamiliaProductos servicio = new GestorFamiliaProductos())
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

                dgv.Columns["Familia_id"].HeaderText = "ID";
                dgv.Columns["Familia_Codigo"].HeaderText = "Codigo";
                dgv.Columns["Familia_tipo"].HeaderText = "Tipo";
                dgv.Columns["Familia_descripcion"].HeaderText = "Descripción";
                dgv.Columns["Familia_estado"].Visible = false;
            }
        }
        #endregion Métodos Cargar DataGrid

        #region Métodos Limpiar 
        private void Limpiar()
        {
            txb_Codigo.Text = "";
            txb_Tipo.Text = "";
            txb_Descripcion.Text = "";

            id = 0;
            ckb_Activar.Visible = false;

            errorProvider1.Clear();

            CargarGridFamilia();
        }
        #endregion Métodos Limpiar

        #region Métodos Campos Vacios
        private int CampoVacio()
        {
            if (txb_Codigo.Text == "")
            {
                errorProvider1.SetError(txb_Codigo, "Ingresar el código");
                return 1;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txb_Tipo.Text == "")
            {
                errorProvider1.SetError(txb_Tipo, "Ingresar el tipo de familia");
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
                return 0;
            }
        }
        #endregion Métodos Campos Vacios

        #region Eventos Botones
        private void btnFamilia_Insertar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0)
            {
                using (GestorFamiliaProductos Gestor = new GestorFamiliaProductos())
                {
                    Gestor.Insertar(txb_Codigo.Text, txb_Tipo.Text, txb_Descripcion.Text, "A");
                }
                Limpiar();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio() == 0 && id != 0)
            {
                using (GestorFamiliaProductos Gestor = new GestorFamiliaProductos())
                {
                    if (ckb_Activar.Checked == true)
                    {
                        Gestor.Modificar(id, txb_Codigo.Text, txb_Tipo.Text, txb_Descripcion.Text, "A");
                    }
                    else
                    {
                        Gestor.Modificar(id, txb_Codigo.Text, txb_Tipo.Text, txb_Descripcion.Text, "I");
                    }
                    Limpiar();
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (GestorFamiliaProductos Gestor = new GestorFamiliaProductos())
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
                int numFila = dgv.CurrentCell.RowIndex;
                id = int.Parse(this.dgv[0, numFila].Value.ToString());

                using (GestorFamiliaProductos Gestor = new GestorFamiliaProductos())
                {
                    dset = Gestor.Consultar(id);
                    dtable = dset.Tables[0];

                }
                txb_Codigo.Text = dtable.Rows[0]["Familia_Codigo"].ToString();
                txb_Tipo.Text = dtable.Rows[0]["Familia_tipo"].ToString();
                txb_Descripcion.Text = dtable.Rows[0]["Familia_descripcion"].ToString();


                if (dtable.Rows[0]["Familia_estado"].ToString() == "A")
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

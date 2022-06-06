using CapaPresentacion.Modulos_Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modulos
{
    public partial class frmMantenimiento : Form
    {
        private Form currentChildForm;

        public frmMantenimiento()
        {
            InitializeComponent();
            OpenChildForm(new frmRegistroArticulo());
        }

        #region Métodos
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Mantenimiento.Controls.Add(childForm);
            panel_Mantenimiento.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion Métodos

        #region Eventos botones
        private void registroArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroArticulo());
        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroCliente());
        }
        private void registroFamilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroFamilia());
        }
        private void registroProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroProveedor());
        }
        private void registroUnidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroUnidadesMedida());
        }
        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroUsuarios());
        }
        private void mantenimientoDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroFactura());
        }
        #endregion

        
    }
}

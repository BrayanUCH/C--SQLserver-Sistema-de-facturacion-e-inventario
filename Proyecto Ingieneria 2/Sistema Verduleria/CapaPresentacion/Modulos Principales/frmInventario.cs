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
    public partial class frmInventario : Form
    {
        private Form currentChildForm;

        public frmInventario()
        {
            InitializeComponent();
            OpenChildForm(new frmRegistroInventarioLocal());
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
            panel_inventario.Controls.Add(childForm);
            panel_inventario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion Métodos

        #region Eventos    

        private void inventarioDelLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroInventarioLocal());
        }

        private void inventarioDeLaBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistroInventarioBodega());
        }
        #endregion Eventos
    }
}

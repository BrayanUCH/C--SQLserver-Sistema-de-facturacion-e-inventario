using CapaPresentacion.Modulos;
using CapaPresentacion.Modulos_Principales;
using CapaPresentacion.Modulos_Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new frmLOGIN());
            Application.Run(new frmPrincipal());
            //Application.Run(new frmFacturación());
            //Application.Run(new frmInventario());
            //Application.Run(new frmAgregarCliente());
            //Application.Run(new frmReportes());
            //Application.Run(new frmRegistroFactura());
            //Application.Run(new frmRegistroArticulo());
            //Application.Run(new frmRegistroBodega());
            //Application.Run(new frmRegistroCliente());
            //Application.Run(new frmRegistroFamilia());
            //Application.Run(new frmRegistroUsuarios());
            //Application.Run(new frmRegistroProveedor());
            //Application.Run(new frmRegistroCustasXPagar());
            //Application.Run(new frmRegistroUnidadesMedida());
            //Application.Run(new frmRegistroInventarioBodega());
            //Application.Run(new frmRegistroInventarioLocal());
            //Application.Run(new frmOlvidarContraseña());
        }
    }
}

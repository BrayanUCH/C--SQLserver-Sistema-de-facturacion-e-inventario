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
    public partial class frmRegistroFactura : Form
    {
        public frmRegistroFactura()
        {
            InitializeComponent();
            CargarGridFaturas();
        }

        private void CargarGridFaturas()
        {
            using (GestorFacturacion servicio = new GestorFacturacion())
            {
                DataTable dtable = new DataTable();

                if (ckb_fecha.Checked == true && txb_filtradoFecha.Text != "")
                {
                    dtable = servicio.ListarFiltradoFecha(txb_filtradoFecha.Text);
                }
                else if (ckb_numeroFactura.Checked == true && txb_filtradoFactura.Text != "")
                {
                    dtable = servicio.ListarFiltradoId(int.Parse(txb_filtradoFactura.Text));
                }
                else
                {
                    dtable = servicio.ListarA();
                }

                DataTable Factura = new DataTable();
                Factura.Columns.Add("Numero de factura", typeof(int));
                Factura.Columns.Add("Cliente", typeof(string));
                Factura.Columns.Add("Cedula del cliente", typeof(string));
                Factura.Columns.Add("Fecha", typeof(string));
                Factura.Columns.Add("Observaciones", typeof(string));
                Factura.Columns.Add("Numero de articulos", typeof(int));
                Factura.Columns.Add("SubTotal", typeof(double));
                Factura.Columns.Add("Impuesto", typeof(double));
                Factura.Columns.Add("Decuento", typeof(double));
                Factura.Columns.Add("Total", typeof(double));

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow rowFactura = Factura.NewRow();
                    rowFactura["Numero de factura"] = int.Parse(dtable.Rows[i]["Facturacion_id"].ToString());

                    DataSet dsetcliente = new DataSet();
                    DataTable dtablecliente = new DataTable();
                    if (int.Parse(dtable.Rows[i]["Facturacion_ClienteID"].ToString()) != 0)
                    {
                        using (GestorCliente Gestor = new GestorCliente())
                        {
                            dsetcliente = Gestor.Consultar(int.Parse(dtable.Rows[i]["Facturacion_ClienteID"].ToString()));
                            dtablecliente = dsetcliente.Tables[0];
                        }
                        rowFactura["Cliente"] = dtablecliente.Rows[0]["Cliente_nombre"].ToString();
                        rowFactura["Cedula del cliente"] = dtablecliente.Rows[0]["Cliente_Cedula"].ToString();
                    }
                    else
                    {
                        rowFactura["Cliente"] = "No indica";
                        rowFactura["Cedula del cliente"] = "No indica";
                    }
                    rowFactura["Fecha"] = dtable.Rows[i]["Facturacion_Fecha"].ToString();
                    rowFactura["Observaciones"] = dtable.Rows[i]["Facturacion_Observaciones"].ToString();
                    rowFactura["Numero de articulos"] = int.Parse(dtable.Rows[i]["Facturacion_NumeroArticulos"].ToString());
                    rowFactura["SubTotal"] = double.Parse(dtable.Rows[i]["Facturacion_SubTotal"].ToString());
                    rowFactura["Impuesto"] = double.Parse(dtable.Rows[i]["Facturacion_Impuesto"].ToString());
                    rowFactura["Decuento"] = double.Parse(dtable.Rows[i]["Facturacion_Descuento"].ToString());
                    rowFactura["Total"] = double.Parse(dtable.Rows[i]["Facturacion_Total"].ToString());

                    Factura.Rows.Add(rowFactura);
                }
                dgv_facturas.DataSource = Factura;
            }
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dgv_detalleFactura.DataSource = null;
            txb_filtradoFactura.Text = "";
            txb_filtradoFecha.Text = "";
            ckb_fecha.Checked = false;
            ckb_numeroFactura.Checked = false;
            CargarGridFaturas();
        }

        private void dgv_facturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ID = 0;
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgv_facturas.CurrentCell.RowIndex;
                ID = int.Parse(this.dgv_facturas[0, numFila].Value.ToString());

                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    dset = Gestor.Consultar(ID);
                    dtable = dset.Tables[0];
                }

                DataTable Detalle = new DataTable();

                Detalle.Columns.Add("ID", typeof(string));
                Detalle.Columns.Add("Producto", typeof(string));
                Detalle.Columns.Add("Cantidad", typeof(string));
                Detalle.Columns.Add("Descuento", typeof(string));
                Detalle.Columns.Add("Impuesto", typeof(string));
                Detalle.Columns.Add("Precio", typeof(string));

                DataTable dTableDetalle = new DataTable();

                using (GestorDetalleFactura service = new GestorDetalleFactura())
                {
                    dTableDetalle = service.ListarIdFactura(ID);
                }

                foreach (DataRow rowDetalle in dTableDetalle.Rows)
                {
                    DataSet dsU = new DataSet();
                    DataTable dtU = new DataTable();
                    using (GestorArticulo service = new GestorArticulo())
                    {
                        dsU = service.Consultar(int.Parse(rowDetalle["DetalleFactura_ArticulosID"].ToString()));
                        dtU = dsU.Tables[0];
                    }

                    DataRow row = Detalle.NewRow();
                    row["ID"] = rowDetalle["DetalleFactura_ArticulosID"].ToString();
                    row["Producto"] = dtU.Rows[0]["Articulos_Nombre"].ToString(); ;
                    row["Cantidad"] = rowDetalle["DetalleFactura_Cantidad"].ToString();
                    row["Descuento"] = rowDetalle["DetalleFactura_Descuento"].ToString();
                    row["Impuesto"] = rowDetalle["DetalleFactura_Impuesto"].ToString();
                    row["Precio"] = rowDetalle["DetalleFactura_Precio"].ToString();

                    Detalle.Rows.Add(row);
                }
                dgv_detalleFactura.DataSource = Detalle;
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ckb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_fecha.Checked == true)
            {
                ckb_numeroFactura.Checked = false;
            }
            CargarGridFaturas();
        }

        private void ckb_numeroFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_numeroFactura.Checked == true)
            {
                ckb_fecha.Checked = false;
            }
            CargarGridFaturas();
        }

        private void txb_filtradoFecha_TextChanged(object sender, EventArgs e)
        {
            CargarGridFaturas();
        }

        private void txb_filtradoFactura_TextChanged(object sender, EventArgs e)
        {
            CargarGridFaturas();
        }

        private void txb_filtradoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

    }
}
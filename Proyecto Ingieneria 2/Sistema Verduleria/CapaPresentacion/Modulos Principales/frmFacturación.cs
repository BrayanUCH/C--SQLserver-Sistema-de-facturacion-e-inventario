using CapaPresentacion.Modulos_Registros;
using SistemaVerduleria.CapaIntegracion;
using SistemaVerduleria.CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CapaPresentacion.Modulos
{
    public partial class frmFacturación : Form
    {

        private int idArticuloProducto = 0;
        private string nombreProducto = "";
        private double descuentoProducto = 0;
        private double ImpuestoProducto = 0;
        private double precioProducto = 0;
        private string pesoProducto = "";

        private List<DetalleFactura> factura = new List<DetalleFactura>();
        private int idArticuloFactura = 0;
        private string nombreFactura = "";
        private double descuentoFactura = 0;
        private double ImpuestoFactura = 0;
        private double cantidadFactura = 0;
        private double precioFactura = 0;

        private int numFila = 0;

        public frmFacturación()
        {
            InitializeComponent();
            CargarGridProductos();
            CargarComboFamilia();
            CargarComboCliente();
            CargarComboCliente();
            ActualizarFactura();
        }

        private void CargarGridProductos()
        {
            using (GestorArticulo servicio = new GestorArticulo())
            {
                if (ckb_productoFiltrar.Checked == true && ckb_familiaFiltrar.Checked == true)
                {
                    if (cbx_filtrar.SelectedItem != null)
                    {
                        dgv_Productos.DataSource = servicio.ListarPF(cbx_filtrar.SelectedValue.ToString(), txtb_filtrar.Text);
                    }
                    else
                    {
                        dgv_Productos.DataSource = servicio.ListarP(txtb_filtrar.Text);
                    }
                }
                else if (ckb_productoFiltrar.Checked == true && ckb_familiaFiltrar.Checked == false)
                {
                    dgv_Productos.DataSource = servicio.ListarP(txtb_filtrar.Text);
                }
                else if (ckb_productoFiltrar.Checked == false && ckb_familiaFiltrar.Checked == true)
                {
                    if (cbx_filtrar.SelectedItem != null)
                    {
                        dgv_Productos.DataSource = servicio.ListarF(cbx_filtrar.SelectedValue.ToString());
                    }
                    else
                    {
                        dgv_Productos.DataSource = servicio.ListarPF("", "");
                    }
                }
                else
                {
                    dgv_Productos.DataSource = servicio.ListarP("");
                }

                dgv_Productos.Columns["Articulos_id"].HeaderText = "ID";
                dgv_Productos.Columns["Articulos_FamiliaID"].Visible = false;
                dgv_Productos.Columns["Articulos_UnidadesMedidaID"].Visible = false;
                dgv_Productos.Columns["Articulos_Nombre"].HeaderText = "Producto";
                dgv_Productos.Columns["Articulos_Codigo"].HeaderText = "Codigo";
                dgv_Productos.Columns["Articulos_Descripcion"].HeaderText = "Descripción";
                dgv_Productos.Columns["Articulos_Precio"].HeaderText = "Precio";
                dgv_Productos.Columns["Articulos_CantidadUnidadesMedida"].HeaderText = "Peso";
                dgv_Productos.Columns["Articulos_Descuento"].HeaderText = "Descuento";
                dgv_Productos.Columns["Articulos_Impuesto"].HeaderText = "Impuesto";
                dgv_Productos.Columns["Articulos_Estado"].Visible = false;
            }
        }
        private void CargarComboFamilia()
        {
            using (GestorFamiliaProductos servicio = new GestorFamiliaProductos())
            {
                cbx_filtrar.DataSource = servicio.ListarA();

                cbx_filtrar.ValueMember = "Familia_Codigo";
                cbx_filtrar.DisplayMember = "Familia_tipo";
                cbx_filtrar.SelectedItem = null;
            }
        }

        private void dgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                int numFila = dgv_Productos.CurrentCell.RowIndex;
                idArticuloProducto = int.Parse(this.dgv_Productos[0, numFila].Value.ToString());

                using (GestorArticulo Gestor = new GestorArticulo())
                {
                    dset = Gestor.Consultar(idArticuloProducto);
                    dtable = dset.Tables[0];

                }

                nombreProducto = dtable.Rows[0]["Articulos_Nombre"].ToString();
                descuentoProducto = double.Parse(dtable.Rows[0]["Articulos_Descuento"].ToString());
                ImpuestoProducto = double.Parse(dtable.Rows[0]["Articulos_Impuesto"].ToString());
                precioProducto = double.Parse(dtable.Rows[0]["Articulos_Precio"].ToString());
                pesoProducto = dtable.Rows[0]["Articulos_CantidadUnidadesMedida"].ToString() + " " + dtable.Rows[0]["Articulos_UnidadesMedidaID"].ToString();

                precioProducto = (precioProducto * (1 + (ImpuestoProducto / 100))) / (1 + (descuentoProducto / 100));

                txtb_productoProducto.Text = dtable.Rows[0]["Articulos_Nombre"].ToString();
                txtb_pesoProducto.Text = pesoProducto;
                txtb_precioVentaProducto.Text = precioProducto.ToString();
                txtb_cantidadProducto.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            //dgv_articulosFactura
            //factura.Add()
            if (revisarProducto() == true)
            {
                DetalleFactura obj = new DetalleFactura();

                obj.DetalleFactura_ArticulosID = idArticuloProducto;
                obj.DetalleFactura_Cantidad = double.Parse(txtb_cantidadProducto.Text);
                obj.DetalleFactura_Descuento = descuentoProducto;
                obj.DetalleFactura_Impuesto = ImpuestoProducto;
                obj.DetalleFactura_Precio = double.Parse(txtb_cantidadProducto.Text) * precioProducto;

                factura.Add(obj);
                limpiarProducto();
                ActualizarFactura();
                actualizarTotales();
            }
        }
        private void ActualizarFactura()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Producto", typeof(string));
            table.Columns.Add("Cantidad", typeof(double));
            table.Columns.Add("Descuento", typeof(double));
            table.Columns.Add("Impuesto", typeof(double));
            table.Columns.Add("Precio", typeof(double));

            foreach (DetalleFactura obj in factura)
            {
                DataSet dsU = new DataSet();
                DataTable dtU = new DataTable();

                using (GestorArticulo service = new GestorArticulo())
                {
                    dsU = service.Consultar(obj.DetalleFactura_ArticulosID);
                    dtU = dsU.Tables[0];
                }

                DataRow row = table.NewRow();
                row["ID"] = obj.DetalleFactura_ArticulosID;
                row["Producto"] = dtU.Rows[0]["Articulos_Nombre"].ToString(); ;
                row["Cantidad"] = obj.DetalleFactura_Cantidad;
                row["Descuento"] = obj.DetalleFactura_Descuento;
                row["Impuesto"] = obj.DetalleFactura_Impuesto;
                row["Precio"] = obj.DetalleFactura_Precio;
                
                table.Rows.Add(row);
            }
            dgv_articulosFactura.DataSource = table;
            //dgv_articulosFactura.Columns[5].Width = 200;

        }
        private Boolean revisarProducto()
        {
            foreach (DetalleFactura obj in factura)
            {
                if (obj.DetalleFactura_ArticulosID == idArticuloProducto)
                {
                    obj.DetalleFactura_Precio = (obj.DetalleFactura_Precio / obj.DetalleFactura_Cantidad) * (obj.DetalleFactura_Cantidad + double.Parse(txtb_cantidadProducto.Text));
                    obj.DetalleFactura_Cantidad = obj.DetalleFactura_Cantidad + double.Parse(txtb_cantidadProducto.Text);
                    limpiarProducto();
                    ActualizarFactura();
                    actualizarTotales();
                    return false;
                }
            }
            if (idArticuloProducto == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para poder agregarlo a la factura.", "Validación");
                return false;
            }
            else if (txtb_cantidadProducto.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de cantidad para poder agregar un producto.", "Validación");
                return false;
            }
            return true;
        }

        private void btn_limpiarProducto_Click(object sender, EventArgs e)
        {
            limpiarProducto();
        }
        private void limpiarProducto()
        {
            txtb_productoProducto.Clear();
            txtb_cantidadProducto.Clear();
            txtb_pesoProducto.Clear();
            txtb_precioVentaProducto.Clear();

            idArticuloProducto = 0;
            nombreProducto = "";
            descuentoProducto = 0;
            ImpuestoProducto = 0;
            precioProducto = 0;
        }

        private void cbx_filtrar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarGridProductos();
        }

        private void txtb_filtrar_TextChanged(object sender, EventArgs e)
        {
            CargarGridProductos();
        }

        private void ckb_familiaFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            CargarGridProductos();
        }

        private void ckb_productoFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            CargarGridProductos();
        }
        ////////////////////////////////////////////////////
        ///////////////////////////////////////////////////
        //////////////////////////////////////////////////
        private void CargarComboCliente()
        {
            using (GestorCliente servicio = new GestorCliente())
            {
                cbx_cliente.DataSource = servicio.ListarFiltrado(txb_filtrarCliente.Text);

                cbx_cliente.ValueMember = "Cliente_id";
                cbx_cliente.DisplayMember = "Cliente_Cedula";
                cbx_cliente.SelectedItem = null;
            }
        }

        private void txb_filtrarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarComboCliente();
        }
        private void btn_EliminarFactura_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar la factura?, se perderan todos los datos guardados hasta el momento.",
                "ELIMINAR FACTURA", buttons);
            if (result == DialogResult.Yes)
            {
                eliminarFactura();
            }
        }
        private void eliminarFactura()
        {
            limpiarProducto();
            limpiarFactura();

            factura.Clear();

            ActualizarFactura();

            txb_Correo.Text = "";

            txb_filtrarCliente.Clear();
            txtbr_observaciones.Clear();
            cbx_cliente.SelectedItem = null;
            cbx_filtrar.SelectedItem = null;
            txtb_descuentoGeneral.Clear();

            txtb_subtotal.Text = "0.00";
            txtb_descuento.Text = "0.00";
            txtb_impuesto.Text = "0.00";
            txtb_total.Text = "0.00";
        }
        private void limpiarFactura()
        {
            idArticuloFactura = 0;
            nombreFactura = "";
            descuentoFactura = 0;
            ImpuestoFactura = 0;
            precioFactura = 0;
            cantidadFactura = 0;

            txtb_cantidadFactura.Clear();
            txtb_productoFactura.Clear();
            txtb_precioFactura.Clear();
            txtb_pesoFactura.Clear();
        }
        private void btn_limpiarProductoFactura_Click(object sender, EventArgs e)
        {
            limpiarFactura();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frm = new frmAgregarCliente();
            frm.ShowDialog();
            Refresh();
            CargarComboCliente();
        }

        private void dgv_articulosFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();
                numFila = dgv_articulosFactura.CurrentCell.RowIndex;
                //idArticuloFactura = int.Parse(this.dgv_articulosFactura[0, numFila].Value.ToString());

                DataSet dsU = new DataSet();
                DataTable dtU = new DataTable();

                using (GestorArticulo service = new GestorArticulo())
                {
                    dsU = service.Consultar(factura[numFila].DetalleFactura_ArticulosID);
                    dtU = dsU.Tables[0];
                }

                idArticuloFactura = factura[numFila].DetalleFactura_ArticulosID;
                nombreFactura = dtU.Rows[0]["Articulos_Nombre"].ToString();
                descuentoFactura = factura[numFila].DetalleFactura_Descuento;
                ImpuestoFactura = factura[numFila].DetalleFactura_Impuesto;
                precioFactura = factura[numFila].DetalleFactura_Precio;
                cantidadFactura = factura[numFila].DetalleFactura_Cantidad;

                txtb_cantidadFactura.Text = cantidadFactura.ToString();
                txtb_productoFactura.Text = nombreFactura;

                double aux = precioFactura / cantidadFactura;
                //aux = (aux  * (1 + (ImpuestoFactura / 100))) / (1 + (descuentoFactura / 100));
                txtb_precioFactura.Text = aux.ToString();
                txtb_pesoFactura.Text = dtU.Rows[0]["Articulos_CantidadUnidadesMedida"].ToString();
                txtb_cantidadFactura.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("No ha selecionado ningun elemento de la tabla. ", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_editarProducto_Click(object sender, EventArgs e)
        {
            if (revisarProductoFactura("Editar") == true)
            {
                foreach (DetalleFactura obj in factura)
                {
                    if (obj.DetalleFactura_ArticulosID == idArticuloFactura)
                    {
                        obj.DetalleFactura_Precio = (obj.DetalleFactura_Precio / obj.DetalleFactura_Cantidad) * double.Parse(txtb_cantidadFactura.Text);
                        obj.DetalleFactura_Cantidad = double.Parse(txtb_cantidadFactura.Text);
                    }
                }
                ActualizarFactura();
                limpiarFactura();
                actualizarTotales();
            }
        }

        private Boolean revisarProductoFactura(string metodo)
        {
            if (idArticuloFactura == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para poder ediatarlo.", "Validación");
                return false;
            }
            else if (txtb_cantidadFactura.Text == "" && metodo == "Editar")
            {
                MessageBox.Show("Debe llenar el campo de cantidad para poder actualizar un producto.", "Validación");
                return false;
            }
            return true;
        }

        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            if (revisarProductoFactura("Eliminar") == true)
            {
                factura.RemoveAt(numFila);

                ActualizarFactura();
                limpiarFactura();
                actualizarTotales();
            }
        }
        ///////////////////////////////////////////////////
        ///////////////////////////////////////////////////
        ///////////////////////////////////////////////////

        private void actualizarTotales()
        {
            txtb_subtotal.Text = "0";
            txtb_descuento.Text = "0";
            txtb_impuesto.Text = "0";
            txtb_total.Text = "0";

            double subtotal = 0;
            double descuento = 0;
            double impuesto = 0;
            double total = 0;

            foreach (DetalleFactura obj in factura)
            {
                subtotal = subtotal + (((obj.DetalleFactura_Precio + (obj.DetalleFactura_Precio * (obj.DetalleFactura_Descuento / 100))) / (1 + (obj.DetalleFactura_Impuesto / 100))));
                impuesto = impuesto + (((obj.DetalleFactura_Precio + (obj.DetalleFactura_Precio * (obj.DetalleFactura_Descuento / 100))) / (1 + (obj.DetalleFactura_Impuesto / 100))) * (obj.DetalleFactura_Impuesto / 100));
                descuento = descuento + (obj.DetalleFactura_Precio * (obj.DetalleFactura_Descuento / 100));
            }

            total = (subtotal + impuesto) - descuento;
            if (txtb_descuentoGeneral.Text != "")
            {
                descuento = descuento + (total * (double.Parse(txtb_descuentoGeneral.Text) / 100));
                total = total - (total * (double.Parse(txtb_descuentoGeneral.Text) / 100));
            }

            txtb_subtotal.Text = subtotal.ToString();
            txtb_descuento.Text = descuento.ToString();
            txtb_impuesto.Text = impuesto.ToString();
            txtb_total.Text = total.ToString();


        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que desea procesar esta factura?", "FINALIZAR FACTURA", buttons);
            if (result == DialogResult.Yes)
            {
                if (factura.Count != 0)
                {
                    DataSet dset = new DataSet();
                    DataTable dtable = new DataTable();

                    using (GestorFacturacion Gestor = new GestorFacturacion())
                    {
                        if (cbx_cliente.SelectedItem != null)
                        {
                            Gestor.Insertar(txtbr_observaciones.Text, int.Parse(cbx_cliente.SelectedValue.ToString()), double.Parse(txtb_descuento.Text), double.Parse(txtb_impuesto.Text),
                            factura.Count, double.Parse(txtb_subtotal.Text), double.Parse(txtb_total.Text),
                            (DateTime.Now).ToString(), "A");
                        }
                        else
                        {
                            Gestor.Insertar(txtbr_observaciones.Text, 0, double.Parse(txtb_descuento.Text), double.Parse(txtb_impuesto.Text),
                            factura.Count, double.Parse(txtb_subtotal.Text), double.Parse(txtb_total.Text),
                            (DateTime.Now).ToString(), "A");
                        }
                        dset = Gestor.UltimoRegistro();
                        dtable = dset.Tables[0];
                    }
                    InsertarDetalleFactura(int.Parse(dtable.Rows[0]["Facturacion_id"].ToString()));
                    if (cbx_cliente.SelectedValue != null || txb_Correo.Text != "")
                    {
                        ImformacionCorreo();
                    }
                    eliminarFactura();
                }
                else
                {
                    MessageBox.Show("No hay ningun articulo en la factura.", "ERROR AL PROCESAR");
                }
            }
        }

        private void InsertarDetalleFactura(int id)
        {
            using (GestorDetalleFactura Gestor = new GestorDetalleFactura())
            {
                foreach (DetalleFactura obj in factura)
                {
                    Gestor.Insertar(obj.DetalleFactura_ArticulosID, id, obj.DetalleFactura_Cantidad, obj.DetalleFactura_Descuento,
                        obj.DetalleFactura_Impuesto, obj.DetalleFactura_Precio, "A");
                }
            }

        }

        private void txtb_descuentoGeneral_TextChanged(object sender, EventArgs e)
        {
            actualizarTotales();
        }

        private void ImformacionCorreo()
        {
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();

            using (GestorFacturacion Gestor = new GestorFacturacion())
            {
                dset = Gestor.UltimoRegistro();
                dtable = dset.Tables[0];
            }
            
            string InforFactura = "<h3 style='text-align: center;' > ";
            InforFactura += "Numero de factura: " + int.Parse(dtable.Rows[0]["Facturacion_id"].ToString()) + "<br>";
          
            DataSet dsetcliente = new DataSet();
            DataTable dtablecliente = new DataTable();
            if (cbx_cliente.SelectedValue != null)
            {
                using (GestorCliente Gestor = new GestorCliente())
                {
                    dsetcliente = Gestor.Consultar(int.Parse(dtable.Rows[0]["Facturacion_ClienteID"].ToString()));
                    dtablecliente = dsetcliente.Tables[0];
                }
                InforFactura += "Cliente: " + dtablecliente.Rows[0]["Cliente_nombre"].ToString() + "<br>";
            }
            else
            {
                InforFactura += "No definido: " + dtablecliente.Rows[0]["Cliente_nombre"].ToString() + "<br>";
            }
            InforFactura += "Fecha: " + dtable.Rows[0]["Facturacion_Fecha"].ToString() + "<br>";
            InforFactura += "Numero de articulos: " + int.Parse(dtable.Rows[0]["Facturacion_NumeroArticulos"].ToString()) + "<br>";
            InforFactura += "Sub Total: " + double.Parse(dtable.Rows[0]["Facturacion_SubTotal"].ToString()) + "<br>";
            InforFactura += "Impuesto: " + double.Parse(dtable.Rows[0]["Facturacion_Impuesto"].ToString()) + "<br>";
            InforFactura += "Descuento: " + double.Parse(dtable.Rows[0]["Facturacion_Descuento"].ToString()) + "<br>";
            InforFactura += "Total: " + double.Parse(dtable.Rows[0]["Facturacion_Total"].ToString());

            InforFactura += "</h3>";

            ///Detalle Factura 
            DataTable Detalle = new DataTable();

            Detalle.Columns.Add("ID", typeof(int));
            Detalle.Columns.Add("Producto", typeof(string));
            Detalle.Columns.Add("Cantidad", typeof(double));
            Detalle.Columns.Add("Descuento", typeof(double));
            Detalle.Columns.Add("Impuesto", typeof(double));
            Detalle.Columns.Add("Precio", typeof(double));

            foreach (DetalleFactura obj in factura)
            {
                DataSet dsU = new DataSet();
                DataTable dtU = new DataTable();

                using (GestorArticulo service = new GestorArticulo())
                {
                    dsU = service.Consultar(obj.DetalleFactura_ArticulosID);
                    dtU = dsU.Tables[0];
                }

                DataRow row = Detalle.NewRow();
                row["ID"] = obj.DetalleFactura_ArticulosID;
                row["Producto"] = dtU.Rows[0]["Articulos_Nombre"].ToString(); ;
                row["Cantidad"] = obj.DetalleFactura_Cantidad;
                row["Descuento"] = obj.DetalleFactura_Descuento;
                row["Impuesto"] = obj.DetalleFactura_Impuesto;
                row["Precio"] = obj.DetalleFactura_Precio;

                Detalle.Rows.Add(row);
            }


            //Factura
            //Detalle
            //dtablecliente.Rows[0]["Cliente_CorreoElectronico"].ToString()
            //txb_Correo.Text
            Detalle.Columns.Remove("ID");
            if (cbx_cliente.SelectedValue != null)
            {
                try
                {
                    enviarCorreo(dtablecliente.Rows[0]["Cliente_CorreoElectronico"].ToString(), InforFactura, toHTML_Table(Detalle));
                }
                catch (Exception) { }
            }
            if (txb_Correo.Text != "")
            {
                try
                {
                    enviarCorreo(txb_Correo.Text, InforFactura, toHTML_Table(Detalle));
                }
                catch (Exception) { }
            }
        }
        public static string toHTML_Table(DataTable dt)
        {
            if (dt.Rows.Count == 0) return ""; // enter code here

            StringBuilder builder = new StringBuilder();
            builder.Append("<html>");
            builder.Append("<head>");
            builder.Append("<title>");
            builder.Append("Page-");
            builder.Append(Guid.NewGuid());
            builder.Append("</title>");
            builder.Append("</head>");
            builder.Append("<body>");
            builder.Append("<div style='text-align: center;'>");
            builder.Append("<table border='2px' cellpadding='5' cellspacing='0'");
            builder.Append("style='border: solid 1px Silver; font-size: x-small; align-items: center; text-align: center;'>");
            builder.Append("<tr align='left' valign='top'>");
            foreach (DataColumn c in dt.Columns)
            {
                builder.Append("<td align='left' valign='top' style='background: rgb(33, 92, 99)' ><b>");
                builder.Append(c.ColumnName);
                builder.Append("</b></td>");
            }
            builder.Append("</tr>");
            foreach (DataRow r in dt.Rows)
            {
                builder.Append("<tr align='left' valign='top'>");
                foreach (DataColumn c in dt.Columns)
                {
                    builder.Append("<td align='left' valign='top'>");
                    builder.Append(r[c.ColumnName]);
                    builder.Append("</td>");
                }
                builder.Append("</tr>");
            }
            builder.Append("</table>");
            builder.Append("</div>");
            builder.Append("</body>");
            builder.Append("</html>");

            return builder.ToString();
        }
        private void enviarCorreo(string correo, string htmlFactura, string htmlDetalle)
        {
            MailMessage recuperacion = new MailMessage();

            recuperacion.To.Add(correo);
            recuperacion.Subject = "FACTURA Verduleria Querubín.";
            recuperacion.SubjectEncoding = Encoding.UTF8;
            //recuperacion.Bcc.Add("verduleriaquerubin@gmail.com");

            recuperacion.Body = "<h1 style='text-align: center;'> Factura emitida por la Verduleria el Querubín. </h1>" +
                "<h2 style='text-align: center;'> Estimado(a) cliente se le adjunta la información referente a la factura: </h2>" +
                htmlFactura +
                "<br> " +
                "<h2 style = 'text-align: center;' > Productos de la factura:</ h2 > "+
                "<br>" +
                htmlDetalle + " \n <h1 style='text-align: center;'> GRACIAS POR SU COMPRA </h1>";

            recuperacion.BodyEncoding = Encoding.UTF8;
            recuperacion.IsBodyHtml = true;
            recuperacion.From = new MailAddress("verduleriaquerubin@gmail.com", "SISTEMA DE FACTURACIÓN 'Verdulería Querubín'");

            SmtpClient cliente = new SmtpClient();
            //verduleriaquerubin@gmail.com
            //Querubin261021
            cliente.Credentials = new NetworkCredential("verduleriaquerubin@gmail.com", "Querubin261021");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(recuperacion);
            }
            catch (Exception)
            {
                MessageBox.Show("Revise su conexión o la dirección de correo electrónico.", "ERROR");
            }
        }

        private void frmFacturación_Load(object sender, EventArgs e)
        {

        }

        private void txtb_cantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\r' && idArticuloProducto != 0)
            {
                if (revisarProducto() == true)
                {
                    DetalleFactura obj = new DetalleFactura();

                    obj.DetalleFactura_ArticulosID = idArticuloProducto;
                    obj.DetalleFactura_Cantidad = double.Parse(txtb_cantidadProducto.Text);
                    obj.DetalleFactura_Descuento = descuentoProducto;
                    obj.DetalleFactura_Impuesto = ImpuestoProducto;
                    obj.DetalleFactura_Precio = double.Parse(txtb_cantidadProducto.Text) * precioProducto;

                    factura.Add(obj);
                    limpiarProducto();
                    ActualizarFactura();
                    actualizarTotales();
                }
            }
        }

        private void txtb_cantidadFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\r')
            {
                if (revisarProductoFactura("Editar") == true)
                {
                    foreach (DetalleFactura obj in factura)
                    {
                        if (obj.DetalleFactura_ArticulosID == idArticuloFactura)
                        {
                            obj.DetalleFactura_Precio = (obj.DetalleFactura_Precio / obj.DetalleFactura_Cantidad) * double.Parse(txtb_cantidadFactura.Text);
                            obj.DetalleFactura_Cantidad = double.Parse(txtb_cantidadFactura.Text);
                        }
                    }
                    ActualizarFactura();
                    limpiarFactura();
                    actualizarTotales();
                }
            }
        }
    }
}

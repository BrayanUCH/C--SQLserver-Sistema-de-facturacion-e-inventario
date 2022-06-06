using SistemaVerduleria.CapaIntegracion;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion.Modulos
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
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
        private void enviarCorreo(string correo, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.To.Add(correo);
                mail.Subject = "FACTURA Verduleria Querubín.";
                mail.SubjectEncoding = Encoding.UTF8;
                //recuperacion.Bcc.Add("verduleriaquerubin@gmail.com");

                mail.Body = body;

                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.From = new MailAddress("verduleriaquerubin@gmail.com", "SISTEMA DE FACTURACIÓN 'Verdulería Querubín'");

                SmtpClient cliente = new SmtpClient();
                //verduleriaquerubin@gmail.com
                //Querubin261021
                cliente.Credentials = new NetworkCredential("verduleriaquerubin@gmail.com", "Querubin261021");

                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";


                cliente.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Revise su conexión o la dirección de correo electrónico.", "ERROR");
            }
        }
        private void ConsultaFactura(int ID, string CORREO)
        {
            try
            {
                #region Factura
                DataSet dset = new DataSet();
                DataTable dtable = new DataTable();

                using (GestorFacturacion Gestor = new GestorFacturacion())
                {
                    dset = Gestor.Consultar(ID);
                    dtable = dset.Tables[0];
                }

                DataSet dsetcliente = new DataSet();
                DataTable dtablecliente = new DataTable();
                string cliente = "";
                if (int.Parse(dtable.Rows[0]["Facturacion_ClienteID"].ToString()) != 0)
                {
                    using (GestorCliente Gestor = new GestorCliente())
                    {
                        dsetcliente = Gestor.Consultar(int.Parse(dtable.Rows[0]["Facturacion_ClienteID"].ToString()));
                        dtablecliente = dsetcliente.Tables[0];
                    }
                    cliente = dtablecliente.Rows[0]["Cliente_nombre"].ToString();
                }
                else
                {
                    cliente = "No definido";
                }


                string InforFactura = "<h1 style='text-align: center;' > ";
                InforFactura += "Factura emitida por la Verduleria el Querubín. \n" +
                    "Estimado(a) se le adjunta una 'COPIA' de la factura numero: " + int.Parse(dtable.Rows[0]["Facturacion_id"].ToString()) + ":" + " </h1>" +
                    "<br> " +
                    "<h2 style='text-align: center;'>";

                InforFactura += "Cliente: " + cliente + "<br>";
                InforFactura += "Fecha de emisión: " + dtable.Rows[0]["Facturacion_Fecha"].ToString() + "<br>";
                InforFactura += "Numero de articulos: " + int.Parse(dtable.Rows[0]["Facturacion_NumeroArticulos"].ToString()) + "<br>";
                InforFactura += "SubTotal: " + double.Parse(dtable.Rows[0]["Facturacion_SubTotal"].ToString()) + "<br>";
                InforFactura += "Impuesto: " + double.Parse(dtable.Rows[0]["Facturacion_Impuesto"].ToString()) + "<br>";
                InforFactura += "Descuento: " + double.Parse(dtable.Rows[0]["Facturacion_Descuento"].ToString()) + "<br>";
                InforFactura += "Tottal: " + double.Parse(dtable.Rows[0]["Facturacion_Total"].ToString()) + "<br>";
                InforFactura += "</h2> <br>";

                #endregion

                #region Detalle Factura
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
                #endregion

                Detalle.Columns.Remove("ID");
                InforFactura += "<h3 style='text-align: center;'> Productos de la factura:</h3> <br>";
                InforFactura += "<div>" + toHTML_Table(Detalle) + "</div>";

                if (dtable.Rows.Count != 0)
                {
                    enviarCorreo(CORREO, InforFactura);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Numero de factura invalido", "ERROR");
            }
        }
        private void ConsultarClientes(string correo)
        {
            #region Datos del datatable
            DataTable dtable = new DataTable();

            using (GestorCliente servicio = new GestorCliente())
            {
                dtable = servicio.ListarA();
            }
            dtable.Columns.Remove("Cliente_id");
            dtable.Columns["Cliente_nombre"].ColumnName = "Nombre";
            dtable.Columns["Cliente_Cedula"].ColumnName = "Cedula";
            dtable.Columns["Cliente_CorreoElectronico"].ColumnName = "Correo electronico";
            dtable.Columns["Cliente_Telefono"].ColumnName = "Telefono";
            dtable.Columns["Cliente_FechaNacimiento"].ColumnName = "Fecha de nacimiento";
            dtable.Columns.Remove("Cliente_Estado");
            #endregion

            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'>Lista de los clientes activos de la Verduleria Querubín.<br>" +
                "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín:</h1><br>" +
                toHTML_Table(dtable);
                
                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("No existen clientes registrados en la base de datos del sistema.", "ERROR");
            }
            #endregion
        }
        private void ConsultarCliente(string correo, string Cedula)
        {
            #region Datos del datatable
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();
           
            using (GestorCliente Gestor = new GestorCliente())
            {
                dset = Gestor.ConsultarCedula(Cedula);
                dtable = dset.Tables[0];

            }
            #endregion
            
            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'> Cliente consultado de la Verduleria Querubín. <br>" +
                   "\n Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín: </h1> <br>";
                body += "<h2 style='text-align: center;'> ";

                body += "Nombre: " + dtable.Rows[0]["Cliente_nombre"] + "<br>";
                body += "Cedula: " + dtable.Rows[0]["Cliente_Cedula"] + "<br>";
                body += "Correo electronico: " + dtable.Rows[0]["Cliente_CorreoElectronico"] + "<br>";
                body += "Telefono: " + dtable.Rows[0]["Cliente_Telefono"] + "<br>";
                body += "Fecha de nacimiento: " + dtable.Rows[0]["Cliente_FechaNacimiento"] + "<br>";

                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("El número de cédula no pertenece a ningunos de los clientes registrados.", "INCORRECTO");
            }
            #endregion
        }
        private void ConsultarProveedores(string correo)
        {
            #region Datos del datatable
            DataTable dtable = new DataTable();

            using (GestorProveedor servicio = new GestorProveedor())
            {
                dtable = servicio.ListarA();
            }
            dtable.Columns.Remove("Proveedor_id");
            dtable.Columns["Proveedor_Cedula"].ColumnName = "Cedula";
            dtable.Columns["Proveedor_Codigo"].ColumnName = "Codigo";
            dtable.Columns["Proveedor_NombreORazonSocial"].ColumnName = "Nombre o razón social";
            dtable.Columns["Proveedor_FechaIngreso"].ColumnName = "Fecha de ingreso";
            dtable.Columns["Proveedor_Saldo"].ColumnName = "Saldo";
            dtable.Columns["Proveedor_CuentaDelBanco"].ColumnName = "Numero de cuenta";
            dtable.Columns["Proveedor_Banco"].ColumnName = "Banco";
            dtable.Columns["Proveedor_DiasDePago"].ColumnName = "Dias de pago";
            dtable.Columns["Proveedor_Telefono"].ColumnName = "Telefono";
            dtable.Columns["Proveedor_CorreoElectronico"].ColumnName = "Correo electronico";
            dtable.Columns.Remove("Proveedor_Estado");
            #endregion

            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'> Lista de los Provedores activos de la Verduleria Querubín.<br>" +
                "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín:</h1> <br>" +
                toHTML_Table(dtable);
                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("No existen proveedores registrados en la base de datos del sistema.", "ERROR");
            }
            #endregion
        }
        private void ConsultarProveedor(string correo, string Cedula_codigo, string tipo)
        {
            #region Datos del datatable
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();

            using (GestorProveedor Gestor = new GestorProveedor())
            {
                if (tipo == "Cedula")
                {
                    dset = Gestor.ConsultarCedula(Cedula_codigo);
                }
                else
                {
                    dset = Gestor.ConsultarCodigo(Cedula_codigo);
                }
                dtable = dset.Tables[0];
            }
            #endregion

            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'> Proveedor consultado de la Verduleria Querubín. <br>" +
                  "\n Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín: </h1> <br>";
                body += "<h2 style='text-align: center;'> ";

                body += "Nombre o razon social: " + dtable.Rows[0]["Proveedor_NombreORazonSocial"] + "<br>";
                body += "Cedula: " + dtable.Rows[0]["Proveedor_Cedula"] + "<br>";
                body += "Codigo: " + dtable.Rows[0]["Proveedor_Codigo"] + "<br>";
                body += "fecha de ingreso: " + dtable.Rows[0]["Proveedor_FechaIngreso"] + "<br>";
                body += "Saldo: " + dtable.Rows[0]["Proveedor_Saldo"] + "<br>";
                body += "Cuenta de banco: " + dtable.Rows[0]["Proveedor_CuentaDelBanco"] + "<br>";
                body += "Banco: " + dtable.Rows[0]["Proveedor_Banco"] + "<br>";
                body += "Dias de pago: " + dtable.Rows[0]["Proveedor_DiasDePago"] + "<br>";
                body += "Telefono: " + dtable.Rows[0]["Proveedor_Telefono"] + "<br>";
                body += "Correo electronico: " + dtable.Rows[0]["Proveedor_CorreoElectronico"] + "<br>";

                enviarCorreo(correo, body);
            }
            else
            {
                if (tipo == "Cedula")
                {
                    MessageBox.Show("El número de cédula no pertenece a ninguno de los proveedores registrados.", "INCORRECTO");
                }
                else
                {
                    MessageBox.Show("El codigo no pertenece a ninguno proveedor registrado.", "INCORRECTO");
                }
            }
            #endregion
        }
        private void ConsultarProductos(string correo)
        {
            #region Datos del datatable
            DataTable dtable = new DataTable();
            DataTable tablenew = new DataTable();

            using (GestorArticulo servicio = new GestorArticulo())
            {
                dtable = servicio.ListarA();
            }
            tablenew.Columns.Add("Codigo");
            tablenew.Columns.Add("Descripción");
            tablenew.Columns.Add("Producto");
            tablenew.Columns.Add("Familia");
            tablenew.Columns.Add("Unidades de media");
            tablenew.Columns.Add("Peso");
            tablenew.Columns.Add("Precio");
            tablenew.Columns.Add("Descuento");
            tablenew.Columns.Add("Impuesto");
            #region NEW DATATABLE

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                #region Familia
                DataSet set = new DataSet();
                DataTable tableFamilia = new DataTable();

                using (GestorFamiliaProductos Gestor = new GestorFamiliaProductos())
                {
                    set = Gestor.Consultar(int.Parse(dtable.Rows[i]["Articulos_FamiliaID"].ToString()));
                    tableFamilia = set.Tables[0];
                }

                #endregion Familia
                object[] o = {
                         dtable.Rows[i]["Articulos_Codigo"].ToString(),
                         dtable.Rows[i]["Articulos_Descripcion"].ToString(),
                         dtable.Rows[i]["Articulos_Nombre"].ToString(),
                         tableFamilia.Rows[0]["Familia_tipo"].ToString(),
                         dtable.Rows[i]["Articulos_UnidadesMedidaID"].ToString(),
                         dtable.Rows[i]["Articulos_CantidadUnidadesMedida"].ToString(),
                         dtable.Rows[i]["Articulos_Precio"].ToString(),
                         dtable.Rows[i]["Articulos_Descuento"].ToString(),
                         dtable.Rows[i]["Articulos_Impuesto"].ToString(),
                    };

                tablenew.Rows.Add(o);
            }
            #endregion NEW DATATABLE

            #endregion Datos del datatable

            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'> Lista de los productos activos de la Verduleria Querubín. <br>" +
                "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín:</h1><br>" +
                toHTML_Table(tablenew);
                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("No existen productos registrados en la base de datos del sistema.", "ERROR");
            }
            #endregion
        }
        private void ConsultarInventarioLocal(string correo)
        {
            DataTable dtable = new DataTable();
            DataTable tablenew = new DataTable();
            using (GestorInventario servicio = new GestorInventario())
            {
                dtable = servicio.ListarAL();
            }

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
                        dtable.Rows[i]["Inventario_ArticuloID"].ToString(),
                        table.Rows[0]["Articulos_Nombre"].ToString(),
                        table.Rows[0]["Articulos_Codigo"].ToString(),
                        dtable.Rows[i]["Inventario_Cantidad"].ToString(),
                        table.Rows[0]["Articulos_Descripcion"].ToString()
                    };

                tablenew.Rows.Add(o);
            }
            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'>Lista de los productos activos del inventario del local de la Verduleria Querubín. <br>" +
                "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín:</h1><br>" +
                toHTML_Table(tablenew);
                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("No existen productos registrados en la base de datos del sistema.", "ERROR");
            }
            #endregion
            //dgvInventarioLocal.Columns["ID Inventario"].Visible = false;
        }
        private void ConsultarInventarioBodega(string correo)
        {
            DataTable dtable = new DataTable();
            DataTable tablenew = new DataTable();
            using (GestorInventario servicio = new GestorInventario())
            {
                dtable = servicio.ListarAB();
            }
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
                        dtable.Rows[i]["Inventario_ArticuloID"].ToString(),
                        table.Rows[0]["Articulos_Nombre"].ToString(),
                        table.Rows[0]["Articulos_Codigo"].ToString(),
                        dtable.Rows[i]["Inventario_Cantidad"].ToString(),
                        table.Rows[0]["Articulos_Descripcion"].ToString()
                    };

                tablenew.Rows.Add(o);
            }
            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'> Lista de los productos activos del inventario de la bodega de la Verduleria Querubín.<br>" +
                "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín:</h1><br>" +
                toHTML_Table(tablenew);
                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("No existen productos registrados en la base de datos del sistema.", "ERROR");
            }
            #endregion

        }
        private void ConsultarCuentasPorPagar(string correo)
        {
            DataTable dtable = new DataTable();
            DataTable tablenew = new DataTable();

            using (GestorCuentasPorPagar servicio = new GestorCuentasPorPagar())
            {
                dtable = servicio.ListarA();
            }
            tablenew.Columns.Add("Proveedor");
            tablenew.Columns.Add("Descripción");
            tablenew.Columns.Add("Fecha de pago");
            tablenew.Columns.Add("Monto");

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                #region articulo
                DataSet set = new DataSet();
                DataTable table = new DataTable();
                int ID = int.Parse(dtable.Rows[i]["CuentasXPagar_ProveedorID"].ToString());

                using (GestorProveedor Gestor = new GestorProveedor())
                {
                    set = Gestor.Consultar(ID);
                    table = set.Tables[0];
                }
                #endregion
                object[] o = {
                        table.Rows[0]["Proveedor_NombreORazonSocial"].ToString(),
                        dtable.Rows[i]["CuentasXPagar_Descripcion"].ToString(),
                        dtable.Rows[i]["CuentasXPagar_FechaPago"].ToString(),
                        dtable.Rows[i]["CuentasXPagar_Monto"].ToString(),
                    };

                tablenew.Rows.Add(o);
            }
            #region Envio al Correo
            if (dtable.Rows.Count != 0)
            {
                string body = "<h1 style='text-align: center;'> Lista de las cuentas por pagar activas de la Verduleria Querubín.<br>" +
                "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín:</h1><br>" +
                toHTML_Table(tablenew);
                enviarCorreo(correo, body);
            }
            else
            {
                MessageBox.Show("No existen productos registrados en la base de datos del sistema.", "ERROR");
            }
            #endregion

        }
        private void ConsultarCuentaPorPagarProvedor(string correo, string cedula)
        {
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();
            DataTable tablenew = new DataTable();

            using (GestorProveedor servicio = new GestorProveedor())
            {
                dset = servicio.ConsultarCedula(cedula);
                dtable = dset.Tables[0];
            }
            if (dtable.Rows.Count != 0)
            {
                tablenew.Columns.Add("Descripción");
                tablenew.Columns.Add("Fecha de pago");
                tablenew.Columns.Add("Monto");

                DataTable table = new DataTable();
                int ID = int.Parse(dtable.Rows[0]["Proveedor_id"].ToString());

                using (GestorCuentasPorPagar Gestor = new GestorCuentasPorPagar())
                {
                    table = Gestor.ConsultarIdProveedor(ID);
                }

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    object[] o = {
                        table.Rows[i]["CuentasXPagar_Descripcion"].ToString(),
                        table.Rows[i]["CuentasXPagar_FechaPago"].ToString(),
                        table.Rows[i]["CuentasXPagar_Monto"].ToString(),
                    };

                    tablenew.Rows.Add(o);
                }

                #region Envio al Correo
                if (tablenew.Rows.Count != 0)
                {
                    string body = "<h1 style='text-align: center;'>Lista de las cuentas por pagar activos de " + dtable.Rows[0]["Proveedor_NombreORazonSocial"].ToString() + " en la Verduleria Querubín.<br>" +
                    "Estimado(a) esta información es brindada por el sistema de facturación de la Verduleria Querubín: </h1> <br>" +
                    toHTML_Table(tablenew);
                    
                    enviarCorreo(correo, body);
                }
                else
                {
                    MessageBox.Show("No existen cuentas por pagar registradas a ese proveedor en la base de datos del sistema.", "ERROR");
                }
                #endregion
            }
            else
            {
                MessageBox.Show("No existe un proveedor con ese numero de cedula registrado en la base de datos del sistema.", "ERROR");
            }
        }

        private int ValidarCorreo()
        {
            errorProvider1.Clear();
            if (txb_Correo1.Text != "" && txb_Correo2.Text != "")
            {
                return 3;
            }
            else if (txb_Correo1.Text != "" && txb_Correo2.Text == "")
            {
                return 1;
            }
            else if (txb_Correo1.Text == "" && txb_Correo2.Text != "")
            {
                return 2;
            }
            return 0;
        }

        private void btn_numeroFactura_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1 && txb_numeroFactura.Text != "")
            {
                ConsultaFactura(int.Parse(txb_numeroFactura.Text), txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2 && txb_numeroFactura.Text != "")
            {
                ConsultaFactura(int.Parse(txb_numeroFactura.Text), txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3 && txb_numeroFactura.Text != "")
            {
                ConsultaFactura(int.Parse(txb_numeroFactura.Text), txb_Correo1.Text);
                ConsultaFactura(int.Parse(txb_numeroFactura.Text), txb_Correo2.Text);
            }
            else
            {
                if (txb_numeroFactura.Text == "")
                {
                    errorProvider1.SetError(txb_numeroFactura, "Ingresar un numero");
                }
                else
                {
                    errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
                }
            }
        }

        private void btn_cedulaCliente_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1 && txb_cedulaCliente.Text != "")
            {
                ConsultarCliente(txb_Correo1.Text, txb_cedulaCliente.Text);
            }
            else if (ValidarCorreo() == 2 && txb_cedulaCliente.Text != "")
            {
                ConsultarCliente(txb_Correo2.Text, txb_cedulaCliente.Text);
            }
            else if (ValidarCorreo() == 3 && txb_cedulaCliente.Text != "")
            {
                ConsultarCliente(txb_Correo1.Text, txb_cedulaCliente.Text);
                ConsultarCliente(txb_Correo2.Text, txb_cedulaCliente.Text);
            }
            else
            {
                if (txb_cedulaCliente.Text == "")
                {
                    errorProvider1.SetError(txb_cedulaCliente, "Ingresar un numero de cedula");
                }
                else
                {
                    errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
                }
            }
        }

        private void btn_cedulaProveedor_Click(object sender, EventArgs e)
        {
            string tipo = "Cedula";
            if (ckb_codigo.Checked == true)
            {
                tipo = "Codigo";
            }
            if (ValidarCorreo() == 1 && txb_cedulaProveedor.Text != "")
            {
                ConsultarProveedor(txb_Correo1.Text, txb_cedulaProveedor.Text, tipo);
            }
            else if (ValidarCorreo() == 2 && txb_cedulaProveedor.Text != "")
            {
                ConsultarProveedor(txb_Correo2.Text, txb_cedulaProveedor.Text, tipo);
            }
            else if (ValidarCorreo() == 3 && txb_cedulaProveedor.Text != "")
            {
                ConsultarProveedor(txb_Correo1.Text, txb_cedulaProveedor.Text, tipo);
                ConsultarProveedor(txb_Correo2.Text, txb_cedulaProveedor.Text, tipo);
            }
            else
            {
                if (txb_cedulaProveedor.Text == "")
                {
                    errorProvider1.SetError(txb_cedulaProveedor, "Ingresar un numero de cedula");
                }
                else
                {
                    errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
                }
            }
        }

        private void btn_cuentasPorPagar_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1 && txb_cedulaProveedorCPP.Text != "")
            {
                ConsultarCuentaPorPagarProvedor(txb_Correo1.Text, txb_cedulaProveedorCPP.Text);
            }
            else if (ValidarCorreo() == 2 && txb_cedulaProveedorCPP.Text != "")
            {
                ConsultarCuentaPorPagarProvedor(txb_Correo2.Text, txb_cedulaProveedorCPP.Text);
            }
            else if (ValidarCorreo() == 3 && txb_cedulaProveedorCPP.Text != "")
            {
                ConsultarCuentaPorPagarProvedor(txb_Correo1.Text, txb_cedulaProveedorCPP.Text);
                ConsultarCuentaPorPagarProvedor(txb_Correo2.Text, txb_cedulaProveedorCPP.Text);
            }
            else
            {
                if (txb_cedulaProveedorCPP.Text == "")
                {
                    errorProvider1.SetError(txb_cedulaProveedorCPP, "Ingresar un numero de cedula");
                }
                else
                {
                    errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
                }
            }
        }

        private void btn_reporteClientes_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1)
            {
                ConsultarClientes(txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2)
            {
                ConsultarClientes(txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3)
            {
                ConsultarClientes(txb_Correo1.Text);
                ConsultarClientes(txb_Correo2.Text);
            }
            else
            {
                errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
            }
        }

        private void btn_reporteProveedores_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1)
            {
                ConsultarProveedores(txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2)
            {
                ConsultarProveedores(txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3)
            {
                ConsultarProveedores(txb_Correo1.Text);
                ConsultarProveedores(txb_Correo2.Text);
            }
            else
            {
                errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
            }
        }

        private void btn_reporteProductos_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1)
            {
                ConsultarProductos(txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2)
            {
                ConsultarProductos(txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3)
            {
                ConsultarProductos(txb_Correo1.Text);
                ConsultarProductos(txb_Correo2.Text);
            }
            else
            {
                errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
            }
        }

        private void btn_reporteInventarioLocal_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1)
            {
                ConsultarInventarioLocal(txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2)
            {
                ConsultarInventarioLocal(txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3)
            {
                ConsultarInventarioLocal(txb_Correo1.Text);
                ConsultarInventarioLocal(txb_Correo2.Text);
            }
            else
            {
                errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
            }
        }

        private void btn_reporteInventarioBodega_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1)
            {
                ConsultarInventarioBodega(txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2)
            {
                ConsultarInventarioBodega(txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3)
            {
                ConsultarInventarioBodega(txb_Correo1.Text);
                ConsultarInventarioBodega(txb_Correo2.Text);
            }
            else
            {
                errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
            }
        }

        private void btn_reporteCuentasPorPagar_Click(object sender, EventArgs e)
        {
            if (ValidarCorreo() == 1)
            {
                ConsultarCuentasPorPagar(txb_Correo1.Text);
            }
            else if (ValidarCorreo() == 2)
            {
                ConsultarCuentasPorPagar(txb_Correo2.Text);
            }
            else if (ValidarCorreo() == 3)
            {
                ConsultarCuentasPorPagar(txb_Correo1.Text);
                ConsultarCuentasPorPagar(txb_Correo2.Text);
            }
            else
            {
                errorProvider1.SetError(txb_Correo1, "Ingresar un correo");
            }
        }

        private void txb_numeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47))
            {
                e.Handled = true;
                return;
            }
        }
    }
}

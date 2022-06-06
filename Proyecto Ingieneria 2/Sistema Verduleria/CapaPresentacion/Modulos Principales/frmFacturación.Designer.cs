namespace CapaPresentacion.Modulos
{
    partial class frmFacturación
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturación));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_articulosFactura = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtb_subtotal = new System.Windows.Forms.TextBox();
            this.txtb_descuento = new System.Windows.Forms.TextBox();
            this.txtb_impuesto = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txtb_total = new System.Windows.Forms.TextBox();
            this.btn_EliminarFactura = new FontAwesome.Sharp.IconButton();
            this.btn_AgregarCliente = new FontAwesome.Sharp.IconButton();
            this.btn_Pagar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.txtb_filtrar = new System.Windows.Forms.TextBox();
            this.txtb_descuentoGeneral = new System.Windows.Forms.TextBox();
            this.txtb_cantidadFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_filtrar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbr_observaciones = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_productoFactura = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtb_pesoFactura = new System.Windows.Forms.TextBox();
            this.txtb_precioFactura = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_editarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_eliminarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_limpiarProductoFactura = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtb_pesoProducto = new System.Windows.Forms.TextBox();
            this.txtb_precioVentaProducto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_agregarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_limpiarProducto = new FontAwesome.Sharp.IconButton();
            this.txtb_productoProducto = new System.Windows.Forms.TextBox();
            this.txtb_cantidadProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckb_familiaFiltrar = new System.Windows.Forms.CheckBox();
            this.ckb_productoFiltrar = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_cliente = new System.Windows.Forms.ComboBox();
            this.txb_filtrarCliente = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.txb_Correo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulosFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dgv_articulosFactura
            // 
            this.dgv_articulosFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_articulosFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_articulosFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_articulosFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_articulosFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_articulosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulosFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_articulosFactura.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_articulosFactura.Location = new System.Drawing.Point(8, 121);
            this.dgv_articulosFactura.Name = "dgv_articulosFactura";
            this.dgv_articulosFactura.Size = new System.Drawing.Size(480, 262);
            this.dgv_articulosFactura.TabIndex = 3;
            this.dgv_articulosFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_articulosFactura_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Subtotal";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Descuento";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Impuesto";
            // 
            // txtb_subtotal
            // 
            this.txtb_subtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_subtotal.Enabled = false;
            this.txtb_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_subtotal.Location = new System.Drawing.Point(86, 422);
            this.txtb_subtotal.Name = "txtb_subtotal";
            this.txtb_subtotal.Size = new System.Drawing.Size(80, 20);
            this.txtb_subtotal.TabIndex = 13;
            this.txtb_subtotal.Text = "0";
            this.txtb_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtb_descuento
            // 
            this.txtb_descuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_descuento.Enabled = false;
            this.txtb_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_descuento.Location = new System.Drawing.Point(86, 449);
            this.txtb_descuento.Name = "txtb_descuento";
            this.txtb_descuento.Size = new System.Drawing.Size(80, 20);
            this.txtb_descuento.TabIndex = 14;
            this.txtb_descuento.Text = "0";
            this.txtb_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtb_impuesto
            // 
            this.txtb_impuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_impuesto.Enabled = false;
            this.txtb_impuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_impuesto.Location = new System.Drawing.Point(86, 474);
            this.txtb_impuesto.Name = "txtb_impuesto";
            this.txtb_impuesto.Size = new System.Drawing.Size(80, 20);
            this.txtb_impuesto.TabIndex = 15;
            this.txtb_impuesto.Text = "0";
            this.txtb_impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(12, 503);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(36, 13);
            this.lbl_Total.TabIndex = 16;
            this.lbl_Total.Text = "Total";
            // 
            // txtb_total
            // 
            this.txtb_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_total.Enabled = false;
            this.txtb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_total.Location = new System.Drawing.Point(86, 500);
            this.txtb_total.Name = "txtb_total";
            this.txtb_total.Size = new System.Drawing.Size(80, 20);
            this.txtb_total.TabIndex = 17;
            this.txtb_total.Text = "0";
            this.txtb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_EliminarFactura
            // 
            this.btn_EliminarFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EliminarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_EliminarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_EliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EliminarFactura.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarFactura.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_EliminarFactura.IconColor = System.Drawing.Color.White;
            this.btn_EliminarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EliminarFactura.IconSize = 30;
            this.btn_EliminarFactura.Location = new System.Drawing.Point(258, 389);
            this.btn_EliminarFactura.Name = "btn_EliminarFactura";
            this.btn_EliminarFactura.Size = new System.Drawing.Size(227, 30);
            this.btn_EliminarFactura.TabIndex = 36;
            this.btn_EliminarFactura.Text = "Eliminar Factura";
            this.btn_EliminarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EliminarFactura.UseVisualStyleBackColor = false;
            this.btn_EliminarFactura.Click += new System.EventHandler(this.btn_EliminarFactura_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_AgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_AgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_AgregarCliente.IconColor = System.Drawing.Color.White;
            this.btn_AgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AgregarCliente.Location = new System.Drawing.Point(380, 41);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(108, 36);
            this.btn_AgregarCliente.TabIndex = 35;
            this.btn_AgregarCliente.Text = "Agregar Cliente";
            this.btn_AgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AgregarCliente.UseVisualStyleBackColor = false;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Pagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pagar.ForeColor = System.Drawing.Color.White;
            this.btn_Pagar.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btn_Pagar.IconColor = System.Drawing.Color.White;
            this.btn_Pagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Pagar.IconSize = 30;
            this.btn_Pagar.Location = new System.Drawing.Point(6, 389);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(229, 30);
            this.btn_Pagar.TabIndex = 33;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pagar.UseVisualStyleBackColor = false;
            this.btn_Pagar.Click += new System.EventHandler(this.btn_Pagar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(175, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Desc General";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cliente";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Productos.Location = new System.Drawing.Point(1, 32);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.Size = new System.Drawing.Size(590, 374);
            this.dgv_Productos.TabIndex = 37;
            this.dgv_Productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellDoubleClick);
            // 
            // txtb_filtrar
            // 
            this.txtb_filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_filtrar.Location = new System.Drawing.Point(356, 5);
            this.txtb_filtrar.Name = "txtb_filtrar";
            this.txtb_filtrar.Size = new System.Drawing.Size(159, 20);
            this.txtb_filtrar.TabIndex = 38;
            this.txtb_filtrar.TextChanged += new System.EventHandler(this.txtb_filtrar_TextChanged);
            // 
            // txtb_descuentoGeneral
            // 
            this.txtb_descuentoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_descuentoGeneral.Location = new System.Drawing.Point(267, 98);
            this.txtb_descuentoGeneral.Name = "txtb_descuentoGeneral";
            this.txtb_descuentoGeneral.Size = new System.Drawing.Size(81, 20);
            this.txtb_descuentoGeneral.TabIndex = 40;
            this.txtb_descuentoGeneral.TextChanged += new System.EventHandler(this.txtb_descuentoGeneral_TextChanged);
            // 
            // txtb_cantidadFactura
            // 
            this.txtb_cantidadFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_cantidadFactura.Location = new System.Drawing.Point(5, 59);
            this.txtb_cantidadFactura.Name = "txtb_cantidadFactura";
            this.txtb_cantidadFactura.Size = new System.Drawing.Size(141, 20);
            this.txtb_cantidadFactura.TabIndex = 41;
            this.txtb_cantidadFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_cantidadFactura_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(2, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cantidad";
            // 
            // cbx_filtrar
            // 
            this.cbx_filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_filtrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filtrar.FormattingEnabled = true;
            this.cbx_filtrar.Location = new System.Drawing.Point(175, 5);
            this.cbx_filtrar.Name = "cbx_filtrar";
            this.cbx_filtrar.Size = new System.Drawing.Size(90, 21);
            this.cbx_filtrar.TabIndex = 44;
            this.cbx_filtrar.SelectionChangeCommitted += new System.EventHandler(this.cbx_filtrar_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Observaciones";
            // 
            // txtbr_observaciones
            // 
            this.txtbr_observaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbr_observaciones.Location = new System.Drawing.Point(8, 46);
            this.txtbr_observaciones.MaxLength = 150;
            this.txtbr_observaciones.Name = "txtbr_observaciones";
            this.txtbr_observaciones.Size = new System.Drawing.Size(220, 36);
            this.txtbr_observaciones.TabIndex = 46;
            this.txtbr_observaciones.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "FACTURA";
            // 
            // txtb_productoFactura
            // 
            this.txtb_productoFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_productoFactura.Enabled = false;
            this.txtb_productoFactura.Location = new System.Drawing.Point(4, 20);
            this.txtb_productoFactura.Name = "txtb_productoFactura";
            this.txtb_productoFactura.Size = new System.Drawing.Size(141, 20);
            this.txtb_productoFactura.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtb_pesoFactura);
            this.panel1.Controls.Add(this.txtb_precioFactura);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btn_editarProducto);
            this.panel1.Controls.Add(this.btn_eliminarProducto);
            this.panel1.Controls.Add(this.btn_limpiarProductoFactura);
            this.panel1.Controls.Add(this.txtb_productoFactura);
            this.panel1.Controls.Add(this.txtb_cantidadFactura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(172, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 100);
            this.panel1.TabIndex = 49;
            // 
            // txtb_pesoFactura
            // 
            this.txtb_pesoFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_pesoFactura.Enabled = false;
            this.txtb_pesoFactura.Location = new System.Drawing.Point(154, 61);
            this.txtb_pesoFactura.Name = "txtb_pesoFactura";
            this.txtb_pesoFactura.Size = new System.Drawing.Size(86, 20);
            this.txtb_pesoFactura.TabIndex = 55;
            // 
            // txtb_precioFactura
            // 
            this.txtb_precioFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_precioFactura.Enabled = false;
            this.txtb_precioFactura.Location = new System.Drawing.Point(154, 22);
            this.txtb_precioFactura.Name = "txtb_precioFactura";
            this.txtb_precioFactura.Size = new System.Drawing.Size(86, 20);
            this.txtb_precioFactura.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(154, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Peso";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(151, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Precio de venta";
            // 
            // btn_editarProducto
            // 
            this.btn_editarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_editarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_editarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_editarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_editarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_editarProducto.IconColor = System.Drawing.Color.Black;
            this.btn_editarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editarProducto.Location = new System.Drawing.Point(249, 6);
            this.btn_editarProducto.Name = "btn_editarProducto";
            this.btn_editarProducto.Size = new System.Drawing.Size(62, 23);
            this.btn_editarProducto.TabIndex = 51;
            this.btn_editarProducto.Text = "Editar";
            this.btn_editarProducto.UseVisualStyleBackColor = false;
            this.btn_editarProducto.Click += new System.EventHandler(this.btn_editarProducto_Click);
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_eliminarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_eliminarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_eliminarProducto.IconColor = System.Drawing.Color.Black;
            this.btn_eliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminarProducto.Location = new System.Drawing.Point(249, 64);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(62, 23);
            this.btn_eliminarProducto.TabIndex = 50;
            this.btn_eliminarProducto.Text = "Eliminar";
            this.btn_eliminarProducto.UseVisualStyleBackColor = false;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.btn_eliminarProducto_Click);
            // 
            // btn_limpiarProductoFactura
            // 
            this.btn_limpiarProductoFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_limpiarProductoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_limpiarProductoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpiarProductoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_limpiarProductoFactura.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpiarProductoFactura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_limpiarProductoFactura.IconColor = System.Drawing.Color.Black;
            this.btn_limpiarProductoFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiarProductoFactura.Location = new System.Drawing.Point(249, 35);
            this.btn_limpiarProductoFactura.Name = "btn_limpiarProductoFactura";
            this.btn_limpiarProductoFactura.Size = new System.Drawing.Size(62, 23);
            this.btn_limpiarProductoFactura.TabIndex = 49;
            this.btn_limpiarProductoFactura.Text = "Limpiar";
            this.btn_limpiarProductoFactura.UseVisualStyleBackColor = false;
            this.btn_limpiarProductoFactura.Click += new System.EventHandler(this.btn_limpiarProductoFactura_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtb_pesoProducto);
            this.panel2.Controls.Add(this.txtb_precioVentaProducto);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btn_agregarProducto);
            this.panel2.Controls.Add(this.btn_limpiarProducto);
            this.panel2.Controls.Add(this.txtb_productoProducto);
            this.panel2.Controls.Add(this.txtb_cantidadProducto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(497, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 100);
            this.panel2.TabIndex = 52;
            // 
            // txtb_pesoProducto
            // 
            this.txtb_pesoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_pesoProducto.Enabled = false;
            this.txtb_pesoProducto.Location = new System.Drawing.Point(434, 58);
            this.txtb_pesoProducto.Name = "txtb_pesoProducto";
            this.txtb_pesoProducto.Size = new System.Drawing.Size(141, 20);
            this.txtb_pesoProducto.TabIndex = 59;
            // 
            // txtb_precioVentaProducto
            // 
            this.txtb_precioVentaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_precioVentaProducto.Enabled = false;
            this.txtb_precioVentaProducto.Location = new System.Drawing.Point(434, 20);
            this.txtb_precioVentaProducto.Name = "txtb_precioVentaProducto";
            this.txtb_precioVentaProducto.Size = new System.Drawing.Size(141, 20);
            this.txtb_precioVentaProducto.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(431, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Peso";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(431, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Precio de venta";
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_agregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_agregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_agregarProducto.IconColor = System.Drawing.Color.Black;
            this.btn_agregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregarProducto.Location = new System.Drawing.Point(153, 20);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(100, 58);
            this.btn_agregarProducto.TabIndex = 55;
            this.btn_agregarProducto.Text = "Agregar";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // btn_limpiarProducto
            // 
            this.btn_limpiarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_limpiarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_limpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpiarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_limpiarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpiarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_limpiarProducto.IconColor = System.Drawing.Color.Black;
            this.btn_limpiarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiarProducto.Location = new System.Drawing.Point(325, 20);
            this.btn_limpiarProducto.Name = "btn_limpiarProducto";
            this.btn_limpiarProducto.Size = new System.Drawing.Size(100, 58);
            this.btn_limpiarProducto.TabIndex = 54;
            this.btn_limpiarProducto.Text = "Limpiar";
            this.btn_limpiarProducto.UseVisualStyleBackColor = false;
            this.btn_limpiarProducto.Click += new System.EventHandler(this.btn_limpiarProducto_Click);
            // 
            // txtb_productoProducto
            // 
            this.txtb_productoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_productoProducto.Enabled = false;
            this.txtb_productoProducto.Location = new System.Drawing.Point(6, 20);
            this.txtb_productoProducto.Name = "txtb_productoProducto";
            this.txtb_productoProducto.Size = new System.Drawing.Size(141, 20);
            this.txtb_productoProducto.TabIndex = 48;
            // 
            // txtb_cantidadProducto
            // 
            this.txtb_cantidadProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtb_cantidadProducto.Location = new System.Drawing.Point(5, 58);
            this.txtb_cantidadProducto.Name = "txtb_cantidadProducto";
            this.txtb_cantidadProducto.Size = new System.Drawing.Size(141, 20);
            this.txtb_cantidadProducto.TabIndex = 41;
            this.txtb_cantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_cantidadProducto_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Producto";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ckb_familiaFiltrar);
            this.panel3.Controls.Add(this.ckb_productoFiltrar);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtb_filtrar);
            this.panel3.Controls.Add(this.dgv_Productos);
            this.panel3.Controls.Add(this.cbx_filtrar);
            this.panel3.Location = new System.Drawing.Point(494, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 411);
            this.panel3.TabIndex = 53;
            // 
            // ckb_familiaFiltrar
            // 
            this.ckb_familiaFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckb_familiaFiltrar.AutoSize = true;
            this.ckb_familiaFiltrar.Location = new System.Drawing.Point(154, 8);
            this.ckb_familiaFiltrar.Name = "ckb_familiaFiltrar";
            this.ckb_familiaFiltrar.Size = new System.Drawing.Size(15, 14);
            this.ckb_familiaFiltrar.TabIndex = 54;
            this.ckb_familiaFiltrar.UseVisualStyleBackColor = true;
            this.ckb_familiaFiltrar.CheckedChanged += new System.EventHandler(this.ckb_familiaFiltrar_CheckedChanged);
            // 
            // ckb_productoFiltrar
            // 
            this.ckb_productoFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckb_productoFiltrar.AutoSize = true;
            this.ckb_productoFiltrar.Location = new System.Drawing.Point(335, 8);
            this.ckb_productoFiltrar.Name = "ckb_productoFiltrar";
            this.ckb_productoFiltrar.Size = new System.Drawing.Size(15, 14);
            this.ckb_productoFiltrar.TabIndex = 53;
            this.ckb_productoFiltrar.UseVisualStyleBackColor = true;
            this.ckb_productoFiltrar.CheckedChanged += new System.EventHandler(this.ckb_productoFiltrar_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(30, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Familia de producto";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(271, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Producto";
            // 
            // cbx_cliente
            // 
            this.cbx_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cliente.FormattingEnabled = true;
            this.cbx_cliente.Location = new System.Drawing.Point(57, 3);
            this.cbx_cliente.Name = "cbx_cliente";
            this.cbx_cliente.Size = new System.Drawing.Size(291, 21);
            this.cbx_cliente.TabIndex = 54;
            // 
            // txb_filtrarCliente
            // 
            this.txb_filtrarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_filtrarCliente.Location = new System.Drawing.Point(355, 4);
            this.txb_filtrarCliente.Name = "txb_filtrarCliente";
            this.txb_filtrarCliente.Size = new System.Drawing.Size(111, 20);
            this.txb_filtrarCliente.TabIndex = 55;
            this.txb_filtrarCliente.TextChanged += new System.EventHandler(this.txb_filtrarCliente_TextChanged);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 19;
            this.iconPictureBox2.Location = new System.Drawing.Point(469, 6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(19, 29);
            this.iconPictureBox2.TabIndex = 56;
            this.iconPictureBox2.TabStop = false;
            // 
            // txb_Correo
            // 
            this.txb_Correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Correo.Location = new System.Drawing.Point(237, 46);
            this.txb_Correo.Name = "txb_Correo";
            this.txb_Correo.Size = new System.Drawing.Size(125, 20);
            this.txb_Correo.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(234, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Correo electrónico";
            // 
            // frmFacturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1095, 524);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txb_Correo);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.txb_filtrarCliente);
            this.Controls.Add(this.cbx_cliente);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbr_observaciones);
            this.Controls.Add(this.txtb_descuentoGeneral);
            this.Controls.Add(this.btn_EliminarFactura);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.txtb_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtb_subtotal);
            this.Controls.Add(this.txtb_descuento);
            this.Controls.Add(this.txtb_impuesto);
            this.Controls.Add(this.dgv_articulosFactura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACIÓN";
            this.Load += new System.EventHandler(this.frmFacturación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulosFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_articulosFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtb_subtotal;
        private System.Windows.Forms.TextBox txtb_descuento;
        private System.Windows.Forms.TextBox txtb_impuesto;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txtb_total;
        private FontAwesome.Sharp.IconButton btn_EliminarFactura;
        private FontAwesome.Sharp.IconButton btn_AgregarCliente;
        private FontAwesome.Sharp.IconButton btn_Pagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.TextBox txtb_filtrar;
        private System.Windows.Forms.TextBox txtb_descuentoGeneral;
        private System.Windows.Forms.TextBox txtb_cantidadFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_filtrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtbr_observaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_productoFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtb_productoProducto;
        private System.Windows.Forms.TextBox txtb_cantidadProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_editarProducto;
        private FontAwesome.Sharp.IconButton btn_eliminarProducto;
        private FontAwesome.Sharp.IconButton btn_limpiarProductoFactura;
        private FontAwesome.Sharp.IconButton btn_agregarProducto;
        private FontAwesome.Sharp.IconButton btn_limpiarProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckb_familiaFiltrar;
        private System.Windows.Forms.CheckBox ckb_productoFiltrar;
        private System.Windows.Forms.ComboBox cbx_cliente;
        private System.Windows.Forms.TextBox txb_filtrarCliente;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtb_pesoProducto;
        private System.Windows.Forms.TextBox txtb_precioVentaProducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtb_pesoFactura;
        private System.Windows.Forms.TextBox txtb_precioFactura;
        private System.Windows.Forms.TextBox txb_Correo;
        private System.Windows.Forms.Label label19;
    }
}
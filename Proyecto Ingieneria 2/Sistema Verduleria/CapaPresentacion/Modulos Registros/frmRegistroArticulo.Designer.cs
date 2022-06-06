namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroArticulo
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
            this.components = new System.ComponentModel.Container();
            this.panel_supArticulo = new System.Windows.Forms.Panel();
            this.lblclientes_Titulo = new System.Windows.Forms.Label();
            this.chbListarI = new System.Windows.Forms.CheckBox();
            this.panel_infArticulo = new System.Windows.Forms.Panel();
            this.BtnArticulo_Eliminar = new System.Windows.Forms.Button();
            this.txbArticulo_Descripcion = new System.Windows.Forms.RichTextBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.btnArticulo_Modificar = new System.Windows.Forms.Button();
            this.btnArticulo_Limpiar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txbArticulo_Precio = new System.Windows.Forms.TextBox();
            this.txbArticulo_Descuentos = new System.Windows.Forms.TextBox();
            this.cbxArticulo_UnidadesMedidaID = new System.Windows.Forms.ComboBox();
            this.cbxArticulo_FamiliaID = new System.Windows.Forms.ComboBox();
            this.lblArticulo_Descuento = new System.Windows.Forms.Label();
            this.txbArticulo_Peso = new System.Windows.Forms.TextBox();
            this.lblArticulo_Peso = new System.Windows.Forms.Label();
            this.lblArticulo_Descripcion = new System.Windows.Forms.Label();
            this.txbArticulo_Codigo = new System.Windows.Forms.TextBox();
            this.lblArticulo_Codigo = new System.Windows.Forms.Label();
            this.txbArticulo_Producto = new System.Windows.Forms.TextBox();
            this.lblArticulo_Nombre = new System.Windows.Forms.Label();
            this.txbArticulo_Impuesto = new System.Windows.Forms.TextBox();
            this.lblArticulo_Impuesto = new System.Windows.Forms.Label();
            this.lblArticulo_FamiliaID = new System.Windows.Forms.Label();
            this.lblArticulo_UnidadesMedidaID = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnArticulo_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supArticulo.SuspendLayout();
            this.panel_infArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supArticulo
            // 
            this.panel_supArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supArticulo.Controls.Add(this.lblclientes_Titulo);
            this.panel_supArticulo.Controls.Add(this.chbListarI);
            this.panel_supArticulo.Location = new System.Drawing.Point(0, 0);
            this.panel_supArticulo.Name = "panel_supArticulo";
            this.panel_supArticulo.Size = new System.Drawing.Size(1095, 65);
            this.panel_supArticulo.TabIndex = 0;
            // 
            // lblclientes_Titulo
            // 
            this.lblclientes_Titulo.AutoSize = true;
            this.lblclientes_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientes_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblclientes_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblclientes_Titulo.Name = "lblclientes_Titulo";
            this.lblclientes_Titulo.Size = new System.Drawing.Size(380, 44);
            this.lblclientes_Titulo.TabIndex = 73;
            this.lblclientes_Titulo.Text = "Registro de artículos";
            // 
            // chbListarI
            // 
            this.chbListarI.AutoSize = true;
            this.chbListarI.ForeColor = System.Drawing.Color.White;
            this.chbListarI.Location = new System.Drawing.Point(996, 45);
            this.chbListarI.Name = "chbListarI";
            this.chbListarI.Size = new System.Drawing.Size(96, 17);
            this.chbListarI.TabIndex = 125;
            this.chbListarI.Text = "Listar inactivos";
            this.chbListarI.UseVisualStyleBackColor = true;
            this.chbListarI.CheckedChanged += new System.EventHandler(this.chbListarI_CheckedChanged);
            // 
            // panel_infArticulo
            // 
            this.panel_infArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infArticulo.AutoSize = true;
            this.panel_infArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infArticulo.Controls.Add(this.BtnArticulo_Eliminar);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Descripcion);
            this.panel_infArticulo.Controls.Add(this.chbActivo);
            this.panel_infArticulo.Controls.Add(this.btnArticulo_Modificar);
            this.panel_infArticulo.Controls.Add(this.btnArticulo_Limpiar);
            this.panel_infArticulo.Controls.Add(this.lblPrecio);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Precio);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Descuentos);
            this.panel_infArticulo.Controls.Add(this.cbxArticulo_UnidadesMedidaID);
            this.panel_infArticulo.Controls.Add(this.cbxArticulo_FamiliaID);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_Descuento);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Peso);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_Peso);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_Descripcion);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Codigo);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_Codigo);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Producto);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_Nombre);
            this.panel_infArticulo.Controls.Add(this.txbArticulo_Impuesto);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_Impuesto);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_FamiliaID);
            this.panel_infArticulo.Controls.Add(this.lblArticulo_UnidadesMedidaID);
            this.panel_infArticulo.Controls.Add(this.dgvArticulos);
            this.panel_infArticulo.Controls.Add(this.btnArticulo_Insertar);
            this.panel_infArticulo.Location = new System.Drawing.Point(0, 65);
            this.panel_infArticulo.Name = "panel_infArticulo";
            this.panel_infArticulo.Size = new System.Drawing.Size(1095, 436);
            this.panel_infArticulo.TabIndex = 1;
            // 
            // BtnArticulo_Eliminar
            // 
            this.BtnArticulo_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.BtnArticulo_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArticulo_Eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnArticulo_Eliminar.Location = new System.Drawing.Point(187, 349);
            this.BtnArticulo_Eliminar.Name = "BtnArticulo_Eliminar";
            this.BtnArticulo_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnArticulo_Eliminar.TabIndex = 127;
            this.BtnArticulo_Eliminar.Text = "Eliminar";
            this.BtnArticulo_Eliminar.UseVisualStyleBackColor = false;
            this.BtnArticulo_Eliminar.Click += new System.EventHandler(this.BtnArticulo_Eliminar_Click);
            // 
            // txbArticulo_Descripcion
            // 
            this.txbArticulo_Descripcion.Location = new System.Drawing.Point(127, 112);
            this.txbArticulo_Descripcion.MaxLength = 100;
            this.txbArticulo_Descripcion.Name = "txbArticulo_Descripcion";
            this.txbArticulo_Descripcion.Size = new System.Drawing.Size(135, 40);
            this.txbArticulo_Descripcion.TabIndex = 4;
            this.txbArticulo_Descripcion.Text = "";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.ForeColor = System.Drawing.Color.White;
            this.chbActivo.Location = new System.Drawing.Point(14, 262);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 126;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // btnArticulo_Modificar
            // 
            this.btnArticulo_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnArticulo_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulo_Modificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArticulo_Modificar.Location = new System.Drawing.Point(186, 320);
            this.btnArticulo_Modificar.Name = "btnArticulo_Modificar";
            this.btnArticulo_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnArticulo_Modificar.TabIndex = 11;
            this.btnArticulo_Modificar.Text = "Modificar";
            this.btnArticulo_Modificar.UseVisualStyleBackColor = false;
            this.btnArticulo_Modificar.Click += new System.EventHandler(this.btnArticulo_Modificar_Click);
            // 
            // btnArticulo_Limpiar
            // 
            this.btnArticulo_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnArticulo_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulo_Limpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArticulo_Limpiar.Location = new System.Drawing.Point(187, 291);
            this.btnArticulo_Limpiar.Name = "btnArticulo_Limpiar";
            this.btnArticulo_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btnArticulo_Limpiar.TabIndex = 10;
            this.btnArticulo_Limpiar.Text = "Limpiar";
            this.btnArticulo_Limpiar.UseVisualStyleBackColor = false;
            this.btnArticulo_Limpiar.Click += new System.EventHandler(this.btnArticulo_Limpiar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(11, 161);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 122;
            this.lblPrecio.Text = "Precio";
            // 
            // txbArticulo_Precio
            // 
            this.txbArticulo_Precio.Location = new System.Drawing.Point(127, 158);
            this.txbArticulo_Precio.Name = "txbArticulo_Precio";
            this.txbArticulo_Precio.Size = new System.Drawing.Size(135, 20);
            this.txbArticulo_Precio.TabIndex = 5;
            this.txbArticulo_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbArticulo_Precio_KeyPress);
            // 
            // txbArticulo_Descuentos
            // 
            this.txbArticulo_Descuentos.Location = new System.Drawing.Point(127, 210);
            this.txbArticulo_Descuentos.Name = "txbArticulo_Descuentos";
            this.txbArticulo_Descuentos.Size = new System.Drawing.Size(135, 20);
            this.txbArticulo_Descuentos.TabIndex = 7;
            this.txbArticulo_Descuentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbArticulo_Descuentos_KeyPress);
            // 
            // cbxArticulo_UnidadesMedidaID
            // 
            this.cbxArticulo_UnidadesMedidaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticulo_UnidadesMedidaID.FormattingEnabled = true;
            this.cbxArticulo_UnidadesMedidaID.Location = new System.Drawing.Point(128, 33);
            this.cbxArticulo_UnidadesMedidaID.Name = "cbxArticulo_UnidadesMedidaID";
            this.cbxArticulo_UnidadesMedidaID.Size = new System.Drawing.Size(135, 21);
            this.cbxArticulo_UnidadesMedidaID.TabIndex = 1;
            // 
            // cbxArticulo_FamiliaID
            // 
            this.cbxArticulo_FamiliaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticulo_FamiliaID.FormattingEnabled = true;
            this.cbxArticulo_FamiliaID.Location = new System.Drawing.Point(128, 6);
            this.cbxArticulo_FamiliaID.Name = "cbxArticulo_FamiliaID";
            this.cbxArticulo_FamiliaID.Size = new System.Drawing.Size(135, 21);
            this.cbxArticulo_FamiliaID.TabIndex = 0;
            // 
            // lblArticulo_Descuento
            // 
            this.lblArticulo_Descuento.AutoSize = true;
            this.lblArticulo_Descuento.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Descuento.Location = new System.Drawing.Point(11, 213);
            this.lblArticulo_Descuento.Name = "lblArticulo_Descuento";
            this.lblArticulo_Descuento.Size = new System.Drawing.Size(59, 13);
            this.lblArticulo_Descuento.TabIndex = 114;
            this.lblArticulo_Descuento.Text = "Descuento";
            // 
            // txbArticulo_Peso
            // 
            this.txbArticulo_Peso.Location = new System.Drawing.Point(127, 184);
            this.txbArticulo_Peso.Name = "txbArticulo_Peso";
            this.txbArticulo_Peso.Size = new System.Drawing.Size(135, 20);
            this.txbArticulo_Peso.TabIndex = 6;
            this.txbArticulo_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbArticulo_Peso_KeyPress);
            // 
            // lblArticulo_Peso
            // 
            this.lblArticulo_Peso.AutoSize = true;
            this.lblArticulo_Peso.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Peso.Location = new System.Drawing.Point(11, 187);
            this.lblArticulo_Peso.Name = "lblArticulo_Peso";
            this.lblArticulo_Peso.Size = new System.Drawing.Size(31, 13);
            this.lblArticulo_Peso.TabIndex = 112;
            this.lblArticulo_Peso.Text = "Peso";
            // 
            // lblArticulo_Descripcion
            // 
            this.lblArticulo_Descripcion.AutoSize = true;
            this.lblArticulo_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Descripcion.Location = new System.Drawing.Point(12, 115);
            this.lblArticulo_Descripcion.Name = "lblArticulo_Descripcion";
            this.lblArticulo_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lblArticulo_Descripcion.TabIndex = 110;
            this.lblArticulo_Descripcion.Text = "Descripción";
            // 
            // txbArticulo_Codigo
            // 
            this.txbArticulo_Codigo.Location = new System.Drawing.Point(128, 86);
            this.txbArticulo_Codigo.MaxLength = 10;
            this.txbArticulo_Codigo.Name = "txbArticulo_Codigo";
            this.txbArticulo_Codigo.Size = new System.Drawing.Size(135, 20);
            this.txbArticulo_Codigo.TabIndex = 3;
            // 
            // lblArticulo_Codigo
            // 
            this.lblArticulo_Codigo.AutoSize = true;
            this.lblArticulo_Codigo.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Codigo.Location = new System.Drawing.Point(12, 89);
            this.lblArticulo_Codigo.Name = "lblArticulo_Codigo";
            this.lblArticulo_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lblArticulo_Codigo.TabIndex = 108;
            this.lblArticulo_Codigo.Text = "Código";
            // 
            // txbArticulo_Producto
            // 
            this.txbArticulo_Producto.AccessibleDescription = "";
            this.txbArticulo_Producto.AccessibleName = "";
            this.txbArticulo_Producto.Location = new System.Drawing.Point(128, 60);
            this.txbArticulo_Producto.MaxLength = 50;
            this.txbArticulo_Producto.Name = "txbArticulo_Producto";
            this.txbArticulo_Producto.Size = new System.Drawing.Size(135, 20);
            this.txbArticulo_Producto.TabIndex = 2;
            this.txbArticulo_Producto.Tag = "";
            // 
            // lblArticulo_Nombre
            // 
            this.lblArticulo_Nombre.AutoSize = true;
            this.lblArticulo_Nombre.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Nombre.Location = new System.Drawing.Point(12, 63);
            this.lblArticulo_Nombre.Name = "lblArticulo_Nombre";
            this.lblArticulo_Nombre.Size = new System.Drawing.Size(50, 13);
            this.lblArticulo_Nombre.TabIndex = 106;
            this.lblArticulo_Nombre.Text = "Producto";
            // 
            // txbArticulo_Impuesto
            // 
            this.txbArticulo_Impuesto.Location = new System.Drawing.Point(127, 236);
            this.txbArticulo_Impuesto.Name = "txbArticulo_Impuesto";
            this.txbArticulo_Impuesto.Size = new System.Drawing.Size(135, 20);
            this.txbArticulo_Impuesto.TabIndex = 8;
            this.txbArticulo_Impuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbArticulo_Impuesto_KeyPress);
            // 
            // lblArticulo_Impuesto
            // 
            this.lblArticulo_Impuesto.AutoSize = true;
            this.lblArticulo_Impuesto.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Impuesto.Location = new System.Drawing.Point(11, 239);
            this.lblArticulo_Impuesto.Name = "lblArticulo_Impuesto";
            this.lblArticulo_Impuesto.Size = new System.Drawing.Size(50, 13);
            this.lblArticulo_Impuesto.TabIndex = 104;
            this.lblArticulo_Impuesto.Text = "Impuesto";
            // 
            // lblArticulo_FamiliaID
            // 
            this.lblArticulo_FamiliaID.AutoSize = true;
            this.lblArticulo_FamiliaID.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_FamiliaID.Location = new System.Drawing.Point(12, 9);
            this.lblArticulo_FamiliaID.Name = "lblArticulo_FamiliaID";
            this.lblArticulo_FamiliaID.Size = new System.Drawing.Size(104, 13);
            this.lblArticulo_FamiliaID.TabIndex = 100;
            this.lblArticulo_FamiliaID.Text = "Familia de productos";
            // 
            // lblArticulo_UnidadesMedidaID
            // 
            this.lblArticulo_UnidadesMedidaID.AutoSize = true;
            this.lblArticulo_UnidadesMedidaID.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_UnidadesMedidaID.Location = new System.Drawing.Point(12, 36);
            this.lblArticulo_UnidadesMedidaID.Name = "lblArticulo_UnidadesMedidaID";
            this.lblArticulo_UnidadesMedidaID.Size = new System.Drawing.Size(93, 13);
            this.lblArticulo_UnidadesMedidaID.TabIndex = 98;
            this.lblArticulo_UnidadesMedidaID.Text = "Unidad de medida";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.Location = new System.Drawing.Point(269, 6);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(821, 426);
            this.dgvArticulos.TabIndex = 12;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // btnArticulo_Insertar
            // 
            this.btnArticulo_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnArticulo_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulo_Insertar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArticulo_Insertar.Location = new System.Drawing.Point(187, 262);
            this.btnArticulo_Insertar.Name = "btnArticulo_Insertar";
            this.btnArticulo_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnArticulo_Insertar.TabIndex = 9;
            this.btnArticulo_Insertar.Text = "Insertar";
            this.btnArticulo_Insertar.UseVisualStyleBackColor = false;
            this.btnArticulo_Insertar.Click += new System.EventHandler(this.btnArticulo_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.panel_infArticulo);
            this.Controls.Add(this.panel_supArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroArticulo";
            this.panel_supArticulo.ResumeLayout(false);
            this.panel_supArticulo.PerformLayout();
            this.panel_infArticulo.ResumeLayout(false);
            this.panel_infArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supArticulo;
        private System.Windows.Forms.Panel panel_infArticulo;
        private System.Windows.Forms.Label lblclientes_Titulo;
        private System.Windows.Forms.ComboBox cbxArticulo_UnidadesMedidaID;
        private System.Windows.Forms.ComboBox cbxArticulo_FamiliaID;
        private System.Windows.Forms.Label lblArticulo_Descuento;
        private System.Windows.Forms.TextBox txbArticulo_Peso;
        private System.Windows.Forms.Label lblArticulo_Peso;
        private System.Windows.Forms.Label lblArticulo_Descripcion;
        private System.Windows.Forms.TextBox txbArticulo_Codigo;
        private System.Windows.Forms.Label lblArticulo_Codigo;
        private System.Windows.Forms.TextBox txbArticulo_Producto;
        private System.Windows.Forms.Label lblArticulo_Nombre;
        private System.Windows.Forms.TextBox txbArticulo_Impuesto;
        private System.Windows.Forms.Label lblArticulo_Impuesto;
        private System.Windows.Forms.Label lblArticulo_FamiliaID;
        private System.Windows.Forms.Label lblArticulo_UnidadesMedidaID;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnArticulo_Insertar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txbArticulo_Precio;
        private System.Windows.Forms.TextBox txbArticulo_Descuentos;
        private System.Windows.Forms.Button btnArticulo_Limpiar;
        private System.Windows.Forms.Button btnArticulo_Modificar;
        private System.Windows.Forms.CheckBox chbListarI;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox txbArticulo_Descripcion;
        private System.Windows.Forms.Button BtnArticulo_Eliminar;
    }
}
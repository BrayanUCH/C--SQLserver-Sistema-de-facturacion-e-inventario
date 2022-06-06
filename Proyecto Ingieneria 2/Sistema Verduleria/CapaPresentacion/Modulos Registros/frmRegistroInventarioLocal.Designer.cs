
namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroInventarioLocal
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
            this.panel_infInventario = new System.Windows.Forms.Panel();
            this.BtnInventario_Eliminar = new System.Windows.Forms.Button();
            this.dgvInventarioLocal = new System.Windows.Forms.DataGridView();
            this.txb_filtradoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.btnInventario_Modificar = new System.Windows.Forms.Button();
            this.btnInventario_Limpiar = new System.Windows.Forms.Button();
            this.cbxInventario_ArticuloID = new System.Windows.Forms.ComboBox();
            this.lblArticulo_Codigo = new System.Windows.Forms.Label();
            this.txbInventario_Cantidad = new System.Windows.Forms.TextBox();
            this.lblArticulo_Nombre = new System.Windows.Forms.Label();
            this.btnInventario_Insertar = new System.Windows.Forms.Button();
            this.chbListarI = new System.Windows.Forms.CheckBox();
            this.lblInventario_Titulo = new System.Windows.Forms.Label();
            this.panel_supInventario = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_infInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.panel_supInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_infInventario
            // 
            this.panel_infInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infInventario.AutoSize = true;
            this.panel_infInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infInventario.Controls.Add(this.BtnInventario_Eliminar);
            this.panel_infInventario.Controls.Add(this.dgvInventarioLocal);
            this.panel_infInventario.Controls.Add(this.txb_filtradoProducto);
            this.panel_infInventario.Controls.Add(this.label1);
            this.panel_infInventario.Controls.Add(this.dgv_Productos);
            this.panel_infInventario.Controls.Add(this.chbActivo);
            this.panel_infInventario.Controls.Add(this.btnInventario_Modificar);
            this.panel_infInventario.Controls.Add(this.btnInventario_Limpiar);
            this.panel_infInventario.Controls.Add(this.cbxInventario_ArticuloID);
            this.panel_infInventario.Controls.Add(this.lblArticulo_Codigo);
            this.panel_infInventario.Controls.Add(this.txbInventario_Cantidad);
            this.panel_infInventario.Controls.Add(this.lblArticulo_Nombre);
            this.panel_infInventario.Controls.Add(this.btnInventario_Insertar);
            this.panel_infInventario.Location = new System.Drawing.Point(0, 65);
            this.panel_infInventario.Name = "panel_infInventario";
            this.panel_infInventario.Size = new System.Drawing.Size(938, 436);
            this.panel_infInventario.TabIndex = 5;
            // 
            // BtnInventario_Eliminar
            // 
            this.BtnInventario_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.BtnInventario_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInventario_Eliminar.ForeColor = System.Drawing.Color.White;
            this.BtnInventario_Eliminar.Location = new System.Drawing.Point(187, 332);
            this.BtnInventario_Eliminar.Name = "BtnInventario_Eliminar";
            this.BtnInventario_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnInventario_Eliminar.TabIndex = 130;
            this.BtnInventario_Eliminar.Text = "Eliminar";
            this.BtnInventario_Eliminar.UseVisualStyleBackColor = false;
            this.BtnInventario_Eliminar.Click += new System.EventHandler(this.btnInventario_Eliminar_Click);
            // 
            // dgvInventarioLocal
            // 
            this.dgvInventarioLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventarioLocal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInventarioLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioLocal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventarioLocal.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInventarioLocal.Location = new System.Drawing.Point(269, 6);
            this.dgvInventarioLocal.Name = "dgvInventarioLocal";
            this.dgvInventarioLocal.Size = new System.Drawing.Size(660, 423);
            this.dgvInventarioLocal.TabIndex = 6;
            this.dgvInventarioLocal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarioLocal_CellDoubleClick);
            // 
            // txb_filtradoProducto
            // 
            this.txb_filtradoProducto.Location = new System.Drawing.Point(96, 6);
            this.txb_filtradoProducto.Name = "txb_filtradoProducto";
            this.txb_filtradoProducto.Size = new System.Drawing.Size(167, 20);
            this.txb_filtradoProducto.TabIndex = 0;
            this.txb_filtradoProducto.TextChanged += new System.EventHandler(this.txb_filtradoProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Productos ";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Productos.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Productos.Location = new System.Drawing.Point(15, 32);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.Size = new System.Drawing.Size(247, 154);
            this.dgv_Productos.TabIndex = 128;
            this.dgv_Productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellDoubleClick);
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.ForeColor = System.Drawing.Color.White;
            this.chbActivo.Location = new System.Drawing.Point(15, 245);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 126;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // btnInventario_Modificar
            // 
            this.btnInventario_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnInventario_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario_Modificar.ForeColor = System.Drawing.Color.White;
            this.btnInventario_Modificar.Location = new System.Drawing.Point(187, 303);
            this.btnInventario_Modificar.Name = "btnInventario_Modificar";
            this.btnInventario_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btnInventario_Modificar.TabIndex = 5;
            this.btnInventario_Modificar.Text = "Modificar";
            this.btnInventario_Modificar.UseVisualStyleBackColor = false;
            this.btnInventario_Modificar.Click += new System.EventHandler(this.btnInventario_Modificar_Click);
            // 
            // btnInventario_Limpiar
            // 
            this.btnInventario_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnInventario_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btnInventario_Limpiar.Location = new System.Drawing.Point(187, 274);
            this.btnInventario_Limpiar.Name = "btnInventario_Limpiar";
            this.btnInventario_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btnInventario_Limpiar.TabIndex = 4;
            this.btnInventario_Limpiar.Text = "Limpiar";
            this.btnInventario_Limpiar.UseVisualStyleBackColor = false;
            this.btnInventario_Limpiar.Click += new System.EventHandler(this.btnInventario_Limpiar_Click);
            // 
            // cbxInventario_ArticuloID
            // 
            this.cbxInventario_ArticuloID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInventario_ArticuloID.FormattingEnabled = true;
            this.cbxInventario_ArticuloID.Location = new System.Drawing.Point(118, 192);
            this.cbxInventario_ArticuloID.Name = "cbxInventario_ArticuloID";
            this.cbxInventario_ArticuloID.Size = new System.Drawing.Size(145, 21);
            this.cbxInventario_ArticuloID.TabIndex = 1;
            // 
            // lblArticulo_Codigo
            // 
            this.lblArticulo_Codigo.AutoSize = true;
            this.lblArticulo_Codigo.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Codigo.Location = new System.Drawing.Point(12, 222);
            this.lblArticulo_Codigo.Name = "lblArticulo_Codigo";
            this.lblArticulo_Codigo.Size = new System.Drawing.Size(100, 13);
            this.lblArticulo_Codigo.TabIndex = 108;
            this.lblArticulo_Codigo.Text = "Cantiad de articulos";
            // 
            // txbInventario_Cantidad
            // 
            this.txbInventario_Cantidad.AccessibleDescription = "";
            this.txbInventario_Cantidad.AccessibleName = "";
            this.txbInventario_Cantidad.Location = new System.Drawing.Point(118, 219);
            this.txbInventario_Cantidad.Name = "txbInventario_Cantidad";
            this.txbInventario_Cantidad.Size = new System.Drawing.Size(144, 20);
            this.txbInventario_Cantidad.TabIndex = 2;
            this.txbInventario_Cantidad.Tag = "";
            this.txbInventario_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInventario_Cantidad_KeyPress);
            // 
            // lblArticulo_Nombre
            // 
            this.lblArticulo_Nombre.AutoSize = true;
            this.lblArticulo_Nombre.ForeColor = System.Drawing.Color.White;
            this.lblArticulo_Nombre.Location = new System.Drawing.Point(14, 195);
            this.lblArticulo_Nombre.Name = "lblArticulo_Nombre";
            this.lblArticulo_Nombre.Size = new System.Drawing.Size(50, 13);
            this.lblArticulo_Nombre.TabIndex = 106;
            this.lblArticulo_Nombre.Text = "Producto";
            // 
            // btnInventario_Insertar
            // 
            this.btnInventario_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnInventario_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario_Insertar.ForeColor = System.Drawing.Color.White;
            this.btnInventario_Insertar.Location = new System.Drawing.Point(187, 245);
            this.btnInventario_Insertar.Name = "btnInventario_Insertar";
            this.btnInventario_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnInventario_Insertar.TabIndex = 3;
            this.btnInventario_Insertar.Text = "Insertar";
            this.btnInventario_Insertar.UseVisualStyleBackColor = false;
            this.btnInventario_Insertar.Click += new System.EventHandler(this.btnInventario_Insertar_Click);
            // 
            // chbListarI
            // 
            this.chbListarI.AutoSize = true;
            this.chbListarI.ForeColor = System.Drawing.Color.White;
            this.chbListarI.Location = new System.Drawing.Point(838, 42);
            this.chbListarI.Name = "chbListarI";
            this.chbListarI.Size = new System.Drawing.Size(96, 17);
            this.chbListarI.TabIndex = 125;
            this.chbListarI.Text = "Listar inactivos";
            this.chbListarI.UseVisualStyleBackColor = true;
            this.chbListarI.CheckedChanged += new System.EventHandler(this.chbListarI_CheckedChanged);
            // 
            // lblInventario_Titulo
            // 
            this.lblInventario_Titulo.AutoSize = true;
            this.lblInventario_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblInventario_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblInventario_Titulo.Name = "lblInventario_Titulo";
            this.lblInventario_Titulo.Size = new System.Drawing.Size(582, 44);
            this.lblInventario_Titulo.TabIndex = 73;
            this.lblInventario_Titulo.Text = "Registro de Inventario del Local\r\n";
            // 
            // panel_supInventario
            // 
            this.panel_supInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_supInventario.Controls.Add(this.lblInventario_Titulo);
            this.panel_supInventario.Controls.Add(this.chbListarI);
            this.panel_supInventario.Location = new System.Drawing.Point(0, 0);
            this.panel_supInventario.Name = "panel_supInventario";
            this.panel_supInventario.Size = new System.Drawing.Size(934, 65);
            this.panel_supInventario.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroInventarioLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.panel_infInventario);
            this.Controls.Add(this.panel_supInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroInventarioLocal";
            this.Text = "frmRegistroInventarioLocal";
            this.panel_infInventario.ResumeLayout(false);
            this.panel_infInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.panel_supInventario.ResumeLayout(false);
            this.panel_supInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_infInventario;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.CheckBox chbListarI;
        private System.Windows.Forms.Button btnInventario_Modificar;
        private System.Windows.Forms.Button btnInventario_Limpiar;
        private System.Windows.Forms.ComboBox cbxInventario_ArticuloID;
        private System.Windows.Forms.Label lblArticulo_Codigo;
        private System.Windows.Forms.TextBox txbInventario_Cantidad;
        private System.Windows.Forms.Label lblArticulo_Nombre;
        private System.Windows.Forms.Button btnInventario_Insertar;
        private System.Windows.Forms.Label lblInventario_Titulo;
        private System.Windows.Forms.Panel panel_supInventario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.TextBox txb_filtradoProducto;
        private System.Windows.Forms.DataGridView dgvInventarioLocal;
        private System.Windows.Forms.Button BtnInventario_Eliminar;
    }
}